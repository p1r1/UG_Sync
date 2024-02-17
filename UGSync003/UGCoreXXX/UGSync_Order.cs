using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace UGCore {

    public static class UGSync_Order {

        private static string changeAdressCode(string connString, string accountRecId) {
            ///Change increase last adress Code
            int lastAddressCode = 0;
            string defaultAddressCode = "001";
            try {
                DataTable tableAdressCode = Functions.getDataFromSql(connString,
                    string.Format(@"SELECT AddressCode FROM dbo.Erp_Address WHERE CurrentAccountId='{0}' ORDER BY RecId DESC", accountRecId));
                if (tableAdressCode.Rows.Count > 0) {
                    int.TryParse(tableAdressCode.Rows[0][0].ToString(), out lastAddressCode);
                }
            }
            catch (Exception) { }

            if (lastAddressCode != 0) {
                lastAddressCode++;
                defaultAddressCode = lastAddressCode.ToString("D3");
            }
            return defaultAddressCode;
        }

        private static IEnumerable<string> stringSpliter(string str, int maxChunkSize) {
            for (int i = 0; i < str.Length; i += maxChunkSize)
                yield return str.Substring(i, Math.Min(maxChunkSize, str.Length - i));
        }

        private static Tuple<bool, string> isThisUpdate(string connString, bool isThisBill, string existingAccountRecId, string accountBillName,
                                                        string accountBillAddress1, string accountBillAddress2, string accountBillAddress3) {
            /// false=insert, true= Update
            bool isUpdate = false;
            /// özel koda fatura + siparis yazdır
            string querrybillAddresses = "";
            if (isThisBill) {
                querrybillAddresses = string.Format("SELECT RecId, Line1, Line2, Line3, Explanation FROM Erp_Address WHERE SpecialCode='fatura' and CurrentAccountId = '{0}' ORDER BY RecId DESC", existingAccountRecId);
            }
            else {
                querrybillAddresses = string.Format("SELECT RecId, Line1, Line2, Line3, Explanation FROM Erp_Address WHERE SpecialCode='siparis' and CurrentAccountId = '{0}' ORDER BY RecId DESC", existingAccountRecId);
            }
            DataTable tablebillAddresses = Functions.getDataFromSql(connString, querrybillAddresses);
            //Console.WriteLine(tablebillAddresses.Rows.Count.ToString());
            if (tablebillAddresses.Rows.Count == 0) {
                return new Tuple<bool, string>(false, "");
            }

            string existingAddressRecId = "";
            foreach (DataRow row in tablebillAddresses.Rows) {
                if (row["Line1"].ToString().Trim() == accountBillAddress1.Trim() &&
                    row["Line2"].ToString().Trim() == accountBillAddress2.Trim() &&
                    row["Line3"].ToString().Trim() == accountBillAddress3.Trim() &&
                    row["Explanation"].ToString() == accountBillName) {

                    /// same address and same person
                    isUpdate = true;
                    existingAddressRecId = row["RecId"].ToString();
                    break;
                }

            }///foreach
            ///////////////////////////////////always insert
            tablebillAddresses.Clear();
            return new Tuple<bool, string>(isUpdate, existingAddressRecId);
        }

        public static async Task<bool> /*bool*/ sendOrdersToSql(string daysAgo, string url, string connString, string mySqlConn, string webUsername, string webUserPass, int DELAY_TIME) {
            string logFilePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            string methodName = "SiparişMetodu--> ";
            /// ///
            /// Take website orders, insert them to sentez
            /// ///
            /// create weborder and get webOrders
            string url1 = Functions.createUrl4WebOrders(url, daysAgo, webUsername, webUserPass);
            Log.append(methodName + url1, logFilePath);

            WebOrder webOrders = new WebOrder(url1);
            webOrders.getJsonFromWeb();
            webOrders.createDynamicVar();

            if (!Object.ReferenceEquals(null, webOrders.m_data.orders)) {
                Log.append(methodName + "Sipariş sayısı:" + webOrders.m_data.orders.Count.ToString(), logFilePath);
            }
            else {
                return false;
            }
            /// ///
            /// Insert to Sentez
            /// ///
            if (webOrders.m_data.orders.Count == 0) {
                Log.append(methodName + "Sipariş yok", logFilePath);
            }
            else {
                /// ///
                /// There are orders in the JSON
                /// ///
                foreach (var ordr in webOrders.m_data.orders) {
                    string specialCode = !Object.ReferenceEquals(null, ordr.ord_code) ? ordr.ord_code : "";
                    string orderId = !Object.ReferenceEquals(null, ordr.ord_id) ? ordr.ord_id.ToString() : "";
                    string accountName = !Object.ReferenceEquals(null, ordr.ord_mmb_name) ? ordr.ord_mmb_name.ToString() : "";
                    /// ///
                    /// Check order status
                    /// ///
                    if (!Object.ReferenceEquals(null, ordr.ord_status)) {
                        if (ordr.ord_status.ToString() == "1") {
                            ///bubble
                            Bubble.sendBubbleNote(mySqlConn,
                                                  string.Format("Yeni sipariş\n{0}\n{1}", specialCode, accountName),
                                                  "siparis",
                                                  string.Format(@"https://www.uzaktangelir.com/admin/index.php?p=Orders&view={0}", orderId),
                                                  "1",
                                                  DateTime.Now,
                                                  DateTime.Now.AddDays(2),
                                                  "30",
                                                  "ALL",
                                                  "Sipariş",
                                                  ordr.ord_status.ToString(),
                                                  orderId);
                            continue;
                        }
                        else if (ordr.ord_status.ToString() == "2") {
                            ///bubble
                            Bubble.sendBubbleNote(mySqlConn,
                                                  string.Format("Ödeme bekleyen sipariş\n{0}\n{1}", specialCode, accountName),
                                                  "siparis",
                                                  string.Format(@"https://www.uzaktangelir.com/admin/index.php?p=Orders&view={0}", orderId),
                                                  "2",
                                                  DateTime.Now,
                                                  DateTime.Now.AddDays(2),
                                                  "30",
                                                  "ALL",
                                                  "Sipariş",
                                                  ordr.ord_status.ToString(), /// grand total
                                                  orderId);
                            continue;
                        }
                        else if (ordr.ord_status.ToString() == "12") {
                            /// "Teslimata hazırlanıyor"
                        }
                        else {
                            continue;
                        }
                    }
                    else {
                        continue;
                    }
                    /// ///
                    /// Check the special code. If special codes exist in the order then skip that order.
                    /// ///
                    string queryCountRecId = @"SELECT Count(RecId) as adet FROM  Erp_OrderReceipt WHERE SpecialCode = '" + specialCode + "'";
                    DataTable tableOrderSpecialCode = Functions.getDataFromSql(connString, queryCountRecId);

                    if (tableOrderSpecialCode.Rows.Count < 1) {
                        Log.append(methodName + "tableOrderSpecialCode is empty", logFilePath);
                        break;
                    }

                    if (tableOrderSpecialCode.Rows.Count > 0 && tableOrderSpecialCode.Rows[0][0].ToString() == "0") {
                        /// Sentez doesn't have this order's special code . Make a new order in sentez.
                        //labelInfo2.Invoke(() => labelInfo2.Text = "sipariş sentezde yok!");

                        /// ///
                        /// Account Info
                        /// ///
                        string accountInsertedBy = "6";
                        string accountInsertedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        string accountCompanyId = "1";
                        string accountID = !Object.ReferenceEquals(null, ordr.ord_mmb_id) ? ordr.ord_mmb_id.ToString() : "";
                        string accountType = "2"; /// 1= satici , 2 = alici
                        string accountKind = "2"; /// 1= Şirket,  2 = Şahıs
                        string accountEmail = !Object.ReferenceEquals(null, ordr.ord_mmb_email) ? ordr.ord_mmb_email.ToString() : "";
                        string accountGsmPhone = !Object.ReferenceEquals(null, ordr.ord_billing_phone) ? ordr.ord_billing_phone.ToString() : "";
                        string accountTaxNo = !Object.ReferenceEquals(null, ordr.ord_billing_tax_number) ? ordr.ord_billing_tax_number.ToString() : "";
                        string accounhtInUSe = "1"; /// 1= checked
                        string accountProfession = "";
                        if (!Object.ReferenceEquals(null, ordr.member)) {
                            accountProfession = !Object.ReferenceEquals(null, ordr.member.mmb_job_name) ? ordr.member.mmb_job_name.ToString() : "";
                        }
                        /// ///
                        /// Billing Address !! 001      
                        /// ///
                        string billTown = "";
                        billTown = Functions.executeScalar(connString, string.Format(@"SELECT RecId as adet FROM  Meta_District WHERE CodeN = '{0}'",
                                                                       !Object.ReferenceEquals(null, ordr.ord_billing_town_id) ? ordr.ord_billing_town_id.ToString() : ""));
                        string billCity = "";
                        billCity = Functions.executeScalar(connString, string.Format(@"SELECT RecId as adet FROM  Meta_City WHERE CodeN = '{0}'",
                                                                       !Object.ReferenceEquals(null, ordr.ord_billing_city_id) ? ordr.ord_billing_city_id.ToString() : ""));

                        /// If Corporate bill
                        string accountBillTaxOffice = "";
                        if (!Object.ReferenceEquals(null, ordr.ord_billing_tax_office)) {
                            if (ordr.ord_billing_tax_office != "") {
                                accountBillTaxOffice = ordr.ord_billing_tax_office; /// write this in erp_current account -> blog
                            }
                        }
                        string accountBillAddressType = "1";
                        string accountBillName = !Object.ReferenceEquals(null, ordr.ord_billing_name) ? ordr.ord_billing_name.ToString() : accountName;///write this in erp_address -> explanation
                        if (!Object.ReferenceEquals(null, ordr.ord_billing_firm_name)) {
                            //MessageBox.Show(ordr.ord_billing_firm_name.ToString());
                            if (!string.IsNullOrEmpty(ordr.ord_billing_firm_name.ToString())) {
                                accountBillName = ordr.ord_billing_firm_name.ToString();
                                accountBillAddressType = "2";
                            }
                        }

                        string accountBillAddressIsDeafult = "1";
                        string accountBillAddressSpecialCode = "fatura";
                        string accountBillTown = !string.IsNullOrEmpty(billTown) ? billTown : "";
                        string accountBillCity = !string.IsNullOrEmpty(billCity) ? billCity : "";
                        string accountBillCountry = "186"; /// Turkey
                        string accountBillAddressInUse = "1";
                        string accountBillAddress = !Object.ReferenceEquals(null, ordr.ord_billing_address) ? ordr.ord_billing_address.ToString() : "";
                        //accountBillAddress = Regex.Replace(accountBillAddress, @"[\r\n'/\\]", " ");
                        /// Split the address to lengnt of 50
                        string accountBillAddress1 = "";
                        string accountBillAddress2 = "";
                        string accountBillAddress3 = "";
                        var accountBillAddressList = stringSpliter(accountBillAddress.Trim(), 49);
                        try {
                            if (accountBillAddressList.ToArray().Length == 1) {
                                accountBillAddress1 = accountBillAddressList.ToArray()[0].ToString();
                            }
                            else if (accountBillAddressList.ToArray().Length == 2) {
                                accountBillAddress1 = accountBillAddressList.ToArray()[0].ToString();
                                accountBillAddress2 = accountBillAddressList.ToArray()[1].ToString();
                            }
                            else if (accountBillAddressList.ToArray().Length == 3) {
                                accountBillAddress1 = accountBillAddressList.ToArray()[0].ToString();
                                accountBillAddress2 = accountBillAddressList.ToArray()[1].ToString();
                                accountBillAddress3 = accountBillAddressList.ToArray()[2].ToString();
                            }
                            // else ///too long address 
                        }
                        catch (Exception) { }

                        /// ///
                        /// Shipping Address (not that importat)
                        /// ///
                        string shippingTown = "";
                        shippingTown = Functions.executeScalar(connString, string.Format(@"SELECT RecId FROM  Meta_District WHERE CodeN = '{0}'",
                                                                           !Object.ReferenceEquals(null, ordr.ord_shipping_town_id) ? ordr.ord_shipping_town_id.ToString() : ""));
                        string shippingCity = "";
                        shippingCity = Functions.executeScalar(connString, string.Format(@"SELECT RecId FROM  Meta_City WHERE CodeN = '{0}'",
                                                                                   !Object.ReferenceEquals(null, ordr.ord_shipping_city_id) ? ordr.ord_shipping_city_id.ToString() : ""));

                        ///increase last adress Code
                        //string accountAddressCode = "002";
                        string accountAddressName = !Object.ReferenceEquals(null, ordr.ord_shipping_name) ? ordr.ord_shipping_name : "";
                        string accountAddressType = "1";
                        string accountAddressSpecialCode = "siparis";
                        string accountAddressIsDeafult = "0";
                        string accountTown = !string.IsNullOrEmpty(shippingTown) ? shippingTown : "";
                        string accountCity = !string.IsNullOrEmpty(shippingCity) ? shippingCity : "";
                        string accountCountry = "186"; /// Turkey
                        string accountAddressInUse = "1";
                        string accountCategoryId = "2";
                        string accountAddress = !Object.ReferenceEquals(null, ordr.ord_shipping_address) ? ordr.ord_shipping_address.ToString() : "";
                        //accountAddress = Regex.Replace(accountAddress, @"[\r\n']", " ");
                        /// Split the address to lengnt of 50
                        string accountAddress1 = "";
                        string accountAddress2 = "";
                        string accountAddress3 = "";
                        var accountAddressList = stringSpliter(accountAddress.Trim(), 49);
                        try {
                            if (accountAddressList.ToArray().Length == 1) {
                                accountAddress1 = accountAddressList.ToArray()[0].ToString();
                            }
                            else if (accountAddressList.ToArray().Length == 2) {
                                accountAddress1 = accountAddressList.ToArray()[0].ToString();
                                accountAddress2 = accountAddressList.ToArray()[1].ToString();
                            }
                            else if (accountAddressList.ToArray().Length == 3) {
                                accountAddress1 = accountAddressList.ToArray()[0].ToString();
                                accountAddress2 = accountAddressList.ToArray()[1].ToString();
                                accountAddress3 = accountAddressList.ToArray()[2].ToString();
                            }
                            // else ///too long address 
                        }
                        catch (Exception) { }

                        string explanationShipping = "";
                        try {
                            accountBillName = stringSpliter(accountBillName.Trim(), 49).ToArray()[0].ToString();
                            explanationShipping = stringSpliter(accountAddressName.Trim(), 49).ToArray()[0].ToString();
                        }
                        catch (Exception) { }

                        /// change this inside if else
                        string accountBillAddressCode = "";
                        string accountAddressCode = "";
                        string accountBillAddressRecID = "";
                        string accountAddressRecID = "";

                        /// ///
                        /// Check account(cari). If sentez does NOT has the account then create it.
                        /// ///
                        if (accountID == "0") {
                            /// Not a member of Website. Is this account member of the Sentez? Check via Email. (AccountCode like UGHNF7)
                            string queryAccount = @"SELECT Count(RecId) as adet FROM  Erp_CurrentAccount WHERE EMail = '" + accountEmail + "'";
                            DataTable tableAccount = Functions.getDataFromSql(connString, queryAccount);
                            if (tableAccount.Rows.Count < 1) {
                                Log.append(methodName + "tableAccount is empty.", logFilePath);
                                break;
                            }

                            Log.append(methodName + "id 0 mı ->" + tableAccount.Rows[0][0].ToString(), logFilePath);

                            if (tableAccount.Rows.Count > 0 && tableAccount.Rows[0][0].ToString() == "0") {
                                /// This account's email not in the sentez.
                                /// Give this account an id then insert to Sentez. -> accountId = first order's special code (not email any more)
                                //accountID = !Object.ReferenceEquals(null, ordr.ord_mmb_email) ? ordr.ord_mmb_email.ToString() : "";
                                accountID = !Object.ReferenceEquals(null, ordr.ord_code) ? ordr.ord_code : "";
                                List<Functions.SqlObj> SqlObjsAccount1 = new List<Functions.SqlObj> {
                                    new Functions.SqlObj("CompanyId", accountCompanyId), // 
                                    new Functions.SqlObj("CurrentAccountCode", specialCode), //degis
                                    new Functions.SqlObj("CurrentAccountName", accountName),
                                    new Functions.SqlObj("CurrentAccountType", accountType),
                                    new Functions.SqlObj("CurrentAccountKind", accountKind),
                                    new Functions.SqlObj("EMail", accountEmail),
                                    new Functions.SqlObj("Blog", accountBillTaxOffice),
                                    new Functions.SqlObj("GsmPhone", accountGsmPhone),
                                    new Functions.SqlObj("TaxNo", accountTaxNo),
                                    new Functions.SqlObj("InUse", accounhtInUSe),
                                    new Functions.SqlObj("Profession", accountProfession),
                                    new Functions.SqlObj("CategoryId", accountCategoryId),
                                    new Functions.SqlObj("InsertedAt", accountInsertedAt),
                                    new Functions.SqlObj("InsertedBy", accountInsertedBy)
                                };
                                Functions.insertToSQL(connString, "Erp_CurrentAccount", SqlObjsAccount1.ToArray());

                                /// Take newly created account's RecId from email
                                string newAccountRecId = "";
                                newAccountRecId = Functions.executeScalar(connString, string.Format(@"SELECT RecId FROM  Erp_CurrentAccount WHERE EMail = '{0}'", accountEmail));
                                if (string.IsNullOrEmpty(newAccountRecId)) {
                                    Log.append(methodName + "newAccountRecId is empty", logFilePath);
                                    break;
                                }

                                /// Insert Billing Address
                                accountBillAddressCode = changeAdressCode(connString, newAccountRecId);
                                List<Functions.SqlObj> SqlObjsAddress = new List<Functions.SqlObj> {
                                    new Functions.SqlObj("AddressCode", accountBillAddressCode),
                                    new Functions.SqlObj("SpecialCode", accountBillAddressSpecialCode),
                                    new Functions.SqlObj("CurrentAccountId", newAccountRecId),
                                    new Functions.SqlObj("AddressType", accountBillAddressType),
                                    new Functions.SqlObj("Line1", accountBillAddress1),
                                    new Functions.SqlObj("Line2", accountBillAddress2),
                                    new Functions.SqlObj("Line3", accountBillAddress3),
                                    new Functions.SqlObj("DistrictId", accountBillTown),
                                    new Functions.SqlObj("CityId", accountBillCity),
                                    new Functions.SqlObj("CountryId", accountBillCountry),
                                    new Functions.SqlObj("InUse", accountBillAddressInUse),
                                    new Functions.SqlObj("Explanation", accountBillName),
                                    new Functions.SqlObj("IsDefault", accountBillAddressIsDeafult),
                                    new Functions.SqlObj("InsertedAt", accountInsertedAt),
                                    new Functions.SqlObj("InsertedBy", accountInsertedBy)
                                };
                                Functions.insertToSQL(connString, "Erp_Address", SqlObjsAddress.ToArray());

                                /// Insert Shipping Address
                                accountAddressCode = changeAdressCode(connString, newAccountRecId);
                                List<Functions.SqlObj> SqlObjsAddress2 = new List<Functions.SqlObj> {
                                    new Functions.SqlObj("AddressCode", accountAddressCode),
                                    new Functions.SqlObj("SpecialCode", accountAddressSpecialCode),
                                    new Functions.SqlObj("CurrentAccountId", newAccountRecId),
                                    new Functions.SqlObj("AddressType", accountAddressType),
                                    new Functions.SqlObj("Line1", accountAddress1),
                                    new Functions.SqlObj("Line2", accountAddress2),
                                    new Functions.SqlObj("Line3", accountAddress3),
                                    new Functions.SqlObj("DistrictId", accountTown),
                                    new Functions.SqlObj("CityId", accountCity),
                                    new Functions.SqlObj("CountryId", accountCountry),
                                    new Functions.SqlObj("InUse", accountAddressInUse),
                                    new Functions.SqlObj("Explanation", explanationShipping),
                                    new Functions.SqlObj("IsDefault", accountAddressIsDeafult),
                                    new Functions.SqlObj("InsertedAt", accountInsertedAt),
                                    new Functions.SqlObj("InsertedBy", accountInsertedBy)
                                };
                                Functions.insertToSQL(connString, "Erp_Address", SqlObjsAddress2.ToArray());

                                Log.append(methodName + "1 - emaili kayitli degil! sentezde caride degil." + accountID + " email-> " + accountEmail, logFilePath);

                            }
                            else {
                                /// This account's email EXIST in Sentez
                                accountID = specialCode;
                                /// ///
                                /// Insert/update Addresses
                                /// ///
                                /// Take newly created account's RecId from email
                                string existingAccountRecId = "";
                                existingAccountRecId = Functions.executeScalar(connString, string.Format(@"SELECT RecId FROM  Erp_CurrentAccount WHERE EMail = '{0}'", accountEmail));
                                if (string.IsNullOrEmpty(existingAccountRecId)) {
                                    Log.append(methodName + "newAccountRecId is empty", logFilePath);
                                }
                                ///try to deactivate old addresses
                                Functions.sendSQLCommand(connString, string.Format(@"UPDATE dbo.Erp_Address SET IsDefault='{0}', InUse='{1}' WHERE CurrentAccountId='{2}'", "0", "0", existingAccountRecId));
                                /// /// Billing Address
                                Tuple<bool, string> tupleBill = isThisUpdate(connString, true, existingAccountRecId, accountBillName, accountBillAddress1, accountBillAddress2, accountBillAddress3);
                                ///change accountBillAddressCode
                                if (tupleBill.Item1) {
                                    /// if update change accountcode
                                    accountBillAddressRecID = tupleBill.Item2;
                                    accountBillAddressCode = Functions.executeScalar(connString, string.Format(@"SELECT AddressCode FROM dbo.Erp_Address WHERE SpecialCode='fatura' and RecId={0}", tupleBill.Item2));
                                }
                                else {
                                    /// insert
                                    accountBillAddressCode = changeAdressCode(connString, existingAccountRecId);
                                    List<Functions.SqlObj> SqlObjsAddress = new List<Functions.SqlObj> {
                                        new Functions.SqlObj("AddressCode", accountBillAddressCode),
                                        new Functions.SqlObj("SpecialCode", accountBillAddressSpecialCode),
                                        new Functions.SqlObj("CurrentAccountId", existingAccountRecId),
                                        new Functions.SqlObj("AddressType", accountBillAddressType),
                                        new Functions.SqlObj("Line1", accountBillAddress1),
                                        new Functions.SqlObj("Line2", accountBillAddress2),
                                        new Functions.SqlObj("Line3", accountBillAddress3),
                                        new Functions.SqlObj("DistrictId", accountBillTown),
                                        new Functions.SqlObj("CityId", accountBillCity),
                                        new Functions.SqlObj("CountryId", accountBillCountry),
                                        new Functions.SqlObj("InUse", accountBillAddressInUse),
                                        new Functions.SqlObj("Explanation", accountBillName),
                                        new Functions.SqlObj("IsDefault", accountBillAddressIsDeafult),
                                        new Functions.SqlObj("InsertedAt", accountInsertedAt),
                                        new Functions.SqlObj("InsertedBy", accountInsertedBy)
                                    };
                                    Functions.insertToSQL(connString, "Erp_Address", SqlObjsAddress.ToArray());
                                }

                                /// /// Shipping Address
                                Tuple<bool, string> tupleShip = isThisUpdate(connString, false, existingAccountRecId, accountName, accountAddress1, accountAddress2, accountAddress3);

                                if (tupleShip.Item1) {
                                    /// if update change accountcode
                                    accountAddressRecID = tupleShip.Item2;
                                    accountAddressCode = Functions.executeScalar(connString, string.Format(@"SELECT AddressCode FROM dbo.Erp_Address WHERE SpecialCode='siparis' and RecId={0}", tupleShip.Item2));
                                }
                                else {
                                    accountAddressCode = changeAdressCode(connString, existingAccountRecId);
                                    List<Functions.SqlObj> SqlObjsAddress2 = new List<Functions.SqlObj> {
                                        new Functions.SqlObj("AddressCode", accountAddressCode),
                                        new Functions.SqlObj("SpecialCode", accountAddressSpecialCode),
                                        new Functions.SqlObj("CurrentAccountId", existingAccountRecId),
                                        new Functions.SqlObj("AddressType", accountAddressType),
                                        new Functions.SqlObj("Line1", accountAddress1),
                                        new Functions.SqlObj("Line2", accountAddress2),
                                        new Functions.SqlObj("Line3", accountAddress3),
                                        new Functions.SqlObj("DistrictId", accountTown),
                                        new Functions.SqlObj("CityId", accountCity),
                                        new Functions.SqlObj("CountryId", accountCountry),
                                        new Functions.SqlObj("InUse", accountAddressInUse),
                                        new Functions.SqlObj("Explanation", explanationShipping),
                                        new Functions.SqlObj("IsDefault", accountAddressIsDeafult),
                                        new Functions.SqlObj("InsertedAt", accountInsertedAt),
                                        new Functions.SqlObj("InsertedBy", accountInsertedBy)
                                    };
                                    Functions.insertToSQL(connString, "Erp_Address", SqlObjsAddress2.ToArray());
                                }

                                Log.append(methodName + "2 - siteye uye degil ama sentezde cari." + accountID + " email-> " + accountEmail, logFilePath);
                            }
                        }
                        else {
                            /// Id is NOT 0! A membere of Website!. Check if this account memeber of Sentez via email. (AccountCode like 110122) 
                            /// Get recId
                            string getCurrentAccountCode = string.Format(@"SELECT CurrentAccountCode, EMail FROM  Erp_CurrentAccount WHERE CurrentAccountCode = '{0}' or CurrentAccountCode = '{1}' or EMail = '{2}'",
                                                                         accountID,
                                                                         accountEmail,
                                                                         accountEmail);
                            DataTable tableExistingAccountCode = Functions.getDataFromSql(connString, getCurrentAccountCode);
                            if (tableExistingAccountCode.Rows.Count < 1) {
                                Log.append(methodName + "tableExistingAccountCode is empty", logFilePath);
                            }

                            if (tableExistingAccountCode.Rows.Count < 1) {
                                /// This accounts email NOT exist in Sentez.
                                List<Functions.SqlObj> SqlObjsAccount2 = new List<Functions.SqlObj> {
                                    new Functions.SqlObj("CompanyId", accountCompanyId), // 
                                    new Functions.SqlObj("CurrentAccountCode", accountID),
                                    new Functions.SqlObj("CurrentAccountName", accountName),
                                    new Functions.SqlObj("CurrentAccountType", accountType),
                                    new Functions.SqlObj("CurrentAccountKind", accountKind),
                                    new Functions.SqlObj("EMail", accountEmail),
                                    new Functions.SqlObj("Blog", accountBillTaxOffice),
                                    new Functions.SqlObj("GsmPhone", accountGsmPhone),
                                    new Functions.SqlObj("TaxNo", accountTaxNo),
                                    new Functions.SqlObj("InUse", accounhtInUSe),
                                    new Functions.SqlObj("Profession", accountProfession),
                                    new Functions.SqlObj("CategoryId", accountCategoryId),
                                    new Functions.SqlObj("InsertedAt", accountInsertedAt),
                                    new Functions.SqlObj("InsertedBy", accountInsertedBy)
                                };
                                Functions.insertToSQL(connString, "Erp_CurrentAccount", SqlObjsAccount2.ToArray());

                                /// Take newly created account's RecId from email
                                string newAccountRecId2 = "";
                                newAccountRecId2 = Functions.executeScalar(connString, string.Format(@"SELECT RecId FROM  Erp_CurrentAccount WHERE EMail = '{0}'", accountEmail));
                                if (string.IsNullOrEmpty(newAccountRecId2)) {
                                    Log.append(methodName + "newAccountRecId2 is empty", logFilePath);
                                    break;
                                }
                                /// Insert Billing Address
                                accountBillAddressCode = changeAdressCode(connString, newAccountRecId2);
                                List<Functions.SqlObj> SqlObjsAddress = new List<Functions.SqlObj> {
                                    new Functions.SqlObj("AddressCode", accountBillAddressCode),
                                    new Functions.SqlObj("SpecialCode", accountBillAddressSpecialCode),
                                    new Functions.SqlObj("CurrentAccountId", newAccountRecId2),
                                    new Functions.SqlObj("AddressType", accountBillAddressType),
                                    new Functions.SqlObj("Line1", accountBillAddress1),
                                    new Functions.SqlObj("Line2", accountBillAddress2),
                                    new Functions.SqlObj("Line3", accountBillAddress3),
                                    new Functions.SqlObj("DistrictId", accountBillTown),
                                    new Functions.SqlObj("CityId", accountBillCity),
                                    new Functions.SqlObj("CountryId", accountBillCountry),
                                    new Functions.SqlObj("InUse", accountBillAddressInUse),
                                    new Functions.SqlObj("Explanation", accountBillName),
                                    new Functions.SqlObj("IsDefault", accountBillAddressIsDeafult),
                                    new Functions.SqlObj("InsertedAt", accountInsertedAt),
                                    new Functions.SqlObj("InsertedBy", accountInsertedBy)
                                };
                                Functions.insertToSQL(connString, "Erp_Address", SqlObjsAddress.ToArray());

                                /// Insert Shipping Address
                                accountAddressCode = changeAdressCode(connString, newAccountRecId2);
                                List<Functions.SqlObj> SqlObjsAddress2 = new List<Functions.SqlObj> {
                                    new Functions.SqlObj("AddressCode", accountAddressCode),
                                    new Functions.SqlObj("SpecialCode", accountAddressSpecialCode),
                                    new Functions.SqlObj("CurrentAccountId", newAccountRecId2),
                                    new Functions.SqlObj("AddressType", accountAddressType),
                                    new Functions.SqlObj("Line1", accountAddress1),
                                    new Functions.SqlObj("Line2", accountAddress2),
                                    new Functions.SqlObj("Line3", accountAddress3),
                                    new Functions.SqlObj("DistrictId", accountTown),
                                    new Functions.SqlObj("CityId", accountCity),
                                    new Functions.SqlObj("CountryId", accountCountry),
                                    new Functions.SqlObj("InUse", accountAddressInUse),
                                    new Functions.SqlObj("Explanation", explanationShipping),
                                    new Functions.SqlObj("IsDefault", accountAddressIsDeafult),
                                    new Functions.SqlObj("InsertedAt", accountInsertedAt),
                                    new Functions.SqlObj("InsertedBy", accountInsertedBy)
                                };
                                Functions.insertToSQL(connString, "Erp_Address", SqlObjsAddress2.ToArray());

                                Log.append(methodName + "3 - id 0 degil siteye uye. sentezde cari degil" + accountID + " email-> " + accountEmail, logFilePath);

                            }
                            else {
                                /// ///
                                /// Update accountID
                                /// ///
                                if (tableExistingAccountCode.Rows[0][0].ToString() != accountID) {
                                    if (tableExistingAccountCode.Rows[0][0].ToString() == specialCode/*accountEmail*/ || tableExistingAccountCode.Rows[0][1].ToString() == accountEmail) {
                                        /// This account member of both Website and Sentez.  (become a member later)
                                        /// Compare sentez and website account id
                                        /// Update existing account
                                        string queryUpdate3 = string.Format(@"UPDATE Erp_CurrentAccount SET CurrentAccountCode = '{0}' WHERE CurrentAccountCode = '{1}' or CurrentAccountCode = '{2}' or EMail = '{3}'",
                                                                            accountID, accountID, specialCode, accountEmail); // degis
                                        Functions.sendSQLCommand(connString, queryUpdate3);

                                    }
                                }

                                /// ///
                                /// Insert/update Addresses
                                /// ///
                                /// Take newly created account's RecId from email
                                string existingAccountRecId = "";
                                existingAccountRecId = Functions.executeScalar(connString, string.Format(@"SELECT RecId FROM  Erp_CurrentAccount WHERE EMail = '{0}'", accountEmail));
                                if (string.IsNullOrEmpty(existingAccountRecId)) {
                                    Log.append(methodName + "newAccountRecId is empty", logFilePath);
                                }
                                ///try to deactivate old addresses
                                Functions.sendSQLCommand(connString, string.Format(@"UPDATE dbo.Erp_Address SET IsDefault='{0}', InUse='{1}' WHERE CurrentAccountId='{2}'", "0", "0", existingAccountRecId));
                                /// /// Billing Address
                                Tuple<bool, string> tupleBill2 = isThisUpdate(connString, true, existingAccountRecId, accountBillName, accountBillAddress1, accountBillAddress2, accountBillAddress3);
                                ///change accountBillAddressCode
                                if (tupleBill2.Item1) {
                                    /// if update change accountcode
                                    accountBillAddressRecID = tupleBill2.Item2;
                                    accountBillAddressCode = Functions.executeScalar(connString, string.Format(@"SELECT AddressCode FROM dbo.Erp_Address WHERE SpecialCode='fatura' and RecId={0}", tupleBill2.Item2));
                                }
                                else {
                                    accountBillAddressCode = changeAdressCode(connString, existingAccountRecId);
                                    List<Functions.SqlObj> SqlObjsAddress = new List<Functions.SqlObj> {
                                        new Functions.SqlObj("AddressCode", accountBillAddressCode),
                                        new Functions.SqlObj("SpecialCode", accountBillAddressSpecialCode),
                                        new Functions.SqlObj("CurrentAccountId", existingAccountRecId),
                                        new Functions.SqlObj("AddressType", accountBillAddressType),
                                        new Functions.SqlObj("Line1", accountBillAddress1),
                                        new Functions.SqlObj("Line2", accountBillAddress2),
                                        new Functions.SqlObj("Line3", accountBillAddress3),
                                        new Functions.SqlObj("DistrictId", accountBillTown),
                                        new Functions.SqlObj("CityId", accountBillCity),
                                        new Functions.SqlObj("CountryId", accountBillCountry),
                                        new Functions.SqlObj("InUse", accountBillAddressInUse),
                                        new Functions.SqlObj("Explanation", accountBillName),
                                        new Functions.SqlObj("IsDefault", accountBillAddressIsDeafult),
                                        new Functions.SqlObj("InsertedAt", accountInsertedAt),
                                        new Functions.SqlObj("InsertedBy", accountInsertedBy)
                                    };
                                    Functions.insertToSQL(connString, "Erp_Address", SqlObjsAddress.ToArray());
                                }

                                /// /// Shipping Address
                                Tuple<bool, string> tupleShip2 = isThisUpdate(connString, false, existingAccountRecId, accountName, accountAddress1, accountAddress2, accountAddress3);

                                if (tupleShip2.Item1) {
                                    /// if update change accountcode
                                    accountAddressRecID = tupleShip2.Item2;
                                    accountAddressCode = Functions.executeScalar(connString, string.Format(@"SELECT AddressCode FROM dbo.Erp_Address WHERE SpecialCode='siparis' and RecId={0}", tupleShip2.Item2));
                                }
                                else {
                                    accountAddressCode = changeAdressCode(connString, existingAccountRecId);
                                    List<Functions.SqlObj> SqlObjsAddress2 = new List<Functions.SqlObj> {
                                        new Functions.SqlObj("AddressCode", accountAddressCode),
                                        new Functions.SqlObj("SpecialCode", accountAddressSpecialCode),
                                        new Functions.SqlObj("CurrentAccountId", existingAccountRecId),
                                        new Functions.SqlObj("AddressType", accountAddressType),
                                        new Functions.SqlObj("Line1", accountAddress1),
                                        new Functions.SqlObj("Line2", accountAddress2),
                                        new Functions.SqlObj("Line3", accountAddress3),
                                        new Functions.SqlObj("DistrictId", accountTown),
                                        new Functions.SqlObj("CityId", accountCity),
                                        new Functions.SqlObj("CountryId", accountCountry),
                                        new Functions.SqlObj("InUse", accountAddressInUse),
                                        new Functions.SqlObj("Explanation", explanationShipping),
                                        new Functions.SqlObj("IsDefault", accountAddressIsDeafult),
                                        new Functions.SqlObj("InsertedAt", accountInsertedAt),
                                        new Functions.SqlObj("InsertedBy", accountInsertedBy)
                                    };
                                    Functions.insertToSQL(connString, "Erp_Address", SqlObjsAddress2.ToArray());
                                }

                                Log.append(methodName + "4 - Senteze de siteye de üye." + accountID + " email-> " + accountEmail, logFilePath);
                            }
                        }

                        /// ///
                        /// irsaliye olustur
                        /// ///
                        ///make receiptno
                        string querryGetLastReciptNo = @"SELECT ReceiptNo FROM  Erp_OrderReceipt WHERE ReceiptType = 2 ORDER BY ReceiptNo DESC";
                        DataTable tableLastReceiptNo = Functions.getDataFromSql(connString, querryGetLastReciptNo);
                        // get addressID
                        string queryRecIdFromErp_CurrentAccount = string.Format(@"SELECT RecId FROM  Erp_CurrentAccount WHERE EMail = '{0}'", accountEmail);
                        //MessageBox.Show("accountID\n" + accountID);
                        DataTable tableRecIdFromErp_CurrentAccount = Functions.getDataFromSql(connString, queryRecIdFromErp_CurrentAccount);
                        if (tableRecIdFromErp_CurrentAccount.Rows.Count < 1) {
                            //MessageBox.Show(tableRecIdFromErp_CurrentAccount.Rows.Count.ToString());
                            queryRecIdFromErp_CurrentAccount = string.Format(@"SELECT RecId FROM  Erp_CurrentAccount WHERE CurrentAccountCode = '{0}'", accountID);
                            tableRecIdFromErp_CurrentAccount = Functions.getDataFromSql(connString, queryRecIdFromErp_CurrentAccount);
                            if (tableRecIdFromErp_CurrentAccount.Rows.Count < 1) {
                                Log.append(methodName + "tableRecIdFromErp_CurrentAccount is empty", logFilePath);
                            }
                        }

                        /// ///
                        /// Get Adress for Receipt
                        /// ///
                        DataTable tableAccountAddressId = new DataTable();
                        DataTable tableAccountAddressId2 = new DataTable();

                        string receiptBillingAddressId = "";
                        string receiptShippingAddressId = "";
                        if (string.IsNullOrEmpty(accountBillAddressRecID)) {
                            ///Bill get RecId from Erp_address
                            string queryRecIdFromErp_Address = string.Format(@"SELECT RecId FROM  Erp_Address WHERE InUse = '1' and SpecialCode='fatura' and CurrentAccountId = {0} and AddressCode = {1} ORDER BY RecId DESC",
                                                                          tableRecIdFromErp_CurrentAccount.Rows.Count > 0 ? tableRecIdFromErp_CurrentAccount.Rows[0][0].ToString() : "",
                                                                          accountBillAddressCode);
                            tableAccountAddressId = Functions.getDataFromSql(connString, queryRecIdFromErp_Address);
                            if (tableAccountAddressId.Rows.Count < 1) {
                                //MessageBox.Show(tableAccountAddressId.Rows.Count.ToString());
                                Log.append(methodName + "tableAccountAddressId is empty", logFilePath);
                            }
                            else {
                                receiptBillingAddressId = tableAccountAddressId.Rows.Count > 0 ? tableAccountAddressId.Rows[0][0].ToString() : "";
                            }
                        }
                        else {
                            receiptBillingAddressId = accountBillAddressRecID;
                        }

                        if (string.IsNullOrEmpty(accountAddressRecID)) {
                            /// shipment
                            string queryRecIdFromErp_Address2 = string.Format(@"SELECT RecId FROM  Erp_Address WHERE InUse = '1' and SpecialCode='siparis' and CurrentAccountId = {0} and AddressCode = {1} ORDER BY RecId DESC",
                                                                          tableRecIdFromErp_CurrentAccount.Rows.Count > 0 ? tableRecIdFromErp_CurrentAccount.Rows[0][0].ToString() : "",
                                                                          accountAddressCode);
                            tableAccountAddressId2 = Functions.getDataFromSql(connString, queryRecIdFromErp_Address2);
                            if (tableAccountAddressId2.Rows.Count < 1) {
                                //MessageBox.Show(tableAccountAddressId2.Rows.Count.ToString());
                                Log.append(methodName + "tableAccountAddressId2 is empty", logFilePath);
                            }
                            else {
                                receiptShippingAddressId = tableAccountAddressId2.Rows.Count > 0 ? tableAccountAddressId2.Rows[0][0].ToString() : "";
                            }
                        }
                        else {
                            receiptShippingAddressId = accountAddressRecID;
                        }

                        // getRecId from erp_current account
                        string querryRecIdFromErp_Account = string.Format(@"SELECT RecId FROM  Erp_CurrentAccount WHERE EMail = '{0}'", accountEmail);
                        DataTable tableRecIdFromErp_Account = Functions.getDataFromSql(connString, querryRecIdFromErp_Account);
                        if (tableRecIdFromErp_Account.Rows.Count < 1) {
                            Log.append(methodName + "tableRecIdFromErp_Account is empty", logFilePath);
                        }

                        // getRecId from Erp_PaymentPlan account
                        string querryRecIdFromErp_PaymentPlan = string.Format(@"SELECT RecId FROM  Erp_PaymentPlan WHERE PlanCode = '{0}'",
                                                                              !Object.ReferenceEquals(null, ordr.pop_code) ? ordr.pop_code.ToString() : "");
                        DataTable tableRecIdFromErp_PaymentPlan = Functions.getDataFromSql(connString, querryRecIdFromErp_PaymentPlan);
                        if (tableRecIdFromErp_PaymentPlan.Rows.Count < 1) {
                            Log.append(methodName + "tableRecIdFromErp_PaymentPlan is empty", logFilePath);
                        }


                        string kargoName = !Object.ReferenceEquals(null, ordr.crg_name) ? ordr.crg_name.ToString() : "";
                        // getRecId from erp_current account
                        string querryRecIdFromErp_Transporter = string.Format(@"SELECT RecId FROM  Erp_Transporter WHERE TransporterCode = '{0}'", kargoName);
                        DataTable tableRecIdFromErp_Transporter = Functions.getDataFromSql(connString, querryRecIdFromErp_Transporter);
                        if (tableRecIdFromErp_Transporter.Rows.Count < 1) {
                            Log.append(methodName + "tableRecIdFromErp_Transporter is empty", logFilePath);
                        }
                        string kargoNameId = tableRecIdFromErp_Transporter.Rows.Count > 0 ? tableRecIdFromErp_Transporter.Rows[0][0].ToString() : "";

                        string receiptCompanyId = "1";
                        string receiptReceiptType = "2"; // 1=alış siparişi, 2=satış siparişi
                        string receiptReceiptNo = string.Format("{0:00000000}", (Convert.ToInt32(tableLastReceiptNo.Rows.Count > 0 ? tableLastReceiptNo.Rows[0][0].ToString() : "") + 1)); // make receiptNo
                        Log.append(methodName + "receiptReceiptNo ->" + receiptReceiptNo, logFilePath);

                        string receiptReceiptDate = !Object.ReferenceEquals(null, ordr.ord_insert_date) ? ordr.ord_insert_date.ToString() : "";
                        string receiptReceiptTime = !Object.ReferenceEquals(null, ordr.ord_insert_date) ? ordr.ord_insert_date.ToString() : "";
                        string receiptCurrentAccountId = tableRecIdFromErp_Account.Rows.Count > 0 ? tableRecIdFromErp_Account.Rows[0][0].ToString() : ""; // check this
                        Log.append(methodName + string.Format("receiptCurrentAccountId -> {0}", receiptCurrentAccountId), logFilePath);

                        string receiptWarehouseId = "1";
                        string receiptSpecialCode = !Object.ReferenceEquals(null, ordr.ord_code) ? ordr.ord_code.ToString() : "";

                        string receiptReceiptUpType = "0";
                        string receiptReceiptSubType = "0";
                        string receiptIsTaxExempted = "0";
                        string receiptShipmentType = "1";
                        //string receiptSubTotal = ordr.ord_grand_total;

                        string receiptVatAmount = "";
                        if (!Object.ReferenceEquals(null, ordr.ord_tax_total)) {
                            receiptVatAmount = Convert.ToDouble(ordr.ord_tax_total.ToString()).ToString("0.0000", System.Globalization.CultureInfo.InvariantCulture);
                        }
                        else {
                            receiptVatAmount = "";
                        }

                        //string receiptDiscountsTotal = ordr..ToString();
                        string receiptGrandTotal = "";

                        if (!Object.ReferenceEquals(null, ordr.ord_grand_total)) {
                            //MessageBox.Show(ordr.ord_grand_total.ToString());
                            receiptGrandTotal = Convert.ToDouble(ordr.ord_grand_total.ToString()).ToString("0.0000", System.Globalization.CultureInfo.InvariantCulture);
                        }

                        string receiptIsEximReceipt = "0";
                        string receiptIsApproved = "1";
                        string receiptControlCode = "0";
                        string receiptInsertedAt = !Object.ReferenceEquals(null, ordr.ord_insert_date) ? ordr.ord_insert_date.ToString() : "";
                        string receiptUpdatedAt = !Object.ReferenceEquals(null, ordr.ord_update_date) ? ordr.ord_update_date.ToString() : "";
                        string receiptInsertedBy = "6";
                        string receiptIsDeleted = "0";
                        string receiptCustomerOrderNo = !Object.ReferenceEquals(null, ordr.ord_cargo_ref_no) ? ordr.ord_cargo_ref_no.ToString() : "";
                        string receiptPaymentPlanId = tableRecIdFromErp_PaymentPlan.Rows.Count > 0 ? tableRecIdFromErp_PaymentPlan.Rows[0][0].ToString() : "";
                        string receiptExplanation = "";

                        /// explanation
                        if (!Object.ReferenceEquals(null, ordr.pop_code)) {
                            if (ordr.pop_code == "ccp" || ordr.pop_code == "ccp3d" || ordr.pop_code == "cct" || ordr.pop_code == "cct3d") {
                                receiptExplanation = string.Format("{0} kodlu sipariş, {1} isimli şahsa ait {2} ile tahsil edilmiştir.",
                                                                 specialCode,
                                                                 (!Object.ReferenceEquals(null, ordr.ord_ccowner) ? ordr.ord_ccowner.ToString() : ". . . . . . . . . . . . . ."),
                                                                 "kredi kartı");

                            }
                            else if (ordr.pop_code == "mo") {
                                if (Object.ReferenceEquals(null, ordr.ord_ccowner)) {
                                    receiptExplanation = string.Format("{0} kodlu sipariş, {1} isimli şahsa ait {2} ile tahsil edilmiştir.",
                                                                specialCode,
                                                                ". . . . . . . . . . . . . . . . . . ",
                                                                "EFT");
                                }

                            }
                            else {
                                receiptExplanation = string.Format("{0} kodlu sipariş, {1} isimli şahsa ait {2} ile tahsil edilmiştir.",
                                                                specialCode,
                                                                (!Object.ReferenceEquals(null, ordr.ord_ccowner) ? ordr.ord_ccowner.ToString() : ". . . . . . . . . . . . . ."),
                                                                ". . . . . . . . . . . ");
                            }
                        }
                        else {
                            receiptExplanation = string.Format("{0} kodlu sipariş, {1} isimli şahsa ait {2} ile tahsil edilmiştir.",
                                                               specialCode,
                                                               (!Object.ReferenceEquals(null, ordr.ord_ccowner) ? ordr.ord_ccowner.ToString() : ". . . . . . . . . . . . . ."),
                                                               ". . . . . . . . . . . ");
                        }


                        //kaydet
                        List<Functions.SqlObj> SqlObjReceipts = new List<Functions.SqlObj> {
                                new Functions.SqlObj("CompanyId", receiptCompanyId, false),                          new Functions.SqlObj("ReceiptUpType", receiptReceiptUpType, false),                new Functions.SqlObj("InsertedAt", receiptInsertedAt),
                                new Functions.SqlObj("ReceiptType", receiptReceiptType, false),                      new Functions.SqlObj("ReceiptSubType", receiptReceiptSubType, false),              new Functions.SqlObj("UpdatedAt", receiptUpdatedAt),
                                new Functions.SqlObj("ReceiptNo", receiptReceiptNo),                                 new Functions.SqlObj("IsTaxExempted", receiptIsTaxExempted, false),                new Functions.SqlObj("InsertedBy", receiptInsertedBy, false),
                                new Functions.SqlObj("ReceiptDate", receiptReceiptDate),                             new Functions.SqlObj("ShipmentType", receiptShipmentType, false),                  new Functions.SqlObj("IsDeleted", receiptIsDeleted, false),
                                new Functions.SqlObj("ReceiptTime", receiptReceiptTime),                             new Functions.SqlObj("VatAmount", receiptVatAmount,false),                         new Functions.SqlObj("CustomerOrderNo", receiptCustomerOrderNo),
                                new Functions.SqlObj("CurrentAccountId", receiptCurrentAccountId, false),            new Functions.SqlObj("GrandTotal", receiptGrandTotal, false),                      new Functions.SqlObj("PaymentPlanId", receiptPaymentPlanId, false),
                                new Functions.SqlObj("AddressId", receiptBillingAddressId),                          new Functions.SqlObj("ShippingAddressId", receiptShippingAddressId),               new Functions.SqlObj("IsEximReceipt", receiptIsEximReceipt, false),
                                new Functions.SqlObj("WarehouseId", receiptWarehouseId, false),                      new Functions.SqlObj("IsApproved", receiptIsApproved, false),                      new Functions.SqlObj("Explanation", receiptExplanation),
                                new Functions.SqlObj("SpecialCode", receiptSpecialCode),                             new Functions.SqlObj("ControlCode", receiptControlCode, false),                    new Functions.SqlObj("TransporterId", kargoNameId),
                                new Functions.SqlObj("OrderIdFromWeb", orderId)
                                //UD_Email what the hell is this
                            };
                        Functions.insertToSQL(connString, "Erp_OrderReceipt", SqlObjReceipts.ToArray());

                        // irsaliye kalemlerini gir
                        // get ReciptId
                        string querryGetReciptId = string.Format(@"SELECT RecId FROM  Erp_OrderReceipt WHERE SpecialCode = '{0}'", receiptSpecialCode);
                        DataTable tableReceiptId = Functions.getDataFromSql(connString, querryGetReciptId);

                        string itemOrderReceiptId = "";

                        if (tableReceiptId.Rows.Count < 1) {
                            Log.append(methodName + "tableReceiptId is empty", logFilePath);
                            itemOrderReceiptId = "";
                        }
                        else {
                            itemOrderReceiptId = tableReceiptId.Rows.Count > 0 ? tableReceiptId.Rows[0][0].ToString() : "";
                        }
                        string itemReceiptDate = !Object.ReferenceEquals(null, ordr.ord_insert_date) ? ordr.ord_insert_date.ToString() : "";
                        string itemReceiptType = "2";
                        string itemReceiptSubType = "0";
                        string itemWarehouseId = "1";
                        string itemItemType = "1";
                        string itemUnitId = "51";
                        string itemVatIncluded = "1";
                        string itemCalcType = "0";
                        string itemIsTaxExempted = "0";
                        string itemIsReserved = "1";
                        string itemIsClosed = "0";
                        string itemIsApproved = "1";
                        string itemControlCode = "0";
                        string itemInsertedBy = "6";
                        string itemIsDeleted = "0";
                        string itemInsertedAt = !Object.ReferenceEquals(null, ordr.ord_insert_date) ? ordr.ord_insert_date.ToString() : "";
                        string itemIsWClosed = "0";

                        int i = 1;
                        double receiptSubTotal = 0;
                        double receiptDiscountsTotal = 0;

                        if (!Object.ReferenceEquals(null, ordr.products)) {
                            foreach (var item in ordr.products) {
                                //if (!Object.ReferenceEquals(null, ordr.prd_set)) {
                                //    if (ordr.prd_set == "1") {
                                //        continue;
                                //    }
                                //}

                                string itemBarcode = !Object.ReferenceEquals(null, item.orp_barcode) ? item.orp_barcode.ToString() : "";
                                if (string.IsNullOrEmpty(itemBarcode)) {
                                    continue;
                                }
                                Log.append(methodName + "boşş mu?" + itemBarcode, logFilePath);
                                // get InventoryId
                                string querryGetInventoryId = string.Format(@"SELECT RecId FROM  Erp_Inventory WHERE InventoryCode = '{0}'", itemBarcode);
                                DataTable tableInventoryId = Functions.getDataFromSql(connString, querryGetInventoryId);

                                if (tableInventoryId.Rows.Count < 1) {
                                    Log.append(methodName + "tableInventoryId is empty " + querryGetInventoryId, logFilePath);
                                }
                                /*
                                 orp_quantity tırnaklı ve tırnaksız
                                */
                                //indirim satırı - > DiscountRate|DiscountAmount itemItemType
                                string itemItemOrderNo = i++.ToString();
                                string itemInventoryId = tableInventoryId.Rows.Count > 0 ? tableInventoryId.Rows[0][0].ToString() : "";
                                string itemQuantity = Convert.ToDouble(item.orp_quantity.ToString()).ToString("0.0000", System.Globalization.CultureInfo.InvariantCulture);
                                string itemNetQuantity = Convert.ToDouble(item.orp_quantity.ToString()).ToString("0.0000", System.Globalization.CultureInfo.InvariantCulture);
                                string itemUnitPrice = Convert.ToDouble(item.orp_unit_tprice.ToString()).ToString("0.0000", System.Globalization.CultureInfo.InvariantCulture);
                                string itemVatRate = Convert.ToDouble(item.orp_tax_rate.ToString()).ToString("0.0000", System.Globalization.CultureInfo.InvariantCulture);
                                string itemExpenseRate = Convert.ToDouble(item.orp_tax_rate.ToString()).ToString("0.0000", System.Globalization.CultureInfo.InvariantCulture);
                                string itemVatAmount = Convert.ToDouble(item.orp_tax.ToString()).ToString("0.0000", System.Globalization.CultureInfo.InvariantCulture);
                                string itemVatBaseAmount = Convert.ToDouble(item.orp_total.ToString()).ToString("0.0000", System.Globalization.CultureInfo.InvariantCulture);
                                string itemItemTotal = (Convert.ToDouble(item.orp_unit_price.ToString()) *
                                                       Convert.ToDouble(item.orp_quantity.ToString())).ToString("0.0000", System.Globalization.CultureInfo.InvariantCulture);
                                string itemDiscountsTotal = ((Convert.ToDouble(item.orp_unit_price.ToString()) -
                                                              Convert.ToDouble(item.orp_price.ToString())) *
                                                              Convert.ToDouble(item.orp_quantity.ToString())).ToString("0.0000", System.Globalization.CultureInfo.InvariantCulture);
                                /// discountamount1 + discountamount2+ discountamount3 ... 
                                string itemNetUnitPrice = Convert.ToDouble(item.orp_price.ToString()).ToString("0.0000", System.Globalization.CultureInfo.InvariantCulture);
                                string itemNetItemTotal = Convert.ToDouble(item.orp_total.ToString()).ToString("0.0000", System.Globalization.CultureInfo.InvariantCulture);

                                //kaydet
                                List<Functions.SqlObj> SqlObjReceiptItems = new List<Functions.SqlObj> {
                                new Functions.SqlObj("OrderReceiptId", itemOrderReceiptId, false),    new Functions.SqlObj("ReceiptType",itemReceiptType, false),             new Functions.SqlObj("ReceiptSubType", itemReceiptSubType, false),
                                new Functions.SqlObj("ReceiptDate", itemReceiptDate),                 new Functions.SqlObj("WarehouseId", itemWarehouseId, false),            new Functions.SqlObj("ItemType", itemItemType, false),
                                new Functions.SqlObj("ItemOrderNo", itemItemOrderNo,false),           new Functions.SqlObj("InventoryId", itemInventoryId, false),            new Functions.SqlObj("UnitId", itemUnitId, false),
                                new Functions.SqlObj("Quantity", itemQuantity, false),                new Functions.SqlObj("NetQuantity", itemQuantity, false),               new Functions.SqlObj("UnitPrice", itemUnitPrice, false),
                                new Functions.SqlObj("VatIncluded", itemVatIncluded, false),          new Functions.SqlObj("VatRate", itemVatRate, false),                    new Functions.SqlObj("CalcType", itemCalcType, false),
                                new Functions.SqlObj("ExpenseRate", itemExpenseRate, false),          new Functions.SqlObj("VatAmount", itemVatAmount, false),                new Functions.SqlObj("VatBaseAmount", itemVatBaseAmount, false),
                                new Functions.SqlObj("ItemTotal", itemItemTotal, false),
                                new Functions.SqlObj("DiscountsTotal", itemDiscountsTotal, false),    new Functions.SqlObj("NetUnitPrice", itemNetUnitPrice, false),          new Functions.SqlObj("NetItemTotal", itemItemTotal, false),
                                new Functions.SqlObj("IsTaxExempted", itemIsTaxExempted, false),      new Functions.SqlObj("IsReserved", itemIsReserved, false),              new Functions.SqlObj("IsClosed", itemIsClosed, false),
                                new Functions.SqlObj("IsWClosed", itemIsWClosed, false),
                                new Functions.SqlObj("IsApproved", itemIsApproved, false),            new Functions.SqlObj("ControlCode", itemControlCode, false),            new Functions.SqlObj("InsertedAt", itemInsertedAt),
                                new Functions.SqlObj("InsertedBy", itemInsertedBy, false),            new Functions.SqlObj("IsDeleted", itemIsDeleted, false)
                                    //UD_Email what the hell is this
                                };
                                Functions.insertToSQL(connString, "Erp_OrderReceiptItem", SqlObjReceiptItems.ToArray());

                                // for receipt update
                                receiptSubTotal += Convert.ToDouble(item.orp_unit_price) * Convert.ToDouble(item.orp_quantity);

                                if (Convert.ToDouble(item.orp_discount_rate.ToString()) > 0) {
                                    //indirim varsa
                                    // get ReciptId
                                    string querryDiscountParentItemId = string.Format(@"SELECT Top 1 RecId FROM  Erp_OrderReceiptItem WHERE OrderReceiptId = '{0}' ORDER BY ItemOrderNo DESC", itemOrderReceiptId);
                                    DataTable tableDiscountParentItemId = Functions.getDataFromSql(connString, querryDiscountParentItemId);

                                    string itemDiscountParentItemId = "";
                                    if (tableDiscountParentItemId.Rows.Count < 1) {
                                        Log.append(methodName + "tableDiscountParentItemId is empty", logFilePath);
                                    }
                                    else {
                                        itemDiscountParentItemId = tableDiscountParentItemId.Rows.Count > 0 ? tableDiscountParentItemId.Rows[0][0].ToString() : "";
                                    }
                                    //DiscountAmount = orp_discount_rate / 100 * orp_unit_price * orp_quantity //indirim satırında sadece
                                    //DiscountAmount =(orp_unit_price-orp_price)* orp_quantity 
                                    //DiscountRate //indirim satırında sadece
                                    string itemDiscountRate = Convert.ToDouble(item.orp_discount_rate.ToString()).ToString("0.0000", System.Globalization.CultureInfo.InvariantCulture);
                                    string itemDiscountAmount = ((Convert.ToDouble(item.orp_unit_price.ToString()) -
                                                                 Convert.ToDouble(item.orp_price.ToString())) *
                                                                 Convert.ToDouble(item.orp_quantity.ToString())).ToString("0.0000", System.Globalization.CultureInfo.InvariantCulture);
                                    // for receipt update
                                    receiptDiscountsTotal += (Convert.ToDouble(item.orp_unit_price) - Convert.ToDouble(item.orp_price)) * Convert.ToDouble(item.orp_quantity);

                                    string itemDiscountItemType = "50";
                                    //string itemDiscountParentItemId = tableDiscountParentItemId.Rows[0][0].ToString();
                                    string itemDiscountItemOrderNo = i++.ToString();
                                    string itemDiscountVatIncluded = "0";
                                    //kaydet
                                    List<Functions.SqlObj> SqlObjReceiptItemsDiscount = new List<Functions.SqlObj> {
                                         new Functions.SqlObj("OrderReceiptId", itemOrderReceiptId, false),    new Functions.SqlObj("ReceiptType",itemReceiptType, false),           new Functions.SqlObj("ReceiptDate", itemReceiptDate),
                                         new Functions.SqlObj("DiscountRate", itemDiscountRate, false),        new Functions.SqlObj("DiscountAmount", itemDiscountAmount, false),    new Functions.SqlObj("ItemType", itemDiscountItemType, false),
                                         new Functions.SqlObj("ParentItemId", itemDiscountParentItemId, false),new Functions.SqlObj("ItemOrderNo", itemDiscountItemOrderNo,false),   new Functions.SqlObj("VatIncluded", itemDiscountVatIncluded, false),
                                         new Functions.SqlObj("IsReserved", itemIsReserved, false),            new Functions.SqlObj("IsClosed", itemIsClosed, false),                new Functions.SqlObj("IsApproved", itemIsApproved, false),
                                         new Functions.SqlObj("InsertedAt", itemInsertedAt),                   new Functions.SqlObj("InsertedBy", itemInsertedBy, false),

                                    };
                                    Functions.insertToSQL(connString, "Erp_OrderReceiptItem", SqlObjReceiptItemsDiscount.ToArray());

                                }


                            }// foreach item
                        }
                        // update receipt
                        string queryUpdate2 = string.Format(@"UPDATE Erp_OrderReceipt SET SubTotal = {0}, DiscountsTotal = {1}  WHERE RecId = '{2}'",
                                                            receiptSubTotal.ToString("0.0000", System.Globalization.CultureInfo.InvariantCulture),
                                                            receiptDiscountsTotal.ToString("0.0000", System.Globalization.CultureInfo.InvariantCulture),
                                                            itemOrderReceiptId.ToString());
                        Functions.sendSQLCommand(connString, queryUpdate2);
                        receiptSubTotal = 0;
                        receiptDiscountsTotal = 0;
                    }
                    else {
                        //donothing
                        Log.append(methodName + "sipariş sentezde var", logFilePath);

                    }
                }//foreach
                Log.append(methodName + "bitti kapaniyom", logFilePath);

            } ///end of else

            await Task.Delay(DELAY_TIME);
            return true;

        }

        private static void insertOrderItems() {

        }


    }
}

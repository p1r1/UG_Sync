using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
//using SentezEInvoiceXML;

namespace UGCore {
    public static partial class UGSync_Order {
        private const string TestSpecialCode = ""; // debug only

        public static async Task<bool> /*bool*/ sendOrdersToSql(string daysAgo,
                                                                string url, string connString,
                                                                string mySqlConn,
                                                                string webUsername,
                                                                string webUserPass,
                                                                int DELAY_TIME,
                                                                bool isWebAdressBaseOnUpdateDate = true) {
            string logFilePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            string methodName = "SiparişMetodu--> ";

            /// ///
            /// Take website orders, insert them to sentez
            /// ///
            /// create weborder and get webOrders
            Console.WriteLine("daysAgo" + daysAgo);
            string url1 = Functions.createUrl4WebOrders(url, daysAgo, webUsername, webUserPass, isWebAdressBaseOnUpdateDate);
            Console.WriteLine(url1);
            WebOrder webOrders = new WebOrder(url1);
            /// yeni siparişten teslimata hazırlanıyora sipariş geçirmek için
            webOrders.getJsonFromWeb();
            webOrders.getJsonFromWeb();
            webOrders.createDynamicVar();
            if (Object.ReferenceEquals(null, webOrders)) {
                return false;
            }
            if (Object.ReferenceEquals(null, webOrders.m_data)) {
                return false;
            }

            if (!Object.ReferenceEquals(null, webOrders.m_data.orders)) {
                Log.append(methodName + $" #{DateTime.Now.ToString()}# Sipariş sayısı:" + webOrders.m_data.orders.Count.ToString(), logFilePath);
            }
            else {
                return false;
            }
            /// ///
            /// Check Duplicates
            /// ///
            var JArrayWeborders = (JArray)webOrders.m_data.orders;
            if (JArrayWeborders.GroupBy(x => x["ord_code"]).Any(g => g.Count() > 1)) {
                Console.WriteLine("Json Contains duplicates");
                await PostToDiscrod("Json Contains duplicates", "", "", "");
                await PostToDiscrodAsFile(webOrders.m_data);
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
                    await Task.Delay(200);
                    /// order
                    string specialCode = !Object.ReferenceEquals(null, ordr.ord_code) ? ordr.ord_code : null;

                    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////debug
#if DEBUG
                    
                    //if (specialCode != TestSpecialCode) {
                    //    continue;
                    //}
                   

#endif
                    string orderId = !Object.ReferenceEquals(null, ordr.ord_id) ? ordr.ord_id.ToString() : null;
                    /// HER SİPARİŞE AYRI CARİ AÇ FATURA KISMINI KULLAN (EKRANIN EN SOLU)!!!!!!!!!
                    string accountName = !Object.ReferenceEquals(null, ordr.ord_mmb_name) ? ordr.ord_mmb_name.ToString() : null;
                    string accountShippingName = !Object.ReferenceEquals(null, ordr.ord_shipping_name) ? ordr.ord_shipping_name.ToString() : null;
                    string accountBillName = !Object.ReferenceEquals(null, ordr.ord_billing_name) ? ordr.ord_billing_name.ToString() : null;/// real account name
                    string cargoName = !Object.ReferenceEquals(null, ordr.crg_name) ? ordr.crg_name.ToString() : null;

                    /// ///
                    /// Check order status
                    /// ///
                    if (!Object.ReferenceEquals(null, ordr.ord_status)) {
                        if (ordr.ord_status.ToString() == "1") {
                            ///TODO: ord_status-> ors_id
                            /// Yeni Sipariş - aksaraysa bas, değilse basma
                            //Console.WriteLine(ordr.ord_status.ToString() + "*|*" + ordr.ors_id.ToString());
                            try {
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
                            }
                            catch (Exception) { }
                            /// AKSARAY
                            if (cargoName == "Aksaray Kurye") {
                                /// change cargo status
                                var res = await ChangeOrderStatus(orderId, "12");/// sip hazırlanıyora al
                                if (!res) {
                                    await Task.Delay(200);
                                    var res2 = await ChangeOrderStatus(orderId, "12");/// sip hazırlanıyora al
                                    if (!res2) {
                                        await PostToDiscrod(orderId, specialCode, accountShippingName, "sipariş durumu değiştirilemedi!!!!!!!!!");
                                    }
                                }
                                /// change cargo number
                            }
                            else {
                                continue;
                            }
                        }
                        else if (ordr.ord_status.ToString() == "2") {
                            /// eft - basma
                            Console.WriteLine("EFT - " + ordr.ord_status.ToString() + "*|*" + ordr.ors_id.ToString());
                            try {
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
                            }
                            catch (Exception) { }
                            continue;
                        }
                        else if (ordr.ord_status.ToString() == "12") {
                            /// "Sipariş hazırlanıyor" - bas
                            Console.WriteLine(specialCode + "*|*" + ordr.ord_status.ToString() + "*|*" + ordr.ors_id.ToString());
                            //TODO: korgo noyu column aç!!
                            //TODO: belge no!!
                        }
                        else if (ordr.ord_status.ToString() == "22") {
                            /// "Kargoya Hazır" - bas
                            Console.WriteLine(specialCode + "*|*" + ordr.ord_status.ToString() + "*|*" + ordr.ors_id.ToString());
                            //TODO: korgo noyu column aç!!
                            //TODO: belge no!!
                        }
                        else if (ordr.ord_status.ToString() == "18") {
                            /// "Kurye teslimi" - bas
                            Console.WriteLine(specialCode + "*|*" + ordr.ord_status.ToString() + "*|*" + ordr.ors_id.ToString());
                        }
                        else if (ordr.ord_status.ToString() == "23") {
                            /// "Kapıda Ödeme" - bas
                            Console.WriteLine(specialCode + "*|*" + ordr.ord_status.ToString() + "*|*" + ordr.ors_id.ToString());
                        }
                        //else if (ordr.ord_status.ToString() == "24") {
                        //    Console.WriteLine(specialCode + "*|*" + ordr.ord_status.ToString() + "*|*" + ordr.ors_id.ToString());
                        //}
                        else {
                            Console.WriteLine(specialCode + "*|*" + ordr.ord_status.ToString() + "*|*" + ordr.ors_id.ToString());
                            continue;
                        }
                    }
                    else {
                        Console.WriteLine("ord_status is null");
                        continue;
                    }


                    /// Check special code length
                    if (specialCode.Length > 15) {
                        await PostToDiscrod(orderId, specialCode, accountShippingName, "sipariş kodu 15 haneden uzun. BASAMAZ!!!-> temin edildiye alınıyor.");
                        var res = await ChangeOrderStatus(orderId, "16");
                        if (!res) {
                            await Task.Delay(200);
                            var res2 = await ChangeOrderStatus(orderId, "16");
                            if (!res2) {
                                await PostToDiscrod(orderId, specialCode, accountShippingName, "sipariş durumu değiştirilemedi!!!!!!!!!");
                            }
                        }
                        continue;
                    }

                    /// ///
                    /// Check the special code. If special codes exist in the order then skip that order.
                    /// ///
                    string queryCountRecId = $"SELECT Count(RecId) as adet FROM  Erp_InventoryReceipt WHERE IsCancelled!=1 and SpecialCode='{specialCode}'";
                    DataTable tableOrderSpecialCode = Functions.getDataFromSql(connString, queryCountRecId);

                    if (tableOrderSpecialCode.Rows.Count < 1) {
                        Log.append(methodName + "tableOrderSpecialCode is empty", logFilePath);
                        break;
                    }                    
                    if (tableOrderSpecialCode.Rows[0]["adet"].ToString() != "0") {
                        continue;
                    }

                    /// Double check the special code
                    await Task.Delay(20);
                    string isIRexist1 = Functions.executeScalar(connString, $"select RecId from Erp_InventoryReceipt where IsCancelled!=1 and SpecialCode='{specialCode}'");
                    if (!string.IsNullOrEmpty(isIRexist1)) {
                        continue;
                    }


                    /// The thing
                    if (tableOrderSpecialCode.Rows.Count > 0 && tableOrderSpecialCode.Rows[0][0].ToString() == "0") {
                        /// Sentez doesn't have this order's special code . Make a new order in sentez.

                        /// ///
                        /// printable obj
                        /// ///
                        PrintableReceipt printableReceipt = new PrintableReceipt();
                        printableReceipt.SpecialCode = specialCode;
                        printableReceipt.SpecialCodeBarcode = printableReceipt.generateBarcode(specialCode);
                        printableReceipt.ShippingName = accountShippingName;
                        printableReceipt.BillingName = accountBillName;

                        /// check cargo stuff
                        string receiptCargoNo = !Object.ReferenceEquals(null, ordr.ord_cargo_ref_no) ? ordr.ord_cargo_ref_no.ToString() : null;
                        if (cargoName == "Aras Kargo" || cargoName == "Yurtiçi Kargo" || cargoName == "Aksaray Kurye") {
                            if (ordr.pop_code == "pzr") {
                                /// N-11
                                if (specialCode.Contains("UG-N")) {
                                    /// Do nothing now!
                                }
                            }
                            else {
                                receiptCargoNo = orderId;
                            }
                        }
                        else { // TODO!:This for new kargo
                            if (string.IsNullOrEmpty(receiptCargoNo) || receiptCargoNo.StartsWith("0") == true) {
                                Console.WriteLine("CargoBarcodeString is empty!");
                                continue;
                            }
                        }

                        printableReceipt.CargoBarcodeString = receiptCargoNo;
                        printableReceipt.CargoBarcode = printableReceipt.generateBarcode(receiptCargoNo);
                        //printableReceipt.CargoBarcodeQR = printableReceipt.generateQRBarcode(logo, receiptCargoNo);
                        //Console.WriteLine(printableReceipt.CargoBarcodeQR);

                        if (printableReceipt.CargoBarcode == null || string.IsNullOrEmpty(printableReceipt.CargoBarcodeString)) {
                            Console.WriteLine("CargoBarcodeString is empty!");
                            continue;
                        }

                        #region irsaliye gönderme tarihi old
                        //DateTime now = DateTime.Now;
                        //printableReceipt.InsertDate = now.ToString("dd/MM/yyyy");
                        //printableReceipt.InsertHour = now.ToString("HH:mm");

                        /// shippingDate
                        /// if time passed 16:00 or sunday or satuday
                        //DateTime printShippingDate = now;
                        //if (now.DayOfWeek == DayOfWeek.Sunday) {
                        //    /// sunday-> to monday 1
                        //    //printableReceipt.ShippingDate = DateTime.Today.AddDays(1).AddHours(9).ToString("dd/MM/yyyy"); //hour does not matter
                        //}
                        //else if (now.DayOfWeek == DayOfWeek.Saturday) {
                        //    /// saturday 11 treshold -> to monday 2
                        //    if (now.TimeOfDay >= new TimeSpan(11, 0, 0)) {
                        //        printShippingDate = DateTime.Today.AddDays(2).AddHours(9);
                        //        //printableReceipt.ShippingDate = DateTime.Today.AddDays(2).AddHours(9).ToString("dd/MM/yyyy");
                        //    }
                        //    else {
                        //        printShippingDate = now;
                        //        //printableReceipt.ShippingDate = now.ToString("dd/MM/yyyy");
                        //    }
                        //}
                        //else {
                        //    /// weekdays
                        //    if (now.TimeOfDay >= new TimeSpan(16, 0, 0)) {
                        //        printShippingDate = DateTime.Today.AddDays(1).AddHours(9);
                        //        //printableReceipt.ShippingDate = DateTime.Today.AddDays(1).AddHours(9).ToString("dd/MM/yyyy");
                        //    }
                        //    else {
                        //        printShippingDate = now;
                        //        //printableReceipt.ShippingDate = now.ToString("dd/MM/yyyy");
                        //    }
                        //}
                        #endregion


                        /// create document No
                        /// do not insert document no
                        string docNoTemplate = "UGI" + DateTime.Now.Year;
                        string lastDocNo = Functions.executeScalar(connString,
                                           $@"SELECT DocumentNo FROM Erp_InventoryReceipt WHERE DocumentNo LIKE '{docNoTemplate}%' ORDER BY DocumentNo DESC");

                        string receiptCurrentDocNo = "";
                        if (string.IsNullOrEmpty(lastDocNo)) {
                            receiptCurrentDocNo = docNoTemplate + "00000001";
                            printableReceipt.ReceiptDocNo = receiptCurrentDocNo;
                        }
                        else {
                            int x = Convert.ToInt32(lastDocNo.Substring(lastDocNo.Length - 8));
                            x++;
                            receiptCurrentDocNo = docNoTemplate + x.ToString("00000000");
                            printableReceipt.ReceiptDocNo = receiptCurrentDocNo;
                        }

                        Console.WriteLine(receiptCurrentDocNo);
                        /// get logo from sql
                        DataTable dataLogo = Functions.getDataFromSql(connString, $@"SELECT Definition FROM Meta_Report WHERE ReportName='OFMlogoQR'");
                        Bitmap logo = null;
                        if (dataLogo.Rows.Count == 1) {
                            byte[] bytArray = (byte[])dataLogo.Rows[0][0];
                            MemoryStream mem = new MemoryStream(bytArray);
                            logo = new Bitmap(mem);
                        }

                        //printableReceipt.ReceiptNoQR = printableReceipt.generateQRBarcode(logo, receiptCurrentDocNo);
                        printableReceipt.ReceiptNoBarcode = printableReceipt.generateBarcode(receiptCurrentDocNo, 300, 70);
                        if (string.IsNullOrEmpty(printableReceipt.ReceiptNoBarcode)) {
                            Console.WriteLine("ReceiptNoBarcode is empty!");
                            break;
                        }
                        //Console.WriteLine(printableReceipt.ReceiptNoQR);
                        ////////////////////////////////////////////////////////////////////////////
                        /// ///
                        /// Account Info
                        /// ///                        
                        string accountID = !Object.ReferenceEquals(null, ordr.ord_mmb_id) ? ordr.ord_mmb_id.ToString() : null;
                        string accountTaxNo = !Object.ReferenceEquals(null, ordr.ord_billing_tax_number) ? ordr.ord_billing_tax_number.ToString() : null;
                        if (accountTaxNo.Contains("X")) {
                            try {
                                accountTaxNo = accountTaxNo.Replace("X", "");
                            }
                            catch (Exception) {
                            }

                        }
                        else if (accountTaxNo.Contains("x")) {
                            try {
                                accountTaxNo = accountTaxNo.Replace("x", "");
                            }
                            catch (Exception) {
                            }
                        }
                        if (string.IsNullOrEmpty(accountTaxNo)) {
                            accountTaxNo = "11111111111";
                        }
                        //printableReceipt.TaxNo = accountTaxNo;

                        string accountKind = "2"; /// 1= Şirket,  2= Şahıs , 3= Personel
                        if (accountTaxNo.Length == 11) {
                            accountKind = "2";
                        }
                        else if (accountTaxNo.Length == 10) {
                            accountKind = "1";
                        }
                        else {
                            Log.append(methodName + "accountTaxNo is wrong", logFilePath);
                            Console.WriteLine("accountTaxNo is wrong");
                            accountTaxNo = "11111111111";
                            accountKind = "2";
                            //continue;
                        }

                        string accountEmail = !Object.ReferenceEquals(null, ordr.ord_mmb_email) ? ordr.ord_mmb_email.ToString() : null;
                        printableReceipt.ShippingEmail = accountEmail;
                        string accountBillGsmPhone = !Object.ReferenceEquals(null, ordr.ord_billing_phone) ? ordr.ord_billing_phone.ToString() : null;

                        string accountProfession = null;
                        if (!Object.ReferenceEquals(null, ordr.member)) {
                            accountProfession = !Object.ReferenceEquals(null, ordr.member.mmb_job_name) ? ordr.member.mmb_job_name.ToString() : null;
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        /// ///
                        /// Bill Address 001      
                        /// ///
                        /// District
                        string accountAddressTown = null;
                        if (Object.ReferenceEquals(null, ordr.ord_billing_town_id)) {
                            Console.WriteLine("ordr.ord_billing_town_id yanlış->" + ordr.ord_billing_town_id);
                        }
                        else {
                            try {
                                accountAddressTown = Functions.executeScalar(connString, string.Format(@"SELECT RecId as adet FROM  Meta_District WHERE CodeN = '{0}'",
                                                                                                !Object.ReferenceEquals(null, ordr.ord_billing_town_id) ? ordr.ord_billing_town_id.ToString() : null));
                            }
                            catch (Exception) {
                            }
                        }
                        /// if codeN not esxist, write an error in mysql error log
                        if (string.IsNullOrEmpty(accountAddressTown)) {
                            try {
                                MySqlObj mySql = new MySqlObj(Functions.GetConnString("my_sql"));
                                Console.WriteLine("yow1");
                                mySql.insert($@"INSERT INTO robot.a_log_hata (tablo, tablo_id, guncelleme, guncelleyen, olay)
                                            VALUES('Erp_Address', 0, 
                                            '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', 'OFM_Integration', 'Site_Town_id:{ordr.ord_billing_town_id.ToString()}');",
                                            true);
                            }
                            catch (Exception ex) {
                                Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ex);
                            }
                        }

                        /// city
                        string accountAddressCity = null;
                        accountAddressCity = Functions.executeScalar(connString, string.Format(@"SELECT RecId as adet FROM  Meta_City WHERE CodeN = '{0}'",
                                                                       !Object.ReferenceEquals(null, ordr.ord_billing_city_id) ? ordr.ord_billing_city_id.ToString() : ""));

                        /// If Corporate bill 
                        string accountAddressTaxOffice = null;
                        if (!Object.ReferenceEquals(null, ordr.ord_billing_tax_office)) {
                            if (!string.IsNullOrEmpty(ordr.ord_billing_tax_office.ToString())) {
                                /// write this in erp_current account -> blog
                                accountAddressTaxOffice = ordr.ord_billing_tax_office.ToString();
                            }
                        }
                        string taxOfficeName = accountAddressTaxOffice;
                        var isNumeric = int.TryParse(accountAddressTaxOffice, out int n);
                        if (isNumeric) {
                            taxOfficeName = Functions.executeScalar(connString, $@"SELECT Name FROM Meta_TaxOffice WHERE RecId='{accountAddressTaxOffice}'");
                        }
                        else {
                            accountAddressTaxOffice = null;
                        }
                        //printableReceipt.TaxOffice = taxOfficeName;

                        // check if eInvoice user
                        int isEInvoiceUser = -1;
                        // 2 - earchive 1-efatura
                        // if taxofficename is not empty then check
                        if (!string.IsNullOrEmpty(taxOfficeName)) {
                            try {
                                Console.WriteLine("Checking einvoice on EDM");
                                isEInvoiceUser = EdmEInvoiceCheckUser.IsEInvoiceUserCheck(accountTaxNo);
                                if (isEInvoiceUser == -1) {
                                    // make default e-arşiv
                                    isEInvoiceUser = 2;
                                }
                            }
                            catch (Exception ex) {
                                Console.WriteLine(ex);
                            }
                        }
                        else {
                            // e-arşiv
                            isEInvoiceUser = 2;
                        }
                        ///// sign as E-Invoice
                        //bool isEInvoice = false;
                        //if (!ReferenceEquals(null, ordr.mmb_field1)) {
                        //    if (ordr.mmb_field1.ToString().Trim() == "EInvoice") {
                        //        isEInvoice = true;
                        //    }
                        //}

                        // TradeName
                        string accountBillFirmName = !Object.ReferenceEquals(null, ordr.ord_billing_firm_name) ? ordr.ord_billing_firm_name.ToString() : null;
                        string accountBillTown = !string.IsNullOrEmpty(accountAddressTown) ? accountAddressTown : null;
                        string accountBillCity = !string.IsNullOrEmpty(accountAddressCity) ? accountAddressCity : null;
                        string accountBillAddress = !Object.ReferenceEquals(null, ordr.ord_billing_address) ? ordr.ord_billing_address.ToString() : null;
                        //accountBillAddress = Regex.Replace(accountBillAddress, @"[\r\n'/\\]", " ");

                        /// Split the address to lengnt of 50
                        string accountBillAddress1 = null;
                        string accountBillAddress2 = null;
                        string accountBillAddress3 = null;
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

                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        /// ///
                        /// Shipping Address (not that importat)
                        /// ///
                        /// ship district
                        string shippingTown = null;
                        if (Object.ReferenceEquals(null, ordr.ord_shipping_town_id)) {
                            Console.WriteLine("ordr.ord_billing_town_id yanlış->" + ordr.ord_shipping_town_id);
                        }
                        else {
                            try {
                                string districtCodeN = !Object.ReferenceEquals(null, ordr.ord_shipping_town_id) ? ordr.ord_shipping_town_id.ToString() : "";
                                DataTable tableDistrict = Functions.getDataFromSql(connString, $@"SELECT RecId, DistrictCode FROM  Meta_District WHERE CodeN='{districtCodeN}'");
                                if (tableDistrict.Rows.Count > 0) {
                                    shippingTown = tableDistrict.Rows[0]["RecId"].ToString();
                                    printableReceipt.ShippingCityAndTown = tableDistrict.Rows[0]["DistrictCode"].ToString();
                                }
                            }
                            catch (Exception) {
                            }
                        }
                        string projectId = "6"; //siparişe hazırlanıyor
                        if (!Object.ReferenceEquals(null, ordr.ord_shipping_town)) {
                            string ord_shipping_town = ordr.ord_shipping_town;
                            if (!string.IsNullOrEmpty(ord_shipping_town) && ord_shipping_town.Contains("AKSARAY") && ord_shipping_town.Contains("MERKEZ")) {
                                printableReceipt.Ship68 = "AKSARAY!";
                            }
                            else {
                                printableReceipt.Ship68 = "";
                            }
                        }
                        /// write error in mysql error log
                        if (string.IsNullOrEmpty(shippingTown)) {
                            try {
                                MySqlObj mySql = new MySqlObj(Functions.GetConnString("my_sql"));
                                Console.WriteLine("yow2");
                                mySql.insert($@"INSERT INTO robot.a_log_hata (tablo, tablo_id, guncelleme, guncelleyen, olay)
                                            VALUES('Erp_Address', 0, 
                                            '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', 'OFM_Integration', 'Site_Town_id:{ordr.ord_shipping_town_id.ToString()}');",
                                            true);
                            }
                            catch (Exception ex) {
                                Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ex);
                            }

                        }

                        /// ship City                        
                        string shippingCity = null;
                        shippingCity = Functions.executeScalar(connString, string.Format(@"SELECT RecId FROM  Meta_City WHERE CodeN = '{0}'",
                                                                           !Object.ReferenceEquals(null, ordr.ord_shipping_city_id) ? ordr.ord_shipping_city_id.ToString() : null));

                        ///increase last adress Code
                        string accountShippingPhone = !Object.ReferenceEquals(null, ordr.ord_shipping_phone) ? ordr.ord_shipping_phone : null;
                        printableReceipt.ShippingPhone = accountShippingPhone;
                        string accountShippingAddressName = !Object.ReferenceEquals(null, ordr.ord_shipping_name) ? ordr.ord_shipping_name : null;
                        string accountShippingAddressTown = !string.IsNullOrEmpty(shippingTown) ? shippingTown : null;
                        string accountShippingAddressCity = !string.IsNullOrEmpty(shippingCity) ? shippingCity : null;

                        string accountShippingAddressAddress = !Object.ReferenceEquals(null, ordr.ord_shipping_address) ? ordr.ord_shipping_address.ToString() : null;
                        //accountAddress = Regex.Replace(accountAddress, @"[\r\n']", " ");,
                        printableReceipt.ShippingAddress = accountShippingAddressAddress;

                        /// Split the address to lengnt of 50
                        string accountShippingAddress1 = null;
                        string accountShippingAddress2 = null;
                        string accountShippingAddress3 = null;
                        var accountAddressList = stringSpliter(accountShippingAddressAddress.Trim(), 49);
                        try {
                            if (accountAddressList.ToArray().Length == 1) {
                                accountShippingAddress1 = accountAddressList.ToArray()[0].ToString();
                            }
                            else if (accountAddressList.ToArray().Length == 2) {
                                accountShippingAddress1 = accountAddressList.ToArray()[0].ToString();
                                accountShippingAddress2 = accountAddressList.ToArray()[1].ToString();
                            }
                            else if (accountAddressList.ToArray().Length == 3) {
                                accountShippingAddress1 = accountAddressList.ToArray()[0].ToString();
                                accountShippingAddress2 = accountAddressList.ToArray()[1].ToString();
                                accountShippingAddress3 = accountAddressList.ToArray()[2].ToString();
                            }
                            // else ///too long address 
                        }
                        catch (Exception) { }

                        ////////////////////////////////////////////////////////////////////////////////write
                        /// ///
                        /// Create Account
                        /// ///
                        string currentAccountCode = null;
                        if (accountID == "0") {
                            /// Not a member of Website. 
                            /// ID=(AccountCode like )     
                            currentAccountCode = specialCode;
                        }
                        else {
                            /// Id is NOT 0! A member of Website!. 
                            /// ID=(AccountCode like 110122) 
                            currentAccountCode = accountID + "_" + specialCode;
                        }

                        /// ///
                        /// SELL POINT - SATIŞ NOKTASI
                        /// ///
                        bool isSellPoint = false;
                        string parentAccountRecId = "";
                        if (!ReferenceEquals(null, ordr.mmb_account_code) && !string.IsNullOrEmpty(ordr.mmb_account_code.ToString())) {
                            isSellPoint = true;
                            parentAccountRecId = Functions.executeScalar(connString, $"select RecId from Erp_CurrentAccount where CurrentAccountCode='{ordr.mmb_account_code.ToString()}'");
                        }



                        /// ///
                        /// Create Current Account
                        /// ///
                        string newAccountRecId = null;
                        string sameAccountCodeRecId = Functions.executeScalar(connString, $@"SELECT RecId FROM Erp_CurrentAccount WHERE CurrentAccountCode='{currentAccountCode}'");
                        string bill_adress_code = "001";
                        string ship_adress_code = "002";

                        if (!string.IsNullOrEmpty(sameAccountCodeRecId)) {
                            /// if accountcode exist take recid
                            newAccountRecId = sameAccountCodeRecId;

                            // if accouunt exist change adress code and is default=0
                            DataTable prev_adress_table = Functions.getDataFromSql(connString,
                                         $"select RecId, AddressCode from Erp_Address where CurrentAccountId={newAccountRecId} order by AddressCode desc");

                            if (int.TryParse(prev_adress_table.Rows[0]["AddressCode"].ToString(), out int prev_adrescode)) {

                                // billing
                                bill_adress_code = (prev_adrescode + 1).ToString("000");
                                Functions.SqlObj[] SqlObjAdressUpdate = new Functions.SqlObj[] {
                                    new Functions.SqlObj("IsDefault", "0"),
                                };
                                Functions.updateSQL(connString, "Erp_Address", $"RecId='{prev_adress_table.Rows[0]["RecId"]}'", SqlObjAdressUpdate);

                                // shipping
                                ship_adress_code = (prev_adrescode + 2).ToString("000");
                                Functions.SqlObj[] SqlObjAdressUpdate2 = new Functions.SqlObj[] {
                                    new Functions.SqlObj("IsDefault", "0"),
                                };
                                Functions.updateSQL(connString, "Erp_Address", $"RecId='{prev_adress_table.Rows[1]["RecId"]}'", SqlObjAdressUpdate2);
                            }
                            else {
                                Console.WriteLine("wrong billing adres code");
                                bill_adress_code = "001";
                                ship_adress_code = "002";
                            }

                        }
                        else {
                            /// else insert the account
                            List<Functions.SqlObj> SqlObjsAccount2 = new List<Functions.SqlObj> {
                                new Functions.SqlObj("CompanyId", "1"), /// 1= our company 
                                new Functions.SqlObj("CurrentAccountCode", currentAccountCode),
                                new Functions.SqlObj("CurrentAccountName", accountBillName),
                                new Functions.SqlObj("TradeName", accountBillFirmName),
                                new Functions.SqlObj("CurrentAccountType", "2"), /// 1= satici, 2 = alici
                                new Functions.SqlObj("CurrentAccountKind", accountKind),
                                new Functions.SqlObj("EMail", accountEmail),
                                new Functions.SqlObj("TaxOfficeId", accountAddressTaxOffice),// blog
                                new Functions.SqlObj("Blog", taxOfficeName),
                                new Functions.SqlObj("GsmPhone", accountBillGsmPhone),
                                new Functions.SqlObj("TaxNo", accountTaxNo),
                                new Functions.SqlObj("InUse", "1"), /// 1= checked
                                new Functions.SqlObj("Profession", accountProfession),
                                new Functions.SqlObj("CategoryId", "2"), /// 2=Piramit, Öğretmen etc.
                                new Functions.SqlObj("InsertedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")), /// now
                                new Functions.SqlObj("InsertedBy", "24"), /// 24=webservis
                                new Functions.SqlObj("EInvoiceScenario", "1"), // 1 - temel fatura
                                new Functions.SqlObj("IsEInvoice", isEInvoiceUser.ToString())// 2 - earchive 1-efatura
                            };
                            if (isSellPoint && !string.IsNullOrEmpty(parentAccountRecId)) {
                                SqlObjsAccount2.Add(new Functions.SqlObj("ParentId", parentAccountRecId));
                            }
                            newAccountRecId = Functions.insertToSQLAndRetunId(connString, "Erp_CurrentAccount", SqlObjsAccount2.ToArray()).ToString();
                        }
                        /////////////////////////////////////////////////////////////////////////////////////////////////
                        /// ///
                        /// Create Addresses
                        /// ///
                        /// Insert Billing Address
                        List<Functions.SqlObj> SqlObjsAddress = new List<Functions.SqlObj> {
                                new Functions.SqlObj("CurrentAccountId", newAccountRecId),
                                new Functions.SqlObj("AddressCode", bill_adress_code), /// "001"= first address = bill(fatura)
                                new Functions.SqlObj("SpecialCode", "fatura"), /// "fatura"= special code
                                new Functions.SqlObj("AddressType", "1"), ///  "1" = home adress
                                new Functions.SqlObj("Line1", accountBillAddress1),
                                new Functions.SqlObj("Line2", accountBillAddress2),
                                new Functions.SqlObj("Line3", accountBillAddress3),
                                new Functions.SqlObj("DistrictId", accountBillTown),
                                new Functions.SqlObj("CityId", accountBillCity),
                                new Functions.SqlObj("CountryId", "186"), /// "186"= Turkey
                                new Functions.SqlObj("InUse", "1"), /// "1" = inuse
                                new Functions.SqlObj("IsDefault", "1"), /// "1" = default
                                new Functions.SqlObj("InsertedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")), /// now
                                new Functions.SqlObj("InsertedBy", "24"), /// 24= webservis
                                new Functions.SqlObj("EMail", accountEmail)
                        };
                        string receiptBillingAddressId = null;
                        receiptBillingAddressId = Functions.insertToSQLAndRetunId(connString, "Erp_Address", SqlObjsAddress.ToArray()).ToString();

                        /// Insert Shipping Address
                        List<Functions.SqlObj> SqlObjsAddress2 = new List<Functions.SqlObj> {
                                new Functions.SqlObj("CurrentAccountId", newAccountRecId),
                                new Functions.SqlObj("AddressCode", ship_adress_code),/// "002"= second address = shipping(sevk)
                                new Functions.SqlObj("SpecialCode", "sevk"), ///"sevk" =? specialcode
                                new Functions.SqlObj("AddressType", "1"), ///"1" = home adress
                                new Functions.SqlObj("Line1", accountShippingAddress1),
                                new Functions.SqlObj("Line2", accountShippingAddress2),
                                new Functions.SqlObj("Line3", accountShippingAddress3),
                                new Functions.SqlObj("Phone", accountShippingPhone),
                                new Functions.SqlObj("DistrictId", accountShippingAddressTown),
                                new Functions.SqlObj("Explanation", accountShippingName),
                                new Functions.SqlObj("CityId", accountShippingAddressCity),
                                new Functions.SqlObj("CountryId", "186"), /// "186"= Turkey
                                new Functions.SqlObj("InUse", "1"), /// "1" = inuse
                                new Functions.SqlObj("IsDefault", "0"),
                                new Functions.SqlObj("InsertedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")), ///now
                                new Functions.SqlObj("InsertedBy", "24"), /// 24= webservis
                                new Functions.SqlObj("EMail", accountEmail)
                        };
                        string receiptShippingAddressId = null;
                        receiptShippingAddressId = Functions.insertToSQLAndRetunId(connString, "Erp_Address", SqlObjsAddress2.ToArray()).ToString();

                        /////////////////////////////////////////////////////////////////////////////////
                        /// ///
                        /// irsaliye olustur
                        /// ///
                        /// generate receiptNo
                        DataTable tableLastReceiptNo = Functions.getDataFromSql(connString, @"SELECT ReceiptNo FROM  Erp_InventoryReceipt WHERE ReceiptType='120' ORDER BY ReceiptNo DESC");
                        string receiptReceiptNo = string.Format("{0:00000000}",
                                                  (Convert.ToInt32(tableLastReceiptNo.Rows.Count > 0 ? tableLastReceiptNo.Rows[0][0].ToString() : "") + 1));

                        /// payment plan getRecId from Erp_PaymentPlan account
                        string querryRecIdFromErp_PaymentPlan = string.Format(@"SELECT RecId FROM  Erp_PaymentPlan WHERE PlanCode = '{0}'",
                                                                              !Object.ReferenceEquals(null, ordr.pop_code) ? ordr.pop_code.ToString() : "");
                        DataTable tableRecIdFromErp_PaymentPlan = Functions.getDataFromSql(connString, querryRecIdFromErp_PaymentPlan);
                        if (tableRecIdFromErp_PaymentPlan.Rows.Count < 1) {
                            Log.append(methodName + "tableRecIdFromErp_PaymentPlan is empty", logFilePath);
                        }

                        /// cargoId getRecId from Erp_Transporter account
                        printableReceipt.CargoName = cargoName;
                        string querryRecIdFromErp_Transporter = string.Format(@"SELECT RecId FROM  Erp_Transporter WHERE TransporterCode = '{0}'", cargoName);
                        DataTable tableRecIdFromErp_Transporter = Functions.getDataFromSql(connString, querryRecIdFromErp_Transporter);
                        if (tableRecIdFromErp_Transporter.Rows.Count < 1) {
                            Log.append(methodName + "tableRecIdFromErp_Transporter is empty", logFilePath);
                        }
                        string receiptCargoNameId = tableRecIdFromErp_Transporter.Rows.Count > 0 ? tableRecIdFromErp_Transporter.Rows[0][0].ToString() : null;

                        /// calculate vat amount
                        string receiptVatAmount = null;
                        if (!Object.ReferenceEquals(null, ordr.ord_tax_total)) {
                            receiptVatAmount = Convert.ToDouble(ordr.ord_tax_total.ToString()).ToString("0.0000", System.Globalization.CultureInfo.InvariantCulture);
                        }

                        /// calculate grandtotal
                        string receiptGrandTotal = null;
                        if (!Object.ReferenceEquals(null, ordr.ord_grand_total)) {
                            receiptGrandTotal = Convert.ToDouble(ordr.ord_grand_total.ToString()).ToString("0.0000", System.Globalization.CultureInfo.InvariantCulture);
                            printableReceipt.PayGrandTotal = Convert.ToDouble(ordr.ord_grand_total.ToString()).ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
                            printableReceipt.PayGrandTotal = printableReceipt.PayGrandTotal.Replace('.', ',');
                        }

                        string receiptInsertedAt = !Object.ReferenceEquals(null, ordr.ord_insert_date) ? ordr.ord_insert_date.ToString() : null;
                        string receiptUpdatedAt = !Object.ReferenceEquals(null, ordr.ord_update_date) ? ordr.ord_update_date.ToString() : null;


                        /// ///
                        /// Change Order Status
                        /// ///

                        ///Aksaray 
                        if (!string.IsNullOrEmpty(printableReceipt.Ship68) && printableReceipt.Ship68 == "AKSARAY!") {
                            /// Change order status from website
                            var res = await ChangeOrderStatus(orderId);
                            if (!res) {
                                await Task.Delay(200);
                                var res2 = await ChangeOrderStatus(orderId);
                                if (!res2) {
                                    await PostToDiscrod(orderId, specialCode, accountShippingName, "sipariş durumu değiştirilemedi!!!!!!!!!");
                                }
                                
                            }
                            projectId = "10"; //kurye teslimi
                        }

                        /// Kapıda ödeme
                        string receiptPaymentPlanId = tableRecIdFromErp_PaymentPlan.Rows.Count > 0 ? tableRecIdFromErp_PaymentPlan.Rows[0][0].ToString() : null;
                        printableReceipt.PaymentPlan = !Object.ReferenceEquals(null, ordr.pop_name) ? ordr.pop_name.ToString() : null;
                        bool isThisCashOnDelivery = false;
                        /// Change order status to 23
                        if (!string.IsNullOrEmpty(printableReceipt.PaymentPlan) &&
                            (printableReceipt.PaymentPlan.Contains("KAPIDA") ||
                                printableReceipt.PaymentPlan.Contains("Kapıda") ||
                                printableReceipt.PaymentPlan.ToLower().Contains("KAPIDA".ToLower()) ||
                                printableReceipt.PaymentPlan.ToLower().Contains("Kapıda".ToLower()))) {
                            if (printableReceipt.Ship68 != "AKSARAY!") {
                                isThisCashOnDelivery = true;
                                var res = await ChangeOrderStatus(orderId, "23");
                                if (!res) {
                                    await Task.Delay(200);
                                    var res2 = await ChangeOrderStatus(orderId, "23");
                                    if (!res2) {
                                        await PostToDiscrod(orderId, specialCode, accountShippingName, "sipariş durumu değiştirilemedi!!!!!!!!!");
                                    }                                    
                                }
                                projectId = "15";// Kapıda Ödeme
                            }
                        }

                        /// Aras - Yurtiçi
                        /// change orderstatus to sip hazırlanır -> 12
                        if (cargoName == "Aras Kargo" || cargoName == "Yurtiçi Kargo" /*|| cargoName == "Aksaray Kurye"*/) {
                            if (!string.IsNullOrEmpty(printableReceipt.PaymentPlan) &&
                            (printableReceipt.PaymentPlan.Contains("KAPIDA") ||
                                printableReceipt.PaymentPlan.Contains("Kapıda") ||
                                printableReceipt.PaymentPlan.ToLower().Contains("KAPIDA".ToLower()) ||
                                printableReceipt.PaymentPlan.ToLower().Contains("Kapıda".ToLower()))) {
                                ///Empty!
                            }
                            else {
                                var res = await ChangeOrderStatus(orderId, "12"); // sip. hazırlanıyor
                                if (!res) {
                                    await Task.Delay(200);
                                    var res2 = await ChangeOrderStatus(orderId, "12");
                                    if (!res2) {
                                        await PostToDiscrod(orderId, specialCode, accountShippingName, "sipariş durumu değiştirilemedi!!!!!!!!!");
                                    }                                    
                                }
                                projectId = "6"; // sip. hazırlanıyor
                            }
                        }



                        //string receiptReceiptTime = !Object.ReferenceEquals(null, ordr.ord_insert_date) ? ordr.ord_insert_date.ToString() : null;
                        string receiptReceiptDate = !Object.ReferenceEquals(null, ordr.ord_insert_date) ? ordr.ord_insert_date.ToString() : null;
                        /// everyday 11 o clock
                        string receiptReceiptTime = new DateTime(1899, 12, 30, 11, 0, 0).ToString("yyyy-MM-dd HH:mm:ss");
                        try {
                            DateTime receiptDateTime = Convert.ToDateTime(receiptReceiptDate);
                            TimeSpan diff = DateTime.Now.Subtract(receiptDateTime);
                            if (diff.TotalDays > 5) {
                                receiptReceiptDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            }
                        }
                        catch (Exception ex) {
                            Console.WriteLine(ex);
                        }
                        /// Date and time correction
                        DateTime receiptReceiptDate_full = Convert.ToDateTime(receiptReceiptDate);
                        DateTime receiptReceiptDate_datePart = new DateTime(receiptReceiptDate_full.Year, receiptReceiptDate_full.Month, receiptReceiptDate_full.Day, 0, 0, 0);
                        //DateTime receiptReceiptDate_timePart = new DateTime(1899, 12, 30, receiptReceiptDate_full.Hour, receiptReceiptDate_full.Minute, receiptReceiptDate_full.Second);

                        receiptReceiptDate = receiptReceiptDate_datePart.ToString("yyyy-MM-dd HH:mm:ss");
                        //receiptReceiptTime = receiptReceiptDate_timePart.ToString("yyyy-MM-dd HH:mm:ss");

                        //string specialCode = !Object.ReferenceEquals(null, ordr.ord_code) ? ordr.ord_code.ToString() : null;
                        string receiptCargoNote = !Object.ReferenceEquals(null, ordr.ord_shipping_note) ? ordr.ord_shipping_note.ToString() : null;
                        printableReceipt.CargoNote = receiptCargoNote;
                        string receiptCurrentAccountId = newAccountRecId;
                        string receiptOrderNote = !Object.ReferenceEquals(null, ordr.ord_note) ? ordr.ord_note.ToString() : null;
                        printableReceipt.ShippingNote = receiptOrderNote;

                        /// explanation
                        string receiptExplanation = null;
                        string EArchivesPaymentType = null;
                        string PaymentPlanType = null;
                        string PaymentHandlerName = null;
                        if (!Object.ReferenceEquals(null, ordr.pop_code)) {
                            if (ordr.pop_code == "ccp" || ordr.pop_code == "ccp3d" || ordr.pop_code == "cct" || ordr.pop_code == "cct3d") {
                                receiptExplanation = string.Format("{0} kodlu sipariş, {1} isimli şahsa ait {2} ile tahsil edilmiştir.",
                                                                 specialCode,
                                                                 MakeThisSecret(!Object.ReferenceEquals(null, ordr.ord_ccowner) ? ordr.ord_ccowner.ToString() : "-"),
                                                                 "kredi kartı");

                                //EArchivesPaymentType = "ODEMEARACISI";
                                //PaymentPlanType = "98";
                                //PaymentHandlerName = "NESTPAY ÖDEME SİSTEMLERİ A.Ş.";
                            }
                            else if (ordr.pop_code == "mo") {
                                receiptExplanation = "";
                                //EArchivesPaymentType = "EFT/HAVALE";
                                //PaymentPlanType = "7";
                            }
                            else if (ordr.pop_code == "pzr") {
                                if (specialCode.Contains("UG-N")) { /// N-11
                                    receiptExplanation = string.Format("{0} kodlu sipariş, {1} isimli şahsa ait {2} ile tahsil edilmiştir.",
                                     specialCode,
                                     MakeThisSecret(!Object.ReferenceEquals(null, ordr.ord_ccowner) ? ordr.ord_ccowner.ToString() : "-"),
                                     "pazar yeri aracılığı") + " İŞBU FATURA TUTARI DOĞUŞ PLANET ELEKTRONİK TİCARET VE BİLİŞİM HİZMETLERİ A.Ş. HESABINA DEVREDİLMİŞTİR.";

                                    //EArchivesPaymentType = "ODEMEARACISI";
                                    //PaymentPlanType = "98";
                                    //PaymentHandlerName = "Doğuş Planet Elektronik Ticaret ve Bilişim Hizmetleri A.Ş"; // N11
                                }
                                /// UG-T
                            }
                            else if (ordr.pop_code == "pr" || ordr.pop_code == "prc") {
                                if (cargoName == "Yurtiçi Kargo") {
                                    receiptExplanation = string.Format("{0} kodlu sipariş, {1} isimli şahsa {2} ile kapıda ödeme yöntemi aracılığıyla teslim edilecektir.",
                                                                  specialCode,
                                                                  MakeThisSecret(!Object.ReferenceEquals(null, ordr.ord_billing_name) ? ordr.ord_billing_name.ToString() : "-"),
                                                                  "YURTİÇİ KARGO ");// TODO get this from db
                                }
                                else if (cargoName == "Aksaray Kurye") {
                                    receiptExplanation = string.Format("{0} kodlu sipariş, {1} isimli şahsa {2} ile kapıda ödeme yöntemi aracılığıyla teslim edilecektir.",
                                                                  specialCode,
                                                                  MakeThisSecret(!Object.ReferenceEquals(null, ordr.ord_billing_name) ? ordr.ord_billing_name.ToString() : "-"),
                                                                  "KURYE ");// TODO get this from db
                                }
                                else {
                                    receiptExplanation = string.Format("{0} kodlu sipariş, {1} isimli şahsa {2} ile kapıda ödeme yöntemi aracılığıyla teslim edilecektir.",
                                                                 specialCode,
                                                                 MakeThisSecret(!Object.ReferenceEquals(null, ordr.ord_billing_name) ? ordr.ord_billing_name.ToString() : "-"),
                                                                 "PTT KARGO ");// TODO get this from db
                                }

                                //EArchivesPaymentType = "EFT/HAVALE";
                                //PaymentPlanType = "7";
                            }
                        }
                        else {
                            receiptExplanation = "";
                            //EArchivesPaymentType = "EFT/HAVALE";
                            //PaymentPlanType = "7";
                        }

                        //if (Object.ReferenceEquals(null, ordr.ord_ccowner)) {
                        //    try {
                        //        if (receiptExplanation.Contains("isimli şahsa ait")) {
                        //            receiptExplanation.Replace("isimli şahsa ait", "");
                        //        }
                        //    }
                        //    catch {}
                        //}
                        //else {
                        //    Console.WriteLine(ordr.ord_ccowner);
                        //    if (string.IsNullOrEmpty(ordr.ord_ccowner)) {
                        //        try {
                        //            if (receiptExplanation.Contains("isimli şahsa ait")) {
                        //                receiptExplanation.Replace("isimli şahsa ait", "");
                        //            }
                        //        }
                        //        catch { }
                        //    }
                        //}

                        Log.append(methodName + "receiptReceiptNo ->" + receiptReceiptNo, logFilePath);
                        //Siparişi kaydet
                        List<Functions.SqlObj> SqlObjReceipts = new List<Functions.SqlObj> {
                            new Functions.SqlObj("CompanyId", "1", false), //base
                            new Functions.SqlObj("SpecialCode", specialCode),
                            new Functions.SqlObj("OrderIdFromWeb", orderId),
                            new Functions.SqlObj("ReceiptUpType", "0", false),
                            new Functions.SqlObj("ReceiptType", "120", false), //120 toptan
                            new Functions.SqlObj("ReceiptSubType", "0", false),
                            new Functions.SqlObj("ReceiptNo", receiptReceiptNo),
                            new Functions.SqlObj("TransporterId", receiptCargoNameId),
                            new Functions.SqlObj("VatAmount", receiptVatAmount,false),
                            new Functions.SqlObj("CustomerOrderNo", receiptCargoNo),
                            new Functions.SqlObj("CurrentAccountId", receiptCurrentAccountId, false),
                            new Functions.SqlObj("GrandTotal", receiptGrandTotal, false),
                            new Functions.SqlObj("PaymentPlanId", receiptPaymentPlanId, false),
                            new Functions.SqlObj("AddressId", receiptBillingAddressId),
                            new Functions.SqlObj("ShipToAddressId", receiptShippingAddressId),
                            new Functions.SqlObj("IsEximReceipt", "0", false),
                            new Functions.SqlObj("OutWarehouseId", "1", false),//"1";base
                            new Functions.SqlObj("IsApproved", "0", false), /// do not approve
                            //new Functions.SqlObj("DocumentNo", receiptCurrentDocNo),
                            new Functions.SqlObj("OrderNote", receiptOrderNote),
                            new Functions.SqlObj("Explanation", receiptExplanation),
                            new Functions.SqlObj("ShipmentDate", receiptReceiptDate),
                            new Functions.SqlObj("ApprovedExplanation", receiptCargoNote),
                            new Functions.SqlObj("ControlCode", "0", false),
                            new Functions.SqlObj("IsDeleted", "0", false),
                            new Functions.SqlObj("IsTaxExempted", "0", false),
                            new Functions.SqlObj("EmployeeId", "13"), // "13";//uzaktangelir
                            new Functions.SqlObj("ReceiptTime", receiptReceiptTime),
                            new Functions.SqlObj("ReceiptDate", receiptReceiptDate),//receiptReceiptDate
                            new Functions.SqlObj("UpdatedAt", receiptUpdatedAt),
                            new Functions.SqlObj("InsertedBy", "24", false), //"24";// webservis
                            new Functions.SqlObj("InsertedAt", receiptInsertedAt),
                            new Functions.SqlObj("ShipToCurrentAccountId", receiptCurrentAccountId),
                            new Functions.SqlObj("ProjectId", projectId),
                            new Functions.SqlObj("HasNegativeEffect", "0"),
                            new Functions.SqlObj("WithholdingAmount1", "0"),
                            new Functions.SqlObj("WithholdingAmount2", "0"),
                            new Functions.SqlObj("WithholdingType", "0"),
                            new Functions.SqlObj("Rate1Amount", "0"),
                            new Functions.SqlObj("Rate2Amount", "0"),
                            new Functions.SqlObj("Rate3Amount", "0"),
                            new Functions.SqlObj("Rate4Amount", "0"),
                            new Functions.SqlObj("Rate5Amount", "0"),
                            new Functions.SqlObj("ExciseTaxAmount", "0"),
                            new Functions.SqlObj("CommunicationTaxAmount", "0"),
                            new Functions.SqlObj("DiscountsTotalGross", "0"),
                            new Functions.SqlObj("DistributedExpensesTotal", "0"),
                            new Functions.SqlObj("ExpensesTotal", "0"),
                            new Functions.SqlObj("ForexRate", "0"),
                            new Functions.SqlObj("SubTotalForex", "0"),
                            new Functions.SqlObj("VatAmountForex", "0"),
                            new Functions.SqlObj("WithholdingAmount1Forex", "0"),
                            new Functions.SqlObj("WithholdingAmount2Forex", "0"),
                            new Functions.SqlObj("Rate1AmountForex", "0"),
                            new Functions.SqlObj("Rate2AmountForex", "0"),
                            new Functions.SqlObj("Rate3AmountForex", "0"),
                            new Functions.SqlObj("Rate4AmountForex", "0"),
                            new Functions.SqlObj("Rate5AmountForex", "0"),
                            new Functions.SqlObj("ExciseTaxAmountForex", "0"),
                            new Functions.SqlObj("CommunicationTaxAmountForex", "0"),
                            new Functions.SqlObj("DistributedDiscountsTotalForex", "0"),
                            new Functions.SqlObj("DiscountsTotalForex", "0"),
                            new Functions.SqlObj("DiscountsTotalGrossForex", "0"),
                            new Functions.SqlObj("DistributedExpensesTotalForex", "0"),
                            new Functions.SqlObj("ExpensesTotalForex", "0"),
                            new Functions.SqlObj("GrandTotalForex", "0"),
                            new Functions.SqlObj("IsForexReceipt", "0"),
                            new Functions.SqlObj("IsEDespatch", "0"),
                            new Functions.SqlObj("IsForexEDespatch", "0"),
                            new Functions.SqlObj("EDespatchStatus", "0"),
                            new Functions.SqlObj("DiscountsTotalVatIncludedForex", "0"),
                            new Functions.SqlObj("IsESendMail ", "0"),
                            new Functions.SqlObj("DistributedDiscountsTotalVatIncludedForex", "0"),
                            new Functions.SqlObj("VatAmountAccommodation", "0"),
                            new Functions.SqlObj("WorkplaceId", "2"),
                            new Functions.SqlObj("IsCancelled", "0"),
                            new Functions.SqlObj("EDespatchNo", "0"),
                            new Functions.SqlObj("IsTransportReceipt", "0"),
                            new Functions.SqlObj("EDespatchScenario", "1"),
                            new Functions.SqlObj("EDespatchAdviceType", "SEVK"),
                            new Functions.SqlObj("ShipmentTime",receiptReceiptTime),
                            new Functions.SqlObj("TermDate", receiptReceiptDate),
                            new Functions.SqlObj("SubTotalVatIncludedForex", "0"),
                            new Functions.SqlObj("DiscountsTotalVatIncluded", "0"),
                            new Functions.SqlObj("DistributedDiscountsTotalVatIncluded", "0"),
                            new Functions.SqlObj("VatAmountAccommodationForex", "0")
                        };
                        string lastReceiptId = null;
                        lastReceiptId = Functions.insertToSQLAndRetunId(connString, "Erp_InventoryReceipt", SqlObjReceipts.ToArray()).ToString();

                        if (string.IsNullOrEmpty(lastReceiptId)) {
                            await PostToDiscrod(orderId, specialCode, accountShippingName, "basamadııııı!");
                            continue;
                        }

                        ////////////////////////////////////////////////////////////////////////////
                        /// ///
                        /// Receipt Items (irsaliye kalemleri)
                        /// ///
                        string itemOrderReceiptId = lastReceiptId;
                        string itemReceiptDate = !Object.ReferenceEquals(null, ordr.ord_insert_date) ? ordr.ord_insert_date.ToString() : null;
                        string itemInsertedAt = !Object.ReferenceEquals(null, ordr.ord_insert_date) ? ordr.ord_insert_date.ToString() : null;

                        /// receipt totals
                        int i = 1;
                        double receiptSubTotal = 0;
                        double receiptDiscountsTotal = 0;
                        printableReceipt.itemList = new List<PrintableReceiptItem>();
                        printableReceipt.SetBarcodes = "";
                        printableReceipt.RepeatedProduct = "";
                        bool hasVATException = false;
                        if (!Object.ReferenceEquals(null, ordr.products)) {
                            foreach (var item in ordr.products) {
                                /// loop all receipt items
                                string itemBarcode = !Object.ReferenceEquals(null, item.orp_barcode) ? item.orp_barcode.ToString() : null;
                                if (string.IsNullOrEmpty(itemBarcode)) {
                                    continue;
                                }
                                /// ///
                                /// PrintableReceiptItem
                                /// ///
                                PrintableReceiptItem printableReceiptItem = new PrintableReceiptItem();
                                printableReceiptItem.Barcode = itemBarcode;
                                printableReceiptItem.Name = !Object.ReferenceEquals(null, item.orp_prd_name) ? item.orp_prd_name.ToString() : "";
                                printableReceiptItem.Box = !Object.ReferenceEquals(null, item.prd_box_no) ? item.prd_box_no.ToString() : "";
                                if (!Object.ReferenceEquals(null, item.prd_set) &&
                                    item.prd_set.ToString() != "0") {
                                    if (!printableReceipt.SetBarcodes.Contains(item.prd_set.ToString())) {
                                        printableReceipt.SetBarcodes += item.prd_set + ", ";
                                    }

                                }


                                //string itemQuantityx = Convert.ToDouble(item.orp_quantity.ToString()).ToString("0.0000", System.Globalization.CultureInfo.InvariantCulture);
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
                                double theQuantity = Convert.ToDouble(item.orp_quantity.ToString());
                                //if (!double.TryParse(item.orp_quantity.ToString(), out theQuantity)) {
                                //    Console.WriteLine("theQuantitiy Error");
                                //}

                                /// get set quantity
                                double setQuantity = 1;
                                if (!Object.ReferenceEquals(null, item.prd_set) && item.prd_set.ToString() != "0") {                                    
                                    string SetRecId = Functions.executeScalar(connString, $"SELECT RecId FROM Erp_Inventory WHERE InventoryCode='{item.prd_set.ToString()}'");
                                    string itemRecId = Functions.executeScalar(connString, $"SELECT RecId FROM Erp_Inventory WHERE InventoryCode='{itemBarcode}'");
                                    string setQuantityString = Functions.executeScalar(connString, $"SELECT Quantity FROM Erp_RecipeItem WHERE OwnerInventoryId='{SetRecId}' and InventoryId='{itemRecId}'");
                                    double.TryParse(setQuantityString, out setQuantity);
                                    if (setQuantity == 0) {
                                        setQuantity = 1;
                                        await PostToDiscrod(orderId, specialCode, accountShippingName, "setquantitiy 0 olamaz -> 1 olarak basıldı.");
                                    }
                                    theQuantity = theQuantity * setQuantity;
                                }

                                string itemQuantity = theQuantity.ToString("0.0000", CultureInfo.InvariantCulture);
                                printableReceiptItem.Quantity = itemQuantity.Remove(itemQuantity.LastIndexOf("."));
                                if (string.IsNullOrWhiteSpace(printableReceipt.RepeatedProduct) && printableReceiptItem.Quantity != "1") {
                                    printableReceipt.RepeatedProduct = "Aynı üründen 1'den fazla almış!";
                                }
                                string itemNetUnitPrice = (Convert.ToDouble(item.orp_price.ToString()) / setQuantity).ToString("0.0000", CultureInfo.InvariantCulture);
                                printableReceiptItem.Price = (double)Convert.ToDouble(itemNetUnitPrice);
                                printableReceipt.itemList.Add(printableReceiptItem);


                                string itemNetQuantity = theQuantity.ToString("0.0000", CultureInfo.InvariantCulture);
                                string itemUnitPrice = (Convert.ToDouble(item.orp_unit_tprice.ToString()) / setQuantity).ToString("0.0000", CultureInfo.InvariantCulture);

                                var JValue_item_orp_tax_rate = (Newtonsoft.Json.Linq.JValue)item.orp_tax_rate;
                                //Console.WriteLine(item_orp_tax_rate.GetType().Name + "-" + item_orp_tax_rate. + "-" + item.orp_tax_rate);
                                //item.orp_tax_rate.HasValue ? jToken["PurchasedValue"].Value : 0;
                                //if (!object.ReferenceEquals(null, JValue_item_orp_tax_rate.Value) /*|| !string.IsNullOrEmpty((string)JValue_item_orp_tax_rate.Value)*/) {
                                //    Console.WriteLine(JValue_item_orp_tax_rate.Value + "yow");
                                //}
                                //else {
                                //    Console.WriteLine(JValue_item_orp_tax_rate.Value + "yow22");
                                //}
                                string itemVatRate = Convert.ToDouble(!object.ReferenceEquals(null, JValue_item_orp_tax_rate.Value) ? JValue_item_orp_tax_rate.Value : "0").ToString("0.0000", CultureInfo.InvariantCulture);
                                string itemExpenseRate = Convert.ToDouble(!object.ReferenceEquals(null, JValue_item_orp_tax_rate.Value) ? JValue_item_orp_tax_rate.Value : "0").ToString("0.0000", CultureInfo.InvariantCulture);

                                var JValue_item_orp_tax = (Newtonsoft.Json.Linq.JValue)item.orp_tax;
                                string itemVatAmount = Convert.ToDouble(!object.ReferenceEquals(null, JValue_item_orp_tax_rate.Value) ? JValue_item_orp_tax.Value : "0").ToString("0.0000", CultureInfo.InvariantCulture);
                                string itemVatBaseAmount = Convert.ToDouble(item.orp_total.ToString()).ToString("0.0000", CultureInfo.InvariantCulture);
                                string itemItemTotal = (Convert.ToDouble(item.orp_unit_price.ToString()) * theQuantity / setQuantity).ToString("0.0000", CultureInfo.InvariantCulture);
                                string itemDiscountsTotal = ((Convert.ToDouble(item.orp_unit_price.ToString()) -
                                                              Convert.ToDouble(item.orp_price.ToString())) * theQuantity / setQuantity).ToString("0.0000", CultureInfo.InvariantCulture);
                                /// discountamount1 + discountamount2+ discountamount3 ... 
                                string itemNetItemTotal = Convert.ToDouble(item.orp_total.ToString()).ToString("0.0000", CultureInfo.InvariantCulture);

                                string itemTotalVatIncluded = (Convert.ToDouble(item.orp_unit_tprice.ToString()) * theQuantity / setQuantity).ToString("0.0000", CultureInfo.InvariantCulture);

                                ///// kapıda ödeme aksaray siparişi ise 5 tl çıkar
                                //if (isThisCashOnDelivery &&
                                //    printableReceipt.Ship68 == "AKSARAY!" && 
                                //    itemBarcode == "KARGO" && 
                                //    printableReceiptItem.Name == "PTT" &&
                                //    !ReferenceEquals(null, item.crg_por_price)) {

                                //    itemUnitPrice -= Convert.ToDouble(item.crg_por_price.ToString()).ToString("0.0000", CultureInfo.InvariantCulture);
                                //}

                                ///*
                                //itemleri kaydet
                                List<Functions.SqlObj> SqlObjReceiptItems = new List<Functions.SqlObj> {
                                    new Functions.SqlObj("InventoryReceiptId", itemOrderReceiptId, false),
                                    new Functions.SqlObj("ReceiptType", "120", false), //"120"; toptan
                                    new Functions.SqlObj("ReceiptSubType", "0", false),
                                    new Functions.SqlObj("ReceiptDate", itemReceiptDate),
                                    new Functions.SqlObj("OutWarehouseId", "1", false),//base
                                    new Functions.SqlObj("ItemType", "1", false), //base
                                    new Functions.SqlObj("SpecialCode", specialCode),
                                    new Functions.SqlObj("EmployeeId", "13"), // "13";//uzaktangelir
                                    new Functions.SqlObj("ItemOrderNo", itemItemOrderNo,false),
                                    new Functions.SqlObj("InventoryId", itemInventoryId, false),
                                    new Functions.SqlObj("UnitId", "51", false), //base
                                    new Functions.SqlObj("Quantity", itemQuantity, false),
                                    new Functions.SqlObj("NetQuantity", itemQuantity, false),
                                    new Functions.SqlObj("UnitPrice", itemUnitPrice, false),
                                    new Functions.SqlObj("VatIncluded", "1", false),
                                    new Functions.SqlObj("VatRate", itemVatRate, false),
                                    new Functions.SqlObj("CalcType", "0", false),
                                    new Functions.SqlObj("ExpenseRate", itemExpenseRate, false),
                                    new Functions.SqlObj("VatAmount", itemVatAmount, false),
                                    new Functions.SqlObj("VatBaseAmount", itemVatBaseAmount, false),
                                    new Functions.SqlObj("ItemTotal", itemItemTotal, false),
                                    new Functions.SqlObj("DiscountsTotal", itemDiscountsTotal, false),
                                    new Functions.SqlObj("NetUnitPrice", itemNetUnitPrice, false),
                                    new Functions.SqlObj("NetItemTotal", itemNetItemTotal, false),
                                    new Functions.SqlObj("IsTaxExempted", "0", false),
                                    new Functions.SqlObj("IsClosed", "0", false),
                                    new Functions.SqlObj("IsApproved", "1", false),
                                    new Functions.SqlObj("ControlCode", "0", false),
                                    new Functions.SqlObj("InsertedAt", itemInsertedAt),
                                    new Functions.SqlObj("InsertedBy", "24", false),//"24";//webservis
                                    new Functions.SqlObj("IsDeleted", "0", false),//
                                    new Functions.SqlObj("ItemTotalVatIncluded", itemTotalVatIncluded, false),
                                    new Functions.SqlObj("ExpensesTotal", "0", false),
                                    new Functions.SqlObj("DistributedDiscount", "0", false),
                                    new Functions.SqlObj("DistributedExpense", "0", false),
                                    new Functions.SqlObj("NetUnitPriceForex", "0", false),
                                    new Functions.SqlObj("VatAmountForex", "0", false),
                                    new Functions.SqlObj("VatBaseAmountForex", "0", false),
                                    new Functions.SqlObj("ItemTotalForex", "0", false),
                                    new Functions.SqlObj("ItemTotalVatIncludedForex", "0", false),
                                    new Functions.SqlObj("DiscountsTotalForex", "0", false),
                                    new Functions.SqlObj("ExpensesTotalForex", "0", false),
                                    new Functions.SqlObj("DistributedDiscountForex", "0", false),
                                    new Functions.SqlObj("DistributedExpenseForex", "0", false),
                                    new Functions.SqlObj("NetItemTotalForex", "0", false),
                                };
                                Functions.insertToSQL(connString, "Erp_InventoryReceiptItem", SqlObjReceiptItems.ToArray());

                                if (float.TryParse(itemVatRate, out float itemVatRateInt)) {
                                    if (itemVatRateInt == 0)
                                        hasVATException = true;
                                }

                                /// for receipt update
                                receiptSubTotal += Convert.ToDouble(item.orp_unit_price) * theQuantity / setQuantity;

                                if (Convert.ToDouble(item.orp_discount_rate.ToString()) > 0) {
                                    /// ///
                                    /// if item has discount
                                    /// ///
                                    /// get ReciptId
                                    string querryDiscountParentItemId = string.Format(@"SELECT Top 1 RecId FROM  Erp_InventoryReceiptItem WHERE InventoryReceiptId = '{0}'
                                                                                        ORDER BY ItemOrderNo DESC", itemOrderReceiptId);
                                    DataTable tableDiscountParentItemId = Functions.getDataFromSql(connString, querryDiscountParentItemId);

                                    string itemDiscountParentItemId = null;
                                    if (tableDiscountParentItemId.Rows.Count < 1) {
                                        Log.append(methodName + "tableDiscountParentItemId is empty", logFilePath);
                                    }
                                    else {
                                        itemDiscountParentItemId = tableDiscountParentItemId.Rows.Count > 0 ? tableDiscountParentItemId.Rows[0][0].ToString() : "";
                                    }

                                    //DiscountAmount = orp_discount_rate / 100 * orp_unit_price * orp_quantity //indirim satırında sadece
                                    //DiscountAmount =(orp_unit_price-orp_price)* orp_quantity 
                                    //DiscountRate //indirim satırında sadece
                                    string itemDiscountRate = Convert.ToDouble(item.orp_discount_rate.ToString()).ToString("0.0000", CultureInfo.InvariantCulture);
                                    string itemDiscountAmount = ((Convert.ToDouble(item.orp_unit_price.ToString()) -
                                                                 Convert.ToDouble(item.orp_price.ToString())) * theQuantity / setQuantity).ToString("0.0000", CultureInfo.InvariantCulture);
                                    // for receipt update
                                    receiptDiscountsTotal += (Convert.ToDouble(item.orp_unit_price) - Convert.ToDouble(item.orp_price)) * theQuantity / setQuantity;

                                    //string itemDiscountParentItemId = tableDiscountParentItemId.Rows[0][0].ToString();
                                    string itemDiscountItemOrderNo = i++.ToString();

                                    //indirim satırını kaydet
                                    List<Functions.SqlObj> SqlObjReceiptItemsDiscount = new List<Functions.SqlObj> {
                                        new Functions.SqlObj("InventoryReceiptId", itemOrderReceiptId, false),
                                        new Functions.SqlObj("ReceiptType", "120", false),  //"120"; toptan
                                        new Functions.SqlObj("ReceiptDate", itemReceiptDate),
                                        new Functions.SqlObj("SpecialCode", specialCode),
                                        new Functions.SqlObj("DiscountRate", itemDiscountRate, false),
                                        new Functions.SqlObj("DiscountAmount", itemDiscountAmount, false),
                                        new Functions.SqlObj("ItemType", "50", false),
                                        new Functions.SqlObj("ParentItemId", itemDiscountParentItemId, false),
                                        new Functions.SqlObj("ItemOrderNo", itemDiscountItemOrderNo,false),
                                        new Functions.SqlObj("VatIncluded", "0", false),
                                        new Functions.SqlObj("IsClosed", "0", false),
                                        new Functions.SqlObj("IsApproved", "1", false),
                                        new Functions.SqlObj("InsertedAt", itemInsertedAt),
                                        new Functions.SqlObj("InsertedBy", "24", false),//"24";//webservis
                                         /*new Functions.SqlObj("IsReserved", itemIsReserved, false),*/ 
                                    };
                                    Functions.insertToSQL(connString, "Erp_InventoryReceiptItem", SqlObjReceiptItemsDiscount.ToArray());
                                    //Console.WriteLine("");


                                }// if discount
                            }// foreach item
                        }
                        string SubTotalVatIncludedString = Functions.executeScalar(connString,
                                    $"select sum(ItemTotalVatIncluded) from Erp_InventoryReceiptItem where ReceiptType = 120 and SpecialCode = '{specialCode}'");
                        /// ///
                        /// update receipt for receipt totals
                        /// ///
                        //indirim satırını kaydet
                        Functions.SqlObj[] SqlObjReceiptUpdate1 = new Functions.SqlObj[] {
                            new Functions.SqlObj("SubTotal", receiptSubTotal.ToString("0.0000", CultureInfo.InvariantCulture)),
                            new Functions.SqlObj("DiscountsTotal", receiptDiscountsTotal.ToString("0.0000", CultureInfo.InvariantCulture)),
                            new Functions.SqlObj("SubTotalVatIncluded", receiptSubTotal.ToString("0.0000", CultureInfo.InvariantCulture))/////////////////// E-INVOICE
                        };
                        Functions.updateSQL(connString, "Erp_InventoryReceipt", $"RecId = '{itemOrderReceiptId}'", SqlObjReceiptUpdate1);


                        /// ///
                        /// Post to discord as new order
                        /// ///
#if DEBUG

#else
                        string isIrsaliyeExist = Functions.executeScalar(connString,
                                           $"select RecId from Erp_InventoryReceipt where SpecialCode='{specialCode}'");
                        if (ReferenceEquals(isIrsaliyeExist, null) || string.IsNullOrEmpty(isIrsaliyeExist)) {
                            await PostToDiscrod(orderId, specialCode, "İrsaliye oluşturduktan sonra bulunamadı, iptal edildi!", "");
                            continue;
                        }
                        try {
                            /// post to discord
                            await PostToDiscrod(orderId, specialCode, accountShippingName, receiptGrandTotal);
                        }
                        catch (Exception ex) {
                            Console.WriteLine(ex.ToString());
                        }
#endif

                        #region Fatura-XML-Efatura
                        //Console.WriteLine("New Part starts");
                        ///////////////////////////////////////////////////////////
                        ///// ///
                        ///// Current account receipt JUST ITEM
                        ///// ///
                        //string CurenntAccountReceiptItemRecId = InsertCurrentAccountReceiptItem(connString, receiptReceiptDate, receiptCurrentAccountId, 
                        //                                                                        specialCode, receiptGrandTotal, "6");
                        //if (string.IsNullOrEmpty(CurenntAccountReceiptItemRecId)) {
                        //    Console.WriteLine("CurenntAccountReceiptItemRecId is empty!");
                        //}

                        ///////////////////////////////////////////////////////////
                        ///// ///
                        ///// Invoice
                        ///// ///

                        //if (!double.TryParse(SubTotalVatIncludedString, out double subTotalVatIncluded)) {
                        //    Console.WriteLine("subTotalVatIncluded problem!");
                        //}
                        //string LastInvoiceRecId = InsertInvoice(connString, hasVATException, receiptReceiptDate, receiptReceiptTime, receiptCurrentAccountId,
                        //                                        receiptBillingAddressId, receiptCurrentAccountId, receiptShippingAddressId, receiptPaymentPlanId,
                        //                                        receiptCargoNo, specialCode, receiptCargoNameId, receiptExplanation,
                        //                                        receiptSubTotal.ToString("0.0000", CultureInfo.InvariantCulture), receiptVatAmount, 
                        //                                        receiptDiscountsTotal.ToString("0.0000", CultureInfo.InvariantCulture), receiptGrandTotal,
                        //                                        CurenntAccountReceiptItemRecId, EArchivesPaymentType, subTotalVatIncluded.ToString("0.0000", CultureInfo.InvariantCulture),
                        //                                        "6");
                        //if (string.IsNullOrEmpty(LastInvoiceRecId)) {
                        //    Console.WriteLine("LastInvoiceRecId is empty!");
                        //}



                        ///////////////////////////////////////////////////////////
                        ///// ///
                        ///// Update Receipt for invoice id
                        ///// ///
                        //bool resultInsertReceiptPaymentItem = InsertReceiptPaymentItem(connString, LastInvoiceRecId, receiptReceiptDate,
                        //                                                               receiptGrandTotal, PaymentPlanType, receiptCurrentAccountId, specialCode);

                        //if (!resultInsertReceiptPaymentItem) {
                        //    Console.WriteLine("resultInsertReceiptPaymentItem is false!");
                        //}

                        ///////////////////////////////////////////////////////////
                        ///// ///
                        ///// Update Receipt for invoice id
                        ///// ///
                        //Functions.SqlObj[] SqlObjReceiptUpdatex = new Functions.SqlObj[] {
                        //    new Functions.SqlObj("InvoiceId", LastInvoiceRecId)
                        //};
                        //Functions.updateSQL(connString, "Erp_InventoryReceipt", $"RecId = '{itemOrderReceiptId}'", SqlObjReceiptUpdatex);

                        //////////////////////////////////////////////////////////
                        ///// ///
                        ///// Create EInvoice XML
                        ///// ///
                        //bool isDebugModeOn = true;
                        //string uuid = EInvoiceEmulator.MakeXMLInvoice(connString, specialCode, isDebugModeOn);
                        //if (string.IsNullOrEmpty(uuid)) {
                        //    Console.WriteLine("uuid is empty!");
                        //}

                        //////////////////////////////////////////////////////////
                        ///// ///
                        ///// Update Invoice's uid and  Current account receipt JUST ITEM'source
                        ///// ///
                        //string InvoiceExplanation = Functions.executeScalar(connString, $"select DocumentNo from Erp_Invoice where RecId = {LastInvoiceRecId}");
                        //bool resultCurrentAccountReceipt = UpdateCurrentAccountReceipt(connString, CurenntAccountReceiptItemRecId, LastInvoiceRecId, InvoiceExplanation);
                        //if (!resultCurrentAccountReceipt) {
                        //    Console.WriteLine("resultCurrentAccountReceipt is false!");
                        //}
                        //bool resultEInvoiceUUID = UpdateEInvoiceUUID(connString, LastInvoiceRecId, uuid);
                        //if (!resultEInvoiceUUID) {
                        //    Console.WriteLine("resultEInvoiceUUID is false!");
                        //}

                        //Console.WriteLine("New Part ends");
                        #endregion

                        ////////////////////////////////////////////////////////
                        /// ///
                        /// print to paper
                        /// ///
                        await Task.Delay(200);
                        string IsPrinted = "0";
                        string isIRexist = Functions.executeScalar(connString, 
                                            $"select RecId from Erp_InventoryReceipt where SpecialCode='{specialCode}' and (IsPrinted != '1' or IsPrinted is null)");
                        if (ReferenceEquals(isIRexist, null) || string.IsNullOrEmpty(isIRexist)) {
                            await PostToDiscrod(orderId, specialCode, "İrsaliye oluşturduktan sonra bulunamadı, yazdırmalar iptal edildi!", "");
                            continue;
                        }

                        try {
                            if (Printer(connString, printableReceipt, DateTime.Now, itemOrderReceiptId)) {
                                IsPrinted = "1";
                                await Task.Delay(300);
                            }
                        }
                        catch {
                            try {
                                if (Printer(connString, printableReceipt, DateTime.Now, itemOrderReceiptId)) {
                                    IsPrinted = "1";
                                    await Task.Delay(300);
                                }
                                await Task.Delay(30);
                            }
                            catch (Exception ex) {
                                Console.WriteLine(ex.Message);
                                
                                try {
                                    ///bubble
                                    Bubble.sendBubbleNote(mySqlConn,
                                                          string.Format("{0}-{1}-->Sipariş yazdırılamadı!", specialCode, accountName),
                                                          "yazdırma",
                                                          string.Format(@"https://www.uzaktangelir.com/admin/index.php?p=Orders&view={0}", orderId),
                                                          "1",
                                                          DateTime.Now,
                                                          DateTime.Now.AddDays(3),
                                                          "30",
                                                          "ALL",
                                                          "Yazdırma",
                                                          ordr.ord_status.ToString(),
                                                          orderId);
                                    await PostToDiscrod(orderId, specialCode, "Sipariş yazdırılamadı!", "");
                                }
                                catch (Exception ex2) { Console.WriteLine(ex2.Message); }
                            }
                        }

                        ///// muhasebe sipairş fişi
                        //await Task.Delay(30);
                        //printableReceipt.CargoName += " - *MUHASEBE*";
                        //if (Printer(connString, printableReceipt, DateTime.Now, itemOrderReceiptId)) {
                        //    IsPrinted = "1";
                        //    await Task.Delay(300);
                        //}

                        /// ///
                        /// update receipt IsPrinted
                        /// ///
                        Functions.SqlObj[] SqlObjReceiptUpdate2 = new Functions.SqlObj[] {
                            new Functions.SqlObj("IsPrinted", IsPrinted)
                        };
                        Functions.updateSQL(connString, "Erp_InventoryReceipt", $"RecId = '{itemOrderReceiptId}'", SqlObjReceiptUpdate2);

                        //TODO!: This is for new kargo
                        //SavePrintableReceiptJsonToSql(printableReceipt, itemOrderReceiptId);

                        /// TODO!: check this -> idk this is neccesary
                        receiptSubTotal = 0;
                        receiptDiscountsTotal = 0;

                    }
                    else {
                        /// Order Exists donothing
                        Log.append(methodName + "sipariş sentezde var", logFilePath);
                        continue;
                    }
                }//foreach
                Log.append(methodName + "Orders Ends!", logFilePath);

            } ///end of else

            await Task.Delay(DELAY_TIME);
            Console.WriteLine("Order is DONE!");
            return true;

        }

        /// basic funcs
        private static IEnumerable<string> stringSpliter(string str, int maxChunkSize) {
            /// split strings given length
            for (int i = 0; i < str.Length; i += maxChunkSize)
                yield return str.Substring(i, Math.Min(maxChunkSize, str.Length - i));
        }


        private static string MakeThisSecret(string customername) {
            try {
                string[] names = customername.Split(' ');
                string newName = "";
                for (int i = 0; i < names.Length; i++) {
                    if (!string.IsNullOrEmpty(names[i])) {
                        newName += names[i].Substring(0, 2) + new String('*', names[i].Length - 2) + " ";
                    }
                }
                return newName;
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                return customername;
            }
        }

        private static async Task<bool> SavePrintableReceiptJsonToSql(PrintableReceipt printableReceipt, string IRRecId) {
            /// Erp_InventoryReceiptAttachment -> type 2 -> teknik resim
            try {
                var printaableReceiptJsonString = JsonConvert.SerializeObject(printableReceipt);
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(printaableReceiptJsonString);

                List<Functions.SqlObj2> sqlObPrintObj2 = new List<Functions.SqlObj2> {
                                                    new Functions.SqlObj2("InventoryReceiptId", IRRecId),
                                                    new Functions.SqlObj2("Type", "2"),
                                                    new Functions.SqlObj2("FileName", "PrintaableReceiptJsonString"),
                                                    new Functions.SqlObj2("Attachment", bytes, bytes.Length, "Text"),
                                                    new Functions.SqlObj2("InUse", "1"),
                                                    new Functions.SqlObj2("InsertedBy", "24"),
                                                    new Functions.SqlObj2("InsertedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                                };
                Functions.insertToSQL2(Functions.GetConnString("ms_sql"), "Erp_InventoryReceiptAttachment", sqlObPrintObj2.ToArray());
                await Task.Delay(3);
                return true;
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                return false;
            }
        }


        #region old-print
        ///// ///
        ///// Print
        ///// ///
        ///// get template
        ////Console.WriteLine(printableReceipt.SetBarcodes + "***" + printableReceipt.BillingName);

        //DataTable dataHtmlTemplate = Functions.getDataFromSql(connString, $@"SELECT Definition FROM Meta_Report WHERE ReportName='OFMReceiptTemplate'");
        //byte[] bytArray = (byte[])dataHtmlTemplate.Rows[0][0];
        //string htmlTemplate = System.Text.Encoding.UTF8.GetString(bytArray, 0, bytArray.Length);

        ///// fill template
        //string finalHtml = PrintObj.FillFinalHtml(htmlTemplate, printableReceipt, "finalHtml" + now.ToString("HH_mm"));

        /////finally convert to pdf then print
        //MemoryStream ms = PrintObj.CreatePDFFromHTML(finalHtml);
        //PrintObj.PrintPDF("RONGTA 80mm Series Printer", "", printableReceipt.itemList.Count, ms);
        ////PrintObj.PrintPDF("P-3521 MFP KX", "", printableReceipt.itemList.Count,PrintObj.CreatePDFFromHTML(finalHtml));

        ///// print products
        //DataTable dataHtmlTemplateProduct = Functions.getDataFromSql(connString, $@"SELECT Definition FROM Meta_Report WHERE ReportName='OFMProductTemplate'");
        //byte[] bytArray2 = (byte[])dataHtmlTemplateProduct.Rows[0][0];
        //string htmlTemplate2 = System.Text.Encoding.UTF8.GetString(bytArray2, 0, bytArray2.Length);

        ///// fill template
        //string finalHtml2 = PrintObj.FillFinalHtml(htmlTemplate2, printableReceipt, "products"+now.ToString("HH_mm"));

        /////finally convert to pdf then print
        //MemoryStream ms2 = PrintObj.CreatePDFFromHTML(finalHtml2);
        //PrintObj.PrintPDF("RONGTA 80mm Series Printer", "", printableReceipt.itemList.Count, ms2);
        ////PrintObj.PrintPDF("P-3521 MFP KX", "", printableReceipt.itemList.Count,PrintObj.CreatePDFFromHTML(finalHtml));


        /////insert final html and pdf
        //byte[] bytes = System.Text.Encoding.UTF8.GetBytes(finalHtml);
        //List<Functions.SqlObj2> sqlObPrintObj2 = new List<Functions.SqlObj2> {
        //            new Functions.SqlObj2("InventoryReceiptId", itemOrderReceiptId),
        //            new Functions.SqlObj2("Type", "4"),
        //            new Functions.SqlObj2("FileName", "HtmlReceipt"),
        //            new Functions.SqlObj2("Attachment", bytes, bytes.Length, "Image"),
        //            new Functions.SqlObj2("InUse", "1"),
        //            new Functions.SqlObj2("InsertedBy", "24"),
        //            new Functions.SqlObj2("InsertedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
        //};
        //Functions.insertToSQL2(SqlObj.DEFAULT_CONN_STRING, "Erp_InventoryReceiptAttachment", sqlObPrintObj2.ToArray());

        /////insert final pdf
        //byte[] pdfbytes = ms.ToArray();
        //List<Functions.SqlObj2> sqlObPrintObj = new List<Functions.SqlObj2> {
        //            new Functions.SqlObj2("InventoryReceiptId", itemOrderReceiptId),
        //            new Functions.SqlObj2("Type", "1"),
        //            new Functions.SqlObj2("FileName", "HtmlReceipt"),
        //            new Functions.SqlObj2("Attachment", pdfbytes, pdfbytes.Length, "Image"),
        //            new Functions.SqlObj2("InUse", "1"),
        //            new Functions.SqlObj2("InsertedBy", "24"),
        //            new Functions.SqlObj2("InsertedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
        //};
        //Functions.insertToSQL2(SqlObj.DEFAULT_CONN_STRING, "Erp_InventoryReceiptAttachment", sqlObPrintObj.ToArray());

        //ms.Dispose();
        //ms2.Dispose();
        //IsPrinted = "1";
        #endregion

    }
}
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGCore {
    public static class UGSync_ReceiptAttachment {        
        public static void FindNullAttachments(string url, string webUsername, string webUserPass, int daysAgo, bool isWebAdressBaseOnUpdateDate=true) {
            try {
                /// ///
                /// Find Null attachment orders
                /// ///
                daysAgo = 6;
                /// Take receipts which don't have  any attachment
                string querryAttachment = $@"SELECT RecId, SpecialCode FROM Erp_InventoryReceipt AS o WHERE 
                                            (SELECT Count(RecId) FROM Erp_InventoryReceiptAttachment AS b WHERE o.RecId=b.InventoryReceiptId) != 4 AND
                                            o.ReceiptDate <= '{DateTime.Now.AddDays(1).ToString("yyyy-MM-dd")}' AND 
                                            o.ReceiptDate >= '{DateTime.Now.AddDays(-1 * daysAgo).ToString("yyyy-MM-dd")}' AND 
                                            o.EmployeeId=13 AND o.ReceiptType='120'";

                DataTable tableNullAttachments = Functions.getDataFromSql(Functions.GetConnString("ms_sql"), querryAttachment);

                if (tableNullAttachments == null || tableNullAttachments.Rows.Count < 1) {
                    Console.WriteLine("tableNullAttachments is empty");
                    return;
                }

                /// ///
                /// Take website orders, insert them to sentez
                /// ///
                /// create weborder and get webOrders
                string url1 = Functions.createUrl4WebOrders(url, daysAgo.ToString(), webUsername, webUserPass, isWebAdressBaseOnUpdateDate);

                WebOrder webOrders = new WebOrder(url1);
                webOrders.getJsonFromWeb();
                webOrders.createDynamicVar();

                if (!Object.ReferenceEquals(null, webOrders.m_data.orders)) {
                    Console.WriteLine("Siparis sayisi:" + webOrders.m_data.orders.Count.ToString());
                }
                else {
                    return;
                }

                /// ///
                /// Insert to Sentez
                /// ///
                if (webOrders.m_data.orders.Count == 0) {
                    Console.WriteLine("Sipariş yok");
                }
                else {
                    /// There are orders in the JSON
                    foreach (var ordr in webOrders.m_data.orders) {
                        /// Check order status
                        if (!Object.ReferenceEquals(null, ordr.ord_status)) {
                            if (ordr.ord_status.ToString() == "12" || ordr.ord_status.ToString() == "18" || ordr.ord_status.ToString() == "22"|| ordr.ord_status.ToString() == "23") {
                                /// "Sipariş hazırlanıyor" - "Kurye Teslimi" - "Kapıda Ödeme"  siparişleri buralardan basıyoruz
                                string specialCode = !Object.ReferenceEquals(null, ordr.ord_code) ? ordr.ord_code : null;
                                foreach (DataRow row in tableNullAttachments.Rows) {
                                    /// loop non attachment orders
                                    if (row["SpecialCode"].ToString() != specialCode) {
                                        continue;
                                    }
                                    /// ///
                                    /// we have a match!!
                                    /// ///
                                    PostToDiscrod(specialCode + " sipariş eklerinde hata var!!! Sipariş fişi çıkmamış olabilir!");
                                    string receiptId = row["RecId"].ToString();
                                    /// delete old attachments
                                    string deleteQuerry = $@"DELETE FROM Erp_InventoryReceiptAttachment WHERE InventoryReceiptId={receiptId}";
                                    Functions.sendSQLCommand(Functions.GetConnString("ms_sql"), deleteQuerry);
                                    /// create receipt
                                    string orderId = !Object.ReferenceEquals(null, ordr.ord_id) ? ordr.ord_id.ToString() : null;
                                    string accountName = !Object.ReferenceEquals(null, ordr.ord_mmb_name) ? ordr.ord_mmb_name.ToString() : null;
                                    string accountShippingName = !Object.ReferenceEquals(null, ordr.ord_shipping_name) ? ordr.ord_shipping_name.ToString() : null;
                                    string accountBillName = !Object.ReferenceEquals(null, ordr.ord_billing_name) ? ordr.ord_billing_name.ToString() : null;/// real account name

                                    Console.WriteLine(ordr.ord_status.ToString() + "*|*" + ordr.ors_id.ToString());
                                    /// ///
                                    /// printable obj
                                    /// ///
                                    PrintableReceipt printableReceipt = new PrintableReceipt();
                                    printableReceipt.SpecialCode = specialCode;
                                    printableReceipt.SpecialCodeBarcode = printableReceipt.generateBarcode(specialCode);
                                    printableReceipt.ShippingName = accountShippingName;
                                    printableReceipt.BillingName = accountBillName;

                                    /// create document No
                                    string docNoTemplate = "UGI" + DateTime.Now.Year;
                                    string lastDocNo = Functions.executeScalar(Functions.GetConnString("ms_sql"),
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

                                    //printableReceipt.ReceiptNoQR = printableReceipt.generateQRBarcode(logo, receiptCurrentDocNo);
                                    printableReceipt.ReceiptNoBarcode = printableReceipt.generateBarcode(receiptCurrentDocNo, 300, 70);
                                    if (string.IsNullOrEmpty(printableReceipt.ReceiptNoBarcode)) {
                                        Console.WriteLine("ReceiptNoBarcode is empty!");
                                        break;
                                    }

                                    //printableReceipt.TaxNo = accountTaxNo;

                                    string accountEmail = !Object.ReferenceEquals(null, ordr.ord_mmb_email) ? ordr.ord_mmb_email.ToString() : null;
                                    printableReceipt.ShippingEmail = accountEmail;

                                    //printableReceipt.TaxOffice = taxOfficeName;

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
                                            DataTable tableDistrict = Functions.getDataFromSql(Functions.GetConnString("ms_sql"), $@"SELECT RecId, DistrictCode FROM  Meta_District WHERE CodeN='{districtCodeN}'");
                                            if (tableDistrict.Rows.Count > 0) {
                                                shippingTown = tableDistrict.Rows[0]["RecId"].ToString();
                                                printableReceipt.ShippingCityAndTown = tableDistrict.Rows[0]["DistrictCode"].ToString();
                                            }
                                        }
                                        catch { }
                                    }
                                    if (!Object.ReferenceEquals(null, ordr.ord_shipping_town)) {
                                        string ord_shipping_town = ordr.ord_shipping_town;
                                        if (ord_shipping_town.Contains("AKSARAY") && ord_shipping_town.Contains("MERKEZ")) {
                                            printableReceipt.Ship68 = "AKSARAY!";
                                        }
                                        else {
                                            printableReceipt.Ship68 = "";
                                        }
                                    }

                                    ///increase last adress Code
                                    string accountShippingPhone = !Object.ReferenceEquals(null, ordr.ord_shipping_phone) ? ordr.ord_shipping_phone : null;
                                    printableReceipt.ShippingPhone = accountShippingPhone;

                                    string accountShippingAddressAddress = !Object.ReferenceEquals(null, ordr.ord_shipping_address) ? ordr.ord_shipping_address.ToString() : null;
                                    //accountAddress = Regex.Replace(accountAddress, @"[\r\n']", " ");,
                                    printableReceipt.ShippingAddress = accountShippingAddressAddress;

                                    /// cargoId getRecId from Erp_Transporter account
                                    string cargoName = !Object.ReferenceEquals(null, ordr.crg_name) ? ordr.crg_name.ToString() : null;
                                    printableReceipt.CargoName = cargoName;

                                    string receiptCargoNo = !Object.ReferenceEquals(null, ordr.ord_cargo_ref_no) ? ordr.ord_cargo_ref_no.ToString() : null;
                                    printableReceipt.CargoBarcodeString = receiptCargoNo;


                                    /// check cargo stuff                        
                                    if (cargoName == "Aras Kargo" || cargoName == "Yurtiçi Kargo") {
                                        if (ordr.pop_code == "pzr") {
                                            if (specialCode.Contains("UG-N")) { /// N-11
                                                                                /// Do nothing now!
                                            }
                                        }
                                        else {
                                            receiptCargoNo = orderId;
                                        }
                                    }
                                    else { // TODO!:This for new kargo
                                        if (string.IsNullOrEmpty(receiptCargoNo) || receiptCargoNo.StartsWith("0") == true) {
                                            Console.WriteLine(specialCode  + "CargoBarcodeString is empty!");
                                            continue;
                                        }
                                    }


                                    printableReceipt.CargoBarcode = printableReceipt.generateBarcode(receiptCargoNo);
                                    //printableReceipt.CargoBarcodeQR = printableReceipt.generateQRBarcode(logo, receiptCargoNo);
                                    //Console.WriteLine(printableReceipt.CargoBarcodeQR);
                                    Console.WriteLine("");
                                    //if (printableReceipt.CargoBarcode == null || string.IsNullOrEmpty(printableReceipt.CargoBarcodeString)) {
                                    //    Console.WriteLine(specialCode + " CargoBarcodeString is empty!");
                                    //    break;
                                    //}

                                    /// payment plan getRecId from Erp_PaymentPlan account
                                    string querryRecIdFromErp_PaymentPlan = string.Format(@"SELECT RecId FROM  Erp_PaymentPlan WHERE PlanCode = '{0}'",
                                                                                          !Object.ReferenceEquals(null, ordr.pop_code) ? ordr.pop_code.ToString() : "");
                                    DataTable tableRecIdFromErp_PaymentPlan = Functions.getDataFromSql(Functions.GetConnString("ms_sql"), querryRecIdFromErp_PaymentPlan);
                                    string receiptPaymentPlanId = tableRecIdFromErp_PaymentPlan.Rows.Count > 0 ? tableRecIdFromErp_PaymentPlan.Rows[0][0].ToString() : null;
                                    printableReceipt.PaymentPlan = !Object.ReferenceEquals(null, ordr.pop_name) ? ordr.pop_name.ToString() : null;

                                    string receiptCargoNote = !Object.ReferenceEquals(null, ordr.ord_shipping_note) ? ordr.ord_shipping_note.ToString() : null;
                                    printableReceipt.CargoNote = receiptCargoNote;
                                    string receiptOrderNote = !Object.ReferenceEquals(null, ordr.ord_note) ? ordr.ord_note.ToString() : null;
                                    //printableReceipt.ShippingNote = receiptOrderNote;


                                    /// ///
                                    /// kalemler
                                    /// ///
                                    printableReceipt.itemList = new List<PrintableReceiptItem>();
                                    printableReceipt.SetBarcodes = "";
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
                                            if (!Object.ReferenceEquals(null, item.prd_set) && item.prd_set.ToString() != "0") {
                                                if (!printableReceipt.SetBarcodes.Contains(item.prd_set.ToString())) {
                                                    printableReceipt.SetBarcodes += item.prd_set + ", ";
                                                }
                                            }

                                            string itemQuantity = Convert.ToDouble(item.orp_quantity.ToString()).ToString("0.0000", System.Globalization.CultureInfo.InvariantCulture);
                                            printableReceiptItem.Quantity = itemQuantity.Remove(itemQuantity.LastIndexOf("."));
                                            printableReceipt.itemList.Add(printableReceiptItem);

                                        }
                                    }
                                    //Functions.DumpObjectProp(printableReceipt);
                                    ///Save receipt!

                                    Printer(Functions.GetConnString("ms_sql"), printableReceipt, DateTime.Now, receiptId);
                                }//in foreach

                            }
                            else {
                                continue;
                            }
                        }
                        else {
                            continue;
                        }
                    }//out foreach
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                //return;
            }
        }

        private static bool Printer(string connString, PrintableReceipt printableReceipt, DateTime now, string itemOrderReceiptId) {
            /// do not print receipt
            bool result = false;
            try {
                /// ///
                /// Print receipt
                /// ///
                /// get template
                //Console.WriteLine(printableReceipt.SetBarcodes + "***" + printableReceipt.BillingName);

                DataTable dataHtmlTemplate = Functions.getDataFromSql(connString, $@"SELECT Definition FROM Meta_Report WHERE ReportName='OFMReceiptTemplate'");
                byte[] bytArray = (byte[])dataHtmlTemplate.Rows[0][0];
                string htmlTemplate = System.Text.Encoding.UTF8.GetString(bytArray, 0, bytArray.Length);

                /// fill template
                string finalHtml = PrintObj.FillFinalHtml(htmlTemplate, printableReceipt, "finalHtml" + now.ToString("HH_mm"));

                ///finally convert to pdf then print
                MemoryStream ms = PrintObj.CreatePDFFromHTML(finalHtml);

                ///insert final html and pdf
                if (!SaveReceiptToDb(finalHtml, ms, itemOrderReceiptId, false)) {
                    return false;
                }


                /// print
                //if (PrintReceipt(ms, printableReceipt.itemList.Count)) {
                //    string updatePrint = $@"UPDATE Erp_InventoryReceiptAttachment SET Explanation = CONCAT(Explanation, ',1') WHERE Type IN (4,1) AND InventoryReceiptId = '{itemOrderReceiptId}'";
                //    Functions.sendSQLCommand(connString, updatePrint);
                //}

                result = true;

                /// print products
                if (PrintProductReceipt(connString, printableReceipt, now, itemOrderReceiptId)) {

                }
                else {
                    Console.WriteLine("product can not printed!");
                }

                ms.Dispose();
                return result;
            }
            catch (Exception ex) {
                result = false;
                Console.WriteLine(ex.Message);
                return result;
            }
        }

        private static bool PrintProductReceipt(string connString, PrintableReceipt printableReceipt, DateTime now, string itemOrderReceiptId) {
            /// this is inside receipt funct.
            bool result = false;
            try {
                /// ///
                /// print products
                /// ///
                DataTable dataHtmlTemplateProduct = Functions.getDataFromSql(connString, $@"SELECT Definition FROM Meta_Report WHERE ReportName='OFMProductTemplate'");
                byte[] bytArray2 = (byte[])dataHtmlTemplateProduct.Rows[0][0];
                string htmlTemplate2 = System.Text.Encoding.UTF8.GetString(bytArray2, 0, bytArray2.Length);

                /// fill template
                string finalHtml2 = PrintObj.FillFinalHtml(htmlTemplate2, printableReceipt, "products" + now.ToString("HH_mm"));

                /// finally convert to pdf then print
                MemoryStream ms2 = PrintObj.CreatePDFFromHTML(finalHtml2);

                /// insert final html and pdf
                if (!SaveReceiptToDb(finalHtml2, ms2, itemOrderReceiptId, true)) {
                    return false;
                }


                /////// do not print

                ms2.Dispose();
                result = true;
                return result;
            }
            catch (Exception ex) {
                result = false;
                Console.WriteLine(ex.Message);
                return result;
            }
        }

        private static bool SaveReceiptToDb(string html, MemoryStream ms, string itemOrderReceiptId, bool isPrintProductReceipt) {
            string htmlType = "4";
            string pdfType = "1";
            string fileName = "Ust_Receipt";
            if (isPrintProductReceipt) {
                htmlType = "5";
                pdfType = "3";
                fileName = "Alt_Products";
            }
            bool result = false;
            try {
                ///insert final html
                if (string.IsNullOrEmpty(html)) {
                    return false;
                }
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(html);
                if (bytes == null || bytes.Length <= 0) {
                    try {
                        ///bubble
                        Bubble.sendBubbleNote(Functions.GetConnString("my_sql"),
                                              string.Format("{0}-->Fiş html kaydedilemedi!", isPrintProductReceipt),
                                              "yazdırma",
                                              "",
                                              "1",
                                              DateTime.Now,
                                              DateTime.Now.AddDays(3),
                                              "30",
                                              "ALL",
                                              "Yazdırma",
                                              "",
                                              "");

                    }
                    catch { }
                    Console.WriteLine(string.Format("{0}-->Fiş html kaydedilemedi!", isPrintProductReceipt));
                }
                else {
                    List<Functions.SqlObj2> sqlObPrintObj2 = new List<Functions.SqlObj2> {
                                        new Functions.SqlObj2("InventoryReceiptId", itemOrderReceiptId),
                                        new Functions.SqlObj2("Type", htmlType),
                                        new Functions.SqlObj2("FileName", fileName),
                                        new Functions.SqlObj2("Attachment", bytes, bytes.Length, "Image"),
                                        new Functions.SqlObj2("InUse", "1"),
                                        new Functions.SqlObj2("InsertedBy", "24"),
                                        new Functions.SqlObj2("InsertedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                    };
                    Functions.insertToSQL2(Functions.GetConnString("ms_sql"), "Erp_InventoryReceiptAttachment", sqlObPrintObj2.ToArray());
                }

                ///insert final pdf
                if (ms == null) {
                    return false;
                }
                byte[] pdfbytes = ms.ToArray();
                if (pdfbytes == null || bytes.Length <= 0) {
                    try {
                        ///bubble
                        Bubble.sendBubbleNote(Functions.GetConnString("my_sql"),
                                              string.Format("{0}-->Fiş pdf kaydedilemedi!", isPrintProductReceipt),
                                              "yazdırma",
                                              "",
                                              "1",
                                              DateTime.Now,
                                              DateTime.Now.AddDays(3),
                                              "30",
                                              "ALL",
                                              "Yazdırma",
                                              "",
                                              "");

                    }
                    catch { }
                    Console.WriteLine(string.Format("{0}-->Fiş pdf kaydedilemedi!", isPrintProductReceipt));
                }
                else {
                    List<Functions.SqlObj2> sqlObPrintObj = new List<Functions.SqlObj2> {
                                        new Functions.SqlObj2("InventoryReceiptId", itemOrderReceiptId),
                                        new Functions.SqlObj2("Type", pdfType),
                                        new Functions.SqlObj2("FileName", fileName),
                                        new Functions.SqlObj2("Attachment", pdfbytes, pdfbytes.Length, "Image"),
                                        new Functions.SqlObj2("InUse", "1"),
                                        new Functions.SqlObj2("InsertedBy", "24"),
                                        new Functions.SqlObj2("InsertedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                    };
                    Functions.insertToSQL2(Functions.GetConnString("ms_sql"), "Erp_InventoryReceiptAttachment", sqlObPrintObj.ToArray());
                }

                result = true;
                return result;
            }
            catch (Exception ex) {
                try {
                    ///bubble
                    Bubble.sendBubbleNote(Functions.GetConnString("my_sql"),
                                          string.Format("{0}-->Fiş pdf kaydedilemedi!", isPrintProductReceipt),
                                          "yazdırma",
                                          "",
                                          "1",
                                          DateTime.Now,
                                          DateTime.Now.AddDays(3),
                                          "30",
                                          "ALL",
                                          "Yazdırma",
                                          "",
                                          "");
                    Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ex);
                }
                catch { }
                return result;
            }

        }


        private static async Task<bool> PostToDiscrod(string msg) {
            bool result = false;
            try {
                var client = new RestClient("https://discordapp.com/api/webhooks/629709704666546208/LwqlilWMAAooromK_SE2tLO8sBCr5NxhQXZAeZARpYApmrHzae_ms_kn20-325-P2t2M");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json",
                                      "{\r\n  \"username\": \"Sipariş HATA var!\",\r\n  \"content\": \"" + $@"{msg}" + "\"\r\n}",//,\r\n\"tts\": true <@591213089748418571> 
                                      ParameterType.RequestBody);
                IRestResponse response = await client.ExecuteAsync(request);
                //Console.WriteLine(response.Content);
                if (response.StatusCode == System.Net.HttpStatusCode.OK) {
                    result = true;
                }
                else {
                    result = false;
                }
                return result;
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                return result;
            }
        }
        ///eof
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGCore {
    public static partial class UGSync_Order {
        ///// print printtopapaer
        //private static async Task<bool> PrintToPaper(string connString, PrintableReceipt printableReceipt, string itemOrderReceiptId) {
        //    /// ///
        //    /// print to paper
        //    /// ///
        //    string IsPrinted = "0";
        //    try {
        //        if (Printer(connString, printableReceipt, DateTime.Now, itemOrderReceiptId)) {
        //            IsPrinted = "1";
        //            await Task.Delay(300);
        //            /// ///
        //            /// update receipt IsPrinted
        //            /// ///
        //            Functions.SqlObj[] SqlObjReceiptUpdate2 = new Functions.SqlObj[] {
        //                new Functions.SqlObj("IsPrinted", IsPrinted)
        //            };
        //            Functions.updateSQL(connString, "Erp_InventoryReceipt", $"RecId = '{itemOrderReceiptId}'", SqlObjReceiptUpdate2);
        //            return true;
        //        }
        //        else {
        //            return false;
        //        }
        //    }
        //    catch {
        //        try {
        //            if (Printer(connString, printableReceipt, DateTime.Now, itemOrderReceiptId)) {
        //                IsPrinted = "1";
        //                await Task.Delay(300);

        //                /// ///
        //                /// update receipt IsPrinted
        //                /// ///
        //                Functions.SqlObj[] SqlObjReceiptUpdate2 = new Functions.SqlObj[] {
        //                    new Functions.SqlObj("IsPrinted", IsPrinted)
        //                };
        //                Functions.updateSQL(connString, "Erp_InventoryReceipt", $"RecId = '{itemOrderReceiptId}'", SqlObjReceiptUpdate2);
        //                return true;
        //            }
        //            else {
        //                return false;
        //            }
        //        }
        //        catch (Exception ex) {
        //            //try {
        //            //    ///bubble
        //            //    Bubble.sendBubbleNote(mySqlConn,
        //            //                          string.Format("{0}-{1}-->Sipariş yazdırılamadı!", specialCode, accountName),
        //            //                          "yazdırma",
        //            //                          string.Format(@"https://www.uzaktangelir.com/admin/index.php?p=Orders&view={0}", orderId),
        //            //                          "1",
        //            //                          DateTime.Now,
        //            //                          DateTime.Now.AddDays(3),
        //            //                          "30",
        //            //                          "ALL",
        //            //                          "Yazdırma",
        //            //                          ordr.ord_status.ToString(),
        //            //                          orderId);
        //            //}
        //            //catch {
        //            //}
        //            Console.WriteLine(ex.Message);
        //            return false;
        //        }
        //    }
        //}
       
        /// print funcs
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
                // TODO!: this is for new kargo
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

                /// muhasebe nüshası
                printableReceipt.CargoName += " - *MUHASEBE*";
                printableReceipt.itemList = new List<PrintableReceiptItem>();
                string finalHtml3 = PrintObj.FillFinalHtml(htmlTemplate2, printableReceipt, "products" + now.ToString("HH_mm"));

                /// finally convert to pdf then print
                MemoryStream ms2 = PrintObj.CreatePDFFromHTML(finalHtml2 + finalHtml3);
                //MemoryStream ms3 = PrintObj.CreatePDFFromHTML(finalHtml3);
                //ms3.CopyTo(ms2);

                /// insert final html and pdf
                if (!SaveReceiptToDb(finalHtml2, ms2, itemOrderReceiptId, true)) {
                    return false;
                }


                /// print
                if (PrintReceipt(ms2, printableReceipt.itemList.Count)) {
                    string nowX = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string updatePrint = "UPDATE Erp_InventoryReceiptAttachment" +
                                         $" SET Explanation = CONCAT(Explanation, ',1'), UpdatedAt='{nowX}', UpdatedBy='24'" + 
                                         $" WHERE Type IN (5,3) AND InventoryReceiptId = '{itemOrderReceiptId}'";

                    Functions.sendSQLCommand(connString, updatePrint);
                    result = true;
                }
                else {
                    result = false;
                }

                ms2.Dispose();
            }
            catch (Exception ex) {
                result = false;
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        private static bool PrintReceipt(MemoryStream ms, int itemCount, string printerName = "RONGTA 80mm Series Printer") { //"P-3521 MFP KX"
            bool result = false;
            try {
                if (PrintObj.PrintPDF(printerName, "", itemCount, ms)) {

                    result = true;
                }
                return result;
            }
            catch {
                try {
                    if (PrintObj.PrintPDF(printerName, "", itemCount, ms)) {

                        result = true;
                    }
                    return result;
                }
                catch {
                    return result;
                }
            }
        }

        private static bool SaveReceiptToDb(string html, MemoryStream ms, string itemOrderReceiptId, bool isPrintProductReceipt) {
            string htmlType = "4";
            string pdfType = "1";
            string fileName = "Ust_Receipt";
            if (isPrintProductReceipt) { // sipariş fişi
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


        public static bool PrintProductReceipt(string connString, PrintableReceipt printableReceipt) {
            /// this is public function not saving to db
            bool result = false;
            try {
                /// ///
                /// print products
                /// ///
                DataTable dataHtmlTemplateProduct = Functions.getDataFromSql(connString, $@"SELECT Definition FROM Meta_Report WHERE ReportName='OFMProductTemplate'");
                byte[] bytArray2 = (byte[])dataHtmlTemplateProduct.Rows[0][0];
                string htmlTemplate2 = System.Text.Encoding.UTF8.GetString(bytArray2, 0, bytArray2.Length);

                /// fill template
                string finalHtml2 = PrintObj.FillFinalHtml(htmlTemplate2, printableReceipt, "products" + DateTime.Now.ToString("HH_mm"));

                /// finally convert to pdf then print
                MemoryStream ms2 = PrintObj.CreatePDFFromHTML(finalHtml2);

                /// print
                if (PrintReceipt(ms2, printableReceipt.itemList.Count)) {
                    // success
                    result = true;
                }
                else {
                    result = false;
                }

                ms2.Dispose();
            }
            catch (Exception ex) {
                result = false;
                Console.WriteLine(ex.Message);
                
            }
            return result;
        }

    }
}

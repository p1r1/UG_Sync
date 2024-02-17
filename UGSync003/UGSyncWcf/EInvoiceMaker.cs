using SentezEInvoiceXML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UGCore;

namespace UGSyncWcf {
    public static class EInvoiceMaker {
        private static string connString = Functions.GetConnString("ms_sql");

        public static async Task<bool> InsertInvoice(string specialCode, bool createXML = false) {
            //// Create new stopwatch.
            //Stopwatch stopwatch = new Stopwatch();
            //// Begin timing.
            //stopwatch.Start();

            //// Write hours, minutes and seconds.
            //Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);

            bool result = true;
            try {
                /// check if sip hazirlaniyor
                /// selim abi bütün sipaişler için ugapiye sormaya gerek yok dedi- iptal,

                ///check receipt if exist
                var querry = "select RecId, ReceiptDate, CurrentAccountId, GrandTotal, ReceiptTime, AddressId, ShipToAddressId, PaymentPlanId, CustomerOrderNo, " +
                                    "TransporterId, Explanation, SubTotal, VatAmount, PaymentPlanId, DiscountsTotal, CurrentAccountReceiptId, ProjectId " +
                             "from Erp_InventoryReceipt " +
                             $"where SpecialCode = '{specialCode}' and (IsCancelled !=1 or IsCancelled IS NULL) and (IsDeleted != 1 or IsDeleted IS NULL) order by RecId desc";
                DataTable receiptTable = Functions.getDataFromSql(connString, querry);

                //// Write hours, minutes and seconds.
                //Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);

                if (receiptTable.Rows.Count < 1) {
                    result = false;
                    Console.WriteLine("Receipt Not Found!");
                    return result;
                }
                string receiptRecId = receiptTable.Rows[0]["RecId"].ToString();
                if (string.IsNullOrEmpty(receiptRecId)) {
                    result = false;
                    Console.WriteLine("RecId Not Found!");
                    return result;
                }

                /// check if "Kapıda Ödeme"
                if (receiptTable.Rows[0]["ProjectId"].ToString() == "15") {
                    result = false;
                    Console.WriteLine("ProjectId -> Kapıda Ödeme!");
                    return result;
                }

                /// check Invoiceif not exist
                string invoiceRecId = Functions.executeScalar(connString, $"select RecId from Erp_Invoice where SpecialCode = '{specialCode}'");
                if (!string.IsNullOrEmpty(invoiceRecId)) {
                    result = false;
                    Console.WriteLine("Invoice Found!");
                    return result;
                }
                /////////////////////////////////////////////////////////
                /// ///
                /// Current account receipt JUST ITEM
                /// ///
                string receiptReceiptDate = receiptTable.Rows[0]["ReceiptDate"].ToString();
                string receiptCurrentAccountId = receiptTable.Rows[0]["CurrentAccountId"].ToString();
                string receiptGrandTotal = receiptTable.Rows[0]["GrandTotal"].ToString();
                string receiptCargoNameId = receiptTable.Rows[0]["TransporterId"].ToString();

                //// Write hours, minutes and seconds.
                //Console.WriteLine("XXTime elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);

                bool insertCARI = UGSync_Order.InsertCurrentAccountReceiptItem(connString, 
                                                                                receiptReceiptDate, 
                                                                                receiptCurrentAccountId,
                                                                                specialCode, 
                                                                                receiptGrandTotal, 
                                                                                "6");
                //// Write hours, minutes and seconds.
                //Console.WriteLine("XXTime elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);

                //if (!insertCARI) {
                //    result = false;
                //    return result;
                //}

                string CurenntAccountReceiptItemRecId = Functions.executeScalar(connString, "select RecId from Erp_CurrentAccountReceiptItem " +
                                                                                            "where ReceiptType = '21' and SourceModule = '11' and SourceType = '120' and " +
                                                                                            $"CurrentAccountId = {receiptCurrentAccountId} order by RecId desc");
                if (string.IsNullOrEmpty(CurenntAccountReceiptItemRecId)) {
                    Console.WriteLine("CurenntAccountReceiptItemRecId is empty!");
                }

                /////////////////////////////////////////////////////////
                /// ///
                /// Invoice
                /// ///
                bool hasVATException = false;
                string zeroVatCountString = Functions.executeScalar(connString, 
                                                $"SELECT RecId FROM Erp_InventoryReceiptItem WHERE VatRate = 0 and SpecialCode = '{specialCode}'");
                if (!string.IsNullOrEmpty(zeroVatCountString) && decimal.TryParse(zeroVatCountString, out decimal zeroVatCount)) {
                    if (zeroVatCount > 0) {
                        hasVATException = true;
                    }
                }

                /// BOTTLENECK!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                string SubTotalVatIncludedString = Functions.executeScalar(connString,
                                                    $"select sum(ItemTotalVatIncluded) from Erp_InventoryReceiptItem where ReceiptType = 120 and SpecialCode = '{specialCode}'");
                if (!double.TryParse(SubTotalVatIncludedString, out double subTotalVatIncluded)) {
                    Console.WriteLine("subTotalVatIncluded problem!");
                }
                //// Write hours, minutes and seconds.
                //Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);

                string paymentPlanId = receiptTable.Rows[0]["PaymentPlanId"].ToString();
                string EArchivesPaymentType = "";
                string PaymentPlanType = "";
                string PaymentToCurrentAccountId = "";
                ///cct3d cct ccp3d
                if (paymentPlanId == "3" || paymentPlanId == "6" || paymentPlanId == "4" || paymentPlanId == "2") {//KK
                    EArchivesPaymentType = "KREDIKARTI/BANKAKARTI";
                    PaymentPlanType = "98";
                    PaymentToCurrentAccountId = "424700";
                }
                else if (paymentPlanId == "1") { // EFT
                    EArchivesPaymentType = "EFT/HAVALE";
                    PaymentPlanType = "7";
                    PaymentToCurrentAccountId = ""; // bizim
                }
                else if (paymentPlanId == "10002") { // pazara yeri
                    if (specialCode.Contains("UG-N")) { // N11
                        EArchivesPaymentType = "ODEMEARACISI";
                        PaymentPlanType = "98";
                        PaymentToCurrentAccountId = "425815"; // doğuş planet - n11
                    }
                }
                else if (paymentPlanId == "5") { // kapıda ödeme - nakit
                    if (receiptCargoNameId == "1") {// PTT
                        EArchivesPaymentType = "KAPIDAODEME";
                        PaymentPlanType = "7";
                        PaymentToCurrentAccountId = "424558";// postane
                    }
                    else if (receiptCargoNameId == "2") {// ARAS
                        EArchivesPaymentType = "KAPIDAODEME";
                        PaymentPlanType = "7";
                        PaymentToCurrentAccountId = "424558";// postane
                    }
                    else if (receiptCargoNameId == "3") {//Yurtiçi
                        EArchivesPaymentType = "KAPIDAODEME";
                        PaymentPlanType = "7";
                        PaymentToCurrentAccountId = "424590";// yurtiçi
                    }
                }
                else if (paymentPlanId == "7") {// kapıda ödeme - KK
                    if (receiptCargoNameId == "1") {// transport PTT
                        EArchivesPaymentType = "KAPIDAODEME";
                        PaymentPlanType = "7";
                        PaymentToCurrentAccountId = "424558";// postane cari
                    }
                    else if (receiptCargoNameId == "2") { // transport ARAS
                        EArchivesPaymentType = "KAPIDAODEME";
                        PaymentPlanType = "7";
                        PaymentToCurrentAccountId = "425790";// aras cari
                    }
                    else if (receiptCargoNameId == "3") {// transport Yuriçi
                        EArchivesPaymentType = "KAPIDAODEME";
                        PaymentPlanType = "7";
                        PaymentToCurrentAccountId = "424590";// yurtiçi cari
                    }
                }
                else {
                    EArchivesPaymentType = "EFT/HAVALE";
                    PaymentPlanType = "7";
                    Console.WriteLine("Other type of payment! = EFT");
                }
                string EArchivesCargoId = "424558"; // ptt
                if (receiptCargoNameId == "1") {
                    EArchivesCargoId = "424558"; // ptt
                }
                else if (receiptCargoNameId == "2") {
                    EArchivesCargoId = "425790"; // aras
                }
                else if (receiptCargoNameId == "3") {
                    EArchivesCargoId = "424590"; // yurtiçi
                }
                string receiptBillingAddressId = receiptTable.Rows[0]["AddressId"].ToString();
                string receiptShippingAddressId = receiptTable.Rows[0]["ShipToAddressId"].ToString();
                string receiptPaymentPlanId = receiptTable.Rows[0]["PaymentPlanId"].ToString();
                string receiptCargoNo = receiptTable.Rows[0]["CustomerOrderNo"].ToString();
                //string receiptCargoNameId = receiptTable.Rows[0]["TransporterId"].ToString();
                string receiptExplanation = receiptTable.Rows[0]["Explanation"].ToString();
                string receiptSubTotal = receiptTable.Rows[0]["SubTotal"].ToString();
                string receiptVatAmount = receiptTable.Rows[0]["VatAmount"].ToString();
                string receiptDiscountsTotal = receiptTable.Rows[0]["DiscountsTotal"].ToString();
                //string receiptReceiptTime = receiptTable.Rows[0]["ReceiptTime"].ToString();
                bool isnertInvoice = false;

                /// delete Erp_CurrentAccountReceiptItem -> invoice
                string currentAccountReceiptId_fromIR = receiptTable.Rows[0]["CurrentAccountReceiptId"].ToString();
                if (!string.IsNullOrEmpty(currentAccountReceiptId_fromIR)) {
                    UGSync_Order.DeleteCARI_InventoryREceipt(connString, receiptRecId, currentAccountReceiptId_fromIR);
                }

                string receiptDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0).ToString("yyyy-MM-dd HH:mm:ss");
                string receiptTime = new DateTime(1899, 12, 30, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second).ToString("yyyy-MM-dd HH:mm:ss");

                /// create invoice
                isnertInvoice = UGSync_Order.InsertInvoice(connString, hasVATException, receiptDate, receiptTime, 
                                                            receiptCurrentAccountId, receiptBillingAddressId, receiptCurrentAccountId, receiptShippingAddressId,
                                                            receiptPaymentPlanId, receiptCargoNo, specialCode, receiptCargoNameId, receiptExplanation,
                                                            receiptSubTotal, receiptVatAmount, receiptDiscountsTotal, receiptGrandTotal,
                                                            CurenntAccountReceiptItemRecId, EArchivesPaymentType, 
                                                            subTotalVatIncluded.ToString("0.0000", CultureInfo.InvariantCulture), "6", PaymentToCurrentAccountId, EArchivesCargoId);
                if (!isnertInvoice) {
                    result = false;
                    return result;
                }
                string LastInvoiceRecId  = Functions.executeScalar(connString, "select RecId from Erp_Invoice " +
                                                                                $"where ReceiptType = '120' and SpecialCode='{specialCode}' " +
                                                                                "order by RecId desc");
                if (string.IsNullOrEmpty(LastInvoiceRecId)) {
                    Console.WriteLine("LastInvoiceRecId is empty!");
                    result = false;
                    return result;
                }

                //// Write hours, minutes and seconds.
                //Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
                /////////////////////////////////////////////////////////
                /// ///
                /// Insert ReceiptPaymentItem
                /// ///
                bool resultInsertReceiptPaymentItem = UGSync_Order.InsertReceiptPaymentItem(connString, LastInvoiceRecId, receiptReceiptDate,
                                                                                            receiptGrandTotal, PaymentPlanType, receiptCurrentAccountId, specialCode);

                if (!resultInsertReceiptPaymentItem) {
                    Console.WriteLine("resultInsertReceiptPaymentItem is false!");
                }

                //// Write hours, minutes and seconds.
                //Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);

                /////////////////////////////////////////////////////////
                /// ///
                /// Update Receipt for invoice id
                /// ///
                Functions.SqlObj[] SqlObjReceiptUpdatex = new Functions.SqlObj[] {
                    new Functions.SqlObj("InvoiceId", LastInvoiceRecId)
                };
                Functions.updateSQL(connString, "Erp_InventoryReceipt", $"RecId = '{receiptRecId}'", SqlObjReceiptUpdatex);

                //// Write hours, minutes and seconds.
                //Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);

                ////////////////////////////////////////////////////////
                /// ///
                /// Update Current account receipt JUST ITEM'source
                /// ///
                string InvoiceDocumentNo = Functions.executeScalar(connString, $"select DocumentNo from Erp_Invoice where RecId = {LastInvoiceRecId}");
                if (string.IsNullOrEmpty(InvoiceDocumentNo)) {
                    Console.WriteLine("InvoiceDocumentNo is empty!");
                    result = false;
                    return result;
                }
                bool resultCurrentAccountReceipt = UGSync_Order.UpdateCurrentAccountReceipt(connString, CurenntAccountReceiptItemRecId, LastInvoiceRecId, InvoiceDocumentNo);
                if (!resultCurrentAccountReceipt) {
                    Console.WriteLine("resultCurrentAccountReceipt is false!");
                }

                //// Write hours, minutes and seconds.
                //Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
                /////DONE!
                Console.WriteLine(specialCode + " -> EInvoiceMaker InvoiceInsert is DONE!");

                result = true;
                ///xml
                if (createXML) {
                    result = await Task.Run(() => CreateEInvoiceXml(specialCode, LastInvoiceRecId));
                }
                await Task.Delay(1);

                //// Stop.
                //stopwatch.Stop();
                //// Write hours, minutes and seconds.
                //Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
            }
            catch (Exception ex) {
                result = false;
                Console.WriteLine(ex);
            }
            return result;
        }

        public static async Task<bool> JustCreateXml(string specialCode, bool isDebugMode) {
            bool result = false;
            try {
                ///check receipt if sexist
                var querry = "select RecId, ReceiptDate, CurrentAccountId, GrandTotal, ReceiptTime, AddressId, ShipToAddressId, " +
                                    "PaymentPlanId, CustomerOrderNo, TransporterId, Explanation, SubTotal, VatAmount, PaymentPlanId, DiscountsTotal " +
                             "from Erp_InventoryReceipt " +
                             $"where SpecialCode = '{specialCode}' order by RecId desc";
                DataTable receiptTable = Functions.getDataFromSql(connString, querry);
                string receiptRecId = receiptTable.Rows[0]["RecId"].ToString();
                if (receiptTable.Rows.Count < 1 || string.IsNullOrEmpty(receiptRecId)) {
                    result = false;
                    Console.WriteLine("Receipt Not Found!");
                    return result;
                }

                /// check Invoice if exist
                string invoiceRecId = Functions.executeScalar(connString, $"select RecId from Erp_Invoice where SpecialCode = '{specialCode}'");
                if (string.IsNullOrEmpty(invoiceRecId)) {
                    result = false;
                    Console.WriteLine("Invoice Found!");
                    return result;
                }

                result = await Task.Run(() => CreateEInvoiceXml(specialCode, invoiceRecId, isDebugMode));
                /// DONE!
                Console.WriteLine("EInvoiceMaker JustCreateXml is DONE!");
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                result = false;
            }
            return result;
        }

        private static async Task<bool> CreateEInvoiceXml(string specialCode, string LastInvoiceRecId, bool isDebugModeOn= true) {
            bool result;
            try {
                ////////////////////////////////////////////////////////
                /// ///
                /// Create EInvoice XML
                /// ///
                //bool isDebugModeOn = true;
                string uuid = EInvoiceEmulator.MakeXMLInvoice(connString, specialCode, isDebugModeOn);
                if (string.IsNullOrEmpty(uuid)) {
                    Console.WriteLine("uuid is empty!");
                    result = false;
                    return result;
                }

                ////////////////////////////////////////////////////////
                /// ///
                /// Update Invoice's uuid
                /// ///
                bool resultEInvoiceUUID = UGSync_Order.UpdateEInvoiceUUIDandEInvoiceStatus(connString, LastInvoiceRecId, uuid);
                if (!resultEInvoiceUUID) {
                    Console.WriteLine("resultEInvoiceUUID is false!");
                }

                ///DONE!
                result = true;
                Console.WriteLine("EInvoiceMaker CreateEInvoiceXml is DONE!");
                await Task.Delay(1);
            }
            catch (Exception ex) {
                result = false;
                Console.WriteLine(ex);
            }
            return result;
        }


        //private static bool CheckPreOrderProduct() {

        //}

    }
}

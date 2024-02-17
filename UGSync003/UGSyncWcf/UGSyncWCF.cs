using Newtonsoft.Json.Linq;
using System;
using System.Globalization;
using System.Threading.Tasks;
using UGCore;
using UGSyncWcf;

namespace UGSyncWebService {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class UGSyncWCF : I_UGSyncWCF {
        private const string webUserName_Str = @"yourPass";
        private const string webUserPass_Str = @"yourPass";
        private const string priceStock_xTop_Str = "10000";
        private const string priceStock_xEr_Str = "1000";
        private const string priceStock_url_Str = @"https://www.uzaktangelir.com/extensions/sentez/index.php";
        private const string product_url_Str = @"https://www.uzaktangelir.com/extensions/sentez/index.php";
        private const string order_url_Str = @"https://www.uzaktangelir.com/extensions/sentez/index.php?export_orders=1&id=0";
        private const string product_TopX_Str = "5";
        private const string order_DaysAgo_Str = "10";
        private const bool product_includeImage_Str = true;
        private const int DELAY_TIME_Str = 3;

        public bool isWebServiceOnline() {
            try {
                return true;
            }
            catch (Exception) {
                return false;
            }
        }

        public async Task<bool> priceStock(string priceStock_xTop,
                                           string priceStock_xEr,
                                           string priceStock_url,
                                           string sqlConn,
                                           string webUserName,
                                           string webUserPass,
                                           int DELAY_TIME) {
            //if (string.IsNullOrEmpty(connString) || string.IsNullOrWhiteSpace(connString) ||
            //    string.IsNullOrEmpty(webUserName) || string.IsNullOrWhiteSpace(webUserName) ||
            //    string.IsNullOrEmpty(webUserPass) || string.IsNullOrWhiteSpace(webUserPass) ||
            //    string.IsNullOrEmpty(priceStock_xTop) || string.IsNullOrWhiteSpace(priceStock_xTop) ||
            //    string.IsNullOrEmpty(priceStock_url) || string.IsNullOrWhiteSpace(priceStock_url) ||
            //    string.IsNullOrEmpty(priceStock_xEr) || string.IsNullOrWhiteSpace(priceStock_xEr)) {
            //    setUpTextBoxes();
            //}
            try {
                await Task.Run(()=> UGSync_PriceStock.sendPriceStockToWebSite(priceStock_xTop, priceStock_xEr, priceStock_url, sqlConn, webUserName, webUserPass, DELAY_TIME, true));
                return true;
            }
            catch (Exception) {
                return false;
            }

        }

        //public async Task<bool> productSummary(string priceStock_xTop,
        //                           string priceStock_xEr,
        //                           string priceStock_url,
        //                           string sqlConn,
        //                           string webUserName,
        //                           string webUserPass,
        //                           int DELAY_TIME) {
        //    //if (string.IsNullOrEmpty(connString) || string.IsNullOrWhiteSpace(connString) ||
        //    //    string.IsNullOrEmpty(webUserName) || string.IsNullOrWhiteSpace(webUserName) ||
        //    //    string.IsNullOrEmpty(webUserPass) || string.IsNullOrWhiteSpace(webUserPass) ||
        //    //    string.IsNullOrEmpty(priceStock_xTop) || string.IsNullOrWhiteSpace(priceStock_xTop) ||
        //    //    string.IsNullOrEmpty(priceStock_url) || string.IsNullOrWhiteSpace(priceStock_url) ||
        //    //    string.IsNullOrEmpty(priceStock_xEr) || string.IsNullOrWhiteSpace(priceStock_xEr)) {
        //    //    setUpTextBoxes();
        //    //}
        //    try {
        //        await Task.Run(() => UGSync_Yazar.sendYazarToWebSite(priceStock_xTop, priceStock_xEr, priceStock_url, sqlConn, webUserName, webUserPass, DELAY_TIME));
        //        return true;
        //    }
        //    catch (Exception) {
        //        return false;
        //    }

        //}



        public async Task<bool> product(string product_TopX,
                                        bool product_includeImage,
                                        string product_url,
                                        string sqlConn,
                                        string webUserName,
                                        string webUserPass,
                                        int DELAY_TIME) {
            //if (string.IsNullOrEmpty(connString) || string.IsNullOrWhiteSpace(connString) ||
            //    string.IsNullOrEmpty(webUserName) || string.IsNullOrWhiteSpace(webUserName) ||
            //    string.IsNullOrEmpty(webUserPass) || string.IsNullOrWhiteSpace(webUserPass) ||
            //    string.IsNullOrEmpty(product_TopX) || string.IsNullOrWhiteSpace(product_TopX)) {
            //    setUpTextBoxes();
            //}
            try {
                await Task.Run(() => UGSync_Product.sendToWebsite(product_TopX, product_includeImage, product_url, sqlConn, webUserName, webUserPass, DELAY_TIME));
                return true;
            }
            catch (Exception) {
                return false;
            }

        }

        public async Task<bool> order(string order_DaysAgo,
                                      string order_url,
                                      string sqlConn,
                                      string mySqlConn,
                                      string webUserName,
                                      string webUserPass,
                                      int DELAY_TIME) {
            //if (string.IsNullOrEmpty(connString) || string.IsNullOrWhiteSpace(connString) ||
            //    string.IsNullOrEmpty(mySqlConn) || string.IsNullOrWhiteSpace(mySqlConn) ||
            //    string.IsNullOrEmpty(webUserName) || string.IsNullOrWhiteSpace(webUserName) ||
            //    string.IsNullOrEmpty(webUserPass) || string.IsNullOrWhiteSpace(webUserPass) ||
            //    string.IsNullOrEmpty(order_DaysAgo) || string.IsNullOrWhiteSpace(order_DaysAgo)) {
            //    setUpTextBoxes();
            //}
            try {
                await Task.Run(() => UGSync_Order.sendOrdersToSql(order_DaysAgo, order_url, sqlConn, mySqlConn, webUserName, webUserPass, DELAY_TIME));
                return true;
            }
            catch (Exception) {
                return false;
            }
        }
        public bool PrintGivenPdf(string ReceiptIdentifier, bool isThisReceiptSpecialCode = false) {
            return PrintObj.PrintGivenPdf(ReceiptIdentifier, isThisReceiptSpecialCode);
        }


        ///gets

        public async Task<bool> priceStockGet() {
            try {
                await Task.Run(() => UGSync_PriceStock.sendPriceStockToWebSite(priceStock_xTop_Str, 
                                                                                priceStock_xEr_Str, 
                                                                                priceStock_url_Str, 
                                                                                Functions.GetConnString("ms_sql"), 
                                                                                webUserName_Str,
                                                                                webUserPass_Str, 
                                                                                DELAY_TIME_Str, 
                                                                                true));
                return true;
            }
            catch (Exception) {
                return false;
            }

        }

        public async Task<bool> productSummaryGet() {
            try {
                await Task.Run(() => UGSync_Yazar.sendYazarToWebSite(priceStock_xTop_Str, 
                                                                     priceStock_xEr_Str, 
                                                                     priceStock_url_Str,
                                                                     Functions.GetConnString("ms_sql"), 
                                                                     webUserName_Str,
                                                                     webUserPass_Str, 
                                                                     DELAY_TIME_Str));
                return true;
            }
            catch (Exception) {
                return false;
            }

        }

        //order get
        public async Task<bool> orderGet(string order_DaysAgo, 
                                      string webUserName,
                                      string webUserPass,
                                      int DELAY_TIME) {
            try {
                await Task.Run(() => UGSync_Order.sendOrdersToSql(order_DaysAgo, "https://www.uzaktangelir.com/extensions/sentez/index.php?export_orders=1&id=0",
                                                                    Functions.GetConnString("ms_sql"), Functions.GetConnString("my_sql"), webUserName, webUserPass, DELAY_TIME));
                return true;
            }
            catch (Exception) {
                return false;
            }
        }

        public async Task<bool> productGet() {
            try {
                await Task.Run(() => UGSync_Product.sendToWebsite(product_TopX_Str, 
                                                                  product_includeImage_Str, 
                                                                  product_url_Str,
                                                                  Functions.GetConnString("ms_sql"), 
                                                                  webUserName_Str, 
                                                                  webUserPass_Str, 
                                                                  DELAY_TIME_Str));
                return true;
            }
            catch (Exception) {
                return false;
            }

        }


        public bool PrintGivenPdfGet(string ReceiptIdentifier, bool isThisReceiptSpecialCode = false) {
            return PrintObj.PrintGivenPdf(ReceiptIdentifier, isThisReceiptSpecialCode);
        }


        //public async Task<bool> InsertPayments() {
        //    // payment tahsilat
        //    //    try {
        //    //        bool isThisEft = false;
        //    //        if (isThisEft) {
        //    //            //kk
        //    //            await UGSync_Payment.Process(Functions.GetConnString("ms_sql"),
        //    //                                        receiptReceiptDate,
        //    //                                        receiptDiscountsTotal.ToString("0.0000", CultureInfo.InvariantCulture),
        //    //                                        receiptCurrentAccountId,
        //    //                                        "3",
        //    //                                        receiptCurrentDocNo); // 3 kk,1 eft
        //    //        }
        //    //        else {
        //    //            //eft
        //    //            await UGSync_Payment.ProcessEft(connString,
        //    //                                       receiptReceiptDate,
        //    //                                       receiptDiscountsTotal.ToString("0.0000", CultureInfo.InvariantCulture),
        //    //                                       receiptCurrentAccountId,
        //    //                                       "3",
        //    //                                       receiptCurrentDocNo); // 3 kk,1 eft
        //    //        }
        //    //    }
        //    //    catch (Exception ex) {
        //    //        Console.WriteLine(ex);
        //    //    }
        //    //}
        //}

        /// others
        /// tahsilat
        public async Task<bool> InsertPayment(string inventoryReceiptRecId) {
            return await UGSync_Payment.CheckReceiptsAndProcess(inventoryReceiptRecId);
        }

        /// efatura
        public async Task<bool> EInvoiceXML(string specialCode, bool CreateXML) {
            bool result = false;
            CreateXML = false; ////////////////////////////////////!!!!!!!!!!!!!!!!!!!!!!
            try {
                if (CreateXML) {
                    result = await Task.Run(()=>EInvoiceMaker.InsertInvoice(specialCode, CreateXML));
                }
                else {
                    result = await Task.Run(() => EInvoiceMaker.InsertInvoice(specialCode));
                }
                //await Task.Delay(-1
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                result = false;
            }
            return result;
        }

        public async Task<bool> JustEInvoiceXml(string specialCode, bool isDebugMode = false) {
            bool result = false;
            try {
                /// XML naming changed!!!
                //result = await Task.Run(() => EInvoiceMaker.JustCreateXml(specialCode, isDebugMode));
                result = false;
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                result = false;
            }
            return result;
        }

        /// non sentez
        public async Task<string> PrintNonDbOrderReceipt(string specialCode) {
            string result;
            try {
                result = await UGOrder_NonSentez.Print(specialCode);
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                result = "false";
            }
            return result;
        }

        /// delete inventory receipt invoice and current account
        public /*async*/ WebServiceReturnObject DeleteOrder(string SpecialCode, int DaysAgo = 3) {
            try {
               string resultLog = UGSync_DeleteOrder.Delete(SpecialCode, DaysAgo);
                //await Task.Delay(1);
                bool result = true;
                if (resultLog.Contains("False")) {
                    result = false;
                }
                return new WebServiceReturnObject { result = result, resultLog = resultLog };
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                return new WebServiceReturnObject { result = false, resultLog = ex.Message };
            }
        }


        /// check einvoice user
        public WebServiceReturnObject CheckInvoiceUser(string vkn) {
            //1 -> yes Einvoice, 0-> No Earchive
            var result = false;
            try {
                result = Convert.ToBoolean(EdmEInvoiceCheckUser.IsEInvoiceUserCheck(vkn));
                return new WebServiceReturnObject { result = result, resultLog = "Success!" };
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                return new WebServiceReturnObject { result = result, resultLog = "Fail!\n" + ex.Message };
            }
        }


    }
}

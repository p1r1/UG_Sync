using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGCore {
    public static class UGOrder_NonSentez {

        public async static Task<string> Print(string specialCode) {
            string result = "";
            try {
                //List<string> specialCodesFromDb = GetDataFromMySql();
                JArray jArrayData = GetDataFromAPI(specialCode);
                List<string> specialCodes = new List<string>();
                if (!object.ReferenceEquals(null, jArrayData)) {
                    Console.WriteLine(jArrayData.Count);
                    if (jArrayData.Count > 0) {
                        for (int i = 0; i < jArrayData.Count; i++) {
                            if (jArrayData[i]["ord_code"].ToString() == specialCode) {
                                /// create printable object
                                PrintableReceipt printableReceipt = new PrintableReceipt();
                                printableReceipt.ReceiptDocNo = "";// send empty
                                printableReceipt.SpecialCodeBarcode = "";// send empty pic
                                printableReceipt.CargoName = jArrayData[i]["crg_name"].ToString() ?? "";
                                printableReceipt.SpecialCode = specialCode;
                                printableReceipt.PaymentPlan = jArrayData[i]["pop_name"].ToString();
                                printableReceipt.ShippingName = jArrayData[i]["ord_shipping_name"].ToString();
                                printableReceipt.BillingName = jArrayData[i]["ord_billing_name"].ToString();

                                printableReceipt.Ship68 = "";
                                if (jArrayData[i]["ord_shipping_city"].ToString().ToLower().Contains("aksaray") &&
                                    jArrayData[i]["ord_shipping_town"].ToString().ToLower().Contains("merkez")) {
                                    printableReceipt.Ship68 = "AKSARAY!";
                                }

                                printableReceipt.SetBarcodes = "";
                                printableReceipt.RepeatedProduct = "";
                                List<PrintableReceiptItem> productList = new List<PrintableReceiptItem>();
                                for (int j = 0; j < jArrayData[i]["products"].Count(); j++) {
                                    PrintableReceiptItem printableReceiptItem = new PrintableReceiptItem();
                                    int.TryParse(jArrayData[i]["products"][j]["orp_price"].ToString(), out int productPrice);
                                    printableReceiptItem.Price = productPrice;
                                    printableReceiptItem.Barcode = jArrayData[i]["products"][j]["orp_barcode"].ToString();
                                    printableReceiptItem.Quantity = jArrayData[i]["products"][j]["orp_quantity"].ToString();
                                    printableReceiptItem.Name = jArrayData[i]["products"][j]["orp_prd_name"].ToString();
                                    if (!object.ReferenceEquals(null, jArrayData[i]["products"][j]["prd_box_no"])) {
                                        printableReceiptItem.Box = jArrayData[i]["products"][j]["prd_box_no"].ToString();
                                    }
                                    else {
                                        printableReceiptItem.Box = "";
                                    }
                                    productList.Add(printableReceiptItem);

                                    if (!object.ReferenceEquals(null, jArrayData[i]["products"][j]["prd_set"]) &&
                                        jArrayData[i]["products"][j]["prd_set"].ToString() != "0") {
                                        if (!printableReceipt.SetBarcodes.Contains(jArrayData[i]["products"][j]["prd_set"].ToString())) {
                                            printableReceipt.SetBarcodes += jArrayData[i]["products"][j]["prd_set"].ToString() + ", ";
                                        }
                                    }
                                    if (printableReceiptItem.Quantity != "1") {
                                        printableReceipt.RepeatedProduct = "Aynı üründen 1'den fazla almış!";
                                    }
                                }
                                printableReceipt.itemList = productList;

                                ///print 
                                UGSync_Order.PrintProductReceipt(Functions.GetConnString("ms_sql"), printableReceipt);

                                /// make a list for to db
                                specialCodes.Add(specialCode);
                            }
                            else {
                                Console.WriteLine("Printed Before");
                            }
                        }
                        /// insert to db
                        //InsertPrintedToMySql(specialCodes);
                    }
                }
                await Task.Delay(1);
                result = string.Join(", ", specialCodes.ToArray());
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                result = "false";
            }
            return result;
        }

        private static JArray GetDataFromAPI(string speicalCode) {
            JArray jArray = null;
            try {
                var client = new RestClient("https://www.uzaktangelir.com/admin/api.php");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Cookie", "admin_template=bs");
                request.AlwaysMultipartFormData = true;
                request.AddParameter("service", "OrdersApi");
                request.AddParameter("method", "list");
                request.AddParameter("username", "yourPass");
                request.AddParameter("password", "yourPass");
                request.AddParameter("ord_code", speicalCode);
                //request.AddParameter("ord_status", "23");
                IRestResponse response = client.Execute(request);
                //Console.WriteLine(response.Content);
                if (!response.IsSuccessful) {
                    return jArray;
                }
                JObject jsonObj = JObject.Parse(response.Content);               

                if (jsonObj.Count < 1 || !jsonObj.ContainsKey("data")) {
                    return jArray; // null
                }
                else {
                    jArray = (JArray)jsonObj["data"];
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }

            return jArray;
        }

        //private static List<string> GetDataFromMySql(double daysAgo = 10) {

        //    MySqlObj mySqlObj = new MySqlObj(MySqlObj.DEFAULT_CONN_STRING);
        //    string now = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
        //    string daysAgoString = DateTime.Now.AddDays(-1 * daysAgo).ToString("yyyy-MM-dd HH:mm:ss");
        //    string query = $"select SpecialCode from ofm_kapida_odeme where Date BETWEEN '{daysAgoString}' AND '{now}'";
        //    mySqlObj.selectTable(query, true);
        //    DataTable dataTable = mySqlObj.dataTableGet;
        //    var list = dataTable.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("SpecialCode")).ToList();
        //    //mySqlObj.closeConnection();
        //    return list;
        //}

        //private static bool InsertPrintedToMySql(List<string> list) {
        //    bool result = false;
        //    try {
        //        List<List<MySqlObj.MySqlPair>> mySqlPairs = new List<List<MySqlObj.MySqlPair>>();
        //        for (int i = 0; i < list.Count(); i++) {
        //            mySqlPairs.Add(new List<MySqlObj.MySqlPair> { new MySqlObj.MySqlPair("SpecialCode", list[i]) });
        //        }
        //        MySqlObj mySqlObj = new MySqlObj(MySqlObj.DEFAULT_CONN_STRING);
        //        mySqlObj.insertMulti("ofm_kapida_odeme", mySqlPairs, true);
        //    }
        //    catch (Exception ex) {
        //        Console.WriteLine(ex);
        //        result = false;
        //    }
        //    return result;
        //}



    }
}

//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
//using RestSharp;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace UGCore {
//    public static partial class UGSync_Order {


//        private static async Task<bool> ChangeCargoNoReCreatePrintableReceipt(string IRRecId) {
//            try {
//                DataTable IR = Functions.getDataFromSql(Functions.GetConnString("ms_sql"), $"select SpecialCode, CustomerOrderNo from Erp_InventoryReceipt where RecId='{IRRecId}'");
//                string specialcode = IR.Rows[0][0].ToString();
//                string cargoNo = IR.Rows[0][1].ToString();

//                if (ReferenceEquals(null, IR) || IR.Rows.Count < 1 || string.IsNullOrEmpty(specialcode)) {
//                    Console.WriteLine("IR is null");
//                    return false;
//                }

//                cargoNo = GetCargoNo(specialcode).Trim();
//                if (string.IsNullOrEmpty(cargoNo)) {
//                    Console.WriteLine("cargoNo is null");
//                    return false;
//                }

//                string querry = $@"SELECT Attachment FROM Erp_InventoryReceiptAttachment WHERE Type='2' AND InventoryReceiptId='{IRRecId}' ORDER BY RecId DESC";
//                DataTable dat = Functions.getDataFromSql(Functions.GetConnString("ms_sql"), querry);
//                var JsonString = Encoding.UTF8.GetString((byte[])dat.Rows[0][0]);
//                var printableReceipt = JsonConvert.DeserializeObject<PrintableReceipt>(JsonString);

//                if (ReferenceEquals(null, printableReceipt)) {
//                    Console.WriteLine("printableReceipt is null");
//                    return false;
//                }
//                printableReceipt.CargoBarcodeString = cargoNo;

//                //var result = await PrintToPaper(Functions.GetConnString("ms_sql"), printableReceipt, IRRecId);
//                var result = SavePrintableReceiptToDB(printableReceipt, IRRecId);
//                return result;
//            }
//            catch (Exception ex) {
//                Console.WriteLine(ex);
//                return false;
//            }
//        }

//        private static string GetCargoNo(string ord_code/*string ord_status = "21"*/) {
//            string cargoNo = null;
//            try {
//                var client = new RestClient("https://www.uzaktangelir.com/admin/api.php");
//                client.Timeout = -1;
//                var request = new RestRequest(Method.POST);
//                request.AlwaysMultipartFormData = true;
//                request.AddParameter("service", "OrdersApi");
//                request.AddParameter("method", "list");
//                request.AddParameter("username", "yourPass");
//                request.AddParameter("password", "yourPass");
//                request.AddParameter("ord_code", ord_code);
//                //request.AddParameter("ord_date1", date1);
//                //request.AddParameter("ord_date2", date2);
//                //request.AddParameter("ord_status", ord_status);
//                IRestResponse response = client.Execute(request);
//                //Console.WriteLine(response.Content);
//                if (response.StatusCode == System.Net.HttpStatusCode.OK) {
//                    var json = JObject.Parse(response.Content);
//                    if (!ReferenceEquals(null, json)) {
//                        var status = json["status"].ToString().Trim();
//                        if (!string.IsNullOrEmpty(status) && status == "200") {
//                            var data = json["data"];
//                            if (!ReferenceEquals(null, data) && data.Count() > 0) {
//                                cargoNo = json["data"][0]["ord_cargo_ref_no"].ToString();
//                            }
//                        }
//                    }
//                }
//                return cargoNo;
//            }
//            catch (Exception ex) {
//                Console.WriteLine(ex);
//                return null;
//            }
//        }

//        private static bool SavePrintableReceiptToDB(PrintableReceipt printableReceipt, string IRRecId) {
//            try {
//                DataTable dataHtmlTemplate = Functions.getDataFromSql(Functions.GetConnString("ms_sql"), $@"SELECT Definition FROM Meta_Report WHERE ReportName='OFMReceiptTemplate'");
//                byte[] bytArray = (byte[])dataHtmlTemplate.Rows[0][0];
//                string htmlTemplate = System.Text.Encoding.UTF8.GetString(bytArray, 0, bytArray.Length);

//                /// fill template
//                string finalHtml = PrintObj.FillFinalHtml(htmlTemplate, printableReceipt, "finalHtml" + DateTime.Now.ToString("HH_mm"));

//                ///finally convert to pdf then print
//                MemoryStream ms = PrintObj.CreatePDFFromHTML(finalHtml);

//                ///insert final html and pdf
//                // TODO!: this is for new kargo
//                if (!SaveReceiptToDb(finalHtml, ms, IRRecId, false)) {
//                    return false;
//                }
//                else {
//                    return true;
//                }
//            }
//            catch (Exception ex) {
//                Console.WriteLine(ex);
//                return false;
//            }


//        }

//    }
//}

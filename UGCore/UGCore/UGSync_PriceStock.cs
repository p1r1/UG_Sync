using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace UGCore {
    public static class UGSync_PriceStock {
        private static DataTable oldTable;
        
        //sendToWebsite(product_TopX, product_includeImage, product_url, sqlConn, webUserName, webUserPass, DELAY_TIME);
        //sendOrdersToSql(order_DaysAgo, order_url, sqlConn, mySqlConn, webUserName, webUserPass, DELAY_TIME);
        public static async Task<bool> sendPriceStockToWebSite(string xTop/*not important get them all*/, 
                                                               string xEr,
                                                               string url,
                                                               string connString,
                                                               string webUserName,
                                                               string webUserPass,
                                                               int DELAY_TIME,
                                                               bool sendFullTable = false) {
            
            string logFilePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            string methodName = "FiyatStok--> ";
            
            /// ///
            /// Send prices and real stock numbers to website via json
            /// ///
            /// get data from sql database 
            string query = "SELECT * From ERP_StockPrice";
            DataTable tableProduct = Functions.getDataFromSql(connString, query);

            /// better to send querry
            //string query = "getDataFromSentezDokuz";/// 0.1-0.2 sec quicker
            //DataTable tableProduct = Functions.getDataFromProcedure(connString, query, null);//.getDataFromSql(connString, query);

            #region old set stock depricated
            /// ///
            /// set stok quantity
            /// ///

            //try {
            //    tableProduct.Select("[prd_inventoryType] = '8'")
            //                 .ToList<DataRow>()
            //                 .ForEach(r => {
            //                     r["prd_stock"] = Functions.getDataFromProcedure(connString, "OFM_getSet",
            //                                        new List<SqlPair> { new SqlPair("setRecId", r["prd_ext_id"], SqlDbType.Int) }).Rows[0][0];
            //                 });
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ex);
            //    return false;
            //    // TODO: catch this diffrent!!! d
            //}


            /// remove unwanted columns
            //DataTable strippedTable = new DataTable();
            //try {
            //    DataView view = new DataView(tableProduct);
            //    strippedTable = view.ToTable(false, "prd_barcode", "prd_stock", "prd_price", "prd_status", "prd_in_use");
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ex);            
            //}

            #endregion

            /// ///
            /// if price or stock not changed do not send
            /// ///
            DataTable finalTable = new DataTable();
            if (oldTable != null && oldTable.Rows.Count > 0) {
                finalTable = comperaTables(tableProduct, oldTable);
                if (finalTable == null || finalTable.Rows.Count < 1) {
                    finalTable = tableProduct;
                }
            }
            else {
                finalTable = tableProduct;
            }
            /// this became oldtable
            if (finalTable!= null & finalTable.Rows.Count > 0) {
                if (oldTable != null && oldTable.Rows.Count > 0) {
                    oldTable.Clear();
                }
                oldTable = finalTable; 
            }

            /// add to dataset for bad old function
            DataSet dat = new DataSet();
            if (sendFullTable) {
                dat.Tables.Add(tableProduct);
            }
            else {
                dat.Tables.Add(finalTable);//strippedTable
            }

            /// debug -delete
            //foreach (DataRow item in dat.Tables[0].Rows) {
            //    if (item["prd_barcode"].ToString() == "5089" ) {
            //        Console.WriteLine("asdasd");
            //        Console.WriteLine("asdasd");
            //    }
            //}

            /// calculate eft stocks
            //DataSet eftCalculatedSet = null;
            //try {
            //    eftCalculatedSet = CalculateEFTStock(dat);
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex);
            //}
            //if (!Object.ReferenceEquals(null, eftCalculatedSet)) {
            //    dat = eftCalculatedSet;
            //}

            /// ///
            /// divide and send data to internet part by part
            /// ///
            if (dat != null && dat.Tables != null && dat.Tables.Count != 0) {
                //divide and conquer

                string firstOutput = "{\n    \"settings\": {\n      \"user\": \"" + webUserName + "\",\n      \"pass\": \"" + webUserPass + "\"\n    },\n    \"products\":" + "{\n\"product\": [\n";
                string lastOutput = "\n}\n}";

                int i = 0;
                /// returns list make json xer
                var jsonList = Functions.makeJsonList(dat, xEr);
                if (jsonList == null || jsonList.Count < 1) {
                    Console.WriteLine("jsonlist is empty!");
                    return false;
                }

                
                foreach (string item in jsonList) {
                    string json = "";
                    json = firstOutput + item.ToString() + lastOutput;
                    //labelInfo2.Invoke(() => labelInfo2.Text = json);

                    Log.append(methodName + i.ToString() + ". \n" + json + "\n ----------\n", logFilePath);

                    // write to site
                    string response = "";
                    bool isWriteToWebSiteSuccess = false;
                    try {
                        response = Functions.writeToSite(url, json);

                        dynamic status = JsonConvert.DeserializeObject(response);
                        if (status.status == "1") {
                            Log.append(methodName + (i + 1).ToString() + ". part siteye aktarıldı.", logFilePath);
                            i++;
                            isWriteToWebSiteSuccess = true;
                        }
                        else {
                            Log.append(methodName + response, logFilePath);
                            isWriteToWebSiteSuccess = false;
                        }
                    }
                    catch (Exception) {
                        Log.append(methodName + "button -> siteye yazamadı!", logFilePath);
                         isWriteToWebSiteSuccess = false;
                    }
                    if (!isWriteToWebSiteSuccess) {
                        await SendViaSiteUI(item);
                    }


                }
                int a = Convert.ToInt32(xTop);
                int b = Convert.ToInt32(xEr);
                Log.append(methodName + ((b * (i - 1)) + (a % b)).ToString() + " adet ürün basıldı", logFilePath);
            }
            else {
                /// hepsini çektiği için buraya hiç düşmez. updated at kullanılabilir
                Log.append(methodName + "Fiyatı değişecek ürün yok", logFilePath);
                Console.WriteLine("dat dataset is empty");
            }
            
            await Task.Delay(DELAY_TIME);
            Console.WriteLine("Fiyat stok DONE!");
            return true;
        }




        private static DataTable comperaTables(DataTable dataTable1, DataTable dataTable2) {
            //DataTable dataTable1; // Load with data
            //DataTable dataTable2; // Load with data (same schema)

            //// Fast check for row count equality.
            //if (dataTable1.Rows.Count != dataTable2.Rows.Count) {
            //    return true;
            //}
            try {
                var differences =
                    dataTable1.AsEnumerable().Except(dataTable2.AsEnumerable(),
                                                            DataRowComparer.Default);

                return differences.Any() ? differences.CopyToDataTable() : new DataTable();
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                return null;                
            }

        }

        /// <summary>
        /// selim abi karışır dedi - açmadan test et!
        /// </summary>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        private static DataSet CalculateEFTStock(DataSet dataSet) {
            try {
                string dateFormat = "yyyy-MM-dd";
                string today = DateTime.Now.ToString(dateFormat);
                string twoDaysAgo = DateTime.Now.AddDays(-2).ToString(dateFormat);
                string order_url = @"https://www.uzaktangelir.com/extensions/sentez/index.php?export_orders=1&id=0";
                string url1 = order_url + "&date1=" + twoDaysAgo + "&date2=" + today + "&user=yourPass&pass=yourPass";
                WebOrder webOrders = new WebOrder(url1);
                webOrders.getJsonFromWeb();
                webOrders.createDynamicVar();

                if (Object.ReferenceEquals(null, webOrders.m_data.orders)) {
                    return null;
                }
                /// get orders
                foreach (var ordr in webOrders.m_data.orders) {
                    if (!Object.ReferenceEquals(null, ordr.ord_status)) {
                        if (ordr.ord_status.ToString() == "2") {
                            ///eft - adjust stocks
                            if (Object.ReferenceEquals(null, ordr.products)) {
                                continue;
                            }
                            foreach (var product in ordr.products) {
                                /// search sentezdokuz table
                                foreach (DataTable table in dataSet.Tables) {
                                    foreach (DataRow row in table.Rows) {
                                        if (!Object.ReferenceEquals(null, product.orp_barcode) && !Object.ReferenceEquals(null, product.orp_quantity)) {
                                            string productBarcode = product.orp_barcode.ToString();
                                            if (row["prd_barcode"].ToString() == productBarcode) {
                                                /// found the product
                                                int productQuantity = 0;
                                                int sentezStock = 0;
                                                if (Int32.TryParse(product.orp_quantity.ToString().Trim(), out productQuantity) &&
                                                    Int32.TryParse(row["prd_stock"].ToString().Trim(), out sentezStock)) {
                                                    /// Parse successful.
                                                    if (sentezStock - productQuantity < 0) {
                                                        row["prd_stock"] = 0;
                                                    }
                                                    else {
                                                        row["prd_stock"] = sentezStock - productQuantity;
                                                    }
                                                }
                                                else {
                                                    /// quantity can not be parsed
                                                    continue;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else {
                            /// yeni sip - kargoya verildi
                            continue;
                        }
                    }
                    else {
                        /// if null skip
                        continue;
                    }
                }/// foreach
                return dataSet;

            }
            catch (Exception ex) {
                Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ex);
                return null;
            }
        }


        private async static Task<bool> SendViaSiteUI(string json) {
            bool result = false;
            try {
                var client = new RestClient("https://www.uzaktangelir.com/extensions/sentez/index.php");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                //request.AddHeader("Cookie", "PHPSESSID=b808abc3ae4cf29204559c5ba27abdd2");
                request.AlwaysMultipartFormData = true;
                request.AddParameter("json", json);
                IRestResponse response = await client.ExecuteAsync(request);
                if (response.IsSuccessful) {
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

    }
}



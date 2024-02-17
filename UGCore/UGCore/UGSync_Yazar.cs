using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace UGCore {
    public static class UGSync_Yazar {
        
        public static async Task<bool> sendYazarToWebSite(string xTop/*not important get them all*/, 
                                                        string xEr,
                                                        string url,
                                                        string connString,
                                                        string webUserName,
                                                        string webUserPass,
                                                        int DELAY_TIME) {
            /*
            string logFilePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            string methodName = "yazar--> ";
            
            /// ///
            /// Send prices and real stock numbers to website via json
            ///  ///
            /// get data from sql database 
            string query = "SELECT prd_barcode, prd_stock, prd_price, prd_status, prd_in_use, prd_ext_id, prd_inventoryType," +
                           "prd_press_date, prd_size, prd_page_count, writers From SentezDokuz";
            DataTable tableProduct = Functions.getDataFromSql(connString, query);

            /// ///
            /// set stok quantity
            /// ///
            try {
                tableProduct.Select("[prd_inventoryType] = '8'")
                 .ToList<DataRow>()
                 .ForEach(r => {
                     r["prd_stock"] = Functions.getDataFromProcedure(connString, "OFM_getSet",
                         new List<SqlPair> { new SqlPair("setRecId", r["prd_ext_id"], SqlDbType.Int) }).Rows[0][0];
                 });

            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                //return false;
            }


            /// remove unwanted columns
            DataTable strippedTable = new DataTable();
            try {
                DataView view = new DataView(tableProduct);
                strippedTable = view.ToTable(false, "prd_barcode", "prd_stock", "prd_price", "prd_status", "prd_in_use", "prd_press_date", "prd_size", "prd_page_count", "writers");
                //, "prd_press_date", "prd_size", "prd_page_count", "writers"
            }
            catch (Exception) { }


            /// add to dataset for bad old function
            //DataSet dat = new DataSet();
            //dat.Tables.Add(strippedTable);
            JsonClasses.SettingsClass settings = new JsonClasses.SettingsClass(webUserName, webUserPass);
            //List<JsonClasses.Product> products = strippedTable.AsEnumerable().Select(x =>
            //                                        new JsonClasses.Product(x.Field<string>("prd_barcode")??"",
            //                                                                x.Field<int>("prd_stock").ToString()??"",
            //                                                                x.Field<decimal>("prd_price").ToString()??"",
            //                                                                x.Field<string>("prd_status")??"", 
            //                                                                x.Field<byte>("prd_in_use").ToString()??"", 
            //                                                                x.Field<string>("prd_press_date").ToString()??"", 
            //                                                                x.Field<string>("prd_size")??"",
            //                                                                x.Field<string>("prd_page_count")??"",
            //                                                                x.Field<string>("writers")??"")
            //                                        ).ToList();

            List<JsonClasses.Product> products = (from rw in strippedTable.AsEnumerable()
                                                    select new JsonClasses.Product(Convert.ToString(rw["prd_barcode"]),
                                                                                   Convert.ToString(rw["prd_stock"]),
                                                                                   Convert.ToString(rw["prd_price"]),
                                                                                   Convert.ToString(rw["prd_status"]),
                                                                                   Convert.ToString(rw["prd_in_use"]),
                                                                                   Convert.ToString(rw["prd_press_date"]),
                                                                                   Convert.ToString(rw["prd_size"]),
                                                                                   Convert.ToString(rw["prd_page_count"]),
                                                                                   Convert.ToString(rw["writers"]))
                                                    ).ToList();

            /// ///
            /// divide and send data to internet part by part
            /// ///
            if (products.Count != 0) {
                //divide and conquer

                //string firstOutput = "{\n    \"settings\": {\n      \"user\": \"" + webUserName + "\",\n      \"pass\": \"" + webUserPass + "\"\n    },\n    \"products\":" + "{\n\"product\": [\n";
                //string lastOutput = "\n}\n}";

                int xxEer = 0;
                Int32.TryParse(xEr, out xxEer);
                int i = 0;
                foreach (string json in makeJsonList(settings, products, xxEer)) {///returns list divide xer
                    //string json = "";
                    //json = firstOutput + item.ToString() + lastOutput;

                    Log.append(methodName + i.ToString() + ". \n" + json + "\n ----------\n", logFilePath);

                    // write to site
                    string response = "";
                    try {
                        response = Functions.writeToSite(url, json);

                        dynamic status = JsonConvert.DeserializeObject(response);
                        if (status.status == "1") {
                            Log.append(methodName + (i + 1).ToString() + ". part siteye aktarıldı.", logFilePath);
                            i++;
                        }
                        else {
                            Log.append(methodName + response, logFilePath);
                        }
                    }
                    catch (Exception) {
                        Log.append(methodName + "button -> siteye yazamadı!", logFilePath);                       
                    }

                }
                int a = Convert.ToInt32(xTop);
                int b = Convert.ToInt32(xEr);
                Log.append(methodName + ((b * (i - 1)) + (a % b)).ToString() + " adet ürün basıldı", logFilePath);
            }
            else {
                /// hepsini çektiği için buraya hiç düşmez. updated at kullanılabilir
                Log.append(methodName + "yazar değişecek ürün yok", logFilePath);
            }

            */
            await Task.Delay(DELAY_TIME);
            Console.WriteLine("Yazar DONE!");
            return true;
            
        }

        private static List<string> makeJsonList(JsonClasses.SettingsClass settings, List<JsonClasses.Product> product, int xxEer) {
            var listList = splitList(product, xxEer);
            List<string> jsonList = new List<string>();
            for (int i = 0; i < listList.Count(); i++) {
                string jsonString = "";
                //JsonClasses.ProducJson productJson = new JsonClasses.ProducJson(settings, listList[i]);
                var productJson = new {
                    settings,
                    products = new {
                        product
                    }
                };
                jsonString = JsonConvert.SerializeObject(productJson);
                jsonList.Add(jsonString);
            }
            Console.WriteLine("");
            return jsonList;
        }

        //public static IEnumerable<List<T>> splitList<T>(List<T> locations, int nSize = 30) {
        //    for (int i = 0; i < locations.Count; i += nSize) {
        //        yield return locations.GetRange(i, Math.Min(nSize, locations.Count - i));
        //    }
        //}

        public static List<List<JsonClasses.Product>> splitList(List<JsonClasses.Product> locations, int nSize = 30) {
            var list = new List<List<JsonClasses.Product>>();

            for (int i = 0; i < locations.Count; i += nSize) {
                list.Add(locations.GetRange(i, Math.Min(nSize, locations.Count - i)));
            }

            return list;
        }



    }
}

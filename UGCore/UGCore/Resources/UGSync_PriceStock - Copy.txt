using Newtonsoft.Json;
using System;
using System.Data;
using System.Threading.Tasks;

namespace UGCore {
    public static class UGSync_PriceStock {
        //sendToWebsite(product_TopX, product_includeImage, product_url, sqlConn, webUserName, webUserPass, DELAY_TIME);
        //sendOrdersToSql(order_DaysAgo, order_url, sqlConn, mySqlConn, webUserName, webUserPass, DELAY_TIME);
        public static async Task<bool> sendPriceStockToWebSite(string xTop, string xEr, string url, string connString, string webUserName, string webUserPass, int DELAY_TIME) {
            /// ///
            /// Send prices and real stock numbers to website via json
            ///  ///
            string logFilePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            string methodName = "FiyatStok--> ";
            /// get data from sql database 
            
            //string query = "SELECT Top " + xTop + " prd_barcode, prd_stock, prd_price prd_status, prd_in_use, prd_ext_id, prd_inventoryType From SentezDokuz";
            string query = "SELECT prd_barcode, prd_stock, prd_price, prd_status, prd_in_use, prd_ext_id, prd_inventoryType From SentezDokuz";
            DataTable tableProduct = Functions.getDataFromSql(connString, query);

            /// set stok quantity
            foreach (DataRow row in tableProduct.Rows) {
                if (row["prd_inventoryType"].ToString() == "8") {
                    string querySet = string.Format("SELECT InventoryId FROM Erp_RecipeItem WHERE OwnerInventoryId = {0} and InUse = '1' ORDER BY GroupNo", row["prd_ext_id"].ToString());
                    DataTable tab = Functions.getDataFromSql(connString, querySet);

                    string queryEnd = "(";
                    foreach (DataRow r in tab.Rows) {
                        queryEnd += r["InventoryId"] + ",";
                    }
                    queryEnd = queryEnd.Remove(queryEnd.LastIndexOf(',')) + ")";

                    string querySentezDokuz = string.Format("SELECT prd_stock FROM SentezDokuz WHERE prd_ext_id IN {0}", queryEnd);
                    DataTable t = Functions.getDataFromSql(connString, querySentezDokuz);
                    double smallestStock = 999999999;
                    foreach (DataRow r in t.Rows) {
                        double.TryParse(r["prd_stock"].ToString(), out double stock);
                        if (stock < smallestStock) {
                            smallestStock = stock;
                        }
                    }
                    row["prd_stock"] = smallestStock.ToString();
                }
            }
            DataTable table2 = new DataTable();
            try {
                DataView view = new DataView(tableProduct);
                table2 = view.ToTable(false, "prd_barcode", "prd_stock", "prd_price", "prd_status", "prd_in_use");
            }
            catch (Exception) { }

            /// add to dataset
            DataSet dat = new DataSet();
            dat.Tables.Add(table2);

            if (dat.Tables.Count != 0) {
                //divide and conquer

                string firstOutput = "{\n    \"settings\": {\n      \"user\": \"" + webUserName + "\",\n      \"pass\": \"" + webUserPass + "\"\n    },\n    \"products\":" + "{\n\"product\": [\n";
                string lastOutput = "\n}\n}";

                int i = 0;
                foreach (string item in Functions.makeJsonList(dat, xEr)) {
                    string s = "";
                    s = firstOutput + item.ToString() + lastOutput;
                    //labelInfo2.Invoke(() => labelInfo2.Text = s);

                    Log.append(methodName + i.ToString() + ". \n" + s + "\n ----------\n", logFilePath);

                    // write to site
                    string response = "";
                    try {
                        response = Functions.writeToSite(url, s);

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
                Log.append(methodName + "Fiyatı değişecek ürün yok", logFilePath);
            }
            await Task.Delay(DELAY_TIME);
            return true;
        }
    }
}

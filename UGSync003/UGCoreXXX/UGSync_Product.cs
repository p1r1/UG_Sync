using Newtonsoft.Json;
using System;
using System.Data;
using System.Threading.Tasks;

namespace UGCore {
    public static class UGSync_Product {
        //sendToWebsite(product_TopX, product_includeImage, product_url, sqlConn, webUserName, webUserPass, DELAY_TIME);
        public static async Task<bool> /*bool*/ sendToWebsite(string TopX, bool includeImage, string url, string connString, string webUsername, string webUserPass, int DELAY_TIME) {
            /// get data from sql database 
            string logFilePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            string methodName = "ÜrünMetodu--> ";
            string query = string.Format(@"SELECT TOP {0} * FROM  SentezDokuz WHERE OzelKod IS NULL OR OzelKod = '' ORDER BY prd_ext_id ASC", TopX);

            DataSet dat = new DataSet();
            dat.Tables.Add(Functions.getDataFromSql(connString, query));

            if (dat.Tables[0].Rows.Count != 0) {
                /// table is not empty
                /// change the table name
                foreach (DataTable item in dat.Tables) {
                    item.TableName = "product";
                }
                /// ////
                /// get Sets
                /// ////
                /// 
                int rowIndex = 0;
                foreach (DataRow row in dat.Tables["product"].Rows) {
                    if (row["prd_inventoryType"].ToString() == "8") {
                        string querySet = string.Format("SELECT InventoryId FROM Erp_RecipeItem WHERE OwnerInventoryId = {0} and InUse = '1' ORDER BY GroupNo", row["prd_ext_id"].ToString());
                        DataTable tab = Functions.getDataFromSql(connString, querySet);

                        string setName = row["prd_barcode"].ToString();
                        string queryEnd = "(";
                        //MessageBox.Show(tab.Rows.Count.ToString());

                        foreach (DataRow r in tab.Rows) {
                            queryEnd += r["InventoryId"] + ",";
                        }
                        queryEnd = queryEnd.Remove(queryEnd.LastIndexOf(',')) + ")";
                        //MessageBox.Show(queryEnd);
                        string querySentezDokuz = string.Format("SELECT * FROM SentezDokuz WHERE prd_ext_id IN {0}", queryEnd);

                        /// make new datatable for set
                        DataTable tableSet = new DataTable();
                        tableSet = row.Table.Clone();
                        tableSet.Rows.Add(row.ItemArray);
                        tableSet.TableName = "set" + rowIndex.ToString();
                        dat.Tables.Add(tableSet);

                        ///delete set row
                        row.Delete();


                        dat.Tables.Add(Functions.getDataFromSql(connString, querySentezDokuz, setName));
                        rowIndex++;
                    }
                }
                dat.AcceptChanges();
                dat.Tables["product"].AcceptChanges();

                /// ///
                /// make Xmark query and delete images
                /// ///
                string sqlQueryEnd = "";
                if (includeImage) {
                    foreach (DataTable table in dat.Tables) {
                        //Console.WriteLine(table.TableName);
                        if (table.TableName == "product" || table.TableName.Substring(0, 3) == "set") {
                            foreach (DataRow row in table.Rows) {
                                foreach (DataColumn col in table.Columns) {
                                    if (col.ColumnName == "prd_barcode") {
                                        sqlQueryEnd += "'" + row[col] + "',";
                                    }
                                }
                            }
                        }
                    }
                }
                else {
                    foreach (DataTable table in dat.Tables) {
                        //Console.WriteLine(table.TableName);
                        if (table.TableName == "product" || table.TableName.Substring(0, 3) == "set") {
                            foreach (DataRow row in table.Rows) {
                                if (row["prd_image"] != null) { /// sil
                                    row["prd_image"] = null;
                                }
                                foreach (DataColumn col in table.Columns) {
                                    if (col.ColumnName == "prd_barcode") {
                                        sqlQueryEnd += "'" + row[col] + "',";
                                    }
                                }
                            }
                        }
                    }
                }

                if (sqlQueryEnd.Length > 0) {
                    sqlQueryEnd = sqlQueryEnd.Remove(sqlQueryEnd.Length - 1);
                }
                sqlQueryEnd = "(" + sqlQueryEnd + ")";
                /// ///
                /// Mark updated items special codes with X
                /// ///
                string s = "x";
                Functions.sendSQLCommand(connString, string.Format(@"UPDATE Erp_Inventory SET SpecialCode = '{0}' WHERE InventoryCode IN {1}", s, sqlQueryEnd));

                /// ///
                /// make Json
                /// ///
                //string json = Functions.makeJson(dat, webUsername, webUserPass); // this is normal
                string json = Functions.makeJson2(dat, webUsername, webUserPass); // this is for sets

                Log.append(json, logFilePath);

                string response = Functions.writeToSite(url, json);
                Log.append(response, logFilePath);

                dynamic status = JsonConvert.DeserializeObject(response);

                if (!Object.ReferenceEquals(null, status.status) && status.status == "1") {
                    if (!Object.ReferenceEquals(null, status.sonuc)) {
                        if (status.sonuc.Count != 0) {
                            for (int i = 0; i < status.sonuc.Count; i++) {
                                try {
                                    //if (!Functions.IsPropertyExist(status, "prd_id")) {
                                    //    continue;
                                    //}

                                    if (!Object.ReferenceEquals(null, status.sonuc[i].prd_id) ||
                                        !Object.ReferenceEquals(null, status.sonuc[i].prd_seo_title) ||
                                        !Object.ReferenceEquals(null, status.sonuc[i].prd_barcode)) {
                                        Functions.sendSQLCommand(connString,
                                                                string.Format(@"UPDATE Erp_Inventory SET SpecialCode = '{0}', WebContent = '{1}' WHERE InventoryCode = '{2}'",
                                                                              status.sonuc[i].prd_id.ToString(),
                                                                              status.sonuc[i].prd_seo_title.ToString(),
                                                                              status.sonuc[i].prd_barcode.ToString()));
                                    }
                                }
                                catch (Exception) { continue; }
                            }
                        }
                        else
                            Log.append(methodName + "Hiç ürün değişmedi.", logFilePath);
                    }
                    else
                        Log.append(methodName + response + "-> Sonuc boş!", logFilePath);

                }
                else
                    Log.append(methodName + response, logFilePath);
            }
            else
                Log.append(methodName + "Özel kodu boş(null) olan ürün yok", logFilePath);

            await Task.Delay(DELAY_TIME);
            return true;
        }
    }
}

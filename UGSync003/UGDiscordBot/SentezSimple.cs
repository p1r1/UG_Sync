using Newtonsoft.Json;
using RestSharp;
using System;
using System.Data;
using System.Net;
using UGCore;

namespace UGDiscordBot {
    public static class SentezSimple {
        public static string activateProduct(string barcode, string recId = "6") {
            SqlObj sql = new SqlObj();
            try {
                sql.initalizeSqlConnection(Functions.GetConnString("ms_sql"));
                sql.openConnection();

                sql.selectString($@"SELECT Count(RecId) FROM Erp_Inventory WHERE InventoryCode='{barcode}'", true);
                if (string.IsNullOrEmpty(sql.scalarStringGet) ||
                    string.IsNullOrWhiteSpace(sql.scalarStringGet) ||
                    sql.scalarStringGet == "0") {
                    return "Ürün yok. -> " + barcode;
                }

                sql.selectTable(string.Format(@"SELECT IsPublishWeb, InUse, UseForSale FROM dbo.Erp_Inventory WHERE InventoryCode='{0}' ORDER BY RecId DESC", barcode), true);
                DataTable table = sql.dataTableGet;
                if (table.Rows.Count != 0) {
                    if (!string.IsNullOrEmpty(table.Rows[0]["InUse"].ToString()) && table.Rows[0]["InUse"].ToString() == "1" &&
                        !string.IsNullOrEmpty(table.Rows[0]["UseForSale"].ToString()) && table.Rows[0]["UseForSale"].ToString() == "1" &&
                        !string.IsNullOrEmpty(table.Rows[0]["IsPublishWeb"].ToString()) && table.Rows[0]["IsPublishWeb"].ToString() == "1") {
                        /// post api for activation
                        UpdateStatusAndSellOnWebsite(barcode);
                        string s = $@"https://www.uzaktangelir.com/tag/{barcode}.html";
                        return "Zaten Aktif.-> " + s;
                    }
                    else {
                        sql.update(string.Format(@"UPDATE Erp_Inventory SET IsPublishWeb='1', InUse='1',
                                                 UseForSale='1', UpdatedBy='{0}', UpdatedAt='{1}' WHERE InventoryCode='{2}'",
                                                 recId, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), barcode), true);
                        /// post api for activation
                        UpdateStatusAndSellOnWebsite(barcode);
                        string s = $@"https://www.uzaktangelir.com/tag/{barcode}.html";
                        return "Aktiflestirildi.-> " + s;
                    }
                }
                else {
                    return "Olmadi.";
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                return "Olmadi.";
            }
            finally {
                sql.closeConnection();
            }
        }
        private struct JsonResponse {
            public int status { get; set; }
        }

        private static bool UpdateStatusAndSellOnWebsite(string barcode, string prd_status = "1", string prd_sell = "y") {
            bool result = false;
            try {
                var client = new RestClient("https://www.uzaktangelir.com/admin/api.php");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                //request.AddHeader("Cookie", "PHPSESSID=9abc6ae5046d0b8e7094520cccd0de42");
                request.AddParameter("service", "ProductsApi");
                request.AddParameter("method", "updateByBarcode");
                request.AddParameter("username", "yourPass");
                request.AddParameter("password", "yourPass");
                request.AddParameter("products[0][prd_barcode]", barcode);
                request.AddParameter("products[0][prd_status]", prd_status);
                request.AddParameter("products[0][prd_sell]", prd_sell);
                IRestResponse response = client.Execute(request);
                //Console.WriteLine(response.Content);
                ///TODO!: check response maybe ?
                if (response.StatusCode == HttpStatusCode.OK) {
                    JsonResponse jsonResponse = JsonConvert.DeserializeObject<JsonResponse>(response.Content);
                    if (jsonResponse.status == 200) {
                        result = true;                        
                    }
                }
                return result;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
                return result;
            }

        }

        public static string productPrice(string barcode) {
            SqlObj sql = new SqlObj();
            try {
                sql.initalizeSqlConnection(Functions.GetConnString("ms_sql"));
                sql.openConnection();

                sql.selectString(string.Format("SELECT RecId FROM Erp_Inventory WHERE InventoryCode='{0}' ORDER BY RecId DESC", barcode), true);
                string productRecId = sql.scalarStringGet;
                sql.selectString(string.Format("SELECT Price FROM Erp_InventoryPriceList WHERE InventoryId='{0}' and PriceCode='1' and PriceType='2' and IsPriceDiscount='1' ORDER BY RecId ASC", productRecId), true);
                return sql.scalarStringGet;

            }
            catch (System.Exception) {
                return "Olmadi!";
            }
            finally {
                sql.closeConnection();
            }
        }

        public static string productStock(string barcode) {
            SqlObj sql = new SqlObj();
            //int T_NetQuantity = 0;
            try {
                sql.initalizeSqlConnection(Functions.GetConnString("ms_sql"));
                sql.openConnection();
                sql.selectString(string.Format("SELECT RecId FROM Erp_Inventory WHERE InventoryCode='{0}' ORDER BY RecId DESC", barcode), true);
                string productRecId = sql.scalarStringGet;
                sql.selectString(string.Format(@"SELECT sum(isnull(ActualStock,0)) FROM dbo.Erp_InventoryTotal WHERE InventoryId = '{0}'
                                                 AND isnull(TotalDate,0) = 0 AND isnull(InventoryVariantId,0) = 0 AND isnull(WarehouseId,0) != 0", productRecId), true);
                return sql.scalarStringGet;
                /*
                sql.selectString(string.Format("SELECT RecId FROM Erp_Inventory WHERE InventoryCode='{0}' ORDER BY RecId DESC", barcode), true);
                string productRecId = sql.scalarStringGet;
                sql.selectTable(string.Format(@"SELECT InventoryReceiptId, ReceiptType, NetQuantity FROM Erp_InventoryReceiptItem WHERE InventoryId='{0}' and ReceiptType!=100",productRecId), true);
                DataTable table = sql.dataTableGet;

                for (int i = 0; i < table.Rows.Count; i++) {
                    string inventoryReceipId = table.Rows[i]["InventoryReceiptId"].ToString();
                    int receiptType = 0;
                    int.TryParse(table.Rows[i]["ReceiptType"].ToString(), out receiptType);
                    int netQuantity = 0;
                    int.TryParse(table.Rows[i]["NetQuantity"].ToString(), out netQuantity);
                    
                    //+1 99 2 3 - 121 120
                    if (receiptType < 100) {
                        T_NetQuantity += netQuantity;
                    }
                    else {
                        T_NetQuantity -= netQuantity;
                    }
                }
                return T_NetQuantity;
                */
            }
            catch (System.Exception) {
                return "Olmadi!";
            }
            finally {
                sql.closeConnection();
            }
        } 
        public static string recid(string barcode) {
            SqlObj sql = new SqlObj();
            //int T_NetQuantity = 0;
            try {
                sql.initalizeSqlConnection(Functions.GetConnString("ms_sql"));
                sql.openConnection();
                sql.selectString(string.Format("SELECT RecId FROM Erp_Inventory WHERE InventoryCode='{0}' ORDER BY RecId DESC", barcode), true);
                return sql.scalarStringGet;
            }
            catch (System.Exception) {
                return "Olmadi!";
            }
            finally {
                sql.closeConnection();
            }
        }

        //public static string productStock(string barcode) {
        //    MySqlObj mysql = new MySqlObj();
        //    //int T_NetQuantity = 0;
        //    try {
        //        mysql.initalizeSqlConnection(Functions.GetConnString("ms_sql"));
        //        mysql.openConnection();
        //        mysql.selectString(string.Format("SELECT RecId FROM Erp_Inventory WHERE InventoryCode='{0}' ORDER BY RecId DESC", barcode), true);
        //        string productRecId = mysql.scalarStringGet;
        //        mysql.selectString(string.Format(@"SELECT sum(isnull(ActualStock,0)) FROM dbo.Erp_InventoryTotal WHERE InventoryId = '{0}'
        //                                         AND isnull(TotalDate,0) = 0 AND isnull(InventoryVariantId,0) = 0 AND isnull(WarehouseId,0) != 0", productRecId), true);
        //        return mysql.scalarStringGet;

        //    }
        //    catch (System.Exception) {
        //        return "Olmadi!";
        //    }
        //    finally {
        //        mysql.closeConnection();
        //    }
        //}

        public static object sendSqlRequest() {
            return null;
        }


    }
}

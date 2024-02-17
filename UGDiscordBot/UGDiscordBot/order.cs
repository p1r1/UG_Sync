using System;
using System.Collections.Generic;
using System.Text;

namespace UGDiscordBot {
    public class order {
        public const string PRODUCT_URL = @"https://www.uzaktangelir.com/?p=Products&view={0}";

        public class Product {
            public string m_name { get; }
            public string m_barcode { get; }
            public string m_quantity { get; }
            public string m_link { get; }

            public Product(string name, string quantity, string barcode, string link) {
                m_name = name;
                m_barcode = barcode;
                m_quantity = quantity;
                m_link = link;
            }
        }

        public class Customer {
            public string m_name { get; }
            public string m_ordCode { get; }
            public string m_ordPaymentType { get; }
            public string m_ordDate { get; }
            public string m_ordTotalPrice { get; }
            //public string m_ordPercentage { get; }
            public string m_ordChangeDate { get; }
            public string m_ordCargo { get; }
            public List<Product> m_productList { get; set; }

            public Customer(string name, string ordCode, string ordPaymentType, string ordDate, string ordTotalPrice, /*string ordPercentage,*/ string ordChangeDate, string ordCargo) {
                m_name = name;
                m_ordCode = ordCode;
                m_ordPaymentType = ordPaymentType;
                m_ordDate = ordDate;
                m_ordTotalPrice = ordTotalPrice;
                /*m_ordPercentage = ordPercentage;*/
                m_ordChangeDate = ordChangeDate;
                m_ordCargo = ordCargo;
            }
        }
          
        public List<Customer> checkOrders(string url, string daysAgo, string webUsername, string webUserPass) {
            
            /// ///
            /// Take website orders, insert them to sentez
            /// ///
            /// create weborder and get webOrders
            string url1 = createUrl4WebOrders(url, daysAgo, webUsername, webUserPass);

            WebOrder webOrders = new WebOrder(url1);
            webOrders.getJsonFromWeb();
            webOrders.createDynamicVar();

            List<Customer> customerList = new List<Customer>();

            if (!Object.ReferenceEquals(null, webOrders.m_data.orders)) {
                foreach (var ordr in webOrders.m_data.orders) {
                    if (!Object.ReferenceEquals(null, ordr.ord_status)) {
                        if (ordr.ord_status.ToString() == "12") {
                            string cAccountName = !Object.ReferenceEquals(null, ordr.ord_mmb_name) ? ordr.ord_mmb_name.ToString() : "";
                            string cSpecialCode = !Object.ReferenceEquals(null, ordr.ord_code) ? ordr.ord_code : "";
                            string cPaymentType = !Object.ReferenceEquals(null, ordr.pop_code) ? ordr.pop_code.ToString() : "";
                            string cOrdDate = !Object.ReferenceEquals(null, ordr.ord_date) ? ordr.ord_date.ToString() : "";
                            string cGrandTotal= !Object.ReferenceEquals(null, ordr.ord_grand_total) ? ordr.ord_grand_total.ToString() : "";
                            string cUpdateDate= !Object.ReferenceEquals(null, ordr.ord_update_date) ? ordr.ord_update_date.ToString() : "";
                            string cOrdCargo= !Object.ReferenceEquals(null, ordr.crg_name) ? ordr.crg_name.ToString() : "";

                            Customer c = new Customer(cAccountName, cSpecialCode, cPaymentType, cOrdDate, cGrandTotal, cUpdateDate, cOrdCargo);
                            List<Product> pList = new List<Product>();
                            if (!Object.ReferenceEquals(null, ordr.products)) {                                
                                foreach (var item in ordr.products) {
                                    if (Object.ReferenceEquals(null, item.orp_prd_name) || item.orp_prd_name.ToString() == "PTT") {
                                        continue;
                                    }
                                    string pName = !Object.ReferenceEquals(null, item.orp_prd_name) ? item.orp_prd_name.ToString() : "";
                                    string pBarcode = !Object.ReferenceEquals(null, item.orp_barcode) ? item.orp_barcode : "";
                                    string pQuantity = !Object.ReferenceEquals(null, item.orp_quantity) ? item.orp_quantity : "";
                                    string pUrl = !Object.ReferenceEquals(null, item.orp_prd_id) ? string.Format(PRODUCT_URL, item.orp_prd_id.ToString()) : "";
                                    pList.Add(new Product(pName, pQuantity, pBarcode, pUrl));
                                }
                            }
                            c.m_productList = pList;
                            customerList.Add(c);
                        }
                        else {
                            continue;
                        }
                    }
                    else {
                        continue;
                    }
                }
                return customerList;
            }

            return null;
        }

        public static string createUrl4WebOrders(string url, string textBoxDaysAgo, string textBoxWebUsername, string textBoxWebUserPass) {
            //Log uLog = new Log();
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            /////
            ///Create url base on date
            ////
            DateTime now = DateTime.Now;
            int days = Convert.ToInt32(textBoxDaysAgo);
            if (days == 0) {
                days = 10;
            }
            DateTime daysAgo = now.AddDays(-1 * days);

            string dateFormat = "yyyy-MM-dd";
            string date2 = now.ToString(dateFormat);
            string date1 = daysAgo.ToString(dateFormat);
            string user = textBoxWebUsername;
            if (user == "") {
                user = "uzaktanGLR6523";
            }
            string pass = textBoxWebUserPass;
            if (pass == "") {
                pass = "654Dfg654DFgj5645";
            }
            return url + "&date1=" + date1 + "&date2=" + date2 + @"&user=" + user + "&pass=" + pass;

        }
    }
}

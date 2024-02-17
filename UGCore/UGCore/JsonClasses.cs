using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGCore {
    public class JsonClasses {
        //public class ProducJson {
        //    SettingsClass m_settings { get; set; }
        //    List<Product> m_products { get; set; }
        //    public ProducJson(SettingsClass settings, List<Product> products) {
        //        m_settings = settings;
        //        m_products = products;
        //    }
        //}

        public class SettingsClass {
            [JsonProperty("user")]
            public string m_user { get; set; }
            [JsonProperty("pass")]
            public string m_pass { get; set; }
            public SettingsClass(string user, string pass) {
                m_user = user;
                m_pass = pass;
            }
        }

        public class Product {
            [JsonProperty("prd_barcode")]
            public string m_prd_barcode { get; set; }
            [JsonProperty("prd_stock")]
            public string m_prd_stock { get; set; }
            [JsonProperty("prd_price")]
            public string m_prd_price { get; set; }
            [JsonProperty("prd_status")]
            public string m_prd_status { get; set; }
            [JsonProperty("prd_in_use")]
            public string m_prd_in_use { get; set; }
            [JsonProperty("prd_press_date")]
            public string m_prd_press_date { get; set; }
            [JsonProperty("prd_size")]
            public string m_prd_size { get; set; }
            [JsonProperty("prd_page_count")]
            public string m_prd_page_count { get; set; }
            [JsonProperty("writers")]
            public string m_writers { get; set; }

            public Product(string prd_barcode,
                           string prd_stock,
                           string prd_price,
                           string prd_status,
                           string prd_in_use,
                           string prd_press_date,
                           string prd_size,
                           string prd_page_count,
                           string writers) {
                m_prd_barcode = prd_barcode;
                m_prd_stock = prd_stock;
                m_prd_price = prd_price;
                m_prd_status = prd_status;
                m_prd_in_use = prd_in_use;
                m_prd_press_date = prd_press_date;
                m_prd_size = prd_size;
                m_prd_page_count = prd_page_count;
                m_writers = writers;
            }



        }

    }
}

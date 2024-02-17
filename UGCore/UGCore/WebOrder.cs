using System;
using System.Net;
using Newtonsoft.Json.Linq;

namespace UGCore {
    public class WebOrder {
        /// variables        
        private string m_url { get; set; }
        public string m_json { get; set; }
        public dynamic m_data { get; set; }

        /// constructors
        public WebOrder() {
            m_url = "";
            m_json = "";
        }
        public WebOrder(string url1) {
            m_url = url1;
            m_json = "";
        }

        /// getters, setters        
        public string m_urlGetSet { get; set; }
        public string m_jsonGetSet { get; set; }
        //public dynamic md_dataGetSet { get; set; }        

        /// functions        
        public void getJsonFromWeb() { // get json from web then make dynamic variables
            try {
                using (WebClient wc = new WebClient()) {
                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    m_json = wc.DownloadString(m_url);

                }
                m_json = "[" + m_json + "]";
                //Console.WriteLine(m_json);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
        }

        public void createDynamicVar() {
            try {
                //JArray j = new JArray();
                dynamic blogPosts = JArray.Parse(m_json);
                m_data = blogPosts[0];
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
            //MessageBox.Show(m_data.orders[0].ord_mmb_name.ToString());
            //Clipboard.SetText(m_data.orders[0].ord_mmb_name.ToString());
            //Console.Write(m_data.orders[1].ord_mmb_name.ToString());
        }



    }//class
}//namespace

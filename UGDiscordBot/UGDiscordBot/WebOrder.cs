using Newtonsoft.Json.Linq;
using System.Net;

namespace UGDiscordBot {
    public class WebOrder {

        /// constructors
        public WebOrder() { }
        public WebOrder(string url1) {
            m_url = url1;
        }

        /// variables        
        private string m_url = "";
        private string m_json = "";
        public dynamic m_data;
        /// getters, setters        
        public string m_urlGetSet { get; set; }
        public string m_jsonGetSet { get; set; }
        //public dynamic md_dataGetSet { get; set; }        

        /// functions        
        public void getJsonFromWeb() { // get json from web then make dynamic variables
            using (WebClient wc = new WebClient()) {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                m_json = wc.DownloadString(m_url);

            }
            m_json = "[" + m_json + "]";
            //Console.WriteLine(m_json);
        }
        public void createDynamicVar() {
            JArray j = new JArray();
            dynamic blogPosts = JArray.Parse(m_json);
            m_data = blogPosts[0];
            //MessageBox.Show(m_data.orders[0].ord_mmb_name.ToString());
            //Clipboard.SetText(m_data.orders[0].ord_mmb_name.ToString());
            //Console.Write(m_data.orders[1].ord_mmb_name.ToString());
        }



    }//class
}//namespace

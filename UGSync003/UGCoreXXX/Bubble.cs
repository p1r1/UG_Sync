using System;
using System.Collections.Generic;

namespace UGCore {
    public static class Bubble {

        private static MySqlObj m_mySqlObj;
        public static void sendBubbleNote(string mySqlConnString, string message, string action, string url, string oncelik, DateTime baslagic, DateTime bitis, string sure, string kisi, string baslik, string deger, string kod) {
            m_mySqlObj = new MySqlObj();

            m_mySqlObj.initalizeMySqlConnection(mySqlConnString);
            m_mySqlObj.openConnection();

            if (!isBubbleExist(action, kod, deger, mySqlConnString)) {
                /// insert to a_bubble
                List<MySqlObj.MySqlPair> priceBubbleList = new List<MySqlObj.MySqlPair>() {
                    new MySqlObj.MySqlPair("mesaj", message),
                    new MySqlObj.MySqlPair("action", action),
                    new MySqlObj.MySqlPair("link", url),
                    new MySqlObj.MySqlPair("oncelik", oncelik),/// percentage
                    new MySqlObj.MySqlPair("baslangic", baslagic.ToString("yyyy-MM-dd HH:mm:ss.fff")),
                    new MySqlObj.MySqlPair("bitis", bitis.ToString("yyyy-MM-dd HH:mm:ss.fff")),
                    new MySqlObj.MySqlPair("sure", sure),
                    new MySqlObj.MySqlPair("kisi", kisi),
                    new MySqlObj.MySqlPair("baslik", baslik),
                    new MySqlObj.MySqlPair("deger", deger),
                    new MySqlObj.MySqlPair("kod", kod)
                };

                m_mySqlObj.insert("a_bubble", priceBubbleList);
                m_mySqlObj.executeCommand(MySqlObj.EnumMySqlCommands.Insert);
            }
        }

        public static bool isBubbleExist(string action, string kod, string deger, string mySqlConnString) {
            //m_mySqlObj = new MySqlObj();

            //m_mySqlObj.initalizeMySqlConnection(mySqlConnString);
            //m_mySqlObj.openConnection();
            string idCount = "";
            switch (action) {
                case "siparis":
                case "fiyat":
                    m_mySqlObj.selectString(string.Format(@"SELECT Count(id) as idCount FROM a_bubble WHERE action='{0}' and kod='{1}' and deger='{2}'", action, kod, deger));
                    m_mySqlObj.executeCommand(MySqlObj.EnumMySqlCommands.SelectString);
                    idCount = m_mySqlObj.scalarStringGet;
                    break;
                default:
                    break;
            }
            /// fiyat 


            if (idCount == "0") {
                return false; /// not exist
            }
            else {
                return true; /// exist
            }

            //gorev

            //entegrasyonsa


        }
    }
}

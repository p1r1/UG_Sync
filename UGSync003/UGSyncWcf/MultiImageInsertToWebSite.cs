using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGSyncWcf {
    public static class MultiImageInsertToWebSite {
        public static void Inset() {
            
        }

        private static async Task<bool> PostToDiscrod(string[] images) {
            bool result = false;
            try {
                var client = new RestClient("https://discordapp.com/api/webhooks/777913156386553926/G1QHkcecy-ICwrg_IkKm3poAZuEaY43Nd2i_Ecu0aP4RTjrQGkriURKDd2rhDW5eNsPL");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");

                /// create obj https://gist.github.com/Birdie0/78ee79402a4301b1faf412ab5f1cdcf9
                dynamic jsonObj = new ExpandoObject();
                jsonObj.username = "Sipariş botu";
                for (int i = 0; i < images.Count(); i++) {
                    jsonObj.embeds = new[] {
                          new {
                              image = new { url = images[i].Trim()}
                          }
                    };
                }
                string json = JsonConvert.SerializeObject(jsonObj);
                request.AddParameter("application/json", json, ParameterType.RequestBody);

                IRestResponse response = await client.ExecuteAsync(request);
                //Console.WriteLine(response.Content);
                if (response.StatusCode == System.Net.HttpStatusCode.OK) {
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

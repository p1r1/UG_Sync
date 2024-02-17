using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGCore {
    public static partial class UGSync_Order {
        /// external funcs
        private async static Task<bool> ChangeOrderStatus(string OrderId, string NewStatus = "18") {
            bool result = false;
            try {
                var client = new RestClient("https://www.uzaktangelir.com/admin/api.php");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                request.AddParameter("service", "OrderStatusApi");
                request.AddParameter("method", "changeOrderStatus");
                request.AddParameter("username", "yourPass");
                request.AddParameter("password", "yourPass");
                request.AddParameter("order_id", OrderId);
                request.AddParameter("new_status", NewStatus);
                request.AddParameter("email_notify", "0");
                request.AddParameter("sms_notify", "0");
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

        private static async Task<bool> PostToDiscrod(string orderId, string orderCode, string orderName, string orderPrice) {
            bool result = false;
            try {
                var client = new RestClient("https://discordapp.com/api/webhooks/629709704666546208/LwqlilWMAAooromK_SE2tLO8sBCr5NxhQXZAeZARpYApmrHzae_ms_kn20-325-P2t2M");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                string json = $@"{{
  ""username"": ""Sipariş var!"",
  ""content"": ""Yeni Sipariş:{orderId},{orderCode},{orderName}->{orderPrice}₺"",
  ""avatar_url"": ""https://cdn.discordapp.com/attachments/879698500852527194/879698572034076692/avatar_5.jpg""
}}";
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
        private static async Task<bool> PostToDiscrodAsFile(string sss) {
            bool result = false;
            try {
                var client = new RestClient("https://discordapp.com/api/webhooks/629709704666546208/LwqlilWMAAooromK_SE2tLO8sBCr5NxhQXZAeZARpYApmrHzae_ms_kn20-325-P2t2M");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(sss);
                request.AddFileBytes("file1", bytes, "fileX.txt", "text/plain");
                //request.AddFile("file2", "/D:/Wallpapers/1576500268_gravity_n_shit_w1.jpeg");
                request.AddParameter("payload_json", "{\"embeds:\": [\"title\": \"test\"]}");
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

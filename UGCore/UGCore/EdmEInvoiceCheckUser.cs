using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using UGCore.EdmServiceReference;

namespace UGCore {
    public static class EdmEInvoiceCheckUser {

        public static int IsEInvoiceUserCheck(string vkn) {
            BasicHttpBinding basicHttpBinding = new BasicHttpBinding(BasicHttpSecurityMode.TransportWithMessageCredential) {
                Name = "BasicHttpBinding_IClientInterfaceService",
                BypassProxyOnLocal = false,
                HostNameComparisonMode = HostNameComparisonMode.StrongWildcard,
                AllowCookies = false,
                MaxBufferSize = int.MaxValue,
                MaxBufferPoolSize = 524288L,
                MaxReceivedMessageSize = 2147483647L,
                MessageEncoding = WSMessageEncoding.Text,
                TextEncoding = Encoding.UTF8,
                TransferMode = TransferMode.Buffered,
                UseDefaultWebProxy = true
            };
            basicHttpBinding.SendTimeout = (basicHttpBinding.CloseTimeout = (basicHttpBinding.OpenTimeout = TimeSpan.FromMinutes(5.0)));
            basicHttpBinding.ReceiveTimeout = TimeSpan.FromMinutes(10.0);
            basicHttpBinding.MaxReceivedMessageSize = (long)(basicHttpBinding.ReaderQuotas.MaxArrayLength = (basicHttpBinding.ReaderQuotas.MaxDepth = (basicHttpBinding.ReaderQuotas.MaxNameTableCharCount = (basicHttpBinding.ReaderQuotas.MaxStringContentLength = int.MaxValue))));
            basicHttpBinding.ReaderQuotas.MaxBytesPerRead = 4096;
            basicHttpBinding.Security.Mode = BasicHttpSecurityMode.Transport;
            basicHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
            basicHttpBinding.Security.Transport.ProxyCredentialType = HttpProxyCredentialType.None;
            basicHttpBinding.Security.Transport.Realm = string.Empty;
            basicHttpBinding.Security.Message.ClientCredentialType = BasicHttpMessageCredentialType.UserName;
            basicHttpBinding.Security.Message.AlgorithmSuite = SecurityAlgorithmSuite.Default;
            EndpointAddress remoteAddress = new EndpointAddress("https://portal2.edmbilisim.com.tr/EFaturaEDM/EFaturaEDM.svc");
            int result = 0;
            try {
                //string EdmUserName = LoadScalarObject<string>(connstring, $"select PrmValue from Erp_Parameter where PrmId = 36 and PrmGroup = 29 and CompanyId = 1 ");
                //string EdmUserPass = LoadScalarObject<string>(connstring, $"select PrmValue from Erp_Parameter where PrmId = 37 and PrmGroup = 29 and CompanyId = 1 ");
                string EdmUserName = Functions.executeScalar(Functions.GetConnString("ms_sql"), $"select PrmValue from Erp_Parameter where PrmId = 36 and PrmGroup = 29 and CompanyId = 1");
                string EdmUserPass = Functions.executeScalar(Functions.GetConnString("ms_sql"), $"select PrmValue from Erp_Parameter where PrmId = 37 and PrmGroup = 29 and CompanyId = 1");
                using (EFaturaEDMPortClient edmClient = new EFaturaEDMPortClient(basicHttpBinding, remoteAddress)) {
                    REQUEST_HEADERType request = new REQUEST_HEADERType();
                    //request.REQUEST_HEADER = new REQUEST_HEADERType();
                    request.SESSION_ID = "0";
                    request.CLIENT_TXN_ID = Guid.NewGuid().ToString();
                    request.ACTION_DATE = DateTime.Now;
                    request.ACTION_DATESpecified = true;
                    request.REASON = "EFATURA GONDERME VE ALMA ISLEMLERI TEST";
                    request.APPLICATION_NAME = "EDM EFATURA V1.0";
                    request.HOSTNAME = "HOST-EDM-DEFAULT";
                    request.CHANNEL_NAME = "EDM";
                    request.COMPRESSED = "N";

                    //login
                    LoginRequest loginRequest = new LoginRequest();
                    loginRequest.REQUEST_HEADER = request;
                    loginRequest.USER_NAME = EdmUserName;
                    loginRequest.PASSWORD = EdmUserPass;
                    var loginResponse = edmClient.Login(loginRequest);
                    var loginResponseMessage = new EDM_LoginResponseMessage(loginResponse);
                    request.SESSION_ID = loginResponse.SESSION_ID;

                    ////check user
                    //GetUserListRequest getUserListRequest = new GetUserListRequest();
                    //getUserListRequest.REQUEST_HEADER = request;
                    //var getUserListResponse = edmClient.GetUserList(getUserListRequest);
                    ////var s = getUserListResponse.Items;
                    //foreach (var user in getUserListResponse.Items) {
                    //    Console.WriteLine(user.TITLE);
                    //}

                    // can be overload the EDM < 200 sip.
                    CheckUserRequest checkUserRequest = new CheckUserRequest();
                    checkUserRequest.REQUEST_HEADER = request;
                    checkUserRequest.USER = new GIBUSER();
                    checkUserRequest.USER.IDENTIFIER = vkn;
                    var checkUser = edmClient.CheckUser(checkUserRequest);


                    // 2 - earchive 1-efatura
                    if (checkUser.Length > 0) {
                        result = 1;
                    }
                    else {
                        result = 2;
                    }
                    //logout
                    LogoutRequest logoutRequest = new LogoutRequest();
                    logoutRequest.REQUEST_HEADER = request;
                    edmClient.Logout(logoutRequest);
                }

            }
            catch (Exception e){ 
                result = -1;
                Console.WriteLine(e);
                //throw; 
            }
            return result;
        }

        // drapper

        //private static T LoadScalarObject<T>(string connstring, string querry) {
        //    using (var conn = new SqlConnection(connstring)) {
        //        //Console.WriteLine(conn.ConnectionString);
        //        var output = conn.ExecuteScalar(querry);
        //        return (T)output;
        //    }
        //}


    }
}

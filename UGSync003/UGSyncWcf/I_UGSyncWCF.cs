using Newtonsoft.Json.Linq;
using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Threading.Tasks;
using UGSyncWcf;

namespace UGSyncWebService {
    //get ownership 
    //netsh http add urlacl url=http://+:64433/ user=Everyone

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
    //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

    //System.Globalization.CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("en-US");
    //System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = new System.Globalization.CultureInfo("en-US");
    [ServiceContract(SessionMode = SessionMode.NotAllowed)]
    public interface I_UGSyncWCF {
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest,
         ResponseFormat = WebMessageFormat.Json, UriTemplate = "isWebServiceOnline")]
        bool isWebServiceOnline();

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest,
         ResponseFormat = WebMessageFormat.Json, UriTemplate = "priceStock")]
        Task<bool> priceStock(string priceStock_xTop,
                              string priceStock_xEr,
                              string priceStock_url,
                              string connString,
                              string webUserName,
                              string webUserPass,
                              int DELAY_TIME);

        //[OperationContract]
        //[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest,
        // ResponseFormat = WebMessageFormat.Json, UriTemplate = "productSummary")]
        //Task<bool> productSummary(string priceStock_xTop,
        //                      string priceStock_xEr,
        //                      string priceStock_url,
        //                      string connString,
        //                      string webUserName,
        //                      string webUserPass,
        //                      int DELAY_TIME);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest,
         ResponseFormat = WebMessageFormat.Json, UriTemplate = "product")]
        Task<bool> product(string product_TopX,
                           bool product_includeImage,
                           string product_url,
                           string connString,
                           string webUserName,
                           string webUserPass,
                           int DELAY_TIME);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest,
         ResponseFormat = WebMessageFormat.Json, UriTemplate = "order")]
        Task<bool> order(string order_DaysAgo,
                         string order_url,
                         string connString,
                         string mySqlConn,
                         string webUserName,
                         string webUserPass,
                         int DELAY_TIME);


        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest,
         ResponseFormat = WebMessageFormat.Json, UriTemplate = "printGivenPdf")]
        bool PrintGivenPdf(string ReceiptIdentifier, bool isThisReceiptSpecialCode = false);
        /*
        [OperationContract]
        void priceStock(string priceStock_xTop,
                              string priceStock_xEr,
                              string priceStock_url,
                              string connString,
                              string webUserName,
                              string webUserPass,
                              int DELAY_TIME);
        [OperationContract]
        void product(string product_TopX,
                           bool product_includeImage,
                           string product_url,
                           string connString,
                           string webUserName,
                           string webUserPass,
                           int DELAY_TIME);
        [OperationContract]
       void order(string order_DaysAgo,
                         string order_url,
                         string connString,
                         string mySqlConn,
                         string webUserName,
                         string webUserPass,
                         int DELAY_TIME);
        */
        // TODO: Add your service operations here
        // TODO: Add your service operations here DONE! ??!


        ////////////////////////////////////////////////////////////////////////////////////////
        /// gets
        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/priceStock")]
        Task<bool> priceStockGet();


        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/productSummary")]
        Task<bool> productSummaryGet();


        //http://192.168.1.117:64433/printOrder?order_DaysAgo=10&webUserName=yourPass&webUserPass=yourPass&DELAY_TIME=10
        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "/printOrder?order_DaysAgo={order_DaysAgo}&webUserName={webUserName}&webUserPass={webUserPass}&DELAY_TIME={DELAY_TIME}")]
        Task<bool> orderGet(string order_DaysAgo,
                                 string webUserName,
                                 string webUserPass,
                                 int DELAY_TIME);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/product")]
        Task<bool> productGet();


        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/printgivenpdf?receiptidentifier={ReceiptIdentifier}&isThisReceiptSpecialCode={isThisReceiptSpecialCode}")]
        bool PrintGivenPdfGet(string ReceiptIdentifier, bool isThisReceiptSpecialCode = false);// can not get default here !!!


        ////////////////////others
        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/insertPayment?inventoryReceiptRecId={inventoryReceiptRecId}")]
        Task<bool> InsertPayment(string inventoryReceiptRecId);

        /// <summary>
        /// Create Invoice - EInvoiceXML
        /// </summary>
        /// <param name="specialCode">order code</param>
        /// <param name="CreateXML">wheter create xml or not</param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "/einvoicexml?specialCode={specialCode}&CreateXML={CreateXML}")]
        Task<bool> EInvoiceXML(string specialCode, bool CreateXML);


        //[OperationContract]
        //[WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json,
        // UriTemplate = "/justeinvoicexml?specialCode={specialCode}&isDebugModeOn={isDebugModeOn}")]
        //Task<bool> JustEInvoiceXml(string specialCode, bool isDebugModeOn);


        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "/printnondborderreceipt?specialcode={specialCode}")]
        Task<string> PrintNonDbOrderReceipt(string specialCode);

        //[OperationContract]
        //[WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json,
        // UriTemplate = "/deleteorder?specialcode={SpecialCode}&daysago={DaysAgo}")]
        //WebServiceReturnObject DeleteOrder(string SpecialCode, int DaysAgo = 3); // can not get default here !!!

        // CheckEinvoiceUser
        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "/checkeinvoiceuser?vkn={vkn}")]
        WebServiceReturnObject CheckInvoiceUser(string vkn); 
    }
}

// Use a data contract as illustrated in the sample below to add composite types to service operations.
// You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "UGSyncWcf.ContractType".
//[DataContract]
//public class CompositeType {

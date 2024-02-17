﻿using Dapper;
using Microsoft.XmlDiffPatch;
using RestSharp;
using SentezEInvoiceXML.diffobj;
using SentezEInvoiceXML.EdmService;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.Xsl;
using UblSharp;
using UblSharp.CommonAggregateComponents;
//using UGCore;

namespace SentezEInvoiceXML {
    public partial class Form1 : Form {
        /// <summary>
        /// CONSTS!
        /// sql connection string
        /// </summary>

        public Form1() {
            InitializeComponent();
        }


        private const bool isDebugMode = true;
        private void button1_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(textBox1.Text) && textBox1.Text.Length != 6) {
                label1.Text += "This is Empty or Wrong";
                label1.BackColor = Color.Red;
            }
            else {
                string SpecialCode = textBox1.Text;
                MakeXMLInvoice(SpecialCode, isDebugMode);
                Console.WriteLine("Button DONE!");
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            var invoices = LoadAnonTable<Erp_Invoice>($"select top 100 SpecialCode from Erp_Invoice where SpecialCode IS NOT NULL order by RecId desc "); //OFFSET 10 ROWS FETCH NEXT 10 ROWS ONLY;
            foreach (var invoice in invoices) {
                MakeXMLInvoice(invoice.SpecialCode.ToString(), isDebugMode);
            }
            Console.WriteLine("Button DONE!");
        }

        private string ConvertStringToUtf8Bom(string source) {
            var data = Encoding.UTF8.GetBytes(source);
            var result = Encoding.UTF8.GetPreamble().Concat(data).ToArray();
            var encoder = new UTF8Encoding(true);

            return encoder.GetString(result);
        }

        public string CreateXMLDocumentName(string specialCode, bool isEInvoice) {
            string docName;
            try {
                string docNameStart = "";
                if (isEInvoice) {
                    docNameStart = LoadScalarObject<string>($"select PrmValue from Erp_Parameter where PrmId = 39 and PrmGroup = 29 and CompanyId = 1 ");
                }
                else {
                    docNameStart = LoadScalarObject<string>($"select PrmValue from Erp_Parameter where PrmId = 93 and PrmGroup = 29 and CompanyId = 1 ");
                }
                docName = docNameStart + DateTime.Now.Year.ToString();
                //Console.WriteLine(irsaliyeNo);
                long invoiceRecIdLong = LoadScalarObject<long>($@"SELECT InvoiceId FROM Erp_InventoryReceipt WHERE SpecialCode = '{specialCode}'");
                string invoiceRecId = invoiceRecIdLong.ToString();
                if (!string.IsNullOrEmpty(invoiceRecId.ToString())) {
                    //Console.WriteLine(invoiceRecId);
                    string invoiceDocNo = LoadScalarObject<string>($@"SELECT DocumentNo FROM Erp_Invoice WHERE RecId = {invoiceRecId}");
                    if (!string.IsNullOrEmpty(invoiceDocNo)) {
                        if (invoiceDocNo.Trim().Substring(0, 3) != docNameStart) {
                            Console.WriteLine("not UGE - UGF doc");
                            return "";
                        }
                        //Console.WriteLine(invoiceDocNo);
                        int invoiceRecIdInt;
                        Int32.TryParse(invoiceRecId, out invoiceRecIdInt);
                        if (invoiceRecIdInt != 0) {
                            invoiceRecId = invoiceRecIdInt.ToString().PadLeft(9, '0');
                        }
                        else {
                            Console.WriteLine("invoiceDocNoInt Wrong");
                        }
                        invoiceDocNo = invoiceDocNo.Replace(docName, "");
                        invoiceDocNo = invoiceDocNo.TrimStart('0');
                        docName += invoiceRecId + "-" + invoiceDocNo + ".xml";
                        //Console.WriteLine("xml name ->" + docName);
                    }
                    else {
                        Console.WriteLine("Wrong/Empty invoice");
                        docName =  "";
                    }
                }
                else {
                    Console.WriteLine("Wrong/Empty Receipt");
                    docName = "";
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                docName = "";
                throw;
            }
            return docName;
        }

        private int IsEInvoiceUserCheck(string vkn) {
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
                string EdmUserName = LoadScalarObject<string>($"select PrmValue from Erp_Parameter where PrmId = 36 and PrmGroup = 29 and CompanyId = 1 ");
                string EdmUserPass = LoadScalarObject<string>($"select PrmValue from Erp_Parameter where PrmId = 37 and PrmGroup = 29 and CompanyId = 1 ");
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

                    if (checkUser.Length > 0) {
                        result = 1;
                    }
                    else {
                        result = 0;
                    }
                    //logout
                    LogoutRequest logoutRequest = new LogoutRequest();
                    logoutRequest.REQUEST_HEADER = request;
                    edmClient.Logout(logoutRequest);
                }

            }
            catch { result = -1;  throw; }
            return result;
        }
       


        public static List<T> LoadAnonTable<T>(string querry) {
            using (var conn = new SqlConnection(UGCore.Functions.GetConnString("ms_sql"))) {
                //Console.WriteLine(conn.ConnectionString);
                var output = conn.Query<T>(querry, new DynamicParameters());
                return output.ToList();
            }
        }

        public static T LoadScalarObject<T>(string querry) {
            using (var conn = new SqlConnection(UGCore.Functions.GetConnString("ms_sql"))) {
                //Console.WriteLine(conn.ConnectionString);
                var output = conn.ExecuteScalar(querry);
                return (T)output;
            }
        }

        private bool MakeXMLInvoice(string SpecialCode, bool isDebug = false) {
            bool result = false;
            try {
                /// get neccessary DB data
                // TODO: can be optimized by cutting unnecessary data
                if (string.IsNullOrEmpty(SpecialCode)) {
                    Console.WriteLine("specialcode is empty!");
                    result = false;
                    return result;
                }
                string erpInventoryReceiptQuerry = $@"select * from Erp_InventoryReceipt where SpecialCode = '{SpecialCode}' order by RecId desc";
                var erpInventoryReceipt = LoadAnonTable<Erp_InventoryReceipt>(erpInventoryReceiptQuerry).FirstOrDefault();
                if (ReferenceEquals(erpInventoryReceipt, null) || ReferenceEquals(erpInventoryReceipt.RecId, null) || erpInventoryReceipt.RecId <= 0) {
                    result = false;
                    return result;
                }

                if (string.IsNullOrEmpty(erpInventoryReceipt.RecId.ToString())) {
                    Console.WriteLine("erpInventoryReceipt.RecId is empty!");
                    result = false;
                    return result;
                }
                string erpInventoryReceiptItemsQuerry = $@"select * from Erp_InventoryReceiptItem where InventoryReceiptId = {erpInventoryReceipt.RecId} and ItemType = 1";
                var erpInventoryReceiptItems = LoadAnonTable<Erp_InventoryReceiptItem>(erpInventoryReceiptItemsQuerry);
                if (ReferenceEquals(erpInventoryReceiptItems, null) || erpInventoryReceiptItems.Count() <= 0) {
                    result = false;
                    return result;
                }

                if (string.IsNullOrEmpty(erpInventoryReceipt.InvoiceId.ToString())) {
                    Console.WriteLine("erpInventoryReceipt.InvoiceId is empty!");
                    result = false;
                    return result;
                }
                string erpInvoiceQuerry = $@"select * from Erp_Invoice where RecId = {erpInventoryReceipt.InvoiceId} order by RecId desc";
                var erpInvoice = LoadAnonTable<Erp_Invoice>(erpInvoiceQuerry).FirstOrDefault();
                if (ReferenceEquals(erpInvoice, null) || ReferenceEquals(erpInvoice.RecId, null) || erpInvoice.RecId <= 0) {
                    result = false;
                    return result;
                }

                if (string.IsNullOrEmpty(erpInvoice.PaymentPlanId.ToString())) {
                    Console.WriteLine("erpInvoice.PaymentPlanId is empty!");
                    result = false;
                    return result;
                }
                string erpPaymentPlanQuerry = $@"select * from Erp_PaymentPlan where RecId = {erpInvoice.PaymentPlanId}";
                var erpPaymentPlan = LoadAnonTable<Erp_Paymentplan>(erpPaymentPlanQuerry).FirstOrDefault();
                if (ReferenceEquals(erpPaymentPlan, null) || ReferenceEquals(erpPaymentPlan.RecId, null) || erpPaymentPlan.RecId <= 0) {
                    result = false;
                    return result;
                }

                /// customer
                if (string.IsNullOrEmpty(erpInventoryReceipt.CurrentAccountId.ToString())) {
                    Console.WriteLine("erpInventoryReceipt.CurrentAccountId is empty!");
                    result = false;
                    return result;
                }
                string erpCurrentAccountQuerry = $@"select * from Erp_CurrentAccount where RecId = {erpInventoryReceipt.CurrentAccountId}";
                var erpCurrentAccount = LoadAnonTable<Erp_CurrentAccount>(erpCurrentAccountQuerry).FirstOrDefault();
                if (ReferenceEquals(erpCurrentAccount, null) || ReferenceEquals(erpCurrentAccount.RecId, null) || erpCurrentAccount.RecId <= 0) {
                    result = false;
                    return result;
                }

                if (string.IsNullOrEmpty(erpInventoryReceipt.AddressId.ToString())) {
                    Console.WriteLine("erpAccountAddress.CityId is empty!");
                    result = false;
                    return result;
                }
                string erpAccountAddressQuerry = $@"select * from  Erp_Address where RecId = {erpInventoryReceipt.AddressId} order by RecId desc";
                var erpAccountAddress = LoadAnonTable<Erp_Address>(erpAccountAddressQuerry).FirstOrDefault();
                if (ReferenceEquals(erpAccountAddress, null) || ReferenceEquals(erpAccountAddress.RecId, null) || erpAccountAddress.RecId <= 0) {
                    result = false;
                    return result;
                }


                if (string.IsNullOrEmpty(erpAccountAddress.CityId.ToString())) {
                    Console.WriteLine("erpAccountAddress.CityId is empty!");
                    result = false;
                    return result;
                }
                string erpAccountCityQuerry = $@"select * from Meta_City where RecId = {erpAccountAddress.CityId} order by RecId desc";
                var erpAccountCity = LoadAnonTable<Erp_City>(erpAccountCityQuerry).FirstOrDefault();
                if (ReferenceEquals(erpAccountCity, null) || ReferenceEquals(erpAccountCity.RecId, null) || erpAccountCity.RecId <= 0) {
                    result = false;
                    return result;
                }


                if (string.IsNullOrEmpty(erpAccountAddress.DistrictId.ToString())) {
                    Console.WriteLine("erpAccountAddress.DistrictId is empty!");
                    result = false;
                    return result;
                }
                string erpAccountDistrictQuerry = $@"select * from Meta_District where RecId={erpAccountAddress.DistrictId} order by RecId desc";
                var erpAccountDistrict = LoadAnonTable<Erp_District>(erpAccountDistrictQuerry).FirstOrDefault();
                if (ReferenceEquals(erpAccountDistrict, null) || ReferenceEquals(erpAccountDistrict.RecId, null) || erpAccountDistrict.RecId <= 0) {
                    result = false;
                    return result;
                }

                /// our company
                if (string.IsNullOrEmpty(erpInventoryReceipt.CompanyId.ToString())) {
                    Console.WriteLine("erpInventoryReceipt.CompanyId is empty!");
                    result = false;
                    return result;
                }
                string erpCompanyQuerry = $@"select * from Erp_Company where RecId = {erpInventoryReceipt.CompanyId} order by RecId desc";
                var erpCompany = LoadAnonTable<Erp_Company>(erpCompanyQuerry).FirstOrDefault();
                if (ReferenceEquals(erpCompany, null) || ReferenceEquals(erpCompany.RecId, null) || erpCompany.RecId <= 0) {
                    result = false;
                    return result;
                }

                if (string.IsNullOrEmpty(erpCompany.CityId.ToString())) {
                    Console.WriteLine("erpCompany.CityId is empty!");
                    result = false;
                    return result;
                }
                string erpCompanyCityQuerry = $@"select * from Meta_City where RecId = {erpCompany.CityId} order by RecId desc";
                var erpCompanyCity = LoadAnonTable<Erp_City>(erpCompanyCityQuerry).FirstOrDefault();
                if (ReferenceEquals(erpCompanyCity, null) || ReferenceEquals(erpCompanyCity.RecId, null) || erpCompanyCity.RecId <= 0) {
                    result = false;
                    return result;
                }

                if (string.IsNullOrEmpty(erpCompany.DistrictId.ToString())) {
                    Console.WriteLine("erpCompany.DistrictId is empty!");
                    result = false;
                    return result;
                }
                string erpCompanyDistrictQuerry = $@"select * from Meta_District where RecId={erpCompany.DistrictId} order by RecId desc";
                var erpCompanyDistrict = LoadAnonTable<Erp_District>(erpCompanyDistrictQuerry).FirstOrDefault();
                if (ReferenceEquals(erpCompanyDistrict, null) || ReferenceEquals(erpCompanyDistrict.RecId, null) || erpCompanyDistrict.RecId <= 0) {
                    result = false;
                    return result;
                }

                if (string.IsNullOrEmpty(erpCompany.TaxOfficeId.ToString())) {
                    Console.WriteLine("erpCompany.TaxOfficeId is empty!");
                    result = false;
                    return result;
                }
                string erpCompanyTaxOfficeQuerry = $@"select * from Meta_TaxOffice where RecId={erpCompany.TaxOfficeId} order by RecId desc";
                var erpCompanyTaxOffice = LoadAnonTable<Erp_TaxOffice>(erpCompanyTaxOfficeQuerry).FirstOrDefault();
                if (ReferenceEquals(erpCompanyTaxOffice, null) || ReferenceEquals(erpCompanyTaxOffice.RecId, null) || erpCompanyTaxOffice.RecId <= 0) {
                    result = false;
                    return result;
                }

                /// ///
                /// shall I begin     
                /// ///
                /// check if user is using einvoice or earchive
                bool isEInvoiceUser = false;
                int xxx = IsEInvoiceUserCheck(erpCurrentAccount.TaxNo);
                if (xxx == 1) {
                    isEInvoiceUser = true;
                }
                else if (xxx == 0) {
                    isEInvoiceUser = false;
                }
                else {
                    Console.WriteLine("Cannot check Edm for isEInvoiceUser");
                    result = false;
                    return result;
                }

                ///check if xml file created before
                var xmlObj = UGCore.Functions.GetXmlFileLocation();

                string folderPath = "";
                if (isEInvoiceUser) {
                    folderPath = xmlObj.einvoice;
                }
                else {
                    folderPath = xmlObj.earchive;
                }
                string docName = CreateXMLDocumentName(SpecialCode, isEInvoiceUser);
                string docFullPath = folderPath + docName;
                if (string.IsNullOrEmpty(docName)) {
                    result = false;
                    return result;
                }
                else {
                    if (File.Exists(docFullPath)) {
                        Console.WriteLine(docFullPath + " is already exsits!");
                        if (!isDebug) {
                            result = false;
                            return result;
                        }
                    }
                }

                /// create Invoice
                InvoiceType invoice = new InvoiceType();
                invoice.UBLExtensions = new UBLExtensionType[] { new UBLExtensionType { ExtensionContent = new ExtensionContentType() } };
                invoice.UBLVersionID = new UBLVersionIDType { Value = "2.1" }; //const
                invoice.CustomizationID = new CustomizationIDType { Value = "TR1.2" };//const
                string profileId = "";
                if (isEInvoiceUser) {
                    profileId = "TEMELFATURA";
                }
                else {
                    profileId = "EARSIVFATURA";
                }
                invoice.ProfileID = new ProfileIDType { Value = profileId }; //make
                invoice.ID = new IDType { Value = erpInvoice.DocumentNo }; //get
                invoice.CopyIndicator = new CopyIndicatorType { Value = false }; // const asıl/kopya
                invoice.UUID = new UUIDType { Value = Guid.NewGuid().ToString() }; ////////////////////////////////////////////////////save this to eInvoice
                invoice.IssueDate = new IssueDateType { Value = erpInvoice.ReceiptDate };
                invoice.IssueTime = new IssueTimeType { Value = erpInvoice.ReceiptTime.ToString("HH:mm:ss") };

                string InvoiceTypeCode = "SATIS";
                if (erpInvoice.VatAmount == 0) {
                    InvoiceTypeCode = "ISTISNA";
                }
                invoice.InvoiceTypeCode = new InvoiceTypeCodeType { Value = InvoiceTypeCode };//make
                string odemeTarihi = erpInvoice.EArchivesSendDate.ToString("dd.MM.yyyy");
                invoice.Note = new NoteType[] {
                    new NoteType{Value = object.ReferenceEquals(null, erpInvoice.Explanation) ? "" : erpInvoice.Explanation.ToString()},
                    new NoteType{Value = "e-Arşiv izni kapsamında elektronik ortamda iletilmiştir."},
                    new NoteType{Value = "Bu satış internet üzerinden geçekleştirilmiştir."},
                    new NoteType{Value = $@"İnternet Sitesi : {erpInvoice.EArchivesWebAddress} | Ödeme Tarihi : {odemeTarihi} | Ödeme Tipi : {erpInvoice.EArchivesPaymentType} "},//get
                    new NoteType{Value = "Yalnız," + MoneyTalks.ParayiYaziyaCevir(erpInvoice.GrandTotal.ToString("0.00"))  + "'dir."},//??
                    new NoteType{Value = $@"Cari Hesap Bakiyesi : {erpInvoice.GrandTotal.ToString("0.00").Replace('.', ',')} BB"},
                };
                if (isEInvoiceUser) {
                    var notes = invoice.Note.ToList();
                    notes.RemoveAt(1);
                    invoice.Note = notes.ToArray();
                }

                if (!object.ReferenceEquals(erpInvoice.EInvoiceTaxExemptionReasonCode, null) &&
                    !string.IsNullOrEmpty(erpInvoice.EInvoiceTaxExemptionReasonCode.ToString()) &&
                    erpInvoice.EInvoiceTaxExemptionReasonCode.ToString() == "335") {
                    var notes = invoice.Note.ToList();
                    notes.Insert(0, new NoteType { Value = "Vergi Muafiyet Sebebi : 335 - 13/n Basılı Kitap ve Süreli Yayınların Teslimleri" });
                    invoice.Note = notes.ToArray();
                }

                invoice.DocumentCurrencyCode = new DocumentCurrencyCodeType { Value = "TRY" };//const
                invoice.LineCountNumeric = new LineCountNumericType { Value = erpInventoryReceiptItems.Count() };

                if (!isEInvoiceUser && !string.IsNullOrEmpty(erpInventoryReceipt.DocumentNo.ToString())) {
                    invoice.DespatchDocumentReference = new DocumentReferenceType[] {
                        new DocumentReferenceType{
                            ID = new IDType { Value = erpInventoryReceipt.DocumentNo.ToString() }, //get irsaliye
                            IssueDate = new IssueDateType { Value =  erpInventoryReceipt.ReceiptDate }//get
                        }
                    };
                }

                string AttachmentString = File.ReadAllText("base64.txt");//get - this is all the same
                byte[] AttachmentArray = System.Text.Encoding.UTF8.GetBytes(AttachmentString);
                List<DocumentReferenceType> documentReferenceTypes = new List<DocumentReferenceType>();
                documentReferenceTypes.Add(
                    new DocumentReferenceType {
                        ID = new IDType { Value = Guid.NewGuid().ToString() },//give
                        IssueDate = new IssueDateType { Value = erpInvoice.ReceiptDate }, //erpInventoryReceipt.ReceiptDate},//get
                        DocumentType = new DocumentTypeType { Value = "XSLT" },//const
                        Attachment = new AttachmentType {
                            EmbeddedDocumentBinaryObject = new EmbeddedDocumentBinaryObjectType {
                                mimeCode = "application/xml",//const
                                encodingCode = "Base64",//const
                                characterSetCode = "UTF-8",//const
                                filename = erpInvoice.DocumentNo + ".xslt",//make
                                Value = AttachmentArray//get
                            }
                        }
                    }
                );
                if (isEInvoiceUser) {
                    documentReferenceTypes.Add(
                        new DocumentReferenceType {
                            ID = new IDType { Value = Guid.NewGuid().ToString()},
                            IssueDate = new IssueDateType { Value = erpInvoice.ReceiptDate },
                            DocumentType = new DocumentTypeType { Value = "UD_EInvoiceIntegratorInvoiceId" }
                        }
                    );
                }
                invoice.AdditionalDocumentReference = documentReferenceTypes.ToArray();


                invoice.Signature = new SignatureType[] {
                    new SignatureType {
                        ID = new IDType{ schemeID = "VKN_TCKN", Value = erpCompany.TaxNo},//const - get 
                        SignatoryParty = new PartyType {
                            PartyIdentification = new PartyIdentificationType[]{
                                new PartyIdentificationType{ID = new IDType{schemeID = "VKN", Value = erpCompany.TaxNo} }//const - get
                            },
                            PostalAddress = new AddressType {
                                StreetName = new StreetNameType{Value = erpCompany.Address1},// get
                                BuildingName = new BuildingNameType{Value = erpCompany.Address2}, //get
                                BuildingNumber = new BuildingNumberType{Value = erpCompany.DoorNo}, //get
                                CitySubdivisionName = new CitySubdivisionNameType{ Value  = erpCompanyDistrict.DistrictName }, //get
                                CityName = new CityNameType{Value = erpCompanyCity.CityName }, //get
                                PostalZone = new PostalZoneType{Value = erpCompany.PostalCode}, //get
                                Country = new CountryType{Name = new NameType1{ Value = "Türkiye" } }//const
                            }
                        },
                        DigitalSignatureAttachment = new AttachmentType{
                            ExternalReference= new ExternalReferenceType{URI = new URIType{ Value= "#Signature"} }//get
                        }
                    }
                };

                invoice.AccountingSupplierParty = new SupplierPartyType {
                    Party = new PartyType {
                        WebsiteURI = new WebsiteURIType { Value = erpCompany.Internet.ToString() },//get
                        PartyIdentification = new PartyIdentificationType[] {
                            new PartyIdentificationType { ID = new IDType { schemeID = "VKN", Value = erpCompany.TaxNo } },//const - get 
                            new PartyIdentificationType { ID = new IDType { schemeID = "MERSISNO", Value = erpCompany.MersisNo } },//const - get 
                            new PartyIdentificationType { ID = new IDType { schemeID = "TICARETSICILNO", Value = erpCompany.TradeRegistrationNo } } //const - get 
                        },
                        PartyName = new PartyNameType { Name = new NameType1 { Value = erpCompany.CompanyName } },//get
                        PostalAddress = new AddressType {
                            StreetName = new StreetNameType { Value = erpCompany.Address1 },//get
                            BuildingName = new BuildingNameType { Value = erpCompany.Address2 },//get
                            BuildingNumber = new BuildingNumberType { Value = erpCompany.DoorNo },//get
                            CitySubdivisionName = new CitySubdivisionNameType { Value = erpCompanyDistrict.DistrictName },//get
                            CityName = new CityNameType { Value = erpCompanyCity.CityName },//get
                            PostalZone = new PostalZoneType { Value = erpCompany.PostalCode },//get
                            Country = new CountryType { Name = new NameType1 { Value = "Türkiye" } }//const
                        },
                        PartyTaxScheme = new PartyTaxSchemeType {
                            TaxScheme = new TaxSchemeType { Name = new NameType1 { Value = erpCompanyTaxOffice.Name } }//get
                        },
                        Contact = new ContactType {
                            Telephone = new TelephoneType { Value = erpCompany.Phone },//get
                            Telefax = new TelefaxType(),
                            ElectronicMail = new ElectronicMailType { Value = erpCompany.EMail }//get                     
                        }
                    }
                };

                string firstName = erpCurrentAccount.CurrentAccountName.Substring(0, erpCurrentAccount.CurrentAccountName.LastIndexOf(' '));
                string lastName = erpCurrentAccount.CurrentAccountName.Substring(erpCurrentAccount.CurrentAccountName.LastIndexOf(' ') + 1);
                string partyIdentificationTypeSchemaId = "";
                string erpAccountTaxOfficeName = "";
                if (isEInvoiceUser) {
                    partyIdentificationTypeSchemaId = "VKN";

                    string erpAccountTaxOfficeQuerry = $@"select * from Meta_TaxOffice where RecId={erpCurrentAccount.TaxOfficeId} order by RecId desc";
                    var erpAccountTaxOffice = LoadAnonTable<Erp_TaxOffice>(erpAccountTaxOfficeQuerry).FirstOrDefault();
                    if (ReferenceEquals(erpAccountTaxOffice, null) || ReferenceEquals(erpAccountTaxOffice.RecId, null) || erpAccountTaxOffice.RecId <= 0) {
                        result = false;
                        return result;
                    }
                    else {
                        erpAccountTaxOfficeName = erpAccountTaxOffice.Name;
                    }
                }
                else {
                    partyIdentificationTypeSchemaId = "TCKN";
                }
                invoice.AccountingCustomerParty = new CustomerPartyType {
                    Party = new PartyType {
                        PartyIdentification = new PartyIdentificationType[] {
                            new PartyIdentificationType{ ID = new IDType { schemeID = partyIdentificationTypeSchemaId, Value = erpCurrentAccount.TaxNo } }//const - get
                        },
                        PartyName = new PartyNameType { Name = new NameType1 { Value = erpCurrentAccount.CurrentAccountName  + " - " + erpCurrentAccount.TradeName} },//get
                        PostalAddress = new AddressType {
                            StreetName = new StreetNameType { Value = erpAccountAddress.Line1 },// get
                            BuildingName = new BuildingNameType { Value = erpAccountAddress.Line2 + erpAccountAddress.Line3 },//get
                            CitySubdivisionName = new CitySubdivisionNameType { Value = erpAccountDistrict.DistrictName },//get
                            CityName = new CityNameType { Value = erpAccountCity.CityName },//get
                            Country = new CountryType { Name = new NameType1 { Value = "Türkiye" } }//const
                        },
                        PartyTaxScheme = new PartyTaxSchemeType { TaxScheme = new TaxSchemeType { Name = new NameType1 { Value = erpAccountTaxOfficeName } } },//get
                        Contact = new ContactType { ElectronicMail = new ElectronicMailType { Value = erpCurrentAccount.EMail } },//get
                        Person = new PersonType {
                            FirstName = new FirstNameType { Value = firstName },//get
                            FamilyName = new FamilyNameType { Value = lastName }//get
                        }
                    }
                };
                if (isEInvoiceUser) {
                    invoice.AccountingCustomerParty.Party.Contact.Telephone = new TelephoneType { Value = erpCurrentAccount.GsmPhone };
                    invoice.AccountingCustomerParty.Party.Person = null;
                }

                invoice.PaymentMeans = new PaymentMeansType[] {
                    new PaymentMeansType{
                        PaymentMeansCode = new PaymentMeansCodeType { Value = "1"},//get - PaymentMeans is null then it is 1
                        PaymentDueDate = new PaymentDueDateType { Value = erpInvoice.TermDate }//get
                    }
                };

                invoice.PaymentTerms = new PaymentTermsType { Note = new NoteType { Value = erpPaymentPlan.Explanation } };//get

                // based on items
                //foreach (var item in erpInventoryReceiptItems) {
                //    if (item.ItemType == 1) {

                //    }
                //}
                var GroupsTotalVatBaseAmounts = from item in erpInventoryReceiptItems
                                                group item by item.VatRate into vatGroup
                                                select new {
                                                    GroupX = vatGroup.Key,
                                                    TotalVatBaseAmount = vatGroup.Sum(x => x.VatBaseAmount),
                                                };
                List<TaxSubtotalType> TaxSubtotals = new List<TaxSubtotalType>();
                int i = 1;
                bool writeZeroTaxSubtotalx = false;
                if (GroupsTotalVatBaseAmounts.Count() > 1) {
                    if (erpInventoryReceiptItems.Count() > 1) {
                        writeZeroTaxSubtotalx = true;
                    }
                }
                foreach (var vGroup in GroupsTotalVatBaseAmounts) {
                    decimal.TryParse(vGroup.GroupX.ToString(), out decimal vatRate);                    
                    if (vatRate == 0) {
                        if (writeZeroTaxSubtotalx) {
                            continue;
                        }
                    }
                    decimal taxAmount = ((decimal)vGroup.TotalVatBaseAmount) * vatRate / 100;
                    decimal taxAbleAmount = decimal.Round((decimal)vGroup.TotalVatBaseAmount, 2, MidpointRounding.AwayFromZero);
                    if (vatRate == 0) {
                        taxAbleAmount = 0;
                    }
                    TaxSubtotals.Add(
                        new TaxSubtotalType {
                            TaxableAmount = new TaxableAmountType { currencyID = "TRY", Value = taxAbleAmount }, // get??
                                TaxAmount = new TaxAmountType { currencyID = "TRY", Value = decimal.Round(taxAmount, 2, MidpointRounding.AwayFromZero) },
                            CalculationSequenceNumeric = new CalculationSequenceNumericType { Value = i++ },
                            Percent = new PercentType1 { Value = decimal.Round(vatRate, 2, MidpointRounding.AwayFromZero) },
                            TaxCategory = new TaxCategoryType {
                                TaxScheme = new TaxSchemeType {
                                Name = new NameType1 { Value = "KDV" },//const
                                    TaxTypeCode = new TaxTypeCodeType { Value = "0015" }//const
                                }
                            }
                        }
                     );
                }             

                if (TaxSubtotals.Count() == 1) {
                    if (TaxSubtotals[0].Percent.Value == 0) {
                        if (isEInvoiceUser) {
                            TaxSubtotals[0].TaxCategory.TaxScheme = new TaxSchemeType();
                        }

                        if (!object.ReferenceEquals(erpInvoice.EInvoiceTaxExemptionReasonCode, null) &&
                            !string.IsNullOrEmpty(erpInvoice.EInvoiceTaxExemptionReasonCode.ToString()) &&
                            erpInvoice.EInvoiceTaxExemptionReasonCode.ToString() == "335") {
                            TaxSubtotals[0].TaxCategory.TaxExemptionReasonCode = new TaxExemptionReasonCodeType { Value = "335" };
                            TaxSubtotals[0].TaxCategory.TaxExemptionReason = new TaxExemptionReasonType { Value = "335 - 13/n Basılı Kitap ve Süreli Yayınların Teslimleri" };
                        }
                        else {
                            Console.WriteLine("Muafiyet sebebi girilmemiş!");
                            result = false;
                            return result;
                        }
                    }
                }
                invoice.TaxTotal = new TaxTotalType[] {
                    new TaxTotalType {
                        TaxAmount =  new TaxAmountType { currencyID = "TRY", Value = decimal.Round((decimal)erpInvoice.VatAmount, 2, MidpointRounding.AwayFromZero) }, //const -  get 
                        TaxSubtotal = TaxSubtotals.ToArray()
                    }
                };

                invoice.LegalMonetaryTotal = new MonetaryTotalType {
                    LineExtensionAmount = new LineExtensionAmountType { currencyID = "TRY", Value = decimal.Round((decimal)erpInvoice.SubTotal, 2, MidpointRounding.AwayFromZero) },//get
                    TaxExclusiveAmount = new TaxExclusiveAmountType { currencyID = "TRY", Value = decimal.Round((decimal)(erpInvoice.SubTotal - erpInvoice.DiscountsTotal), 2, MidpointRounding.AwayFromZero) },//get
                    TaxInclusiveAmount = new TaxInclusiveAmountType { currencyID = "TRY", Value = decimal.Round((decimal)(erpInvoice.GrandTotal), 2, MidpointRounding.AwayFromZero) },//get
                    AllowanceTotalAmount = new AllowanceTotalAmountType { currencyID = "TRY", Value = decimal.Round((decimal)(erpInvoice.DiscountsTotal), 2, MidpointRounding.AwayFromZero) },//get
                    ChargeTotalAmount = new ChargeTotalAmountType { currencyID = "TRY", Value = decimal.Round((decimal)(erpInvoice.ExpensesTotal), 2, MidpointRounding.AwayFromZero) },//get
                    PayableAmount = new PayableAmountType { currencyID = "TRY", Value = decimal.Round((decimal)(erpInvoice.GrandTotal), 2, MidpointRounding.AwayFromZero) }//get
                };

                /// items - kalemler
                List<InvoiceLineType> invoiceLineTypes = new List<InvoiceLineType>();
                int j = 1;
                bool wrtieZeroVatrateTaxTotal = erpInventoryReceiptItems.Select(x => x.VatRate)
                                                                       .Distinct()
                                                                       .Count() > 1;

                foreach (var receiptItem in erpInventoryReceiptItems) {
                    var unitSetItem = LoadAnonTable<Erp_UnitSetItem>($@"select * from Meta_UnitSetItem where RecId = {receiptItem.UnitId}").FirstOrDefault();
                    var erpInventory = LoadAnonTable<Erp_Inventory>($@"select * from Erp_Inventory where RecId = {receiptItem.InventoryId}").FirstOrDefault();
                    
                    decimal unitPrice = 0m;
                    decimal vatRate = 0m;
                    decimal priceAmount = 0m;
                    decimal.TryParse(receiptItem.UnitPrice.ToString(), out unitPrice);
                    decimal.TryParse(receiptItem.VatRate.ToString(), out vatRate);
                    priceAmount = unitPrice / (1m + vatRate / 100m);
                    
                    InvoiceLineType invoiceLine = new InvoiceLineType {
                        ID = new IDType { Value = j++.ToString() }, // make
                        Note = new NoteType[] { new NoteType { Value = "True - " + (receiptItem.UnitPrice * receiptItem.Quantity).ToString("0.00000000").Replace('.', ',') + " - 0,00000000" } }, //get - const
                        InvoicedQuantity = new InvoicedQuantityType { unitCode = unitSetItem.UniversalCode, Value = (decimal)receiptItem.Quantity }, //get
                        LineExtensionAmount = new LineExtensionAmountType { currencyID = "TRY", Value = decimal.Round((decimal)receiptItem.NetItemTotal, 2, MidpointRounding.AwayFromZero) }, //get
                        TaxTotal = new TaxTotalType {
                            TaxAmount = new TaxAmountType { currencyID = "TRY", Value = decimal.Round((decimal)receiptItem.VatAmount, 2) },
                            TaxSubtotal = new TaxSubtotalType[] {
                                new TaxSubtotalType{
                                    TaxableAmount = new TaxableAmountType { currencyID = "TRY", Value = decimal.Round((decimal)receiptItem.VatAmount, 2, MidpointRounding.AwayFromZero)},
                                    TaxAmount = new TaxAmountType{ currencyID = "TRY", Value = decimal.Round((decimal)receiptItem.VatAmount, 2, MidpointRounding.AwayFromZero) },
                                    Percent = new PercentType1 { Value = decimal.Round(vatRate, 2, MidpointRounding.AwayFromZero) },
                                    TaxCategory = new TaxCategoryType{
                                        TaxScheme = new TaxSchemeType{
                                            Name = new NameType1{ Value = "KDV"},
                                            TaxTypeCode = new TaxTypeCodeType{ Value = "0015"}
                                        }
                                    }
                                }
                            }
                        },
                        Item = new ItemType {
                            Name = new NameType1 { Value = erpInventory.InventoryName },
                            ModelName = new ModelNameType { Value = erpInventory.InventoryCode },
                            ManufacturersItemIdentification = new ItemIdentificationType { ID = new IDType { Value = erpInventory.InventoryCode } }
                        },
                        Price = new PriceType {
                            PriceAmount = new PriceAmountType { currencyID = "TRY", Value = decimal.Round(priceAmount, 2, MidpointRounding.AwayFromZero) }
                        }
                    };

                    if (!wrtieZeroVatrateTaxTotal && vatRate == 0) {
                        invoiceLine.TaxTotal = null;
                    }

                    var discountLines = LoadAnonTable<Erp_InventoryReceiptItem>($@"select * from Erp_InventoryReceiptItem where ParentItemId = {receiptItem.RecId} and ItemType = 50");
                    List<AllowanceChargeType> AllowanceChargeTypes = new List<AllowanceChargeType>();
                    if (discountLines.Count > 0) {
                        foreach (var discountLine in discountLines) {
                            if (!object.Equals(null, discountLine.RecId) && discountLine.RecId != 0) { // indirim var
                                AllowanceChargeTypes.Add(
                                    new AllowanceChargeType {
                                        ChargeIndicator = new ChargeIndicatorType { Value = false }, // const
                                        AllowanceChargeReason = new AllowanceChargeReasonType { Value = "İndirim" }, //const ??
                                        MultiplierFactorNumeric = new MultiplierFactorNumericType { Value = decimal.Round((decimal)discountLine.DiscountRate / 100m, 3, MidpointRounding.AwayFromZero) },
                                        Amount = new AmountType2 { currencyID = "TRY", Value = decimal.Round((decimal)discountLine.DiscountAmount, 2, MidpointRounding.AwayFromZero) },
                                        BaseAmount = new BaseAmountType { currencyID = "TRY", Value = decimal.Round((decimal)receiptItem.ItemTotal, 2, MidpointRounding.AwayFromZero) }
                                    }
                                );
                            }
                        }
                        invoiceLine.AllowanceCharge = AllowanceChargeTypes.ToArray();
                    }
                    invoiceLineTypes.Add(invoiceLine);
                }//foreach
                invoice.InvoiceLine = invoiceLineTypes.ToArray();

                string sss = ConvertStringToUtf8Bom(Serialize3(invoice));
                result = true;
                File.WriteAllText(@"d:/eaeaea/" + docName + "2", sss);
                //Console.WriteLine(sss);
                Console.WriteLine("done ->" + docName);
                Console.WriteLine();
            }
            catch (Exception ex){
                Console.WriteLine(ex);
                result = false;  
                //throw; 
            }
            return result;
        }

        public static List<T> LoadAnonTableAll<T>(string tableName) {
            using (var conn = new SqlConnection(UGCore.Functions.GetConnString("ms_sql"))) {
                //Console.WriteLine(conn.ConnectionString);
                var output = conn.Query<T>("SELECT * FROM " + tableName, new DynamicParameters());
                return output.ToList();
            }
        }

        //public static List<T> LoadAnonTable<T>(string querry) {
        //    using (var conn = new SqlConnection(Functions.GetConnString("ms_sql"))) {
        //        //Console.WriteLine(conn.ConnectionString);
        //        var output = conn.Query<T>(querry, new DynamicParameters());
        //        return output.ToList();
        //    }
        //}

        public class Utf8StringWriter : StringWriter {
            public override Encoding Encoding => Encoding.UTF8;
        }

        //public static string Serialize4<T>(T SomeSerializableObject) {
        //    XmlSerializerNamespaces xmlSerializerNamespaces = new XmlSerializerNamespaces();
        //    xmlSerializerNamespaces.Add("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2");
        //    xmlSerializerNamespaces.Add("udt", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2");
        //    xmlSerializerNamespaces.Add("ccts", "urn:un:unece:uncefact:documentation:2");
        //    xmlSerializerNamespaces.Add("ds", "http://www.w3.org/2000/09/xmldsig#");
        //    xmlSerializerNamespaces.Add("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2");
        //    xmlSerializerNamespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
        //    xmlSerializerNamespaces.Add("xades", "http://uri.etsi.org/01903/v1.3.2#");
        //    xmlSerializerNamespaces.Add("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
        //    xmlSerializerNamespaces.Add("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
        //    xmlSerializerNamespaces.Add("ubltr", "urn:oasis:names:specification:ubl:schema:xsd:TurkishCustomizationExtensionComponents");

        //    var serializer = new XmlSerializer(SomeSerializableObject.GetType());
        //    string utf8;
        //    using (StringWriter writer = new Utf8StringWriter { NewLine = "\r\n" }) {
        //        serializer.Serialize(writer, SomeSerializableObject, xmlSerializerNamespaces);
        //        utf8 = writer.ToString();
        //    }
        //    return utf8;
        //}

        public static string Serialize3<T>(T dataToSerialize) {
            try {
                XmlSerializer xsSubmit = new XmlSerializer(typeof(T));
                //var subReq = new T();
                var xml = "";
                using (var sww = new Utf8StringWriter()) {
                    XmlSerializerNamespaces xmlSerializerNamespaces = new XmlSerializerNamespaces();
                    xmlSerializerNamespaces.Add("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2");
                    xmlSerializerNamespaces.Add("udt", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2");
                    xmlSerializerNamespaces.Add("ccts", "urn:un:unece:uncefact:documentation:2");
                    xmlSerializerNamespaces.Add("ds", "http://www.w3.org/2000/09/xmldsig#");
                    xmlSerializerNamespaces.Add("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2");
                    xmlSerializerNamespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
                    xmlSerializerNamespaces.Add("xades", "http://uri.etsi.org/01903/v1.3.2#");
                    xmlSerializerNamespaces.Add("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
                    xmlSerializerNamespaces.Add("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
                    xmlSerializerNamespaces.Add("ubltr", "urn:oasis:names:specification:ubl:schema:xsd:TurkishCustomizationExtensionComponents");

                    using (XmlWriter xmlWriter = XmlWriter.Create(sww, new XmlWriterSettings {
                        Indent = true,
                        NamespaceHandling = NamespaceHandling.OmitDuplicates,
                        NewLineHandling = NewLineHandling.Entitize,
                        Encoding = Encoding.UTF8,
                        NewLineChars = "\r\n",
                        //ConformanceLevel = ConformanceLevel.Auto
                    })) {
                        //xmlWriter.WriteAttributeString("xsi", "schemaLocation", "xmlns", "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2 UBL-Invoice-2.1.xsd");
                        //xmlWriter.WriteStartElement("xsi", "schemaLocation", "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2 UBL-Invoice-2.1.xsd");
                        xsSubmit.Serialize(xmlWriter, dataToSerialize, xmlSerializerNamespaces);
                        xml = sww.ToString(); // Your XML
                    }
                    return xml;
                }
            }
            catch {
                throw;
            }
        }
        
        public static string Serialize<T>(T dataToSerialize) {
            try {
                var stringwriter = new System.IO.StringWriter();
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stringwriter, dataToSerialize);
                return stringwriter.ToString();
            }
            catch {
                throw;
            }
        }

        public static T Deserialize<T>(string xmlText) {
            try {
                var stringReader = new System.IO.StringReader(xmlText);
                var serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(stringReader);
            }
            catch {
                throw;
            }
        }

        private void checkEInvoiceUser() {
            var client = new RestClient("https://portal2.edmbilisim.com.tr/EFaturaEDM/EFaturaEDM.svc");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/xml");
            request.AddParameter("application/xml", "<Envelope xmlns=\"http://schemas.xmlsoap.org/soap/envelope/\">\r\n    " +
                "<Body>\r\n        <LoginRequest xmlns=\"http://tempuri.org/\">\r\n            " +
                "<REQUEST_HEADER>\r\n                " +
                "<SESSION_ID>0</SESSION_ID>\r\n                " +
                $"<CLIENT_TXN_ID>{Guid.NewGuid().ToString()}</CLIENT_TXN_ID>\r\n                " +
                $"<ACTION_DATE>{DateTime.Now}</ACTION_DATE>\r\n                " +
                "<REASON>EFATURA GONDERME VE ALMA ISLEMLERI TEST</REASON>\r\n                " +
                "<APPLICATION_NAME>EDM EFATURA V1.0</APPLICATION_NAME>\r\n                " +
                "<HOSTNAME>HOST-EDM-DEFAULT</HOSTNAME>\r\n                " +
                "<CHANNEL_NAME>EDM</CHANNEL_NAME>\r\n                " +
                "<COMPRESSED>N</COMPRESSED>\r\n            " +
                "</REQUEST_HEADER>\r\n            " +
                "<USER_NAME>cc_3a</USER_NAME>\r\n            " +
                "<PASSWORD>muhasebe@uzaktangelir.com</PASSWORD>\r\n        " +
                "</LoginRequest>\r\n    " +
                "</Body>\r\n</Envelope>", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Headers[0].Value);
        }

        private void button2_Click(object sender, EventArgs e) {
            var s = TransformXMLToHTML(@"d:\irsaliye.xml", @"d:\SentezEArchiveInvoice.xslt");
            Console.WriteLine(s);
        }

        public static string TransformXMLToHTML(string inputXmlPath, string xsltPath) {
            string inputXml = File.ReadAllText(inputXmlPath);
            string xsltString = File.ReadAllText(xsltPath);
            XslCompiledTransform transform = new XslCompiledTransform();
            using (XmlReader reader = XmlReader.Create(new StringReader(xsltString))) {
                transform.Load(reader);
            }
            StringWriter results = new StringWriter();
            using (XmlReader reader = XmlReader.Create(new StringReader(inputXml))) {
                transform.Transform(reader, null, results);
            }
            return results.ToString();
        }

        private void button4_Click(object sender, EventArgs e) {
            var invoices = LoadAnonTable<Erp_Invoice>($"select top 100 SpecialCode from Erp_Invoice where SpecialCode IS NOT NULL order by RecId desc "); //OFFSET 10 ROWS FETCH NEXT 10 ROWS ONLY;
            foreach (var invoice in invoices) {
                ///check if xml file created before
                var xmlObj = UGCore.Functions.GetXmlFileLocation();
                string folderPath = xmlObj.earchive;
                
                string docName = CreateXMLDocumentName(invoice.SpecialCode.ToString(), false);
                string docFullPath = folderPath + docName;
                if (string.IsNullOrEmpty(docName)) {
                    Console.WriteLine("wrong docfullpath");
                    return;
                }
                string finalFile = "d:/eaeaea/ofm_" + docName;
                using (var swm = new Utf8StringWriter()) {
                    using (XmlWriter xmlWriter = XmlWriter.Create(swm, new XmlWriterSettings {
                        Indent = true,
                        NamespaceHandling = NamespaceHandling.OmitDuplicates,
                        NewLineHandling = NewLineHandling.Entitize,
                        Encoding = Encoding.UTF8,
                        NewLineChars = "\r\n",
                        //ConformanceLevel = ConformanceLevel.Auto
                    })) {
                        GenerateDiffGram(docFullPath, finalFile, xmlWriter);
                        Console.WriteLine(swm.ToString());
                        Console.WriteLine();
                    }
                }
            }              
            
        }

        public void GenerateDiffGram(string originalFile, string finalFile, XmlWriter diffGramWriter) {
            XmlDiff xmldiff = new XmlDiff(XmlDiffOptions.IgnoreChildOrder | XmlDiffOptions.IgnoreNamespaces | 
                                            XmlDiffOptions.IgnorePrefixes | XmlDiffOptions.IgnoreWhitespace |
                                            XmlDiffOptions.IgnoreComments | XmlDiffOptions.IgnoreDtd |
                                            XmlDiffOptions.IgnorePI | XmlDiffOptions.IgnoreXmlDecl);

            using (diffGramWriter) {
                bool bIdentical = xmldiff.Compare(originalFile, finalFile, false, diffGramWriter);
                Console.WriteLine(originalFile + "_*_" +  finalFile + "\n***" + bIdentical.ToString() + "***\n___________________");
                //diffgramWriter.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e) {
            var invoices = LoadAnonTable<Erp_Invoice>($"select top 103 SpecialCode from Erp_Invoice where SpecialCode IS NOT NULL order by RecId desc "); //OFFSET 10 ROWS FETCH NEXT 10 ROWS ONLY;
            foreach (var invoice in invoices) {
                ///check if xml file created before
                var xmlObj = UGCore.Functions.GetXmlFileLocation();

                string folderPath = xmlObj.earchive;
                string docName = CreateXMLDocumentName(invoice.SpecialCode.ToString(), false);
                string docFullPath = folderPath + docName;
                if (string.IsNullOrEmpty(docName)) {
                    Console.WriteLine("wrong docfullpath");
                    return;
                }
                string finalFile = "d:/eaeaea/ofm_" + docName;
                /// xml-> obj compare objects
                try {
                    InvoiceType sentez;
                    InvoiceType ofm;
                    //string sentezXMLString = File.ReadAllText(docFullPath);
                    //string ofmXMLString = File.ReadAllText(finalFile);
                    //if (string.IsNullOrEmpty(sentezXMLString) || string.IsNullOrEmpty(ofmXMLString)) {
                        XmlSerializer serializer = new XmlSerializer(typeof(InvoiceType));
                        using (var rdr = new StreamReader(docFullPath)) {
                            sentez = (InvoiceType)serializer.Deserialize(rdr);
                        }
                        using (var rdr2 = new StreamReader(finalFile)) {
                            ofm = (InvoiceType)serializer.Deserialize(rdr2);
                        }
                        Console.WriteLine(object.Equals(sentez, ofm));
                    //}
                                     
                    
                    Console.WriteLine();
                    //Invoicexxx invoicexx;
                    //XmlSerializer serializer = new XmlSerializer(typeof(Invoicexxx));
                    //using (var reader = new StringReader(model.XmlDocument)) {
                    //    invoicexx = (Invoicexxx)serializer.Deserialize(reader);
                    //}
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.GetBaseException());
                    //throw;
                }
                Console.WriteLine();
                //File.ReadAllText(docFullPath)
            }
        }

    }
}

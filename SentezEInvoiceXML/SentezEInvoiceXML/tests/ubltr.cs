//// ------------------------------------------------------------------------------
////  This is a sample that show the following:
////   - How to save an UBL Larsen invoice instance to xml
////   - Xml file xsd validation
////
//// Sample data taken from
//// http://docs.oasis-open.org/ubl/os-UBL-2.0-update/xml/UBL-Invoice-2.0-Example.xml
//// ------------------------------------------------------------------------------

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Xml.Linq;
//using UblLarsen.Ubl2.Cac;
//using UblLarsen.Ubl2.Udt;
//using System.Xml;
//using System.Xml.Serialization;
//using System.IO;
//using UblLarsen.Ubl2.Ext;

//namespace SentezEInvoiceXML {
//    public static class ubltr {

//        public static UblLarsen.Ubl2.InvoiceType PopulateInvoiceWithSampleData() {
//            // Default that shpould be set when you load the library. Don't need to set it for each document.
//            UblLarsen.Ubl2.UblBaseDocumentType.GlbCustomizationID =
//                "urn:oasis:names:specification:ubl:xpath:Invoice-2.0:sbs-1.0-draft";
//            UblLarsen.Ubl2.UblBaseDocumentType.GlbProfileID =
//                "bpid:urn:oasis:names:draft:bpss:ubl-2-sbs-invoice-notification-draft";

//            // Default value assinged to all amounts in this thread
//            AmountType.TlsDefaultCurrencyID = "TRY";


//            // This initialization will only work with C# 3.0 and above
//            UblLarsen.Ubl2.InvoiceType res = new UblLarsen.Ubl2.InvoiceType {
//                UBLExtensions = new UBLExtensionType[]
//                {
//                    //new UBLExtensionType
//                    //{
//                    //    ExtensionContent = new XmlElement("","","",null)
//                    //    {
//                    //        InnerText = "<n4:auto-generated_for_wildcard/>"
//                    //    }
//                    //}
//                },
//                // UBLVersionID = "2.0", Don't need to set this one. hardcoded in the library
//                UBLVersionID = "2.1",
//                CustomizationID = "TR1.2",
//                ProfileID = "TEMELFATURA",
//                ID = "GIB20090000000001",
//                CopyIndicator = false,
//                UUID = "849FBBCE-E081-40B4-906C-94C5FF9D1AC3",
//                IssueDate = new DateTime(2005, 6, 21),
//                IssueTime = DateTime.Now,
//                InvoiceTypeCode = "SATIS",
//                //Note = new TextType[] { "sample" },
//                //TaxPointDate = new DateTime(2005, 6, 21),
//                DocumentCurrencyCode = "TRY",
//                LineCountNumeric = 1,
//                InvoicePeriod = new PeriodType[]
//                    {
//                       new PeriodType
//                       {
//                           StartDate = new DateTime(2005, 6, 21) ,
//                           EndDate = new DateTime(2016, 6, 21)
//                       }
//                    },
//                //OrderReference = new OrderReferenceType
//                //{
//                //    ID = "AEG012345",
//                //    SalesOrderID = "CON0095678",
//                //    UUID = "6E09886B-DC6E-439F-82D1-7CCAC7F4E3B1",
//                //    IssueDate = new DateTime(2005, 6, 20)
//                //},
//                Signature = new SignatureType[]
//                {
//                   new SignatureType
//                   {
//                       ID = new IdentifierType{schemeID = "VKN_TCKN", Value = "1288331521"},
//                       SignatoryParty = new PartyType
//                       {
//                           PartyIdentification = new PartyIdentificationType[]
//                           {
//                               new PartyIdentificationType
//                               {
//                                   ID = new IdentifierType{schemeID = "VKN", Value = "1288331521"}
//                               }
//                           },
//                           PostalAddress = new AddressType
//                           {
//                               StreetName = "Papatya Cad Yasemin Sokak",
//                               BuildingNumber = "21",
//                               CitySubdivisionName = "Beşiktaş",
//                               CityName = "İstanbul",
//                               PostalZone = "34100",
//                               Country = new CountryType
//                               {
//                                   Name = "Türkiye"
//                               }
//                           }
//                       },
//                       DigitalSignatureAttachment = new AttachmentType
//                       {
//                           ExternalReference = new ExternalReferenceType
//                           {
//                               URI = "#Signature"
//                           }
//                       }
//                   }
//                },
//                AccountingSupplierParty = new SupplierPartyType {
//                    //CustomerAssignedAccountID = "CO001",
//                    Party = new PartyType {
//                        WebsiteURI = "http://wwww.aaa.com.tr",
//                        PartyIdentification = new PartyIdentificationType[]
//                        {
//                           new PartyIdentificationType
//                           {
//                               ID = new IdentifierType{schemeID = "VKN", Value = "1288331521"}
//                           }
//                        },
//                        PartyName = new PartyNameType[]
//                        {
//                           "AAA Anonim Şirketi"
//                        },
//                        //EndpointID = "DK12345678",
//                        PostalAddress = new AddressType {
//                            ID = "1234567890",
//                            StreetName = "Papatya Cad Yasemin Sokak",
//                            //BuildingName = "Thereabouts",                            
//                            BuildingNumber = "21",
//                            CitySubdivisionName = "Beşiktaş",
//                            CityName = "İstanbul",
//                            PostalZone = "341000",
//                            //CountrySubentity = "Heremouthshire",
//                            //AddressLine = new AddressLineType[] { "The Roundabout" },
//                            Country = new CountryType {
//                                Name = "Türkiye"
//                            }
//                        },
//                        PartyTaxScheme = new PartyTaxSchemeType[]
//                        {
//                           new PartyTaxSchemeType
//                           {
//                               //RegistrationName = "Farthing Purchasing Consortia",
//                               //CompanyID = "175 269 2355",
//                               //ExemptionReason = "N/A",
//                               TaxScheme = new TaxSchemeType
//                               {
//                                  Name = "Büyük Mükellefler"
//                               }
//                           }
//                        },
//                        Contact = new ContactType {
//                            Name = "Mrs Bouquet",
//                            Telephone = "0158 1233714",
//                            Telefax = "0158 1233856",
//                            ElectronicMail = "jb+supplier@drivr.com",
//                        }
//                    }
//                },
//                AccountingCustomerParty = new CustomerPartyType {
//                    //CustomerAssignedAccountID = "XFB01",
//                    //SupplierAssignedAccountID = "GT00978567",
//                    Party = new PartyType {
//                        WebsiteURI = "",
//                        PartyIdentification = new PartyIdentificationType[]
//                        {
//                           new PartyIdentificationType{ ID = new IdentifierType{schemeID = "TCKN" , Value = "1234567890"} },
//                           new PartyIdentificationType{ ID = new IdentifierType{schemeID = "TESISATNO" , Value = "1234567"}  },
//                           new PartyIdentificationType{ ID = new IdentifierType{schemeID = "SAYACNO" , Value = "12345678"}  }
//                        },
//                        //PartyName = new PartyNameType[] { "IYT Corporation" },
//                        PostalAddress = new AddressType {
//                            ID = "ATATÜRK MAH.",
//                            Room = "1",
//                            StreetName = "6. Sokak",
//                            //BuildingName = "Thereabouts",
//                            BuildingNumber = "1",
//                            CitySubdivisionName = "Beşiktaş",
//                            CityName = "Bridgtow",
//                            PostalZone = "ZZ99 1ZZ",
//                            //CountrySubentity = "Avon",
//                            //AddressLine = new AddressLineType[] { "3rd Floor, Room 5" },
//                            Country = new CountryType { Name = "Türkiye" }
//                        },
//                        //PartyTaxScheme = new PartyTaxSchemeType[]
//                        //{
//                        //    new PartyTaxSchemeType
//                        //    {
//                        //        RegistrationName = "Bridgtow District Council",
//                        //        CompanyID = "12356478",
//                        //        ExemptionReason = "Local Authority",
//                        //        TaxScheme = new TaxSchemeType { ID = "UK VAT", TaxTypeCode="VAT" }
//                        //    }
//                        //},
//                        Contact = new ContactType {
//                            Name = "Mr Fred Churchill",
//                            Telephone = "0127 2653214",
//                            Telefax = "0127 2653215",
//                            ElectronicMail = "jb+customer@drivr.com"
//                        },
//                        Person = new PersonType {
//                            FirstName = "Ali",
//                            FamilyName = "YILMAZ"
//                        }
//                    }
//                },
//                PaymentTerms = new PaymentTermsType[]
//                {
//                   new PaymentTermsType
//                   {
//                       Note = new TextType[] { "BBB Bank Otomatik Ödeme" },
//                       //Payment due date yok eklenmeli
//                   }
//                },
//                TaxTotal = new TaxTotalType[]
//                {
//                   new TaxTotalType
//                   {
//                       TaxAmount = new AmountType{currencyID = "TRY",Value = 2.73M},
//                       //TaxEvidenceIndicator = true,
//                       TaxSubtotal = new TaxSubtotalType[]
//                       {
//                           new TaxSubtotalType
//                           {
//                               TaxableAmount = new AmountType{currencyID = "TRY" , Value = 15.15M},
//                               TaxAmount = new AmountType{currencyID = "TRY" , Value = 2.73M},
//                               TaxCategory = new TaxCategoryType
//                               {
//                                   //ID = "A",
//                                   TaxScheme = new TaxSchemeType
//                                       {
//                                           //ID = "UK VAT",
//                                           TaxTypeCode = "0015"
//                                       }
//                               }
//                           }
//                       }
//                   }
//                },
//                //Delivery = new DeliveryType[]
//                //{
//                //    new DeliveryType
//                //    {
//                //        ActualDeliveryDate = new DateTime(2005,6,20),
//                //        //ActualDeliveryTime = new DateTime(DateTime.Parse("11:30:00.0Z", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AssumeUniversal).Ticks, DateTimeKind.Utc),
//                //        ActualDeliveryTime = new DateTime(2005,6,20,11,30,00,DateTimeKind.Utc), // MS DateTime xml serializing have a bug! Won't serialize time as utc, always local.
//                //        DeliveryAddress = new AddressType
//                //        {
//                //            StreetName = "Avon Way",
//                //            BuildingName = "Thereabouts",
//                //            BuildingNumber = "56A",
//                //            CityName = "Bridgtow",
//                //            PostalZone = "ZZ99 1ZZ",
//                //            CountrySubentity = "Avon",
//                //            AddressLine = new AddressLineType[] { "3rd Floor, Room 5" },
//                //            Country = new CountryType { IdentificationCode = "GB"}
//                //        }
//                //    }
//                //},
//                LegalMonetaryTotal = new MonetaryTotalType {
//                    LineExtensionAmount = new AmountType { currencyID = "TRY", Value = 15.15M },
//                    TaxExclusiveAmount = new AmountType { currencyID = "TRY", Value = 15.15M },
//                    AllowanceTotalAmount = new AmountType { currencyID = "TRY", Value = 17.88M },
//                    PayableAmount = new AmountType { currencyID = "TRY", Value = 17.88M }
//                },
//                InvoiceLine = new InvoiceLineType[]
//                {
//                   new InvoiceLineType
//                   {
//                       ID = "1",
//                       InvoicedQuantity = new QuantityType{ unitCode="KWH", Value=100 },
//                       LineExtensionAmount = new AmountType { currencyID = "TRY", Value = 15.15M },
//                       AllowanceCharge = new AllowanceChargeType[]
//                       {
//                           new AllowanceChargeType
//                           {
//                               ChargeIndicator = false,
//                               MultiplierFactorNumeric = 0.0M,
//                               Amount = new AmountType { currencyID = "TRY", Value = 0M },
//                               BaseAmount = new AmountType { currencyID = "TRY", Value = 15.15M }
//                           }
//                       },
//                       //OrderLineReference = new OrderLineReferenceType[]
//                       //{
//                       //    new OrderLineReferenceType
//                       //    {
//                       //        LineID = "1",
//                       //        SalesOrderLineID = "A",
//                       //        LineStatusCode = "NoStatus",
//                       //        OrderReference = new OrderReferenceType
//                       //        {
//                       //            ID = "AEG012345",
//                       //            SalesOrderID = "CON0095678",
//                       //            UUID = "6E09886B-DC6E-439F-82D1-7CCAC7F4E3B1",
//                       //            IssueDate = new DateTime(2005,6,20)
//                       //        }
//                       //    }
//                       //},
//                       TaxTotal = new TaxTotalType[]
//                       {
//                           new TaxTotalType
//                           {
//                               TaxAmount = new AmountType { currencyID = "TRY", Value = 2.73M },
//                               //TaxEvidenceIndicator = true,
//                               TaxSubtotal = new TaxSubtotalType[]
//                               {
//                                   new TaxSubtotalType
//                                   {
//                                       TaxableAmount = new AmountType { currencyID = "TRY", Value = 15.15M },
//                                       TaxAmount = new AmountType { currencyID = "TRY", Value = 2.73M },
//                                       Percent = 18.0M,
//                                       TaxCategory = new TaxCategoryType
//                                       {
//                                           //ID = "A",
//                                           //Percent = 17.5M,
//                                           TaxScheme = new TaxSchemeType
//                                           {
//                                               //ID = "UK VAT",
//                                               Name = "KDV",
//                                               TaxTypeCode = "0015"
//                                           }
//                                       }
//                                   }
//                               }
//                           }
//                       },
//                       Item = new ItemType
//                       {
//                           //Description = new TextType[] { "Acme beeswax" },
//                           Name = "Elektirik Tüketim Bedeli"
//                           //BuyersItemIdentification = new ItemIdentificationType { ID = "6578489" },
//                           //SellersItemIdentification = new ItemIdentificationType { ID = "17589683" },
//                           //ItemInstance = new ItemInstanceType[]
//                           //{
//                           //    new ItemInstanceType
//                           //    {
//                           //        LotIdentification = new LotIdentificationType { LotNumberID = "546378239", ExpiryDate = new DateTime(2010,1,1) }
//                           //    }
//                           //}
//                       },
//                       Price = new PriceType
//                       {
//                           PriceAmount = new AmountType { currencyID = "TRY", Value = 0.15M },
//                           //BaseQuantity = new QuantityType{ unitCode="KG", Value = 1 }
//                       }
//                   }
//                }
//               //PaymentMeans = new PaymentMeansType[]
//               //{
//               //    new PaymentMeansType
//               //    {
//               //        PaymentMeansCode = "20",
//               //        PaymentDueDate = new DateTime(2005,7,21),
//               //        PayeeFinancialAccount = new FinancialAccountType
//               //        {
//               //            ID = "12345678",
//               //            Name = "Farthing Purchasing Consortia",
//               //            AccountTypeCode = "Current",
//               //            CurrencyCode = "GBP",
//               //            FinancialInstitutionBranch = new BranchType
//               //            {
//               //                ID = "10-26-58",
//               //                Name = "Open Bank Ltd, Bridgstow Branch ",
//               //                FinancialInstitution = new FinancialInstitutionType
//               //                {
//               //                    ID = "10-26-58",
//               //                    Name = "Open Bank Ltd",
//               //                    Address = new AddressType
//               //                    {
//               //                        StreetName = "City Road",
//               //                        BuildingName = "Banking House",
//               //                        BuildingNumber = "12",
//               //                        CityName = "London",
//               //                        PostalZone = "AQ1 6TH",
//               //                        CountrySubentity = "London",
//               //                        AddressLine = new AddressLineType[] {  "5th Floor" },
//               //                        Country = new CountryType { IdentificationCode = "GB" }
//               //                    }
//               //                },
//               //                Address = new AddressType
//               //                {
//               //                    StreetName = "Busy Street",
//               //                    BuildingName = "The Mall",
//               //                    BuildingNumber = "152",
//               //                    CityName = "Farthing",
//               //                    PostalZone = "AA99 1BB",
//               //                    CountrySubentity = "Heremouthshire",
//               //                    AddressLine = new AddressLineType[] { "West Wing" },
//               //                    Country = new CountryType {  IdentificationCode = "GB" }
//               //                }
//               //            },
//               //            Country = new CountryType { IdentificationCode = "GB" }
//               //        }
//               //    }
//               //},
//               //AllowanceCharge = new AllowanceChargeType[]
//               //{
//               //    new AllowanceChargeType
//               //    {
//               //        ChargeIndicator = false,
//               //        AllowanceChargeReasonCode = "17",
//               //        MultiplierFactorNumeric = 0.10M,
//               //        Amount = 10.00M
//               //    }
//               //}
//            };

//            return res;
//        }


//        ///usage
//        //static void Main() {
//        //    string xmlFilename = @"Deneme.xml";

//        //    UblLarsen.Ubl2.InvoiceType invoice = PopulateInvoiceWithSampleData();

//        //    XmlWriterSettings setting = new XmlWriterSettings();
//        //    setting.Indent = true;
//        //    setting.IndentChars = "\t";

//        //    using (XmlWriter writer = XmlWriter.Create(xmlFilename, setting)) {
//        //        writer.WriteProcessingInstruction(
//        //            "xml-stylesheet", "type='text/xsl' href='general.xslt'");
//        //        Type typeToSerialize = typeof(UblLarsen.Ubl2.InvoiceType);
//        //        XmlSerializer xs = new XmlSerializer(typeToSerialize);
//        //        xs.Serialize(writer, invoice);
//        //    }



//        //    Console.WriteLine("Invoice written to:\n{0}", new FileInfo(xmlFilename).FullName);
//        //    Console.WriteLine("Compare it with:\n{0}", "http://docs.oasis-open.org/ubl/os-UBL-2.0-update/xml/UBL-Invoice-2.0-Example.xml");

//        //    // See the unittest for more save samples
//        //}
//    }

//}
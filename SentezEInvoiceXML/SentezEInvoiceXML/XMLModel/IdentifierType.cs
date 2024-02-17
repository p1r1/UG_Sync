using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020002C1 RID: 705
	[XmlInclude(typeof(IdentifierType1))]
	[XmlInclude(typeof(WebsiteURIType))]
	[XmlInclude(typeof(VesselIDType))]
	[XmlInclude(typeof(VersionIDType))]
	[XmlInclude(typeof(VariantIDType))]
	[XmlInclude(typeof(ValidatorIDType))]
	[XmlInclude(typeof(UpperOrangeHazardPlacardIDType))]
	[XmlInclude(typeof(UUIDType))]
	[XmlInclude(typeof(URIType))]
	[XmlInclude(typeof(UBLVersionIDType))]
	[XmlInclude(typeof(TransportationServiceDetailsURIType))]
	[XmlInclude(typeof(TransportExecutionPlanReferenceIDType))]
	[XmlInclude(typeof(TrainIDType))]
	[XmlInclude(typeof(TrackingIDType))]
	[XmlInclude(typeof(TraceIDType))]
	[XmlInclude(typeof(TenderEnvelopeIDType))]
	[XmlInclude(typeof(SupplierAssignedAccountIDType))]
	[XmlInclude(typeof(SuccessiveSequenceIDType))]
	[XmlInclude(typeof(SubscriberIDType))]
	[XmlInclude(typeof(SpecificationIDType))]
	[XmlInclude(typeof(SignatureIDType))]
	[XmlInclude(typeof(ShippingOrderIDType))]
	[XmlInclude(typeof(SerialIDType))]
	[XmlInclude(typeof(SequenceNumberIDType))]
	[XmlInclude(typeof(SequenceIDType))]
	[XmlInclude(typeof(SellerEventIDType))]
	[XmlInclude(typeof(SecurityIDType))]
	[XmlInclude(typeof(SchemeURIType))]
	[XmlInclude(typeof(SalesOrderLineIDType))]
	[XmlInclude(typeof(SalesOrderIDType))]
	[XmlInclude(typeof(RevisedForecastLineIDType))]
	[XmlInclude(typeof(RequiredCustomsIDType))]
	[XmlInclude(typeof(RequestForQuotationLineIDType))]
	[XmlInclude(typeof(ReleaseIDType))]
	[XmlInclude(typeof(RegistrationNationalityIDType))]
	[XmlInclude(typeof(RegistrationIDType))]
	[XmlInclude(typeof(ReferencedConsignmentIDType))]
	[XmlInclude(typeof(ReferenceIDType))]
	[XmlInclude(typeof(RailCarIDType))]
	[XmlInclude(typeof(RadioCallSignIDType))]
	[XmlInclude(typeof(ProfileIDType))]
	[XmlInclude(typeof(ProfileExecutionIDType))]
	[XmlInclude(typeof(ProductTraceIDType))]
	[XmlInclude(typeof(PrimaryAccountNumberIDType))]
	[XmlInclude(typeof(PreviousVersionIDType))]
	[XmlInclude(typeof(PreviousJobIDType))]
	[XmlInclude(typeof(PrepaidPaymentReferenceIDType))]
	[XmlInclude(typeof(PerformingCarrierAssignedIDType))]
	[XmlInclude(typeof(PaymentTermsDetailsURIType))]
	[XmlInclude(typeof(PaymentMeansIDType))]
	[XmlInclude(typeof(PaymentIDType))]
	[XmlInclude(typeof(ParentDocumentVersionIDType))]
	[XmlInclude(typeof(ParentDocumentLineReferenceIDType))]
	[XmlInclude(typeof(ParentDocumentIDType))]
	[XmlInclude(typeof(OriginalJobIDType))]
	[XmlInclude(typeof(OriginalContractingSystemIDType))]
	[XmlInclude(typeof(OpenTenderIDType))]
	[XmlInclude(typeof(OntologyURIType))]
	[XmlInclude(typeof(NetworkIDType))]
	[XmlInclude(typeof(NationalityIDType))]
	[XmlInclude(typeof(MarkingIDType))]
	[XmlInclude(typeof(LowerOrangeHazardPlacardIDType))]
	[XmlInclude(typeof(LotNumberIDType))]
	[XmlInclude(typeof(LogoReferenceIDType))]
	[XmlInclude(typeof(LocationIDType))]
	[XmlInclude(typeof(LoadingSequenceIDType))]
	[XmlInclude(typeof(LineIDType))]
	[XmlInclude(typeof(LicensePlateIDType))]
	[XmlInclude(typeof(LanguageIDType))]
	[XmlInclude(typeof(JourneyIDType))]
	[XmlInclude(typeof(IssuerIDType))]
	[XmlInclude(typeof(IssueNumberIDType))]
	[XmlInclude(typeof(InstructionIDType))]
	[XmlInclude(typeof(InformationURIType))]
	[XmlInclude(typeof(ImmobilizationCertificateIDType))]
	[XmlInclude(typeof(IdentificationIDType))]
	[XmlInclude(typeof(IDType))]
	[XmlInclude(typeof(HazardClassIDType))]
	[XmlInclude(typeof(FreightForwarderAssignedIDType))]
	[XmlInclude(typeof(ExtendedIDType))]
	[XmlInclude(typeof(ExchangeMarketIDType))]
	[XmlInclude(typeof(EndpointIDType))]
	[XmlInclude(typeof(EconomicOperatorRegistryURIType))]
	[XmlInclude(typeof(DocumentIDType))]
	[XmlInclude(typeof(CustomizationIDType))]
	[XmlInclude(typeof(CustomerAssignedAccountIDType))]
	[XmlInclude(typeof(ContractedCarrierAssignedIDType))]
	[XmlInclude(typeof(ContractFolderIDType))]
	[XmlInclude(typeof(ConsumptionReportIDType))]
	[XmlInclude(typeof(ConsumptionIDType))]
	[XmlInclude(typeof(ConsignorAssignedIDType))]
	[XmlInclude(typeof(ConsigneeAssignedIDType))]
	[XmlInclude(typeof(CompanyIDType))]
	[XmlInclude(typeof(ChipApplicationIDType))]
	[XmlInclude(typeof(CarrierAssignedIDType))]
	[XmlInclude(typeof(CV2IDType))]
	[XmlInclude(typeof(BuyerProfileURIType))]
	[XmlInclude(typeof(BuyerEventIDType))]
	[XmlInclude(typeof(BusinessIdentityEvidenceIDType))]
	[XmlInclude(typeof(BusinessClassificationEvidenceIDType))]
	[XmlInclude(typeof(BrokerAssignedIDType))]
	[XmlInclude(typeof(BarcodeSymbologyIDType))]
	[XmlInclude(typeof(AwardingCriterionIDType))]
	[XmlInclude(typeof(AuctionURIType))]
	[XmlInclude(typeof(AttributeIDType))]
	[XmlInclude(typeof(AircraftIDType))]
	[XmlInclude(typeof(AgencyIDType))]
	[XmlInclude(typeof(AdditionalAccountIDType))]
	[XmlInclude(typeof(AccountIDType))]
	[XmlInclude(typeof(ExtensionVersionIDType))]
	[XmlInclude(typeof(ExtensionURIType))]
	[XmlInclude(typeof(ExtensionAgencyURIType))]
	[XmlInclude(typeof(ExtensionAgencyIDType))]
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
	[Serializable]
	public class IdentifierType
	{
		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x000033B0 File Offset: 0x000015B0
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x000033B8 File Offset: 0x000015B8
		[XmlAttribute(DataType = "normalizedString")]
		public string schemeID
		{
			get
			{
				return this.schemeIDField;
			}
			set
			{
				this.schemeIDField = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x000033C1 File Offset: 0x000015C1
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x000033C9 File Offset: 0x000015C9
		[XmlAttribute]
		public string schemeName
		{
			get
			{
				return this.schemeNameField;
			}
			set
			{
				this.schemeNameField = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x000033D2 File Offset: 0x000015D2
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x000033DA File Offset: 0x000015DA
		[XmlAttribute(DataType = "normalizedString")]
		public string schemeAgencyID
		{
			get
			{
				return this.schemeAgencyIDField;
			}
			set
			{
				this.schemeAgencyIDField = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x000033E3 File Offset: 0x000015E3
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x000033EB File Offset: 0x000015EB
		[XmlAttribute]
		public string schemeAgencyName
		{
			get
			{
				return this.schemeAgencyNameField;
			}
			set
			{
				this.schemeAgencyNameField = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x000033F4 File Offset: 0x000015F4
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x000033FC File Offset: 0x000015FC
		[XmlAttribute(DataType = "normalizedString")]
		public string schemeVersionID
		{
			get
			{
				return this.schemeVersionIDField;
			}
			set
			{
				this.schemeVersionIDField = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x00003405 File Offset: 0x00001605
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x0000340D File Offset: 0x0000160D
		[XmlAttribute(DataType = "anyURI")]
		public string schemeDataURI
		{
			get
			{
				return this.schemeDataURIField;
			}
			set
			{
				this.schemeDataURIField = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x00003416 File Offset: 0x00001616
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x0000341E File Offset: 0x0000161E
		[XmlAttribute(DataType = "anyURI")]
		public string schemeURI
		{
			get
			{
				return this.schemeURIField;
			}
			set
			{
				this.schemeURIField = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x00003427 File Offset: 0x00001627
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x0000342F File Offset: 0x0000162F
		[XmlText(DataType = "normalizedString")]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}

		// Token: 0x04000156 RID: 342
		private string schemeIDField;

		// Token: 0x04000157 RID: 343
		private string schemeNameField;

		// Token: 0x04000158 RID: 344
		private string schemeAgencyIDField;

		// Token: 0x04000159 RID: 345
		private string schemeAgencyNameField;

		// Token: 0x0400015A RID: 346
		private string schemeVersionIDField;

		// Token: 0x0400015B RID: 347
		private string schemeDataURIField;

		// Token: 0x0400015C RID: 348
		private string schemeURIField;

		// Token: 0x0400015D RID: 349
		private string valueField;
	}
}

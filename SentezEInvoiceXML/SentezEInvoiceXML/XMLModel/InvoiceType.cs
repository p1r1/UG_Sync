using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
//using Sentez.Common.Commands;
//using Sentez.Core.ParameterClasses;

namespace SentezEInvoiceXML
{
	// Token: 0x02000024 RID: 36
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")]
	[XmlRoot("Invoice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2", IsNullable = false)]
	[Serializable]
	public class InvoiceType
	{

		[XmlAttributeAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string xsiSchemaLocation = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2 UBL-Invoice-2.1.xsd";
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00002C0F File Offset: 0x00000E0F
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00002C17 File Offset: 0x00000E17
		[XmlArray(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
		[XmlArrayItem("UBLExtension", IsNullable = false)]
		public UBLExtensionType[] UBLExtensions
		{
			get
			{
				return this.uBLExtensionsField;
			}
			set
			{
				this.uBLExtensionsField = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00002C20 File Offset: 0x00000E20
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00002C28 File Offset: 0x00000E28
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public UBLVersionIDType UBLVersionID
		{
			get
			{
				return this.uBLVersionIDField;
			}
			set
			{
				this.uBLVersionIDField = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00002C31 File Offset: 0x00000E31
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00002C39 File Offset: 0x00000E39
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CustomizationIDType CustomizationID
		{
			get
			{
				return this.customizationIDField;
			}
			set
			{
				this.customizationIDField = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00002C42 File Offset: 0x00000E42
		// (set) Token: 0x060001BA RID: 442 RVA: 0x00002C4A File Offset: 0x00000E4A
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ProfileIDType ProfileID
		{
			get
			{
				return this.profileIDField;
			}
			set
			{
				this.profileIDField = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00002C53 File Offset: 0x00000E53
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00002C5B File Offset: 0x00000E5B
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IDType ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00002C64 File Offset: 0x00000E64
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00002C6C File Offset: 0x00000E6C
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CopyIndicatorType CopyIndicator
		{
			get
			{
				return this.copyIndicatorField;
			}
			set
			{
				this.copyIndicatorField = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00002C75 File Offset: 0x00000E75
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00002C7D File Offset: 0x00000E7D
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public UUIDType UUID
		{
			get
			{
				return this.uUIDField;
			}
			set
			{
				this.uUIDField = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00002C86 File Offset: 0x00000E86
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x00002C8E File Offset: 0x00000E8E
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IssueDateType IssueDate
		{
			get
			{
				return this.issueDateField;
			}
			set
			{
				this.issueDateField = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00002C97 File Offset: 0x00000E97
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x00002C9F File Offset: 0x00000E9F
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IssueTimeType IssueTime
		{
			get
			{
				return this.issueTimeField;
			}
			set
			{
				this.issueTimeField = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x00002CA8 File Offset: 0x00000EA8
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x00002CB0 File Offset: 0x00000EB0
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public InvoiceTypeCodeType InvoiceTypeCode
		{
			get
			{
				return this.invoiceTypeCodeField;
			}
			set
			{
				this.invoiceTypeCodeField = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00002CB9 File Offset: 0x00000EB9
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00002CC1 File Offset: 0x00000EC1
		[XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NoteType[] Note
		{
			get
			{
				return this.noteField;
			}
			set
			{
				this.noteField = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00002CCA File Offset: 0x00000ECA
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00002CD2 File Offset: 0x00000ED2
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DocumentCurrencyCodeType DocumentCurrencyCode
		{
			get
			{
				return this.documentCurrencyCodeField;
			}
			set
			{
				this.documentCurrencyCodeField = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00002CDB File Offset: 0x00000EDB
		// (set) Token: 0x060001CC RID: 460 RVA: 0x00002CE3 File Offset: 0x00000EE3
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TaxCurrencyCodeType TaxCurrencyCode
		{
			get
			{
				return this.taxCurrencyCodeField;
			}
			set
			{
				this.taxCurrencyCodeField = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00002CEC File Offset: 0x00000EEC
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00002CF4 File Offset: 0x00000EF4
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PricingCurrencyCodeType PricingCurrencyCode
		{
			get
			{
				return this.pricingCurrencyCodeField;
			}
			set
			{
				this.pricingCurrencyCodeField = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00002CFD File Offset: 0x00000EFD
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x00002D05 File Offset: 0x00000F05
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PaymentCurrencyCodeType PaymentCurrencyCode
		{
			get
			{
				return this.paymentCurrencyCodeField;
			}
			set
			{
				this.paymentCurrencyCodeField = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00002D0E File Offset: 0x00000F0E
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x00002D16 File Offset: 0x00000F16
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PaymentAlternativeCurrencyCodeType PaymentAlternativeCurrencyCode
		{
			get
			{
				return this.paymentAlternativeCurrencyCodeField;
			}
			set
			{
				this.paymentAlternativeCurrencyCodeField = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00002D1F File Offset: 0x00000F1F
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00002D27 File Offset: 0x00000F27
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AccountingCostType AccountingCost
		{
			get
			{
				return this.accountingCostField;
			}
			set
			{
				this.accountingCostField = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00002D30 File Offset: 0x00000F30
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00002D38 File Offset: 0x00000F38
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LineCountNumericType LineCountNumeric
		{
			get
			{
				return this.lineCountNumericField;
			}
			set
			{
				this.lineCountNumericField = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00002D41 File Offset: 0x00000F41
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x00002D49 File Offset: 0x00000F49
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public PeriodType InvoicePeriod
		{
			get
			{
				return this.invoicePeriodField;
			}
			set
			{
				this.invoicePeriodField = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00002D52 File Offset: 0x00000F52
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00002D5A File Offset: 0x00000F5A
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public OrderReferenceType OrderReference
		{
			get
			{
				return this.orderReferenceField;
			}
			set
			{
				this.orderReferenceField = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00002D63 File Offset: 0x00000F63
		// (set) Token: 0x060001DC RID: 476 RVA: 0x00002D6B File Offset: 0x00000F6B
		[XmlElement("BillingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public BillingReferenceType[] BillingReference
		{
			get
			{
				return this.billingReferenceField;
			}
			set
			{
				this.billingReferenceField = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00002D74 File Offset: 0x00000F74
		// (set) Token: 0x060001DE RID: 478 RVA: 0x00002D7C File Offset: 0x00000F7C
		[XmlElement("DespatchDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public DocumentReferenceType[] DespatchDocumentReference
		{
			get
			{
				return this.despatchDocumentReferenceField;
			}
			set
			{
				this.despatchDocumentReferenceField = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060001DF RID: 479 RVA: 0x00002D85 File Offset: 0x00000F85
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x00002D8D File Offset: 0x00000F8D
		[XmlElement("ReceiptDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public DocumentReferenceType[] ReceiptDocumentReference
		{
			get
			{
				return this.receiptDocumentReferenceField;
			}
			set
			{
				this.receiptDocumentReferenceField = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x00002D96 File Offset: 0x00000F96
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x00002D9E File Offset: 0x00000F9E
		[XmlElement("OriginatorDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public DocumentReferenceType[] OriginatorDocumentReference
		{
			get
			{
				return this.originatorDocumentReferenceField;
			}
			set
			{
				this.originatorDocumentReferenceField = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00002DA7 File Offset: 0x00000FA7
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x00002DAF File Offset: 0x00000FAF
		[XmlElement("ContractDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public DocumentReferenceType[] ContractDocumentReference
		{
			get
			{
				return this.contractDocumentReferenceField;
			}
			set
			{
				this.contractDocumentReferenceField = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00002DB8 File Offset: 0x00000FB8
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x00002DC0 File Offset: 0x00000FC0
		[XmlElement("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public DocumentReferenceType[] AdditionalDocumentReference
		{
			get
			{
				return this.additionalDocumentReferenceField;
			}
			set
			{
				this.additionalDocumentReferenceField = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00002DC9 File Offset: 0x00000FC9
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x00002DD1 File Offset: 0x00000FD1
		[XmlElement("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public SignatureType[] Signature
		{
			get
			{
				return this.signatureField;
			}
			set
			{
				this.signatureField = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00002DDA File Offset: 0x00000FDA
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00002DE2 File Offset: 0x00000FE2
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public SupplierPartyType AccountingSupplierParty
		{
			get
			{
				return this.accountingSupplierPartyField;
			}
			set
			{
				this.accountingSupplierPartyField = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00002DEB File Offset: 0x00000FEB
		// (set) Token: 0x060001EC RID: 492 RVA: 0x00002DF3 File Offset: 0x00000FF3
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public CustomerPartyType AccountingCustomerParty
		{
			get
			{
				return this.accountingCustomerPartyField;
			}
			set
			{
				this.accountingCustomerPartyField = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00002DFC File Offset: 0x00000FFC
		// (set) Token: 0x060001EE RID: 494 RVA: 0x00002E04 File Offset: 0x00001004
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public CustomerPartyType BuyerCustomerParty
		{
			get
			{
				return this.buyerCustomerPartyField;
			}
			set
			{
				this.buyerCustomerPartyField = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00002E0D File Offset: 0x0000100D
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x00002E15 File Offset: 0x00001015
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public SupplierPartyType SellerSupplierParty
		{
			get
			{
				return this.sellerSupplierPartyField;
			}
			set
			{
				this.sellerSupplierPartyField = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x00002E1E File Offset: 0x0000101E
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00002E26 File Offset: 0x00001026
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public PartyType TaxRepresentativeParty
		{
			get
			{
				return this.taxRepresentativePartyField;
			}
			set
			{
				this.taxRepresentativePartyField = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00002E2F File Offset: 0x0000102F
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x00002E37 File Offset: 0x00001037
		[XmlElement("Delivery", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public DeliveryType[] Delivery
		{
			get
			{
				return this.deliveryField;
			}
			set
			{
				this.deliveryField = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00002E40 File Offset: 0x00001040
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x00002E48 File Offset: 0x00001048
		[XmlElement("PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public PaymentMeansType[] PaymentMeans
		{
			get
			{
				return this.paymentMeansField;
			}
			set
			{
				this.paymentMeansField = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00002E51 File Offset: 0x00001051
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x00002E59 File Offset: 0x00001059
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public PaymentTermsType PaymentTerms
		{
			get
			{
				return this.paymentTermsField;
			}
			set
			{
				this.paymentTermsField = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00002E62 File Offset: 0x00001062
		// (set) Token: 0x060001FA RID: 506 RVA: 0x00002E6A File Offset: 0x0000106A
		[XmlElement("AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public AllowanceChargeType[] AllowanceCharge
		{
			get
			{
				return this.allowanceChargeField;
			}
			set
			{
				this.allowanceChargeField = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00002E73 File Offset: 0x00001073
		// (set) Token: 0x060001FC RID: 508 RVA: 0x00002E7B File Offset: 0x0000107B
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public ExchangeRateType TaxExchangeRate
		{
			get
			{
				return this.taxExchangeRateField;
			}
			set
			{
				this.taxExchangeRateField = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001FD RID: 509 RVA: 0x00002E84 File Offset: 0x00001084
		// (set) Token: 0x060001FE RID: 510 RVA: 0x00002E8C File Offset: 0x0000108C
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public ExchangeRateType PricingExchangeRate
		{
			get
			{
				return this.pricingExchangeRateField;
			}
			set
			{
				this.pricingExchangeRateField = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00002E95 File Offset: 0x00001095
		// (set) Token: 0x06000200 RID: 512 RVA: 0x00002E9D File Offset: 0x0000109D
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public ExchangeRateType PaymentExchangeRate
		{
			get
			{
				return this.paymentExchangeRateField;
			}
			set
			{
				this.paymentExchangeRateField = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00002EA6 File Offset: 0x000010A6
		// (set) Token: 0x06000202 RID: 514 RVA: 0x00002EAE File Offset: 0x000010AE
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public ExchangeRateType PaymentAlternativeExchangeRate
		{
			get
			{
				return this.paymentAlternativeExchangeRateField;
			}
			set
			{
				this.paymentAlternativeExchangeRateField = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00002EB7 File Offset: 0x000010B7
		// (set) Token: 0x06000204 RID: 516 RVA: 0x00002EBF File Offset: 0x000010BF
		[XmlElement("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public TaxTotalType[] TaxTotal
		{
			get
			{
				return this.taxTotalField;
			}
			set
			{
				this.taxTotalField = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00002EC8 File Offset: 0x000010C8
		// (set) Token: 0x06000206 RID: 518 RVA: 0x00002ED0 File Offset: 0x000010D0
		[XmlElement("WithholdingTaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public TaxTotalType[] WithholdingTaxTotal
		{
			get
			{
				return this.withholdingTaxTotalField;
			}
			set
			{
				this.withholdingTaxTotalField = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00002ED9 File Offset: 0x000010D9
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00002EE1 File Offset: 0x000010E1
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public MonetaryTotalType LegalMonetaryTotal
		{
			get
			{
				return this.legalMonetaryTotalField;
			}
			set
			{
				this.legalMonetaryTotalField = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00002EEA File Offset: 0x000010EA
		// (set) Token: 0x0600020A RID: 522 RVA: 0x00002EF2 File Offset: 0x000010F2
		[XmlElement("InvoiceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public InvoiceLineType[] InvoiceLine
		{
			get
			{
				return this.invoiceLineField;
			}
			set
			{
				this.invoiceLineField = value;
			}
		}

		// Token: 0x040000EC RID: 236
		//[XmlAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		//public string SchemaLocation = SysMng.Instance.getSession().ParamService.GetParameterClass<WorkPeriodParameters>().UblVersionNo.ToString();

		// Token: 0x040000ED RID: 237
		private UBLExtensionType[] uBLExtensionsField;

		// Token: 0x040000EE RID: 238
		private UBLVersionIDType uBLVersionIDField;

		// Token: 0x040000EF RID: 239
		private CustomizationIDType customizationIDField;

		// Token: 0x040000F0 RID: 240
		private ProfileIDType profileIDField;

		// Token: 0x040000F1 RID: 241
		private IDType idField;

		// Token: 0x040000F2 RID: 242
		private CopyIndicatorType copyIndicatorField;

		// Token: 0x040000F3 RID: 243
		private UUIDType uUIDField;

		// Token: 0x040000F4 RID: 244
		private IssueDateType issueDateField;

		// Token: 0x040000F5 RID: 245
		private IssueTimeType issueTimeField;

		// Token: 0x040000F6 RID: 246
		private InvoiceTypeCodeType invoiceTypeCodeField;

		// Token: 0x040000F7 RID: 247
		private NoteType[] noteField;

		// Token: 0x040000F8 RID: 248
		private DocumentCurrencyCodeType documentCurrencyCodeField;

		// Token: 0x040000F9 RID: 249
		private TaxCurrencyCodeType taxCurrencyCodeField;

		// Token: 0x040000FA RID: 250
		private PricingCurrencyCodeType pricingCurrencyCodeField;

		// Token: 0x040000FB RID: 251
		private PaymentCurrencyCodeType paymentCurrencyCodeField;

		// Token: 0x040000FC RID: 252
		private PaymentAlternativeCurrencyCodeType paymentAlternativeCurrencyCodeField;

		// Token: 0x040000FD RID: 253
		private AccountingCostType accountingCostField;

		// Token: 0x040000FE RID: 254
		private LineCountNumericType lineCountNumericField;

		// Token: 0x040000FF RID: 255
		private PeriodType invoicePeriodField;

		// Token: 0x04000100 RID: 256
		private OrderReferenceType orderReferenceField;

		// Token: 0x04000101 RID: 257
		private BillingReferenceType[] billingReferenceField;

		// Token: 0x04000102 RID: 258
		private DocumentReferenceType[] despatchDocumentReferenceField;

		// Token: 0x04000103 RID: 259
		private DocumentReferenceType[] receiptDocumentReferenceField;

		// Token: 0x04000104 RID: 260
		private DocumentReferenceType[] originatorDocumentReferenceField;

		// Token: 0x04000105 RID: 261
		private DocumentReferenceType[] contractDocumentReferenceField;

		// Token: 0x04000106 RID: 262
		private DocumentReferenceType[] additionalDocumentReferenceField;

		// Token: 0x04000107 RID: 263
		private SignatureType[] signatureField;

		// Token: 0x04000108 RID: 264
		private SupplierPartyType accountingSupplierPartyField;

		// Token: 0x04000109 RID: 265
		private CustomerPartyType accountingCustomerPartyField;

		// Token: 0x0400010A RID: 266
		private CustomerPartyType buyerCustomerPartyField;

		// Token: 0x0400010B RID: 267
		private SupplierPartyType sellerSupplierPartyField;

		// Token: 0x0400010C RID: 268
		private PartyType taxRepresentativePartyField;

		// Token: 0x0400010D RID: 269
		private DeliveryType[] deliveryField;

		// Token: 0x0400010E RID: 270
		private PaymentMeansType[] paymentMeansField;

		// Token: 0x0400010F RID: 271
		private PaymentTermsType paymentTermsField;

		// Token: 0x04000110 RID: 272
		private AllowanceChargeType[] allowanceChargeField;

		// Token: 0x04000111 RID: 273
		private ExchangeRateType taxExchangeRateField;

		// Token: 0x04000112 RID: 274
		private ExchangeRateType pricingExchangeRateField;

		// Token: 0x04000113 RID: 275
		private ExchangeRateType paymentExchangeRateField;

		// Token: 0x04000114 RID: 276
		private ExchangeRateType paymentAlternativeExchangeRateField;

		// Token: 0x04000115 RID: 277
		private TaxTotalType[] taxTotalField;

		// Token: 0x04000116 RID: 278
		private TaxTotalType[] withholdingTaxTotalField;

		// Token: 0x04000117 RID: 279
		private MonetaryTotalType legalMonetaryTotalField;

		// Token: 0x04000118 RID: 280
		private InvoiceLineType[] invoiceLineField;
	}
}

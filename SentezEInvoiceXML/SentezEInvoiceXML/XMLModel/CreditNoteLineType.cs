using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000456 RID: 1110
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("CreditNoteLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class CreditNoteLineType
	{
		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000F7B RID: 3963 RVA: 0x00007E49 File Offset: 0x00006049
		// (set) Token: 0x06000F7C RID: 3964 RVA: 0x00007E51 File Offset: 0x00006051
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

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000F7D RID: 3965 RVA: 0x00007E5A File Offset: 0x0000605A
		// (set) Token: 0x06000F7E RID: 3966 RVA: 0x00007E62 File Offset: 0x00006062
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

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000F7F RID: 3967 RVA: 0x00007E6B File Offset: 0x0000606B
		// (set) Token: 0x06000F80 RID: 3968 RVA: 0x00007E73 File Offset: 0x00006073
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

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000F81 RID: 3969 RVA: 0x00007E7C File Offset: 0x0000607C
		// (set) Token: 0x06000F82 RID: 3970 RVA: 0x00007E84 File Offset: 0x00006084
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CreditedQuantityType CreditedQuantity
		{
			get
			{
				return this.creditedQuantityField;
			}
			set
			{
				this.creditedQuantityField = value;
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000F83 RID: 3971 RVA: 0x00007E8D File Offset: 0x0000608D
		// (set) Token: 0x06000F84 RID: 3972 RVA: 0x00007E95 File Offset: 0x00006095
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LineExtensionAmountType LineExtensionAmount
		{
			get
			{
				return this.lineExtensionAmountField;
			}
			set
			{
				this.lineExtensionAmountField = value;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000F85 RID: 3973 RVA: 0x00007E9E File Offset: 0x0000609E
		// (set) Token: 0x06000F86 RID: 3974 RVA: 0x00007EA6 File Offset: 0x000060A6
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TaxPointDateType TaxPointDate
		{
			get
			{
				return this.taxPointDateField;
			}
			set
			{
				this.taxPointDateField = value;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000F87 RID: 3975 RVA: 0x00007EAF File Offset: 0x000060AF
		// (set) Token: 0x06000F88 RID: 3976 RVA: 0x00007EB7 File Offset: 0x000060B7
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AccountingCostCodeType AccountingCostCode
		{
			get
			{
				return this.accountingCostCodeField;
			}
			set
			{
				this.accountingCostCodeField = value;
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000F89 RID: 3977 RVA: 0x00007EC0 File Offset: 0x000060C0
		// (set) Token: 0x06000F8A RID: 3978 RVA: 0x00007EC8 File Offset: 0x000060C8
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

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000F8B RID: 3979 RVA: 0x00007ED1 File Offset: 0x000060D1
		// (set) Token: 0x06000F8C RID: 3980 RVA: 0x00007ED9 File Offset: 0x000060D9
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PaymentPurposeCodeType PaymentPurposeCode
		{
			get
			{
				return this.paymentPurposeCodeField;
			}
			set
			{
				this.paymentPurposeCodeField = value;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000F8D RID: 3981 RVA: 0x00007EE2 File Offset: 0x000060E2
		// (set) Token: 0x06000F8E RID: 3982 RVA: 0x00007EEA File Offset: 0x000060EA
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public FreeOfChargeIndicatorType FreeOfChargeIndicator
		{
			get
			{
				return this.freeOfChargeIndicatorField;
			}
			set
			{
				this.freeOfChargeIndicatorField = value;
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000F8F RID: 3983 RVA: 0x00007EF3 File Offset: 0x000060F3
		// (set) Token: 0x06000F90 RID: 3984 RVA: 0x00007EFB File Offset: 0x000060FB
		[XmlElement("InvoicePeriod")]
		public PeriodType[] InvoicePeriod
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

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000F91 RID: 3985 RVA: 0x00007F04 File Offset: 0x00006104
		// (set) Token: 0x06000F92 RID: 3986 RVA: 0x00007F0C File Offset: 0x0000610C
		[XmlElement("OrderLineReference")]
		public OrderLineReferenceType[] OrderLineReference
		{
			get
			{
				return this.orderLineReferenceField;
			}
			set
			{
				this.orderLineReferenceField = value;
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000F93 RID: 3987 RVA: 0x00007F15 File Offset: 0x00006115
		// (set) Token: 0x06000F94 RID: 3988 RVA: 0x00007F1D File Offset: 0x0000611D
		[XmlElement("DiscrepancyResponse")]
		public ResponseType[] DiscrepancyResponse
		{
			get
			{
				return this.discrepancyResponseField;
			}
			set
			{
				this.discrepancyResponseField = value;
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000F95 RID: 3989 RVA: 0x00007F26 File Offset: 0x00006126
		// (set) Token: 0x06000F96 RID: 3990 RVA: 0x00007F2E File Offset: 0x0000612E
		[XmlElement("DespatchLineReference")]
		public LineReferenceType[] DespatchLineReference
		{
			get
			{
				return this.despatchLineReferenceField;
			}
			set
			{
				this.despatchLineReferenceField = value;
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000F97 RID: 3991 RVA: 0x00007F37 File Offset: 0x00006137
		// (set) Token: 0x06000F98 RID: 3992 RVA: 0x00007F3F File Offset: 0x0000613F
		[XmlElement("ReceiptLineReference")]
		public LineReferenceType[] ReceiptLineReference
		{
			get
			{
				return this.receiptLineReferenceField;
			}
			set
			{
				this.receiptLineReferenceField = value;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000F99 RID: 3993 RVA: 0x00007F48 File Offset: 0x00006148
		// (set) Token: 0x06000F9A RID: 3994 RVA: 0x00007F50 File Offset: 0x00006150
		[XmlElement("BillingReference")]
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

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000F9B RID: 3995 RVA: 0x00007F59 File Offset: 0x00006159
		// (set) Token: 0x06000F9C RID: 3996 RVA: 0x00007F61 File Offset: 0x00006161
		[XmlElement("DocumentReference")]
		public DocumentReferenceType[] DocumentReference
		{
			get
			{
				return this.documentReferenceField;
			}
			set
			{
				this.documentReferenceField = value;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000F9D RID: 3997 RVA: 0x00007F6A File Offset: 0x0000616A
		// (set) Token: 0x06000F9E RID: 3998 RVA: 0x00007F72 File Offset: 0x00006172
		public PricingReferenceType PricingReference
		{
			get
			{
				return this.pricingReferenceField;
			}
			set
			{
				this.pricingReferenceField = value;
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000F9F RID: 3999 RVA: 0x00007F7B File Offset: 0x0000617B
		// (set) Token: 0x06000FA0 RID: 4000 RVA: 0x00007F83 File Offset: 0x00006183
		public PartyType OriginatorParty
		{
			get
			{
				return this.originatorPartyField;
			}
			set
			{
				this.originatorPartyField = value;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000FA1 RID: 4001 RVA: 0x00007F8C File Offset: 0x0000618C
		// (set) Token: 0x06000FA2 RID: 4002 RVA: 0x00007F94 File Offset: 0x00006194
		[XmlElement("Delivery")]
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

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x00007F9D File Offset: 0x0000619D
		// (set) Token: 0x06000FA4 RID: 4004 RVA: 0x00007FA5 File Offset: 0x000061A5
		[XmlElement("PaymentTerms")]
		public PaymentTermsType[] PaymentTerms
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

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000FA5 RID: 4005 RVA: 0x00007FAE File Offset: 0x000061AE
		// (set) Token: 0x06000FA6 RID: 4006 RVA: 0x00007FB6 File Offset: 0x000061B6
		[XmlElement("TaxTotal")]
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

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000FA7 RID: 4007 RVA: 0x00007FBF File Offset: 0x000061BF
		// (set) Token: 0x06000FA8 RID: 4008 RVA: 0x00007FC7 File Offset: 0x000061C7
		[XmlElement("AllowanceCharge")]
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

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x00007FD0 File Offset: 0x000061D0
		// (set) Token: 0x06000FAA RID: 4010 RVA: 0x00007FD8 File Offset: 0x000061D8
		public ItemType Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000FAB RID: 4011 RVA: 0x00007FE1 File Offset: 0x000061E1
		// (set) Token: 0x06000FAC RID: 4012 RVA: 0x00007FE9 File Offset: 0x000061E9
		public PriceType Price
		{
			get
			{
				return this.priceField;
			}
			set
			{
				this.priceField = value;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000FAD RID: 4013 RVA: 0x00007FF2 File Offset: 0x000061F2
		// (set) Token: 0x06000FAE RID: 4014 RVA: 0x00007FFA File Offset: 0x000061FA
		[XmlElement("DeliveryTerms")]
		public DeliveryTermsType[] DeliveryTerms
		{
			get
			{
				return this.deliveryTermsField;
			}
			set
			{
				this.deliveryTermsField = value;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000FAF RID: 4015 RVA: 0x00008003 File Offset: 0x00006203
		// (set) Token: 0x06000FB0 RID: 4016 RVA: 0x0000800B File Offset: 0x0000620B
		[XmlElement("SubCreditNoteLine")]
		public CreditNoteLineType[] SubCreditNoteLine
		{
			get
			{
				return this.subCreditNoteLineField;
			}
			set
			{
				this.subCreditNoteLineField = value;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x00008014 File Offset: 0x00006214
		// (set) Token: 0x06000FB2 RID: 4018 RVA: 0x0000801C File Offset: 0x0000621C
		public PriceExtensionType ItemPriceExtension
		{
			get
			{
				return this.itemPriceExtensionField;
			}
			set
			{
				this.itemPriceExtensionField = value;
			}
		}

		// Token: 0x040005B7 RID: 1463
		private IDType idField;

		// Token: 0x040005B8 RID: 1464
		private UUIDType uUIDField;

		// Token: 0x040005B9 RID: 1465
		private NoteType[] noteField;

		// Token: 0x040005BA RID: 1466
		private CreditedQuantityType creditedQuantityField;

		// Token: 0x040005BB RID: 1467
		private LineExtensionAmountType lineExtensionAmountField;

		// Token: 0x040005BC RID: 1468
		private TaxPointDateType taxPointDateField;

		// Token: 0x040005BD RID: 1469
		private AccountingCostCodeType accountingCostCodeField;

		// Token: 0x040005BE RID: 1470
		private AccountingCostType accountingCostField;

		// Token: 0x040005BF RID: 1471
		private PaymentPurposeCodeType paymentPurposeCodeField;

		// Token: 0x040005C0 RID: 1472
		private FreeOfChargeIndicatorType freeOfChargeIndicatorField;

		// Token: 0x040005C1 RID: 1473
		private PeriodType[] invoicePeriodField;

		// Token: 0x040005C2 RID: 1474
		private OrderLineReferenceType[] orderLineReferenceField;

		// Token: 0x040005C3 RID: 1475
		private ResponseType[] discrepancyResponseField;

		// Token: 0x040005C4 RID: 1476
		private LineReferenceType[] despatchLineReferenceField;

		// Token: 0x040005C5 RID: 1477
		private LineReferenceType[] receiptLineReferenceField;

		// Token: 0x040005C6 RID: 1478
		private BillingReferenceType[] billingReferenceField;

		// Token: 0x040005C7 RID: 1479
		private DocumentReferenceType[] documentReferenceField;

		// Token: 0x040005C8 RID: 1480
		private PricingReferenceType pricingReferenceField;

		// Token: 0x040005C9 RID: 1481
		private PartyType originatorPartyField;

		// Token: 0x040005CA RID: 1482
		private DeliveryType[] deliveryField;

		// Token: 0x040005CB RID: 1483
		private PaymentTermsType[] paymentTermsField;

		// Token: 0x040005CC RID: 1484
		private TaxTotalType[] taxTotalField;

		// Token: 0x040005CD RID: 1485
		private AllowanceChargeType[] allowanceChargeField;

		// Token: 0x040005CE RID: 1486
		private ItemType itemField;

		// Token: 0x040005CF RID: 1487
		private PriceType priceField;

		// Token: 0x040005D0 RID: 1488
		private DeliveryTermsType[] deliveryTermsField;

		// Token: 0x040005D1 RID: 1489
		private CreditNoteLineType[] subCreditNoteLineField;

		// Token: 0x040005D2 RID: 1490
		private PriceExtensionType itemPriceExtensionField;
	}
}

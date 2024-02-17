using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000457 RID: 1111
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("DebitNoteLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class DebitNoteLineType
	{
		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x00008025 File Offset: 0x00006225
		// (set) Token: 0x06000FB5 RID: 4021 RVA: 0x0000802D File Offset: 0x0000622D
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

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x00008036 File Offset: 0x00006236
		// (set) Token: 0x06000FB7 RID: 4023 RVA: 0x0000803E File Offset: 0x0000623E
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

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x00008047 File Offset: 0x00006247
		// (set) Token: 0x06000FB9 RID: 4025 RVA: 0x0000804F File Offset: 0x0000624F
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

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000FBA RID: 4026 RVA: 0x00008058 File Offset: 0x00006258
		// (set) Token: 0x06000FBB RID: 4027 RVA: 0x00008060 File Offset: 0x00006260
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DebitedQuantityType DebitedQuantity
		{
			get
			{
				return this.debitedQuantityField;
			}
			set
			{
				this.debitedQuantityField = value;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000FBC RID: 4028 RVA: 0x00008069 File Offset: 0x00006269
		// (set) Token: 0x06000FBD RID: 4029 RVA: 0x00008071 File Offset: 0x00006271
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

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000FBE RID: 4030 RVA: 0x0000807A File Offset: 0x0000627A
		// (set) Token: 0x06000FBF RID: 4031 RVA: 0x00008082 File Offset: 0x00006282
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

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x0000808B File Offset: 0x0000628B
		// (set) Token: 0x06000FC1 RID: 4033 RVA: 0x00008093 File Offset: 0x00006293
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

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x0000809C File Offset: 0x0000629C
		// (set) Token: 0x06000FC3 RID: 4035 RVA: 0x000080A4 File Offset: 0x000062A4
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

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x000080AD File Offset: 0x000062AD
		// (set) Token: 0x06000FC5 RID: 4037 RVA: 0x000080B5 File Offset: 0x000062B5
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

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000FC6 RID: 4038 RVA: 0x000080BE File Offset: 0x000062BE
		// (set) Token: 0x06000FC7 RID: 4039 RVA: 0x000080C6 File Offset: 0x000062C6
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

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x000080CF File Offset: 0x000062CF
		// (set) Token: 0x06000FC9 RID: 4041 RVA: 0x000080D7 File Offset: 0x000062D7
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

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x000080E0 File Offset: 0x000062E0
		// (set) Token: 0x06000FCB RID: 4043 RVA: 0x000080E8 File Offset: 0x000062E8
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

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x000080F1 File Offset: 0x000062F1
		// (set) Token: 0x06000FCD RID: 4045 RVA: 0x000080F9 File Offset: 0x000062F9
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

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x00008102 File Offset: 0x00006302
		// (set) Token: 0x06000FCF RID: 4047 RVA: 0x0000810A File Offset: 0x0000630A
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

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x00008113 File Offset: 0x00006313
		// (set) Token: 0x06000FD1 RID: 4049 RVA: 0x0000811B File Offset: 0x0000631B
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

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x00008124 File Offset: 0x00006324
		// (set) Token: 0x06000FD3 RID: 4051 RVA: 0x0000812C File Offset: 0x0000632C
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

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x00008135 File Offset: 0x00006335
		// (set) Token: 0x06000FD5 RID: 4053 RVA: 0x0000813D File Offset: 0x0000633D
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

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x00008146 File Offset: 0x00006346
		// (set) Token: 0x06000FD7 RID: 4055 RVA: 0x0000814E File Offset: 0x0000634E
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

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x00008157 File Offset: 0x00006357
		// (set) Token: 0x06000FD9 RID: 4057 RVA: 0x0000815F File Offset: 0x0000635F
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

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000FDA RID: 4058 RVA: 0x00008168 File Offset: 0x00006368
		// (set) Token: 0x06000FDB RID: 4059 RVA: 0x00008170 File Offset: 0x00006370
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

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x00008179 File Offset: 0x00006379
		// (set) Token: 0x06000FDD RID: 4061 RVA: 0x00008181 File Offset: 0x00006381
		[XmlElement("SubDebitNoteLine")]
		public DebitNoteLineType[] SubDebitNoteLine
		{
			get
			{
				return this.subDebitNoteLineField;
			}
			set
			{
				this.subDebitNoteLineField = value;
			}
		}

		// Token: 0x040005D3 RID: 1491
		private IDType idField;

		// Token: 0x040005D4 RID: 1492
		private UUIDType uUIDField;

		// Token: 0x040005D5 RID: 1493
		private NoteType[] noteField;

		// Token: 0x040005D6 RID: 1494
		private DebitedQuantityType debitedQuantityField;

		// Token: 0x040005D7 RID: 1495
		private LineExtensionAmountType lineExtensionAmountField;

		// Token: 0x040005D8 RID: 1496
		private TaxPointDateType taxPointDateField;

		// Token: 0x040005D9 RID: 1497
		private AccountingCostCodeType accountingCostCodeField;

		// Token: 0x040005DA RID: 1498
		private AccountingCostType accountingCostField;

		// Token: 0x040005DB RID: 1499
		private PaymentPurposeCodeType paymentPurposeCodeField;

		// Token: 0x040005DC RID: 1500
		private ResponseType[] discrepancyResponseField;

		// Token: 0x040005DD RID: 1501
		private LineReferenceType[] despatchLineReferenceField;

		// Token: 0x040005DE RID: 1502
		private LineReferenceType[] receiptLineReferenceField;

		// Token: 0x040005DF RID: 1503
		private BillingReferenceType[] billingReferenceField;

		// Token: 0x040005E0 RID: 1504
		private DocumentReferenceType[] documentReferenceField;

		// Token: 0x040005E1 RID: 1505
		private PricingReferenceType pricingReferenceField;

		// Token: 0x040005E2 RID: 1506
		private DeliveryType[] deliveryField;

		// Token: 0x040005E3 RID: 1507
		private TaxTotalType[] taxTotalField;

		// Token: 0x040005E4 RID: 1508
		private AllowanceChargeType[] allowanceChargeField;

		// Token: 0x040005E5 RID: 1509
		private ItemType itemField;

		// Token: 0x040005E6 RID: 1510
		private PriceType priceField;

		// Token: 0x040005E7 RID: 1511
		private DebitNoteLineType[] subDebitNoteLineField;
	}
}

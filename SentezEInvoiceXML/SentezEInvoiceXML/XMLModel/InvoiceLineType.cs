using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003DC RID: 988
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("InvoiceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class InvoiceLineType
	{
		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x000043D9 File Offset: 0x000025D9
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x000043E1 File Offset: 0x000025E1
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

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x000043EA File Offset: 0x000025EA
		// (set) Token: 0x06000824 RID: 2084 RVA: 0x000043F2 File Offset: 0x000025F2
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

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x000043FB File Offset: 0x000025FB
		// (set) Token: 0x06000826 RID: 2086 RVA: 0x00004403 File Offset: 0x00002603
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public InvoicedQuantityType InvoicedQuantity
		{
			get
			{
				return this.invoicedQuantityField;
			}
			set
			{
				this.invoicedQuantityField = value;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x0000440C File Offset: 0x0000260C
		// (set) Token: 0x06000828 RID: 2088 RVA: 0x00004414 File Offset: 0x00002614
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

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x0000441D File Offset: 0x0000261D
		// (set) Token: 0x0600082A RID: 2090 RVA: 0x00004425 File Offset: 0x00002625
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

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x0000442E File Offset: 0x0000262E
		// (set) Token: 0x0600082C RID: 2092 RVA: 0x00004436 File Offset: 0x00002636
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

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x0000443F File Offset: 0x0000263F
		// (set) Token: 0x0600082E RID: 2094 RVA: 0x00004447 File Offset: 0x00002647
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

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x00004450 File Offset: 0x00002650
		// (set) Token: 0x06000830 RID: 2096 RVA: 0x00004458 File Offset: 0x00002658
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

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x00004461 File Offset: 0x00002661
		// (set) Token: 0x06000832 RID: 2098 RVA: 0x00004469 File Offset: 0x00002669
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

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x00004472 File Offset: 0x00002672
		// (set) Token: 0x06000834 RID: 2100 RVA: 0x0000447A File Offset: 0x0000267A
		public TaxTotalType TaxTotal
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

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000835 RID: 2101 RVA: 0x00004483 File Offset: 0x00002683
		// (set) Token: 0x06000836 RID: 2102 RVA: 0x0000448B File Offset: 0x0000268B
		[XmlElement("WithholdingTaxTotal")]
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

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x00004494 File Offset: 0x00002694
		// (set) Token: 0x06000838 RID: 2104 RVA: 0x0000449C File Offset: 0x0000269C
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

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x000044A5 File Offset: 0x000026A5
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x000044AD File Offset: 0x000026AD
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

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x000044B6 File Offset: 0x000026B6
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x000044BE File Offset: 0x000026BE
		[XmlElement("SubInvoiceLine")]
		public InvoiceLineType[] SubInvoiceLine
		{
			get
			{
				return this.subInvoiceLineField;
			}
			set
			{
				this.subInvoiceLineField = value;
			}
		}

		// Token: 0x04000247 RID: 583
		private IDType idField;

		// Token: 0x04000248 RID: 584
		private NoteType[] noteField;

		// Token: 0x04000249 RID: 585
		private InvoicedQuantityType invoicedQuantityField;

		// Token: 0x0400024A RID: 586
		private LineExtensionAmountType lineExtensionAmountField;

		// Token: 0x0400024B RID: 587
		private OrderLineReferenceType[] orderLineReferenceField;

		// Token: 0x0400024C RID: 588
		private LineReferenceType[] despatchLineReferenceField;

		// Token: 0x0400024D RID: 589
		private LineReferenceType[] receiptLineReferenceField;

		// Token: 0x0400024E RID: 590
		private DeliveryType[] deliveryField;

		// Token: 0x0400024F RID: 591
		private AllowanceChargeType[] allowanceChargeField;

		// Token: 0x04000250 RID: 592
		private TaxTotalType taxTotalField;

		// Token: 0x04000251 RID: 593
		private TaxTotalType[] withholdingTaxTotalField;

		// Token: 0x04000252 RID: 594
		private ItemType itemField;

		// Token: 0x04000253 RID: 595
		private PriceType priceField;

		// Token: 0x04000254 RID: 596
		private InvoiceLineType[] subInvoiceLineField;
	}
}

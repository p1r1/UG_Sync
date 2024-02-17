using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003FC RID: 1020
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("SalesItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class SalesItemType
	{
		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x000050CC File Offset: 0x000032CC
		// (set) Token: 0x060009C8 RID: 2504 RVA: 0x000050D4 File Offset: 0x000032D4
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType2 Quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x000050DD File Offset: 0x000032DD
		// (set) Token: 0x060009CA RID: 2506 RVA: 0x000050E5 File Offset: 0x000032E5
		[XmlElement("ActivityProperty")]
		public ActivityPropertyType[] ActivityProperty
		{
			get
			{
				return this.activityPropertyField;
			}
			set
			{
				this.activityPropertyField = value;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x000050EE File Offset: 0x000032EE
		// (set) Token: 0x060009CC RID: 2508 RVA: 0x000050F6 File Offset: 0x000032F6
		[XmlElement("TaxExclusivePrice")]
		public PriceType[] TaxExclusivePrice
		{
			get
			{
				return this.taxExclusivePriceField;
			}
			set
			{
				this.taxExclusivePriceField = value;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x000050FF File Offset: 0x000032FF
		// (set) Token: 0x060009CE RID: 2510 RVA: 0x00005107 File Offset: 0x00003307
		[XmlElement("TaxInclusivePrice")]
		public PriceType[] TaxInclusivePrice
		{
			get
			{
				return this.taxInclusivePriceField;
			}
			set
			{
				this.taxInclusivePriceField = value;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x00005110 File Offset: 0x00003310
		// (set) Token: 0x060009D0 RID: 2512 RVA: 0x00005118 File Offset: 0x00003318
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

		// Token: 0x0400030A RID: 778
		private QuantityType2 quantityField;

		// Token: 0x0400030B RID: 779
		private ActivityPropertyType[] activityPropertyField;

		// Token: 0x0400030C RID: 780
		private PriceType[] taxExclusivePriceField;

		// Token: 0x0400030D RID: 781
		private PriceType[] taxInclusivePriceField;

		// Token: 0x0400030E RID: 782
		private ItemType itemField;
	}
}

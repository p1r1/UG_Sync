using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000411 RID: 1041
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("PricingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class PricingReferenceType
	{
		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x00005A29 File Offset: 0x00003C29
		// (set) Token: 0x06000AF7 RID: 2807 RVA: 0x00005A31 File Offset: 0x00003C31
		public ItemLocationQuantityType OriginalItemLocationQuantity
		{
			get
			{
				return this.originalItemLocationQuantityField;
			}
			set
			{
				this.originalItemLocationQuantityField = value;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x00005A3A File Offset: 0x00003C3A
		// (set) Token: 0x06000AF9 RID: 2809 RVA: 0x00005A42 File Offset: 0x00003C42
		[XmlElement("AlternativeConditionPrice")]
		public PriceType[] AlternativeConditionPrice
		{
			get
			{
				return this.alternativeConditionPriceField;
			}
			set
			{
				this.alternativeConditionPriceField = value;
			}
		}

		// Token: 0x04000397 RID: 919
		private ItemLocationQuantityType originalItemLocationQuantityField;

		// Token: 0x04000398 RID: 920
		private PriceType[] alternativeConditionPriceField;
	}
}

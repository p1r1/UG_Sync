using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003EF RID: 1007
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("AlternativeConditionPrice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class PriceType
	{
		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x00004C59 File Offset: 0x00002E59
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x00004C61 File Offset: 0x00002E61
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PriceAmountType PriceAmount
		{
			get
			{
				return this.priceAmountField;
			}
			set
			{
				this.priceAmountField = value;
			}
		}

		// Token: 0x040002C7 RID: 711
		private PriceAmountType priceAmountField;
	}
}

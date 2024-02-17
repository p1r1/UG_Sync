using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000415 RID: 1045
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ItemPriceExtension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class PriceExtensionType
	{
		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000B22 RID: 2850 RVA: 0x00005B7D File Offset: 0x00003D7D
		// (set) Token: 0x06000B23 RID: 2851 RVA: 0x00005B85 File Offset: 0x00003D85
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AmountType2 Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000B24 RID: 2852 RVA: 0x00005B8E File Offset: 0x00003D8E
		// (set) Token: 0x06000B25 RID: 2853 RVA: 0x00005B96 File Offset: 0x00003D96
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

		// Token: 0x040003AB RID: 939
		private AmountType2 amountField;

		// Token: 0x040003AC RID: 940
		private TaxTotalType[] taxTotalField;
	}
}

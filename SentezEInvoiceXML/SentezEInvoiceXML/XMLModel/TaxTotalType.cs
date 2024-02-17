using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003EC RID: 1004
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class TaxTotalType
	{
		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x00004B6B File Offset: 0x00002D6B
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x00004B73 File Offset: 0x00002D73
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TaxAmountType TaxAmount
		{
			get
			{
				return this.taxAmountField;
			}
			set
			{
				this.taxAmountField = value;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x00004B7C File Offset: 0x00002D7C
		// (set) Token: 0x06000918 RID: 2328 RVA: 0x00004B84 File Offset: 0x00002D84
		[XmlElement("TaxSubtotal")]
		public TaxSubtotalType[] TaxSubtotal
		{
			get
			{
				return this.taxSubtotalField;
			}
			set
			{
				this.taxSubtotalField = value;
			}
		}

		// Token: 0x040002B9 RID: 697
		private TaxAmountType taxAmountField;

		// Token: 0x040002BA RID: 698
		private TaxSubtotalType[] taxSubtotalField;
	}
}

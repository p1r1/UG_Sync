using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200047F RID: 1151
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("PromotionalEventLineItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class PromotionalEventLineItemType
	{
		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x0600120E RID: 4622 RVA: 0x000092CE File Offset: 0x000074CE
		// (set) Token: 0x0600120F RID: 4623 RVA: 0x000092D6 File Offset: 0x000074D6
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

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001210 RID: 4624 RVA: 0x000092DF File Offset: 0x000074DF
		// (set) Token: 0x06001211 RID: 4625 RVA: 0x000092E7 File Offset: 0x000074E7
		public EventLineItemType EventLineItem
		{
			get
			{
				return this.eventLineItemField;
			}
			set
			{
				this.eventLineItemField = value;
			}
		}

		// Token: 0x040006EC RID: 1772
		private AmountType2 amountField;

		// Token: 0x040006ED RID: 1773
		private EventLineItemType eventLineItemField;
	}
}

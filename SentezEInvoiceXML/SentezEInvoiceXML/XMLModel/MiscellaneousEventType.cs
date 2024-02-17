using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000472 RID: 1138
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("MiscellaneousEvent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class MiscellaneousEventType
	{
		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x0600116F RID: 4463 RVA: 0x00008DF5 File Offset: 0x00006FF5
		// (set) Token: 0x06001170 RID: 4464 RVA: 0x00008DFD File Offset: 0x00006FFD
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MiscellaneousEventTypeCodeType MiscellaneousEventTypeCode
		{
			get
			{
				return this.miscellaneousEventTypeCodeField;
			}
			set
			{
				this.miscellaneousEventTypeCodeField = value;
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001171 RID: 4465 RVA: 0x00008E06 File Offset: 0x00007006
		// (set) Token: 0x06001172 RID: 4466 RVA: 0x00008E0E File Offset: 0x0000700E
		[XmlElement("EventLineItem")]
		public EventLineItemType[] EventLineItem
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

		// Token: 0x040006A3 RID: 1699
		private MiscellaneousEventTypeCodeType miscellaneousEventTypeCodeField;

		// Token: 0x040006A4 RID: 1700
		private EventLineItemType[] eventLineItemField;
	}
}

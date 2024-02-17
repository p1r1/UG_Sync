using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200040C RID: 1036
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ScheduledServiceFrequency", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ServiceFrequencyType
	{
		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x0000574E File Offset: 0x0000394E
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x00005756 File Offset: 0x00003956
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public WeekDayCodeType WeekDayCode
		{
			get
			{
				return this.weekDayCodeField;
			}
			set
			{
				this.weekDayCodeField = value;
			}
		}

		// Token: 0x0400036C RID: 876
		private WeekDayCodeType weekDayCodeField;
	}
}

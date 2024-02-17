using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000444 RID: 1092
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ConsumptionAverage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ConsumptionAverageType
	{
		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x00007530 File Offset: 0x00005730
		// (set) Token: 0x06000E58 RID: 3672 RVA: 0x00007538 File Offset: 0x00005738
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AverageAmountType AverageAmount
		{
			get
			{
				return this.averageAmountField;
			}
			set
			{
				this.averageAmountField = value;
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000E59 RID: 3673 RVA: 0x00007541 File Offset: 0x00005741
		// (set) Token: 0x06000E5A RID: 3674 RVA: 0x00007549 File Offset: 0x00005749
		[XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DescriptionType[] Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		// Token: 0x0400052E RID: 1326
		private AverageAmountType averageAmountField;

		// Token: 0x0400052F RID: 1327
		private DescriptionType[] descriptionField;
	}
}

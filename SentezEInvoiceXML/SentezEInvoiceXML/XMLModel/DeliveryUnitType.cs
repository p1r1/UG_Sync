using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000413 RID: 1043
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("DeliveryUnit", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class DeliveryUnitType
	{
		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x00005B17 File Offset: 0x00003D17
		// (set) Token: 0x06000B15 RID: 2837 RVA: 0x00005B1F File Offset: 0x00003D1F
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public BatchQuantityType BatchQuantity
		{
			get
			{
				return this.batchQuantityField;
			}
			set
			{
				this.batchQuantityField = value;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x00005B28 File Offset: 0x00003D28
		// (set) Token: 0x06000B17 RID: 2839 RVA: 0x00005B30 File Offset: 0x00003D30
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ConsumerUnitQuantityType ConsumerUnitQuantity
		{
			get
			{
				return this.consumerUnitQuantityField;
			}
			set
			{
				this.consumerUnitQuantityField = value;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x00005B39 File Offset: 0x00003D39
		// (set) Token: 0x06000B19 RID: 2841 RVA: 0x00005B41 File Offset: 0x00003D41
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public HazardousRiskIndicatorType HazardousRiskIndicator
		{
			get
			{
				return this.hazardousRiskIndicatorField;
			}
			set
			{
				this.hazardousRiskIndicatorField = value;
			}
		}

		// Token: 0x040003A5 RID: 933
		private BatchQuantityType batchQuantityField;

		// Token: 0x040003A6 RID: 934
		private ConsumerUnitQuantityType consumerUnitQuantityField;

		// Token: 0x040003A7 RID: 935
		private HazardousRiskIndicatorType hazardousRiskIndicatorField;
	}
}

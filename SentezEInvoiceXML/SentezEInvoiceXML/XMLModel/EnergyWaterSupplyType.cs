using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200043F RID: 1087
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("EnergyWaterSupply", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class EnergyWaterSupplyType
	{
		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000E06 RID: 3590 RVA: 0x000072AA File Offset: 0x000054AA
		// (set) Token: 0x06000E07 RID: 3591 RVA: 0x000072B2 File Offset: 0x000054B2
		[XmlElement("ConsumptionReport")]
		public ConsumptionReportType[] ConsumptionReport
		{
			get
			{
				return this.consumptionReportField;
			}
			set
			{
				this.consumptionReportField = value;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000E08 RID: 3592 RVA: 0x000072BB File Offset: 0x000054BB
		// (set) Token: 0x06000E09 RID: 3593 RVA: 0x000072C3 File Offset: 0x000054C3
		[XmlElement("EnergyTaxReport")]
		public EnergyTaxReportType[] EnergyTaxReport
		{
			get
			{
				return this.energyTaxReportField;
			}
			set
			{
				this.energyTaxReportField = value;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000E0A RID: 3594 RVA: 0x000072CC File Offset: 0x000054CC
		// (set) Token: 0x06000E0B RID: 3595 RVA: 0x000072D4 File Offset: 0x000054D4
		[XmlElement("ConsumptionAverage")]
		public ConsumptionAverageType[] ConsumptionAverage
		{
			get
			{
				return this.consumptionAverageField;
			}
			set
			{
				this.consumptionAverageField = value;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000E0C RID: 3596 RVA: 0x000072DD File Offset: 0x000054DD
		// (set) Token: 0x06000E0D RID: 3597 RVA: 0x000072E5 File Offset: 0x000054E5
		[XmlElement("EnergyWaterConsumptionCorrection")]
		public ConsumptionCorrectionType[] EnergyWaterConsumptionCorrection
		{
			get
			{
				return this.energyWaterConsumptionCorrectionField;
			}
			set
			{
				this.energyWaterConsumptionCorrectionField = value;
			}
		}

		// Token: 0x04000508 RID: 1288
		private ConsumptionReportType[] consumptionReportField;

		// Token: 0x04000509 RID: 1289
		private EnergyTaxReportType[] energyTaxReportField;

		// Token: 0x0400050A RID: 1290
		private ConsumptionAverageType[] consumptionAverageField;

		// Token: 0x0400050B RID: 1291
		private ConsumptionCorrectionType[] energyWaterConsumptionCorrectionField;
	}
}

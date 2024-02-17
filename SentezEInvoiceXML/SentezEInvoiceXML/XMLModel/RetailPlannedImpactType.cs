using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200045E RID: 1118
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("RetailPlannedImpact", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class RetailPlannedImpactType
	{
		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x0600102D RID: 4141 RVA: 0x000083EE File Offset: 0x000065EE
		// (set) Token: 0x0600102E RID: 4142 RVA: 0x000083F6 File Offset: 0x000065F6
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

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x0600102F RID: 4143 RVA: 0x000083FF File Offset: 0x000065FF
		// (set) Token: 0x06001030 RID: 4144 RVA: 0x00008407 File Offset: 0x00006607
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ForecastPurposeCodeType ForecastPurposeCode
		{
			get
			{
				return this.forecastPurposeCodeField;
			}
			set
			{
				this.forecastPurposeCodeField = value;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x00008410 File Offset: 0x00006610
		// (set) Token: 0x06001032 RID: 4146 RVA: 0x00008418 File Offset: 0x00006618
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ForecastTypeCodeType ForecastTypeCode
		{
			get
			{
				return this.forecastTypeCodeField;
			}
			set
			{
				this.forecastTypeCodeField = value;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001033 RID: 4147 RVA: 0x00008421 File Offset: 0x00006621
		// (set) Token: 0x06001034 RID: 4148 RVA: 0x00008429 File Offset: 0x00006629
		public PeriodType Period
		{
			get
			{
				return this.periodField;
			}
			set
			{
				this.periodField = value;
			}
		}

		// Token: 0x0400060C RID: 1548
		private AmountType2 amountField;

		// Token: 0x0400060D RID: 1549
		private ForecastPurposeCodeType forecastPurposeCodeField;

		// Token: 0x0400060E RID: 1550
		private ForecastTypeCodeType forecastTypeCodeField;

		// Token: 0x0400060F RID: 1551
		private PeriodType periodField;
	}
}

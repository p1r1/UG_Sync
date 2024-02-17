using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000467 RID: 1127
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("FrameworkAgreement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class FrameworkAgreementType
	{
		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x060010BC RID: 4284 RVA: 0x00008861 File Offset: 0x00006A61
		// (set) Token: 0x060010BD RID: 4285 RVA: 0x00008869 File Offset: 0x00006A69
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ExpectedOperatorQuantityType ExpectedOperatorQuantity
		{
			get
			{
				return this.expectedOperatorQuantityField;
			}
			set
			{
				this.expectedOperatorQuantityField = value;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x060010BE RID: 4286 RVA: 0x00008872 File Offset: 0x00006A72
		// (set) Token: 0x060010BF RID: 4287 RVA: 0x0000887A File Offset: 0x00006A7A
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MaximumOperatorQuantityType MaximumOperatorQuantity
		{
			get
			{
				return this.maximumOperatorQuantityField;
			}
			set
			{
				this.maximumOperatorQuantityField = value;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x060010C0 RID: 4288 RVA: 0x00008883 File Offset: 0x00006A83
		// (set) Token: 0x060010C1 RID: 4289 RVA: 0x0000888B File Offset: 0x00006A8B
		[XmlElement("Justification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public JustificationType[] Justification
		{
			get
			{
				return this.justificationField;
			}
			set
			{
				this.justificationField = value;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x060010C2 RID: 4290 RVA: 0x00008894 File Offset: 0x00006A94
		// (set) Token: 0x060010C3 RID: 4291 RVA: 0x0000889C File Offset: 0x00006A9C
		[XmlElement("Frequency", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public FrequencyType[] Frequency
		{
			get
			{
				return this.frequencyField;
			}
			set
			{
				this.frequencyField = value;
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x060010C4 RID: 4292 RVA: 0x000088A5 File Offset: 0x00006AA5
		// (set) Token: 0x060010C5 RID: 4293 RVA: 0x000088AD File Offset: 0x00006AAD
		public PeriodType DurationPeriod
		{
			get
			{
				return this.durationPeriodField;
			}
			set
			{
				this.durationPeriodField = value;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x060010C6 RID: 4294 RVA: 0x000088B6 File Offset: 0x00006AB6
		// (set) Token: 0x060010C7 RID: 4295 RVA: 0x000088BE File Offset: 0x00006ABE
		[XmlElement("SubsequentProcessTenderRequirement")]
		public TenderRequirementType[] SubsequentProcessTenderRequirement
		{
			get
			{
				return this.subsequentProcessTenderRequirementField;
			}
			set
			{
				this.subsequentProcessTenderRequirementField = value;
			}
		}

		// Token: 0x0400064F RID: 1615
		private ExpectedOperatorQuantityType expectedOperatorQuantityField;

		// Token: 0x04000650 RID: 1616
		private MaximumOperatorQuantityType maximumOperatorQuantityField;

		// Token: 0x04000651 RID: 1617
		private JustificationType[] justificationField;

		// Token: 0x04000652 RID: 1618
		private FrequencyType[] frequencyField;

		// Token: 0x04000653 RID: 1619
		private PeriodType durationPeriodField;

		// Token: 0x04000654 RID: 1620
		private TenderRequirementType[] subsequentProcessTenderRequirementField;
	}
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200041F RID: 1055
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("EvaluationCriterion", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class EvaluationCriterionType
	{
		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x00006199 File Offset: 0x00004399
		// (set) Token: 0x06000BE5 RID: 3045 RVA: 0x000061A1 File Offset: 0x000043A1
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public EvaluationCriterionTypeCodeType EvaluationCriterionTypeCode
		{
			get
			{
				return this.evaluationCriterionTypeCodeField;
			}
			set
			{
				this.evaluationCriterionTypeCodeField = value;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x000061AA File Offset: 0x000043AA
		// (set) Token: 0x06000BE7 RID: 3047 RVA: 0x000061B2 File Offset: 0x000043B2
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

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x000061BB File Offset: 0x000043BB
		// (set) Token: 0x06000BE9 RID: 3049 RVA: 0x000061C3 File Offset: 0x000043C3
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ThresholdAmountType ThresholdAmount
		{
			get
			{
				return this.thresholdAmountField;
			}
			set
			{
				this.thresholdAmountField = value;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x000061CC File Offset: 0x000043CC
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x000061D4 File Offset: 0x000043D4
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ThresholdQuantityType ThresholdQuantity
		{
			get
			{
				return this.thresholdQuantityField;
			}
			set
			{
				this.thresholdQuantityField = value;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x000061DD File Offset: 0x000043DD
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x000061E5 File Offset: 0x000043E5
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ExpressionCodeType ExpressionCode
		{
			get
			{
				return this.expressionCodeField;
			}
			set
			{
				this.expressionCodeField = value;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x000061EE File Offset: 0x000043EE
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x000061F6 File Offset: 0x000043F6
		[XmlElement("Expression", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ExpressionType[] Expression
		{
			get
			{
				return this.expressionField;
			}
			set
			{
				this.expressionField = value;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x000061FF File Offset: 0x000043FF
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x00006207 File Offset: 0x00004407
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

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x00006210 File Offset: 0x00004410
		// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x00006218 File Offset: 0x00004418
		[XmlElement("SuggestedEvidence")]
		public EvidenceType[] SuggestedEvidence
		{
			get
			{
				return this.suggestedEvidenceField;
			}
			set
			{
				this.suggestedEvidenceField = value;
			}
		}

		// Token: 0x04000407 RID: 1031
		private EvaluationCriterionTypeCodeType evaluationCriterionTypeCodeField;

		// Token: 0x04000408 RID: 1032
		private DescriptionType[] descriptionField;

		// Token: 0x04000409 RID: 1033
		private ThresholdAmountType thresholdAmountField;

		// Token: 0x0400040A RID: 1034
		private ThresholdQuantityType thresholdQuantityField;

		// Token: 0x0400040B RID: 1035
		private ExpressionCodeType expressionCodeField;

		// Token: 0x0400040C RID: 1036
		private ExpressionType[] expressionField;

		// Token: 0x0400040D RID: 1037
		private PeriodType durationPeriodField;

		// Token: 0x0400040E RID: 1038
		private EvidenceType[] suggestedEvidenceField;
	}
}

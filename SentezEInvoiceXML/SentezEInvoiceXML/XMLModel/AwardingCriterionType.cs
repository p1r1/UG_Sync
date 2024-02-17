using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000427 RID: 1063
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("AwardingCriterion", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class AwardingCriterionType
	{
		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x000064A7 File Offset: 0x000046A7
		// (set) Token: 0x06000C49 RID: 3145 RVA: 0x000064AF File Offset: 0x000046AF
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IDType ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000C4A RID: 3146 RVA: 0x000064B8 File Offset: 0x000046B8
		// (set) Token: 0x06000C4B RID: 3147 RVA: 0x000064C0 File Offset: 0x000046C0
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AwardingCriterionTypeCodeType AwardingCriterionTypeCode
		{
			get
			{
				return this.awardingCriterionTypeCodeField;
			}
			set
			{
				this.awardingCriterionTypeCodeField = value;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000C4C RID: 3148 RVA: 0x000064C9 File Offset: 0x000046C9
		// (set) Token: 0x06000C4D RID: 3149 RVA: 0x000064D1 File Offset: 0x000046D1
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

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000C4E RID: 3150 RVA: 0x000064DA File Offset: 0x000046DA
		// (set) Token: 0x06000C4F RID: 3151 RVA: 0x000064E2 File Offset: 0x000046E2
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public WeightNumericType WeightNumeric
		{
			get
			{
				return this.weightNumericField;
			}
			set
			{
				this.weightNumericField = value;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000C50 RID: 3152 RVA: 0x000064EB File Offset: 0x000046EB
		// (set) Token: 0x06000C51 RID: 3153 RVA: 0x000064F3 File Offset: 0x000046F3
		[XmlElement("Weight", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public WeightType[] Weight
		{
			get
			{
				return this.weightField;
			}
			set
			{
				this.weightField = value;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x000064FC File Offset: 0x000046FC
		// (set) Token: 0x06000C53 RID: 3155 RVA: 0x00006504 File Offset: 0x00004704
		[XmlElement("CalculationExpression", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CalculationExpressionType[] CalculationExpression
		{
			get
			{
				return this.calculationExpressionField;
			}
			set
			{
				this.calculationExpressionField = value;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x0000650D File Offset: 0x0000470D
		// (set) Token: 0x06000C55 RID: 3157 RVA: 0x00006515 File Offset: 0x00004715
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CalculationExpressionCodeType CalculationExpressionCode
		{
			get
			{
				return this.calculationExpressionCodeField;
			}
			set
			{
				this.calculationExpressionCodeField = value;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x0000651E File Offset: 0x0000471E
		// (set) Token: 0x06000C57 RID: 3159 RVA: 0x00006526 File Offset: 0x00004726
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MinimumQuantityType MinimumQuantity
		{
			get
			{
				return this.minimumQuantityField;
			}
			set
			{
				this.minimumQuantityField = value;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x0000652F File Offset: 0x0000472F
		// (set) Token: 0x06000C59 RID: 3161 RVA: 0x00006537 File Offset: 0x00004737
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MaximumQuantityType MaximumQuantity
		{
			get
			{
				return this.maximumQuantityField;
			}
			set
			{
				this.maximumQuantityField = value;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x00006540 File Offset: 0x00004740
		// (set) Token: 0x06000C5B RID: 3163 RVA: 0x00006548 File Offset: 0x00004748
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MinimumAmountType MinimumAmount
		{
			get
			{
				return this.minimumAmountField;
			}
			set
			{
				this.minimumAmountField = value;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x00006551 File Offset: 0x00004751
		// (set) Token: 0x06000C5D RID: 3165 RVA: 0x00006559 File Offset: 0x00004759
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MaximumAmountType MaximumAmount
		{
			get
			{
				return this.maximumAmountField;
			}
			set
			{
				this.maximumAmountField = value;
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000C5E RID: 3166 RVA: 0x00006562 File Offset: 0x00004762
		// (set) Token: 0x06000C5F RID: 3167 RVA: 0x0000656A File Offset: 0x0000476A
		[XmlElement("MinimumImprovementBid", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MinimumImprovementBidType[] MinimumImprovementBid
		{
			get
			{
				return this.minimumImprovementBidField;
			}
			set
			{
				this.minimumImprovementBidField = value;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x00006573 File Offset: 0x00004773
		// (set) Token: 0x06000C61 RID: 3169 RVA: 0x0000657B File Offset: 0x0000477B
		[XmlElement("SubordinateAwardingCriterion")]
		public AwardingCriterionType[] SubordinateAwardingCriterion
		{
			get
			{
				return this.subordinateAwardingCriterionField;
			}
			set
			{
				this.subordinateAwardingCriterionField = value;
			}
		}

		// Token: 0x04000435 RID: 1077
		private IDType idField;

		// Token: 0x04000436 RID: 1078
		private AwardingCriterionTypeCodeType awardingCriterionTypeCodeField;

		// Token: 0x04000437 RID: 1079
		private DescriptionType[] descriptionField;

		// Token: 0x04000438 RID: 1080
		private WeightNumericType weightNumericField;

		// Token: 0x04000439 RID: 1081
		private WeightType[] weightField;

		// Token: 0x0400043A RID: 1082
		private CalculationExpressionType[] calculationExpressionField;

		// Token: 0x0400043B RID: 1083
		private CalculationExpressionCodeType calculationExpressionCodeField;

		// Token: 0x0400043C RID: 1084
		private MinimumQuantityType minimumQuantityField;

		// Token: 0x0400043D RID: 1085
		private MaximumQuantityType maximumQuantityField;

		// Token: 0x0400043E RID: 1086
		private MinimumAmountType minimumAmountField;

		// Token: 0x0400043F RID: 1087
		private MaximumAmountType maximumAmountField;

		// Token: 0x04000440 RID: 1088
		private MinimumImprovementBidType[] minimumImprovementBidField;

		// Token: 0x04000441 RID: 1089
		private AwardingCriterionType[] subordinateAwardingCriterionField;
	}
}

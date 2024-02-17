using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000426 RID: 1062
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("AwardingTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class AwardingTermsType
	{
		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x000063EC File Offset: 0x000045EC
		// (set) Token: 0x06000C32 RID: 3122 RVA: 0x000063F4 File Offset: 0x000045F4
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public WeightingAlgorithmCodeType WeightingAlgorithmCode
		{
			get
			{
				return this.weightingAlgorithmCodeField;
			}
			set
			{
				this.weightingAlgorithmCodeField = value;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x000063FD File Offset: 0x000045FD
		// (set) Token: 0x06000C34 RID: 3124 RVA: 0x00006405 File Offset: 0x00004605
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

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x0000640E File Offset: 0x0000460E
		// (set) Token: 0x06000C36 RID: 3126 RVA: 0x00006416 File Offset: 0x00004616
		[XmlElement("TechnicalCommitteeDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TechnicalCommitteeDescriptionType[] TechnicalCommitteeDescription
		{
			get
			{
				return this.technicalCommitteeDescriptionField;
			}
			set
			{
				this.technicalCommitteeDescriptionField = value;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x0000641F File Offset: 0x0000461F
		// (set) Token: 0x06000C38 RID: 3128 RVA: 0x00006427 File Offset: 0x00004627
		[XmlElement("LowTendersDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LowTendersDescriptionType[] LowTendersDescription
		{
			get
			{
				return this.lowTendersDescriptionField;
			}
			set
			{
				this.lowTendersDescriptionField = value;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000C39 RID: 3129 RVA: 0x00006430 File Offset: 0x00004630
		// (set) Token: 0x06000C3A RID: 3130 RVA: 0x00006438 File Offset: 0x00004638
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PrizeIndicatorType PrizeIndicator
		{
			get
			{
				return this.prizeIndicatorField;
			}
			set
			{
				this.prizeIndicatorField = value;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000C3B RID: 3131 RVA: 0x00006441 File Offset: 0x00004641
		// (set) Token: 0x06000C3C RID: 3132 RVA: 0x00006449 File Offset: 0x00004649
		[XmlElement("PrizeDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PrizeDescriptionType[] PrizeDescription
		{
			get
			{
				return this.prizeDescriptionField;
			}
			set
			{
				this.prizeDescriptionField = value;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000C3D RID: 3133 RVA: 0x00006452 File Offset: 0x00004652
		// (set) Token: 0x06000C3E RID: 3134 RVA: 0x0000645A File Offset: 0x0000465A
		[XmlElement("PaymentDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PaymentDescriptionType[] PaymentDescription
		{
			get
			{
				return this.paymentDescriptionField;
			}
			set
			{
				this.paymentDescriptionField = value;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x00006463 File Offset: 0x00004663
		// (set) Token: 0x06000C40 RID: 3136 RVA: 0x0000646B File Offset: 0x0000466B
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public FollowupContractIndicatorType FollowupContractIndicator
		{
			get
			{
				return this.followupContractIndicatorField;
			}
			set
			{
				this.followupContractIndicatorField = value;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000C41 RID: 3137 RVA: 0x00006474 File Offset: 0x00004674
		// (set) Token: 0x06000C42 RID: 3138 RVA: 0x0000647C File Offset: 0x0000467C
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public BindingOnBuyerIndicatorType BindingOnBuyerIndicator
		{
			get
			{
				return this.bindingOnBuyerIndicatorField;
			}
			set
			{
				this.bindingOnBuyerIndicatorField = value;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x00006485 File Offset: 0x00004685
		// (set) Token: 0x06000C44 RID: 3140 RVA: 0x0000648D File Offset: 0x0000468D
		[XmlElement("AwardingCriterion")]
		public AwardingCriterionType[] AwardingCriterion
		{
			get
			{
				return this.awardingCriterionField;
			}
			set
			{
				this.awardingCriterionField = value;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000C45 RID: 3141 RVA: 0x00006496 File Offset: 0x00004696
		// (set) Token: 0x06000C46 RID: 3142 RVA: 0x0000649E File Offset: 0x0000469E
		[XmlElement("TechnicalCommitteePerson")]
		public PersonType[] TechnicalCommitteePerson
		{
			get
			{
				return this.technicalCommitteePersonField;
			}
			set
			{
				this.technicalCommitteePersonField = value;
			}
		}

		// Token: 0x0400042A RID: 1066
		private WeightingAlgorithmCodeType weightingAlgorithmCodeField;

		// Token: 0x0400042B RID: 1067
		private DescriptionType[] descriptionField;

		// Token: 0x0400042C RID: 1068
		private TechnicalCommitteeDescriptionType[] technicalCommitteeDescriptionField;

		// Token: 0x0400042D RID: 1069
		private LowTendersDescriptionType[] lowTendersDescriptionField;

		// Token: 0x0400042E RID: 1070
		private PrizeIndicatorType prizeIndicatorField;

		// Token: 0x0400042F RID: 1071
		private PrizeDescriptionType[] prizeDescriptionField;

		// Token: 0x04000430 RID: 1072
		private PaymentDescriptionType[] paymentDescriptionField;

		// Token: 0x04000431 RID: 1073
		private FollowupContractIndicatorType followupContractIndicatorField;

		// Token: 0x04000432 RID: 1074
		private BindingOnBuyerIndicatorType bindingOnBuyerIndicatorField;

		// Token: 0x04000433 RID: 1075
		private AwardingCriterionType[] awardingCriterionField;

		// Token: 0x04000434 RID: 1076
		private PersonType[] technicalCommitteePersonField;
	}
}

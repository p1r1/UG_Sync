using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200041B RID: 1051
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("TenderingTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class TenderingTermsType
	{
		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x00005D8C File Offset: 0x00003F8C
		// (set) Token: 0x06000B67 RID: 2919 RVA: 0x00005D94 File Offset: 0x00003F94
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AwardingMethodTypeCodeType AwardingMethodTypeCode
		{
			get
			{
				return this.awardingMethodTypeCodeField;
			}
			set
			{
				this.awardingMethodTypeCodeField = value;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x00005D9D File Offset: 0x00003F9D
		// (set) Token: 0x06000B69 RID: 2921 RVA: 0x00005DA5 File Offset: 0x00003FA5
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PriceEvaluationCodeType PriceEvaluationCode
		{
			get
			{
				return this.priceEvaluationCodeField;
			}
			set
			{
				this.priceEvaluationCodeField = value;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x00005DAE File Offset: 0x00003FAE
		// (set) Token: 0x06000B6B RID: 2923 RVA: 0x00005DB6 File Offset: 0x00003FB6
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MaximumVariantQuantityType MaximumVariantQuantity
		{
			get
			{
				return this.maximumVariantQuantityField;
			}
			set
			{
				this.maximumVariantQuantityField = value;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x00005DBF File Offset: 0x00003FBF
		// (set) Token: 0x06000B6D RID: 2925 RVA: 0x00005DC7 File Offset: 0x00003FC7
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public VariantConstraintIndicatorType VariantConstraintIndicator
		{
			get
			{
				return this.variantConstraintIndicatorField;
			}
			set
			{
				this.variantConstraintIndicatorField = value;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x00005DD0 File Offset: 0x00003FD0
		// (set) Token: 0x06000B6F RID: 2927 RVA: 0x00005DD8 File Offset: 0x00003FD8
		[XmlElement("AcceptedVariantsDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AcceptedVariantsDescriptionType[] AcceptedVariantsDescription
		{
			get
			{
				return this.acceptedVariantsDescriptionField;
			}
			set
			{
				this.acceptedVariantsDescriptionField = value;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x00005DE1 File Offset: 0x00003FE1
		// (set) Token: 0x06000B71 RID: 2929 RVA: 0x00005DE9 File Offset: 0x00003FE9
		[XmlElement("PriceRevisionFormulaDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PriceRevisionFormulaDescriptionType[] PriceRevisionFormulaDescription
		{
			get
			{
				return this.priceRevisionFormulaDescriptionField;
			}
			set
			{
				this.priceRevisionFormulaDescriptionField = value;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000B72 RID: 2930 RVA: 0x00005DF2 File Offset: 0x00003FF2
		// (set) Token: 0x06000B73 RID: 2931 RVA: 0x00005DFA File Offset: 0x00003FFA
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public FundingProgramCodeType FundingProgramCode
		{
			get
			{
				return this.fundingProgramCodeField;
			}
			set
			{
				this.fundingProgramCodeField = value;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000B74 RID: 2932 RVA: 0x00005E03 File Offset: 0x00004003
		// (set) Token: 0x06000B75 RID: 2933 RVA: 0x00005E0B File Offset: 0x0000400B
		[XmlElement("FundingProgram", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public FundingProgramType[] FundingProgram
		{
			get
			{
				return this.fundingProgramField;
			}
			set
			{
				this.fundingProgramField = value;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x00005E14 File Offset: 0x00004014
		// (set) Token: 0x06000B77 RID: 2935 RVA: 0x00005E1C File Offset: 0x0000401C
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MaximumAdvertisementAmountType MaximumAdvertisementAmount
		{
			get
			{
				return this.maximumAdvertisementAmountField;
			}
			set
			{
				this.maximumAdvertisementAmountField = value;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000B78 RID: 2936 RVA: 0x00005E25 File Offset: 0x00004025
		// (set) Token: 0x06000B79 RID: 2937 RVA: 0x00005E2D File Offset: 0x0000402D
		[XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NoteType[] Note
		{
			get
			{
				return this.noteField;
			}
			set
			{
				this.noteField = value;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000B7A RID: 2938 RVA: 0x00005E36 File Offset: 0x00004036
		// (set) Token: 0x06000B7B RID: 2939 RVA: 0x00005E3E File Offset: 0x0000403E
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PaymentFrequencyCodeType PaymentFrequencyCode
		{
			get
			{
				return this.paymentFrequencyCodeField;
			}
			set
			{
				this.paymentFrequencyCodeField = value;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000B7C RID: 2940 RVA: 0x00005E47 File Offset: 0x00004047
		// (set) Token: 0x06000B7D RID: 2941 RVA: 0x00005E4F File Offset: 0x0000404F
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public EconomicOperatorRegistryURIType EconomicOperatorRegistryURI
		{
			get
			{
				return this.economicOperatorRegistryURIField;
			}
			set
			{
				this.economicOperatorRegistryURIField = value;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000B7E RID: 2942 RVA: 0x00005E58 File Offset: 0x00004058
		// (set) Token: 0x06000B7F RID: 2943 RVA: 0x00005E60 File Offset: 0x00004060
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public RequiredCurriculaIndicatorType RequiredCurriculaIndicator
		{
			get
			{
				return this.requiredCurriculaIndicatorField;
			}
			set
			{
				this.requiredCurriculaIndicatorField = value;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000B80 RID: 2944 RVA: 0x00005E69 File Offset: 0x00004069
		// (set) Token: 0x06000B81 RID: 2945 RVA: 0x00005E71 File Offset: 0x00004071
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public OtherConditionsIndicatorType OtherConditionsIndicator
		{
			get
			{
				return this.otherConditionsIndicatorField;
			}
			set
			{
				this.otherConditionsIndicatorField = value;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x00005E7A File Offset: 0x0000407A
		// (set) Token: 0x06000B83 RID: 2947 RVA: 0x00005E82 File Offset: 0x00004082
		[XmlElement("AdditionalConditions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AdditionalConditionsType[] AdditionalConditions
		{
			get
			{
				return this.additionalConditionsField;
			}
			set
			{
				this.additionalConditionsField = value;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000B84 RID: 2948 RVA: 0x00005E8B File Offset: 0x0000408B
		// (set) Token: 0x06000B85 RID: 2949 RVA: 0x00005E93 File Offset: 0x00004093
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LatestSecurityClearanceDateType LatestSecurityClearanceDate
		{
			get
			{
				return this.latestSecurityClearanceDateField;
			}
			set
			{
				this.latestSecurityClearanceDateField = value;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000B86 RID: 2950 RVA: 0x00005E9C File Offset: 0x0000409C
		// (set) Token: 0x06000B87 RID: 2951 RVA: 0x00005EA4 File Offset: 0x000040A4
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DocumentationFeeAmountType DocumentationFeeAmount
		{
			get
			{
				return this.documentationFeeAmountField;
			}
			set
			{
				this.documentationFeeAmountField = value;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000B88 RID: 2952 RVA: 0x00005EAD File Offset: 0x000040AD
		// (set) Token: 0x06000B89 RID: 2953 RVA: 0x00005EB5 File Offset: 0x000040B5
		[XmlElement("PenaltyClause")]
		public ClauseType[] PenaltyClause
		{
			get
			{
				return this.penaltyClauseField;
			}
			set
			{
				this.penaltyClauseField = value;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x00005EBE File Offset: 0x000040BE
		// (set) Token: 0x06000B8B RID: 2955 RVA: 0x00005EC6 File Offset: 0x000040C6
		[XmlElement("RequiredFinancialGuarantee")]
		public FinancialGuaranteeType[] RequiredFinancialGuarantee
		{
			get
			{
				return this.requiredFinancialGuaranteeField;
			}
			set
			{
				this.requiredFinancialGuaranteeField = value;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000B8C RID: 2956 RVA: 0x00005ECF File Offset: 0x000040CF
		// (set) Token: 0x06000B8D RID: 2957 RVA: 0x00005ED7 File Offset: 0x000040D7
		public DocumentReferenceType ProcurementLegislationDocumentReference
		{
			get
			{
				return this.procurementLegislationDocumentReferenceField;
			}
			set
			{
				this.procurementLegislationDocumentReferenceField = value;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x00005EE0 File Offset: 0x000040E0
		// (set) Token: 0x06000B8F RID: 2959 RVA: 0x00005EE8 File Offset: 0x000040E8
		public DocumentReferenceType FiscalLegislationDocumentReference
		{
			get
			{
				return this.fiscalLegislationDocumentReferenceField;
			}
			set
			{
				this.fiscalLegislationDocumentReferenceField = value;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x00005EF1 File Offset: 0x000040F1
		// (set) Token: 0x06000B91 RID: 2961 RVA: 0x00005EF9 File Offset: 0x000040F9
		public DocumentReferenceType EnvironmentalLegislationDocumentReference
		{
			get
			{
				return this.environmentalLegislationDocumentReferenceField;
			}
			set
			{
				this.environmentalLegislationDocumentReferenceField = value;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x00005F02 File Offset: 0x00004102
		// (set) Token: 0x06000B93 RID: 2963 RVA: 0x00005F0A File Offset: 0x0000410A
		public DocumentReferenceType EmploymentLegislationDocumentReference
		{
			get
			{
				return this.employmentLegislationDocumentReferenceField;
			}
			set
			{
				this.employmentLegislationDocumentReferenceField = value;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000B94 RID: 2964 RVA: 0x00005F13 File Offset: 0x00004113
		// (set) Token: 0x06000B95 RID: 2965 RVA: 0x00005F1B File Offset: 0x0000411B
		[XmlElement("ContractualDocumentReference")]
		public DocumentReferenceType[] ContractualDocumentReference
		{
			get
			{
				return this.contractualDocumentReferenceField;
			}
			set
			{
				this.contractualDocumentReferenceField = value;
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000B96 RID: 2966 RVA: 0x00005F24 File Offset: 0x00004124
		// (set) Token: 0x06000B97 RID: 2967 RVA: 0x00005F2C File Offset: 0x0000412C
		public DocumentReferenceType CallForTendersDocumentReference
		{
			get
			{
				return this.callForTendersDocumentReferenceField;
			}
			set
			{
				this.callForTendersDocumentReferenceField = value;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x00005F35 File Offset: 0x00004135
		// (set) Token: 0x06000B99 RID: 2969 RVA: 0x00005F3D File Offset: 0x0000413D
		public PeriodType WarrantyValidityPeriod
		{
			get
			{
				return this.warrantyValidityPeriodField;
			}
			set
			{
				this.warrantyValidityPeriodField = value;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x00005F46 File Offset: 0x00004146
		// (set) Token: 0x06000B9B RID: 2971 RVA: 0x00005F4E File Offset: 0x0000414E
		[XmlElement("PaymentTerms")]
		public PaymentTermsType[] PaymentTerms
		{
			get
			{
				return this.paymentTermsField;
			}
			set
			{
				this.paymentTermsField = value;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000B9C RID: 2972 RVA: 0x00005F57 File Offset: 0x00004157
		// (set) Token: 0x06000B9D RID: 2973 RVA: 0x00005F5F File Offset: 0x0000415F
		[XmlElement("TendererQualificationRequest")]
		public TendererQualificationRequestType[] TendererQualificationRequest
		{
			get
			{
				return this.tendererQualificationRequestField;
			}
			set
			{
				this.tendererQualificationRequestField = value;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000B9E RID: 2974 RVA: 0x00005F68 File Offset: 0x00004168
		// (set) Token: 0x06000B9F RID: 2975 RVA: 0x00005F70 File Offset: 0x00004170
		[XmlElement("AllowedSubcontractTerms")]
		public SubcontractTermsType[] AllowedSubcontractTerms
		{
			get
			{
				return this.allowedSubcontractTermsField;
			}
			set
			{
				this.allowedSubcontractTermsField = value;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000BA0 RID: 2976 RVA: 0x00005F79 File Offset: 0x00004179
		// (set) Token: 0x06000BA1 RID: 2977 RVA: 0x00005F81 File Offset: 0x00004181
		[XmlElement("TenderPreparation")]
		public TenderPreparationType[] TenderPreparation
		{
			get
			{
				return this.tenderPreparationField;
			}
			set
			{
				this.tenderPreparationField = value;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x00005F8A File Offset: 0x0000418A
		// (set) Token: 0x06000BA3 RID: 2979 RVA: 0x00005F92 File Offset: 0x00004192
		[XmlElement("ContractExecutionRequirement")]
		public ContractExecutionRequirementType[] ContractExecutionRequirement
		{
			get
			{
				return this.contractExecutionRequirementField;
			}
			set
			{
				this.contractExecutionRequirementField = value;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x00005F9B File Offset: 0x0000419B
		// (set) Token: 0x06000BA5 RID: 2981 RVA: 0x00005FA3 File Offset: 0x000041A3
		public AwardingTermsType AwardingTerms
		{
			get
			{
				return this.awardingTermsField;
			}
			set
			{
				this.awardingTermsField = value;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x00005FAC File Offset: 0x000041AC
		// (set) Token: 0x06000BA7 RID: 2983 RVA: 0x00005FB4 File Offset: 0x000041B4
		public PartyType AdditionalInformationParty
		{
			get
			{
				return this.additionalInformationPartyField;
			}
			set
			{
				this.additionalInformationPartyField = value;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x00005FBD File Offset: 0x000041BD
		// (set) Token: 0x06000BA9 RID: 2985 RVA: 0x00005FC5 File Offset: 0x000041C5
		public PartyType DocumentProviderParty
		{
			get
			{
				return this.documentProviderPartyField;
			}
			set
			{
				this.documentProviderPartyField = value;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000BAA RID: 2986 RVA: 0x00005FCE File Offset: 0x000041CE
		// (set) Token: 0x06000BAB RID: 2987 RVA: 0x00005FD6 File Offset: 0x000041D6
		public PartyType TenderRecipientParty
		{
			get
			{
				return this.tenderRecipientPartyField;
			}
			set
			{
				this.tenderRecipientPartyField = value;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000BAC RID: 2988 RVA: 0x00005FDF File Offset: 0x000041DF
		// (set) Token: 0x06000BAD RID: 2989 RVA: 0x00005FE7 File Offset: 0x000041E7
		public PartyType ContractResponsibleParty
		{
			get
			{
				return this.contractResponsiblePartyField;
			}
			set
			{
				this.contractResponsiblePartyField = value;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000BAE RID: 2990 RVA: 0x00005FF0 File Offset: 0x000041F0
		// (set) Token: 0x06000BAF RID: 2991 RVA: 0x00005FF8 File Offset: 0x000041F8
		[XmlElement("TenderEvaluationParty")]
		public PartyType[] TenderEvaluationParty
		{
			get
			{
				return this.tenderEvaluationPartyField;
			}
			set
			{
				this.tenderEvaluationPartyField = value;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x00006001 File Offset: 0x00004201
		// (set) Token: 0x06000BB1 RID: 2993 RVA: 0x00006009 File Offset: 0x00004209
		public PeriodType TenderValidityPeriod
		{
			get
			{
				return this.tenderValidityPeriodField;
			}
			set
			{
				this.tenderValidityPeriodField = value;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x00006012 File Offset: 0x00004212
		// (set) Token: 0x06000BB3 RID: 2995 RVA: 0x0000601A File Offset: 0x0000421A
		public PeriodType ContractAcceptancePeriod
		{
			get
			{
				return this.contractAcceptancePeriodField;
			}
			set
			{
				this.contractAcceptancePeriodField = value;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x00006023 File Offset: 0x00004223
		// (set) Token: 0x06000BB5 RID: 2997 RVA: 0x0000602B File Offset: 0x0000422B
		public AppealTermsType AppealTerms
		{
			get
			{
				return this.appealTermsField;
			}
			set
			{
				this.appealTermsField = value;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x00006034 File Offset: 0x00004234
		// (set) Token: 0x06000BB7 RID: 2999 RVA: 0x0000603C File Offset: 0x0000423C
		[XmlElement("Language")]
		public LanguageType[] Language
		{
			get
			{
				return this.languageField;
			}
			set
			{
				this.languageField = value;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x00006045 File Offset: 0x00004245
		// (set) Token: 0x06000BB9 RID: 3001 RVA: 0x0000604D File Offset: 0x0000424D
		[XmlElement("BudgetAccountLine")]
		public BudgetAccountLineType[] BudgetAccountLine
		{
			get
			{
				return this.budgetAccountLineField;
			}
			set
			{
				this.budgetAccountLineField = value;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000BBA RID: 3002 RVA: 0x00006056 File Offset: 0x00004256
		// (set) Token: 0x06000BBB RID: 3003 RVA: 0x0000605E File Offset: 0x0000425E
		public DocumentReferenceType ReplacedNoticeDocumentReference
		{
			get
			{
				return this.replacedNoticeDocumentReferenceField;
			}
			set
			{
				this.replacedNoticeDocumentReferenceField = value;
			}
		}

		// Token: 0x040003CA RID: 970
		private AwardingMethodTypeCodeType awardingMethodTypeCodeField;

		// Token: 0x040003CB RID: 971
		private PriceEvaluationCodeType priceEvaluationCodeField;

		// Token: 0x040003CC RID: 972
		private MaximumVariantQuantityType maximumVariantQuantityField;

		// Token: 0x040003CD RID: 973
		private VariantConstraintIndicatorType variantConstraintIndicatorField;

		// Token: 0x040003CE RID: 974
		private AcceptedVariantsDescriptionType[] acceptedVariantsDescriptionField;

		// Token: 0x040003CF RID: 975
		private PriceRevisionFormulaDescriptionType[] priceRevisionFormulaDescriptionField;

		// Token: 0x040003D0 RID: 976
		private FundingProgramCodeType fundingProgramCodeField;

		// Token: 0x040003D1 RID: 977
		private FundingProgramType[] fundingProgramField;

		// Token: 0x040003D2 RID: 978
		private MaximumAdvertisementAmountType maximumAdvertisementAmountField;

		// Token: 0x040003D3 RID: 979
		private NoteType[] noteField;

		// Token: 0x040003D4 RID: 980
		private PaymentFrequencyCodeType paymentFrequencyCodeField;

		// Token: 0x040003D5 RID: 981
		private EconomicOperatorRegistryURIType economicOperatorRegistryURIField;

		// Token: 0x040003D6 RID: 982
		private RequiredCurriculaIndicatorType requiredCurriculaIndicatorField;

		// Token: 0x040003D7 RID: 983
		private OtherConditionsIndicatorType otherConditionsIndicatorField;

		// Token: 0x040003D8 RID: 984
		private AdditionalConditionsType[] additionalConditionsField;

		// Token: 0x040003D9 RID: 985
		private LatestSecurityClearanceDateType latestSecurityClearanceDateField;

		// Token: 0x040003DA RID: 986
		private DocumentationFeeAmountType documentationFeeAmountField;

		// Token: 0x040003DB RID: 987
		private ClauseType[] penaltyClauseField;

		// Token: 0x040003DC RID: 988
		private FinancialGuaranteeType[] requiredFinancialGuaranteeField;

		// Token: 0x040003DD RID: 989
		private DocumentReferenceType procurementLegislationDocumentReferenceField;

		// Token: 0x040003DE RID: 990
		private DocumentReferenceType fiscalLegislationDocumentReferenceField;

		// Token: 0x040003DF RID: 991
		private DocumentReferenceType environmentalLegislationDocumentReferenceField;

		// Token: 0x040003E0 RID: 992
		private DocumentReferenceType employmentLegislationDocumentReferenceField;

		// Token: 0x040003E1 RID: 993
		private DocumentReferenceType[] contractualDocumentReferenceField;

		// Token: 0x040003E2 RID: 994
		private DocumentReferenceType callForTendersDocumentReferenceField;

		// Token: 0x040003E3 RID: 995
		private PeriodType warrantyValidityPeriodField;

		// Token: 0x040003E4 RID: 996
		private PaymentTermsType[] paymentTermsField;

		// Token: 0x040003E5 RID: 997
		private TendererQualificationRequestType[] tendererQualificationRequestField;

		// Token: 0x040003E6 RID: 998
		private SubcontractTermsType[] allowedSubcontractTermsField;

		// Token: 0x040003E7 RID: 999
		private TenderPreparationType[] tenderPreparationField;

		// Token: 0x040003E8 RID: 1000
		private ContractExecutionRequirementType[] contractExecutionRequirementField;

		// Token: 0x040003E9 RID: 1001
		private AwardingTermsType awardingTermsField;

		// Token: 0x040003EA RID: 1002
		private PartyType additionalInformationPartyField;

		// Token: 0x040003EB RID: 1003
		private PartyType documentProviderPartyField;

		// Token: 0x040003EC RID: 1004
		private PartyType tenderRecipientPartyField;

		// Token: 0x040003ED RID: 1005
		private PartyType contractResponsiblePartyField;

		// Token: 0x040003EE RID: 1006
		private PartyType[] tenderEvaluationPartyField;

		// Token: 0x040003EF RID: 1007
		private PeriodType tenderValidityPeriodField;

		// Token: 0x040003F0 RID: 1008
		private PeriodType contractAcceptancePeriodField;

		// Token: 0x040003F1 RID: 1009
		private AppealTermsType appealTermsField;

		// Token: 0x040003F2 RID: 1010
		private LanguageType[] languageField;

		// Token: 0x040003F3 RID: 1011
		private BudgetAccountLineType[] budgetAccountLineField;

		// Token: 0x040003F4 RID: 1012
		private DocumentReferenceType replacedNoticeDocumentReferenceField;
	}
}

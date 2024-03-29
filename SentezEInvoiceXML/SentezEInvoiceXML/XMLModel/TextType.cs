﻿using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020001AB RID: 427
	[XmlInclude(typeof(NameType))]
	[XmlInclude(typeof(VesselNameType))]
	[XmlInclude(typeof(TechnicalNameType))]
	[XmlInclude(typeof(StreetNameType))]
	[XmlInclude(typeof(ServiceNameType))]
	[XmlInclude(typeof(RoamingPartnerNameType))]
	[XmlInclude(typeof(RetailEventNameType))]
	[XmlInclude(typeof(RegistrationNameType))]
	[XmlInclude(typeof(OtherNameType))]
	[XmlInclude(typeof(NameType1))]
	[XmlInclude(typeof(ModelNameType))]
	[XmlInclude(typeof(MiddleNameType))]
	[XmlInclude(typeof(HolderNameType))]
	[XmlInclude(typeof(FirstNameType))]
	[XmlInclude(typeof(FileNameType))]
	[XmlInclude(typeof(FamilyNameType))]
	[XmlInclude(typeof(CitySubdivisionNameType))]
	[XmlInclude(typeof(CityNameType))]
	[XmlInclude(typeof(CategoryNameType))]
	[XmlInclude(typeof(BuildingNameType))]
	[XmlInclude(typeof(BrandNameType))]
	[XmlInclude(typeof(BlockNameType))]
	[XmlInclude(typeof(AliasNameType))]
	[XmlInclude(typeof(AdditionalStreetNameType))]
	[XmlInclude(typeof(TextType1))]
	[XmlInclude(typeof(XPathType))]
	[XmlInclude(typeof(WorkPhaseType))]
	[XmlInclude(typeof(WeightType))]
	[XmlInclude(typeof(WarrantyInformationType))]
	[XmlInclude(typeof(ValueType))]
	[XmlInclude(typeof(ValueQualifierType))]
	[XmlInclude(typeof(ValidateToolVersionType))]
	[XmlInclude(typeof(ValidateToolType))]
	[XmlInclude(typeof(ValidateProcessType))]
	[XmlInclude(typeof(TransportationServiceDescriptionType))]
	[XmlInclude(typeof(TransportUserSpecialTermsType))]
	[XmlInclude(typeof(TransportUserRemarksType))]
	[XmlInclude(typeof(TransportServiceProviderSpecialTermsType))]
	[XmlInclude(typeof(TransportServiceProviderRemarksType))]
	[XmlInclude(typeof(TradingRestrictionsType))]
	[XmlInclude(typeof(TitleType))]
	[XmlInclude(typeof(TimingComplaintType))]
	[XmlInclude(typeof(TimezoneOffsetType))]
	[XmlInclude(typeof(TimeAmountType))]
	[XmlInclude(typeof(TierRangeType))]
	[XmlInclude(typeof(TextType2))]
	[XmlInclude(typeof(TestMethodType))]
	[XmlInclude(typeof(TelephoneType))]
	[XmlInclude(typeof(TelefaxType))]
	[XmlInclude(typeof(TelecommunicationsSupplyTypeType))]
	[XmlInclude(typeof(TelecommunicationsServiceCategoryType))]
	[XmlInclude(typeof(TelecommunicationsServiceCallType))]
	[XmlInclude(typeof(TechnicalCommitteeDescriptionType))]
	[XmlInclude(typeof(TaxExemptionReasonType))]
	[XmlInclude(typeof(TariffDescriptionType))]
	[XmlInclude(typeof(SummaryDescriptionType))]
	[XmlInclude(typeof(SubscriberTypeType))]
	[XmlInclude(typeof(StatusReasonType))]
	[XmlInclude(typeof(SpecialTransportRequirementsType))]
	[XmlInclude(typeof(SpecialTermsType))]
	[XmlInclude(typeof(SpecialServiceInstructionsType))]
	[XmlInclude(typeof(SpecialInstructionsType))]
	[XmlInclude(typeof(SignatureMethodType))]
	[XmlInclude(typeof(ShipsRequirementsType))]
	[XmlInclude(typeof(ShippingMarksType))]
	[XmlInclude(typeof(ServiceTypeType))]
	[XmlInclude(typeof(ServiceNumberCalledType))]
	[XmlInclude(typeof(SealingPartyTypeType))]
	[XmlInclude(typeof(RoomType))]
	[XmlInclude(typeof(RoleDescriptionType))]
	[XmlInclude(typeof(ResolutionType))]
	[XmlInclude(typeof(ResidenceTypeType))]
	[XmlInclude(typeof(ReplenishmentOwnerDescriptionType))]
	[XmlInclude(typeof(RemarksType))]
	[XmlInclude(typeof(RejectionNoteType))]
	[XmlInclude(typeof(RejectReasonType))]
	[XmlInclude(typeof(RegulatoryDomainType))]
	[XmlInclude(typeof(RegistrationNationalityType))]
	[XmlInclude(typeof(RegionType))]
	[XmlInclude(typeof(ReferenceType))]
	[XmlInclude(typeof(RankType))]
	[XmlInclude(typeof(PurposeType))]
	[XmlInclude(typeof(ProcessReasonType))]
	[XmlInclude(typeof(ProcessDescriptionType))]
	[XmlInclude(typeof(PrizeDescriptionType))]
	[XmlInclude(typeof(PriorityType))]
	[XmlInclude(typeof(PrintQualifierType))]
	[XmlInclude(typeof(PriceTypeType))]
	[XmlInclude(typeof(PriceRevisionFormulaDescriptionType))]
	[XmlInclude(typeof(PriceChangeReasonType))]
	[XmlInclude(typeof(PreviousMeterReadingMethodType))]
	[XmlInclude(typeof(PostboxType))]
	[XmlInclude(typeof(PostalZoneType))]
	[XmlInclude(typeof(PlotIdentificationType))]
	[XmlInclude(typeof(PlacardNotationType))]
	[XmlInclude(typeof(PlacardEndorsementType))]
	[XmlInclude(typeof(PhoneNumberType))]
	[XmlInclude(typeof(PersonalSituationType))]
	[XmlInclude(typeof(PaymentOrderReferenceType))]
	[XmlInclude(typeof(PaymentNoteType))]
	[XmlInclude(typeof(PaymentDescriptionType))]
	[XmlInclude(typeof(PayerReferenceType))]
	[XmlInclude(typeof(PayPerViewType))]
	[XmlInclude(typeof(PasswordType))]
	[XmlInclude(typeof(PartyTypeType))]
	[XmlInclude(typeof(PackingMaterialType))]
	[XmlInclude(typeof(OutstandingReasonType))]
	[XmlInclude(typeof(OtherInstructionType))]
	[XmlInclude(typeof(OrganizationDepartmentType))]
	[XmlInclude(typeof(OrderableUnitType))]
	[XmlInclude(typeof(OptionsDescriptionType))]
	[XmlInclude(typeof(OneTimeChargeTypeType))]
	[XmlInclude(typeof(NoteType))]
	[XmlInclude(typeof(NegotiationDescriptionType))]
	[XmlInclude(typeof(NameSuffixType))]
	[XmlInclude(typeof(MovieTitleType))]
	[XmlInclude(typeof(MonetaryScopeType))]
	[XmlInclude(typeof(MinimumValueType))]
	[XmlInclude(typeof(MinimumImprovementBidType))]
	[XmlInclude(typeof(MeterReadingTypeType))]
	[XmlInclude(typeof(MeterReadingCommentsType))]
	[XmlInclude(typeof(MeterNumberType))]
	[XmlInclude(typeof(MeterNameType))]
	[XmlInclude(typeof(MeterConstantType))]
	[XmlInclude(typeof(MaximumValueType))]
	[XmlInclude(typeof(MarkCareType))]
	[XmlInclude(typeof(MarkAttentionType))]
	[XmlInclude(typeof(LowTendersDescriptionType))]
	[XmlInclude(typeof(LossRiskType))]
	[XmlInclude(typeof(LoginType))]
	[XmlInclude(typeof(LocationType))]
	[XmlInclude(typeof(ListValueType))]
	[XmlInclude(typeof(LineType))]
	[XmlInclude(typeof(LimitationDescriptionType))]
	[XmlInclude(typeof(LegalReferenceType))]
	[XmlInclude(typeof(LatestMeterReadingMethodType))]
	[XmlInclude(typeof(KeywordType))]
	[XmlInclude(typeof(JustificationType))]
	[XmlInclude(typeof(JustificationDescriptionType))]
	[XmlInclude(typeof(JobTitleType))]
	[XmlInclude(typeof(InvoicingPartyReferenceType))]
	[XmlInclude(typeof(InstructionsType))]
	[XmlInclude(typeof(InstructionNoteType))]
	[XmlInclude(typeof(InhouseMailType))]
	[XmlInclude(typeof(InformationType))]
	[XmlInclude(typeof(HeatingTypeType))]
	[XmlInclude(typeof(HaulageInstructionsType))]
	[XmlInclude(typeof(HashAlgorithmMethodType))]
	[XmlInclude(typeof(HandlingInstructionsType))]
	[XmlInclude(typeof(FundingProgramType))]
	[XmlInclude(typeof(FrequencyType))]
	[XmlInclude(typeof(ForwarderServiceInstructionsType))]
	[XmlInclude(typeof(FloorType))]
	[XmlInclude(typeof(FeeDescriptionType))]
	[XmlInclude(typeof(ExtensionType))]
	[XmlInclude(typeof(ExpressionType))]
	[XmlInclude(typeof(ExemptionReasonType))]
	[XmlInclude(typeof(ExclusionReasonType))]
	[XmlInclude(typeof(ElectronicMailType))]
	[XmlInclude(typeof(ElectronicDeviceDescriptionType))]
	[XmlInclude(typeof(DutyType))]
	[XmlInclude(typeof(DocumentTypeType))]
	[XmlInclude(typeof(DocumentStatusReasonDescriptionType))]
	[XmlInclude(typeof(DocumentHashType))]
	[XmlInclude(typeof(DocumentDescriptionType))]
	[XmlInclude(typeof(DistrictType))]
	[XmlInclude(typeof(DescriptionType))]
	[XmlInclude(typeof(DepartmentType))]
	[XmlInclude(typeof(DemurrageInstructionsType))]
	[XmlInclude(typeof(DeliveryInstructionsType))]
	[XmlInclude(typeof(DataSendingCapabilityType))]
	[XmlInclude(typeof(DamageRemarksType))]
	[XmlInclude(typeof(CustomsClearanceServiceInstructionsType))]
	[XmlInclude(typeof(CustomerReferenceType))]
	[XmlInclude(typeof(CurrentChargeTypeType))]
	[XmlInclude(typeof(CountrySubentityType))]
	[XmlInclude(typeof(CorrectionTypeType))]
	[XmlInclude(typeof(ContractTypeType))]
	[XmlInclude(typeof(ContractSubdivisionType))]
	[XmlInclude(typeof(ContractNameType))]
	[XmlInclude(typeof(ContentType))]
	[XmlInclude(typeof(ConsumptionTypeType))]
	[XmlInclude(typeof(ConsumptionLevelType))]
	[XmlInclude(typeof(ConsumersEnergyLevelType))]
	[XmlInclude(typeof(ConditionsType))]
	[XmlInclude(typeof(ConditionsDescriptionType))]
	[XmlInclude(typeof(ConditionType))]
	[XmlInclude(typeof(CompanyLegalFormType))]
	[XmlInclude(typeof(CommentType))]
	[XmlInclude(typeof(CodeValueType))]
	[XmlInclude(typeof(CharacteristicsType))]
	[XmlInclude(typeof(ChannelType))]
	[XmlInclude(typeof(ChangeConditionsType))]
	[XmlInclude(typeof(CertificateTypeType))]
	[XmlInclude(typeof(CarrierServiceInstructionsType))]
	[XmlInclude(typeof(CanonicalizationMethodType))]
	[XmlInclude(typeof(CandidateStatementType))]
	[XmlInclude(typeof(CancellationNoteType))]
	[XmlInclude(typeof(CalculationExpressionType))]
	[XmlInclude(typeof(BuyerReferenceType))]
	[XmlInclude(typeof(BuildingNumberType))]
	[XmlInclude(typeof(BirthplaceNameType))]
	[XmlInclude(typeof(BackorderReasonType))]
	[XmlInclude(typeof(AwardingCriterionDescriptionType))]
	[XmlInclude(typeof(ApprovalStatusType))]
	[XmlInclude(typeof(AllowanceChargeReasonType))]
	[XmlInclude(typeof(AgencyNameType))]
	[XmlInclude(typeof(AdditionalInformationType))]
	[XmlInclude(typeof(AdditionalConditionsType))]
	[XmlInclude(typeof(ActivityTypeType))]
	[XmlInclude(typeof(AccountingCostType))]
	[XmlInclude(typeof(AcceptedVariantsDescriptionType))]
	[XmlInclude(typeof(ExtensionReasonType))]
	[XmlInclude(typeof(ExtensionAgencyNameType))]
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
	[Serializable]
	public class TextType
	{
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060003DB RID: 987 RVA: 0x000031DD File Offset: 0x000013DD
		// (set) Token: 0x060003DC RID: 988 RVA: 0x000031E5 File Offset: 0x000013E5
		[XmlAttribute(DataType = "language")]
		public string languageID
		{
			get
			{
				return this.languageIDField;
			}
			set
			{
				this.languageIDField = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060003DD RID: 989 RVA: 0x000031EE File Offset: 0x000013EE
		// (set) Token: 0x060003DE RID: 990 RVA: 0x000031F6 File Offset: 0x000013F6
		[XmlAttribute(DataType = "normalizedString")]
		public string languageLocaleID
		{
			get
			{
				return this.languageLocaleIDField;
			}
			set
			{
				this.languageLocaleIDField = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060003DF RID: 991 RVA: 0x000031FF File Offset: 0x000013FF
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x00003207 File Offset: 0x00001407
		[XmlText]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}

		// Token: 0x0400013D RID: 317
		private string languageIDField;

		// Token: 0x0400013E RID: 318
		private string languageLocaleIDField;

		// Token: 0x0400013F RID: 319
		private string valueField;
	}
}

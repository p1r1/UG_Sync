using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200033E RID: 830
	[XmlInclude(typeof(VariantConstraintIndicatorType))]
	[XmlInclude(typeof(UnknownPriceIndicatorType))]
	[XmlInclude(typeof(ToOrderIndicatorType))]
	[XmlInclude(typeof(ThirdPartyPayerIndicatorType))]
	[XmlInclude(typeof(TaxIncludedIndicatorType))]
	[XmlInclude(typeof(TaxEvidenceIndicatorType))]
	[XmlInclude(typeof(StatusAvailableIndicatorType))]
	[XmlInclude(typeof(SplitConsignmentIndicatorType))]
	[XmlInclude(typeof(SpecialSecurityIndicatorType))]
	[XmlInclude(typeof(SoleProprietorshipIndicatorType))]
	[XmlInclude(typeof(ReturnableMaterialIndicatorType))]
	[XmlInclude(typeof(ReturnabilityIndicatorType))]
	[XmlInclude(typeof(RequiredCurriculaIndicatorType))]
	[XmlInclude(typeof(RefrigerationOnIndicatorType))]
	[XmlInclude(typeof(RefrigeratedIndicatorType))]
	[XmlInclude(typeof(PublishAwardIndicatorType))]
	[XmlInclude(typeof(PrizeIndicatorType))]
	[XmlInclude(typeof(PricingUpdateRequestIndicatorType))]
	[XmlInclude(typeof(PrepaidIndicatorType))]
	[XmlInclude(typeof(PreCarriageIndicatorType))]
	[XmlInclude(typeof(PowerIndicatorType))]
	[XmlInclude(typeof(PartialDeliveryIndicatorType))]
	[XmlInclude(typeof(OtherConditionsIndicatorType))]
	[XmlInclude(typeof(OrderableIndicatorType))]
	[XmlInclude(typeof(OptionalLineItemIndicatorType))]
	[XmlInclude(typeof(OnCarriageIndicatorType))]
	[XmlInclude(typeof(MarkCareIndicatorType))]
	[XmlInclude(typeof(MarkAttentionIndicatorType))]
	[XmlInclude(typeof(LivestockIndicatorType))]
	[XmlInclude(typeof(LegalStatusIndicatorType))]
	[XmlInclude(typeof(ItemUpdateRequestIndicatorType))]
	[XmlInclude(typeof(IndicationIndicatorType))]
	[XmlInclude(typeof(HumanFoodIndicatorType))]
	[XmlInclude(typeof(HumanFoodApprovedIndicatorType))]
	[XmlInclude(typeof(HazardousRiskIndicatorType))]
	[XmlInclude(typeof(GovernmentAgreementConstraintIndicatorType))]
	[XmlInclude(typeof(GeneralCargoIndicatorType))]
	[XmlInclude(typeof(FullyPaidSharesIndicatorType))]
	[XmlInclude(typeof(FrozenDocumentIndicatorType))]
	[XmlInclude(typeof(FreeOfChargeIndicatorType))]
	[XmlInclude(typeof(FollowupContractIndicatorType))]
	[XmlInclude(typeof(DangerousGoodsApprovedIndicatorType))]
	[XmlInclude(typeof(CustomsImportClassifiedIndicatorType))]
	[XmlInclude(typeof(CopyIndicatorType))]
	[XmlInclude(typeof(ContainerizedIndicatorType))]
	[XmlInclude(typeof(ConsolidatableIndicatorType))]
	[XmlInclude(typeof(CompletionIndicatorType))]
	[XmlInclude(typeof(ChargeIndicatorType))]
	[XmlInclude(typeof(CatalogueIndicatorType))]
	[XmlInclude(typeof(CandidateReductionConstraintIndicatorType))]
	[XmlInclude(typeof(BulkCargoIndicatorType))]
	[XmlInclude(typeof(BindingOnBuyerIndicatorType))]
	[XmlInclude(typeof(BasedOnConsensusIndicatorType))]
	[XmlInclude(typeof(BalanceBroughtForwardIndicatorType))]
	[XmlInclude(typeof(BackOrderAllowedIndicatorType))]
	[XmlInclude(typeof(AuctionConstraintIndicatorType))]
	[XmlInclude(typeof(AnimalFoodIndicatorType))]
	[XmlInclude(typeof(AnimalFoodApprovedIndicatorType))]
	[XmlInclude(typeof(AdValoremIndicatorType))]
	[XmlInclude(typeof(AcceptedIndicatorType))]
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
	[Serializable]
	public class IndicatorType
	{
		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x00003792 File Offset: 0x00001992
		// (set) Token: 0x06000616 RID: 1558 RVA: 0x0000379A File Offset: 0x0000199A
		[XmlText]
		public bool Value
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

		// Token: 0x04000190 RID: 400
		private bool valueField;
	}
}

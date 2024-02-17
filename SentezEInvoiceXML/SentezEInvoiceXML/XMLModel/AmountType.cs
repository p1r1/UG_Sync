using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200002A RID: 42
	[XmlInclude(typeof(AmountType1))]
	[XmlInclude(typeof(ValueAmountType))]
	[XmlInclude(typeof(TransactionCurrencyTaxAmountType))]
	[XmlInclude(typeof(TotalTaxAmountType))]
	[XmlInclude(typeof(TotalTaskAmountType))]
	[XmlInclude(typeof(TotalPaymentAmountType))]
	[XmlInclude(typeof(TotalInvoiceAmountType))]
	[XmlInclude(typeof(TotalDebitAmountType))]
	[XmlInclude(typeof(TotalCreditAmountType))]
	[XmlInclude(typeof(TotalBalanceAmountType))]
	[XmlInclude(typeof(TotalAmountType))]
	[XmlInclude(typeof(ThresholdAmountType))]
	[XmlInclude(typeof(TaxableAmountType))]
	[XmlInclude(typeof(TaxInclusiveAmountType))]
	[XmlInclude(typeof(TaxExclusiveAmountType))]
	[XmlInclude(typeof(TaxEnergyOnAccountAmountType))]
	[XmlInclude(typeof(TaxEnergyBalanceAmountType))]
	[XmlInclude(typeof(TaxEnergyAmountType))]
	[XmlInclude(typeof(TaxAmountType))]
	[XmlInclude(typeof(SettlementDiscountAmountType))]
	[XmlInclude(typeof(RoundingAmountType))]
	[XmlInclude(typeof(RequiredFeeAmountType))]
	[XmlInclude(typeof(PriceAmountType))]
	[XmlInclude(typeof(PrepaidAmountType))]
	[XmlInclude(typeof(PerUnitAmountType))]
	[XmlInclude(typeof(PenaltyAmountType))]
	[XmlInclude(typeof(PayableRoundingAmountType))]
	[XmlInclude(typeof(PayableAmountType))]
	[XmlInclude(typeof(PayableAlternativeAmountType))]
	[XmlInclude(typeof(PartyCapacityAmountType))]
	[XmlInclude(typeof(PaidAmountType))]
	[XmlInclude(typeof(MinimumAmountType))]
	[XmlInclude(typeof(MaximumPaidAmountType))]
	[XmlInclude(typeof(MaximumAmountType))]
	[XmlInclude(typeof(MaximumAdvertisementAmountType))]
	[XmlInclude(typeof(MarketValueAmountType))]
	[XmlInclude(typeof(LowerTenderAmountType))]
	[XmlInclude(typeof(LineExtensionAmountType))]
	[XmlInclude(typeof(LiabilityAmountType))]
	[XmlInclude(typeof(InventoryValueAmountType))]
	[XmlInclude(typeof(InsuranceValueAmountType))]
	[XmlInclude(typeof(InsurancePremiumAmountType))]
	[XmlInclude(typeof(HigherTenderAmountType))]
	[XmlInclude(typeof(FreeOnBoardValueAmountType))]
	[XmlInclude(typeof(FeeAmountType))]
	[XmlInclude(typeof(FaceValueAmountType))]
	[XmlInclude(typeof(EstimatedOverallContractAmountType))]
	[XmlInclude(typeof(EstimatedAmountType))]
	[XmlInclude(typeof(DocumentationFeeAmountType))]
	[XmlInclude(typeof(DeclaredStatisticsValueAmountType))]
	[XmlInclude(typeof(DeclaredForCarriageValueAmountType))]
	[XmlInclude(typeof(DeclaredCustomsValueAmountType))]
	[XmlInclude(typeof(DeclaredCarriageValueAmountType))]
	[XmlInclude(typeof(DebitLineAmountType))]
	[XmlInclude(typeof(CreditLineAmountType))]
	[XmlInclude(typeof(CorrectionUnitAmountType))]
	[XmlInclude(typeof(CorrectionAmountType))]
	[XmlInclude(typeof(CorporateStockAmountType))]
	[XmlInclude(typeof(ChargeTotalAmountType))]
	[XmlInclude(typeof(CallExtensionAmountType))]
	[XmlInclude(typeof(CallBaseAmountType))]
	[XmlInclude(typeof(BaseAmountType))]
	[XmlInclude(typeof(BalanceAmountType))]
	[XmlInclude(typeof(AverageSubsequentContractAmountType))]
	[XmlInclude(typeof(AverageAmountType))]
	[XmlInclude(typeof(AnnualAverageAmountType))]
	[XmlInclude(typeof(AmountType2))]
	[XmlInclude(typeof(AllowanceTotalAmountType))]
	[XmlInclude(typeof(AdvertisementAmountType))]
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
	[Serializable]
	public class AmountType
	{
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00002FDB File Offset: 0x000011DB
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00002FE3 File Offset: 0x000011E3
		[XmlAttribute(DataType = "normalizedString")]
		public string currencyID
		{
			get
			{
				return this.currencyIDField;
			}
			set
			{
				this.currencyIDField = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00002FEC File Offset: 0x000011EC
		// (set) Token: 0x06000229 RID: 553 RVA: 0x00002FF4 File Offset: 0x000011F4
		[XmlAttribute(DataType = "normalizedString")]
		public string currencyCodeListVersionID
		{
			get
			{
				return this.currencyCodeListVersionIDField;
			}
			set
			{
				this.currencyCodeListVersionIDField = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00002FFD File Offset: 0x000011FD
		// (set) Token: 0x0600022B RID: 555 RVA: 0x00003005 File Offset: 0x00001205
		[XmlText]
		public decimal Value
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

		// Token: 0x04000123 RID: 291
		private string currencyIDField;

		// Token: 0x04000124 RID: 292
		private string currencyCodeListVersionIDField;

		// Token: 0x04000125 RID: 293
		private decimal valueField;
	}
}

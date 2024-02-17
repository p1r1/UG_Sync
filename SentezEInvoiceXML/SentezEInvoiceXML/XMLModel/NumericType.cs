using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000149 RID: 329
	[XmlInclude(typeof(RateType))]
	[XmlInclude(typeof(TargetCurrencyBaseRateType))]
	[XmlInclude(typeof(SourceCurrencyBaseRateType))]
	[XmlInclude(typeof(RateType1))]
	[XmlInclude(typeof(OrderableUnitFactorRateType))]
	[XmlInclude(typeof(CalculationRateType))]
	[XmlInclude(typeof(AmountRateType))]
	[XmlInclude(typeof(PercentType))]
	[XmlInclude(typeof(TierRatePercentType))]
	[XmlInclude(typeof(TargetServicePercentType))]
	[XmlInclude(typeof(SettlementDiscountPercentType))]
	[XmlInclude(typeof(ReliabilityPercentType))]
	[XmlInclude(typeof(ProgressPercentType))]
	[XmlInclude(typeof(PercentType1))]
	[XmlInclude(typeof(PenaltySurchargePercentType))]
	[XmlInclude(typeof(PaymentPercentType))]
	[XmlInclude(typeof(ParticipationPercentType))]
	[XmlInclude(typeof(PartecipationPercentType))]
	[XmlInclude(typeof(MinimumPercentType))]
	[XmlInclude(typeof(MaximumPercentType))]
	[XmlInclude(typeof(HumidityPercentType))]
	[XmlInclude(typeof(AirFlowPercentType))]
	[XmlInclude(typeof(ValueType1))]
	[XmlInclude(typeof(NumericType1))]
	[XmlInclude(typeof(WeightNumericType))]
	[XmlInclude(typeof(SequenceNumericType))]
	[XmlInclude(typeof(ResidentOccupantsNumericType))]
	[XmlInclude(typeof(ReminderSequenceNumericType))]
	[XmlInclude(typeof(PackSizeNumericType))]
	[XmlInclude(typeof(OrderQuantityIncrementNumericType))]
	[XmlInclude(typeof(OrderIntervalDaysNumericType))]
	[XmlInclude(typeof(MultiplierFactorNumericType))]
	[XmlInclude(typeof(MinimumNumberNumericType))]
	[XmlInclude(typeof(MaximumPaymentInstructionsNumericType))]
	[XmlInclude(typeof(MaximumNumberNumericType))]
	[XmlInclude(typeof(MaximumCopiesNumericType))]
	[XmlInclude(typeof(LineNumberNumericType))]
	[XmlInclude(typeof(LineCountNumericType))]
	[XmlInclude(typeof(FrozenPeriodDaysNumericType))]
	[XmlInclude(typeof(CalculationSequenceNumericType))]
	[XmlInclude(typeof(BudgetYearNumericType))]
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
	[Serializable]
	public class NumericType
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000367 RID: 871 RVA: 0x0000311C File Offset: 0x0000131C
		// (set) Token: 0x06000368 RID: 872 RVA: 0x00003124 File Offset: 0x00001324
		[XmlAttribute]
		public string format
		{
			get
			{
				return this.formatField;
			}
			set
			{
				this.formatField = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000369 RID: 873 RVA: 0x0000312D File Offset: 0x0000132D
		// (set) Token: 0x0600036A RID: 874 RVA: 0x00003135 File Offset: 0x00001335
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

		// Token: 0x04000134 RID: 308
		private string formatField;

		// Token: 0x04000135 RID: 309
		private decimal valueField;
	}
}

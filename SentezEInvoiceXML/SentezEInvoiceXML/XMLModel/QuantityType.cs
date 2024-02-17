using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200038D RID: 909
	[XmlInclude(typeof(QuantityType1))]
	[XmlInclude(typeof(VarianceQuantityType))]
	[XmlInclude(typeof(ValueQuantityType))]
	[XmlInclude(typeof(TotalTransportHandlingUnitQuantityType))]
	[XmlInclude(typeof(TotalPackagesQuantityType))]
	[XmlInclude(typeof(TotalPackageQuantityType))]
	[XmlInclude(typeof(TotalMeteredQuantityType))]
	[XmlInclude(typeof(TotalGoodsItemQuantityType))]
	[XmlInclude(typeof(TotalDeliveredQuantityType))]
	[XmlInclude(typeof(TotalConsumedQuantityType))]
	[XmlInclude(typeof(TimeDeltaDaysQuantityType))]
	[XmlInclude(typeof(ThresholdQuantityType))]
	[XmlInclude(typeof(TargetInventoryQuantityType))]
	[XmlInclude(typeof(ShortQuantityType))]
	[XmlInclude(typeof(SharesNumberQuantityType))]
	[XmlInclude(typeof(ReturnableQuantityType))]
	[XmlInclude(typeof(RejectedQuantityType))]
	[XmlInclude(typeof(ReceivedTenderQuantityType))]
	[XmlInclude(typeof(ReceivedQuantityType))]
	[XmlInclude(typeof(ReceivedForeignTenderQuantityType))]
	[XmlInclude(typeof(ReceivedElectronicTenderQuantityType))]
	[XmlInclude(typeof(QuantityType2))]
	[XmlInclude(typeof(PreviousMeterQuantityType))]
	[XmlInclude(typeof(PerformanceValueQuantityType))]
	[XmlInclude(typeof(PassengerQuantityType))]
	[XmlInclude(typeof(PackQuantityType))]
	[XmlInclude(typeof(OversupplyQuantityType))]
	[XmlInclude(typeof(OutstandingQuantityType))]
	[XmlInclude(typeof(OperatingYearsQuantityType))]
	[XmlInclude(typeof(NormalTemperatureReductionQuantityType))]
	[XmlInclude(typeof(MultipleOrderQuantityType))]
	[XmlInclude(typeof(MinimumQuantityType))]
	[XmlInclude(typeof(MinimumOrderQuantityType))]
	[XmlInclude(typeof(MinimumInventoryQuantityType))]
	[XmlInclude(typeof(MinimumBackorderQuantityType))]
	[XmlInclude(typeof(MaximumVariantQuantityType))]
	[XmlInclude(typeof(MaximumQuantityType))]
	[XmlInclude(typeof(MaximumOrderQuantityType))]
	[XmlInclude(typeof(MaximumOperatorQuantityType))]
	[XmlInclude(typeof(MaximumBackorderQuantityType))]
	[XmlInclude(typeof(LatestMeterQuantityType))]
	[XmlInclude(typeof(InvoicedQuantityType))]
	[XmlInclude(typeof(GasPressureQuantityType))]
	[XmlInclude(typeof(ExpectedQuantityType))]
	[XmlInclude(typeof(ExpectedOperatorQuantityType))]
	[XmlInclude(typeof(EstimatedOverallContractQuantityType))]
	[XmlInclude(typeof(EstimatedConsumedQuantityType))]
	[XmlInclude(typeof(EmployeeQuantityType))]
	[XmlInclude(typeof(DifferenceTemperatureReductionQuantityType))]
	[XmlInclude(typeof(DeliveredQuantityType))]
	[XmlInclude(typeof(DebitedQuantityType))]
	[XmlInclude(typeof(CustomsTariffQuantityType))]
	[XmlInclude(typeof(CrewQuantityType))]
	[XmlInclude(typeof(ContentUnitQuantityType))]
	[XmlInclude(typeof(ConsumptionWaterQuantityType))]
	[XmlInclude(typeof(ConsumptionEnergyQuantityType))]
	[XmlInclude(typeof(ConsumerUnitQuantityType))]
	[XmlInclude(typeof(ConsignmentQuantityType))]
	[XmlInclude(typeof(ChildConsignmentQuantityType))]
	[XmlInclude(typeof(ChargeableQuantityType))]
	[XmlInclude(typeof(BatchQuantityType))]
	[XmlInclude(typeof(BasicConsumedQuantityType))]
	[XmlInclude(typeof(BaseQuantityType))]
	[XmlInclude(typeof(BackorderQuantityType))]
	[XmlInclude(typeof(ActualTemperatureReductionQuantityType))]
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
	[Serializable]
	public class QuantityType
	{
		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x00003C47 File Offset: 0x00001E47
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x00003C4F File Offset: 0x00001E4F
		[XmlAttribute(DataType = "normalizedString")]
		public string unitCode
		{
			get
			{
				return this.unitCodeField;
			}
			set
			{
				this.unitCodeField = value;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x00003C58 File Offset: 0x00001E58
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x00003C60 File Offset: 0x00001E60
		[XmlAttribute(DataType = "normalizedString")]
		public string unitCodeListID
		{
			get
			{
				return this.unitCodeListIDField;
			}
			set
			{
				this.unitCodeListIDField = value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x00003C69 File Offset: 0x00001E69
		// (set) Token: 0x060006F3 RID: 1779 RVA: 0x00003C71 File Offset: 0x00001E71
		[XmlAttribute(DataType = "normalizedString")]
		public string unitCodeListAgencyID
		{
			get
			{
				return this.unitCodeListAgencyIDField;
			}
			set
			{
				this.unitCodeListAgencyIDField = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x00003C7A File Offset: 0x00001E7A
		// (set) Token: 0x060006F5 RID: 1781 RVA: 0x00003C82 File Offset: 0x00001E82
		[XmlAttribute]
		public string unitCodeListAgencyName
		{
			get
			{
				return this.unitCodeListAgencyNameField;
			}
			set
			{
				this.unitCodeListAgencyNameField = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x00003C8B File Offset: 0x00001E8B
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x00003C93 File Offset: 0x00001E93
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

		// Token: 0x040001D5 RID: 469
		private string unitCodeField;

		// Token: 0x040001D6 RID: 470
		private string unitCodeListIDField;

		// Token: 0x040001D7 RID: 471
		private string unitCodeListAgencyIDField;

		// Token: 0x040001D8 RID: 472
		private string unitCodeListAgencyNameField;

		// Token: 0x040001D9 RID: 473
		private decimal valueField;
	}
}

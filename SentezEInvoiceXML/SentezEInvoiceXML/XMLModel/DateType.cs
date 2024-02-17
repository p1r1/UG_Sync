using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000172 RID: 370
	[XmlInclude(typeof(ValidityStartDateType))]
	[XmlInclude(typeof(ValidationDateType))]
	[XmlInclude(typeof(TaxPointDateType))]
	[XmlInclude(typeof(SubmissionDueDateType))]
	[XmlInclude(typeof(SubmissionDateType))]
	[XmlInclude(typeof(StartDateType))]
	[XmlInclude(typeof(SourceForecastIssueDateType))]
	[XmlInclude(typeof(RevisionDateType))]
	[XmlInclude(typeof(ResponseDateType))]
	[XmlInclude(typeof(ResolutionDateType))]
	[XmlInclude(typeof(RequiredDeliveryDateType))]
	[XmlInclude(typeof(RequestedPublicationDateType))]
	[XmlInclude(typeof(RequestedDespatchDateType))]
	[XmlInclude(typeof(RequestedDeliveryDateType))]
	[XmlInclude(typeof(RegistrationExpirationDateType))]
	[XmlInclude(typeof(RegistrationDateType))]
	[XmlInclude(typeof(RegisteredDateType))]
	[XmlInclude(typeof(ReferenceDateType))]
	[XmlInclude(typeof(ReceivedDateType))]
	[XmlInclude(typeof(PreviousMeterReadingDateType))]
	[XmlInclude(typeof(PlannedDateType))]
	[XmlInclude(typeof(PaymentDueDateType))]
	[XmlInclude(typeof(PaidDateType))]
	[XmlInclude(typeof(OccurrenceDateType))]
	[XmlInclude(typeof(NominationDateType))]
	[XmlInclude(typeof(ManufactureDateType))]
	[XmlInclude(typeof(LatestSecurityClearanceDateType))]
	[XmlInclude(typeof(LatestProposalAcceptanceDateType))]
	[XmlInclude(typeof(LatestPickupDateType))]
	[XmlInclude(typeof(LatestMeterReadingDateType))]
	[XmlInclude(typeof(LatestDeliveryDateType))]
	[XmlInclude(typeof(LastRevisionDateType))]
	[XmlInclude(typeof(IssueDateType))]
	[XmlInclude(typeof(InstallmentDueDateType))]
	[XmlInclude(typeof(GuaranteedDespatchDateType))]
	[XmlInclude(typeof(FirstShipmentAvailibilityDateType))]
	[XmlInclude(typeof(ExpiryDateType))]
	[XmlInclude(typeof(EstimatedDespatchDateType))]
	[XmlInclude(typeof(EstimatedDeliveryDateType))]
	[XmlInclude(typeof(EndDateType))]
	[XmlInclude(typeof(EffectiveDateType))]
	[XmlInclude(typeof(EarliestPickupDateType))]
	[XmlInclude(typeof(DueDateType))]
	[XmlInclude(typeof(DateType1))]
	[XmlInclude(typeof(ComparisonForecastIssueDateType))]
	[XmlInclude(typeof(CallDateType))]
	[XmlInclude(typeof(BirthDateType))]
	[XmlInclude(typeof(BestBeforeDateType))]
	[XmlInclude(typeof(AwardDateType))]
	[XmlInclude(typeof(AvailabilityDateType))]
	[XmlInclude(typeof(ApprovalDateType))]
	[XmlInclude(typeof(ActualPickupDateType))]
	[XmlInclude(typeof(ActualDespatchDateType))]
	[XmlInclude(typeof(ActualDeliveryDateType))]
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
	[Serializable]
	public class DateType
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00003156 File Offset: 0x00001356
		// (set) Token: 0x06000395 RID: 917 RVA: 0x0000315E File Offset: 0x0000135E
		[XmlText(DataType = "date")]
		public DateTime Value
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

		// Token: 0x04000136 RID: 310
		private DateTime valueField;
	}
}

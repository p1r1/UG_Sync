using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000282 RID: 642
	[XmlInclude(typeof(ValidationTimeType))]
	[XmlInclude(typeof(StartTimeType))]
	[XmlInclude(typeof(SourceForecastIssueTimeType))]
	[XmlInclude(typeof(RevisionTimeType))]
	[XmlInclude(typeof(ResponseTimeType))]
	[XmlInclude(typeof(ResolutionTimeType))]
	[XmlInclude(typeof(RequiredDeliveryTimeType))]
	[XmlInclude(typeof(RequestedDespatchTimeType))]
	[XmlInclude(typeof(RegisteredTimeType))]
	[XmlInclude(typeof(ReferenceTimeType))]
	[XmlInclude(typeof(PaidTimeType))]
	[XmlInclude(typeof(OccurrenceTimeType))]
	[XmlInclude(typeof(NominationTimeType))]
	[XmlInclude(typeof(ManufactureTimeType))]
	[XmlInclude(typeof(LatestPickupTimeType))]
	[XmlInclude(typeof(LatestDeliveryTimeType))]
	[XmlInclude(typeof(LastRevisionTimeType))]
	[XmlInclude(typeof(IssueTimeType))]
	[XmlInclude(typeof(GuaranteedDespatchTimeType))]
	[XmlInclude(typeof(ExpiryTimeType))]
	[XmlInclude(typeof(EstimatedDespatchTimeType))]
	[XmlInclude(typeof(EstimatedDeliveryTimeType))]
	[XmlInclude(typeof(EndTimeType))]
	[XmlInclude(typeof(EffectiveTimeType))]
	[XmlInclude(typeof(EarliestPickupTimeType))]
	[XmlInclude(typeof(ComparisonForecastIssueTimeType))]
	[XmlInclude(typeof(CallTimeType))]
	[XmlInclude(typeof(AwardTimeType))]
	[XmlInclude(typeof(ActualPickupTimeType))]
	[XmlInclude(typeof(ActualDespatchTimeType))]
	[XmlInclude(typeof(ActualDeliveryTimeType))]
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
	[Serializable]
	public class TimeType
	{
		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x00003286 File Offset: 0x00001486
		// (set) Token: 0x060004C5 RID: 1221 RVA: 0x0000328E File Offset: 0x0000148E
		[XmlText(DataType = "time")]
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

		// Token: 0x04000146 RID: 326
		private DateTime valueField;
	}
}

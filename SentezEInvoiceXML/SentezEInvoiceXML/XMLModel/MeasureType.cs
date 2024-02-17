using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020002A3 RID: 675
	[XmlInclude(typeof(MeasureType1))]
	[XmlInclude(typeof(ValueMeasureType))]
	[XmlInclude(typeof(TareWeightMeasureType))]
	[XmlInclude(typeof(SourceValueMeasureType))]
	[XmlInclude(typeof(PreEventNotificationDurationMeasureType))]
	[XmlInclude(typeof(PostEventNotificationDurationMeasureType))]
	[XmlInclude(typeof(NetWeightMeasureType))]
	[XmlInclude(typeof(NetVolumeMeasureType))]
	[XmlInclude(typeof(NetTonnageMeasureType))]
	[XmlInclude(typeof(NetNetWeightMeasureType))]
	[XmlInclude(typeof(MinimumMeasureType))]
	[XmlInclude(typeof(MeasureType2))]
	[XmlInclude(typeof(MaximumMeasureType))]
	[XmlInclude(typeof(LongitudeMinutesMeasureType))]
	[XmlInclude(typeof(LongitudeDegreesMeasureType))]
	[XmlInclude(typeof(LoadingLengthMeasureType))]
	[XmlInclude(typeof(LeadTimeMeasureType))]
	[XmlInclude(typeof(LatitudeMinutesMeasureType))]
	[XmlInclude(typeof(LatitudeDegreesMeasureType))]
	[XmlInclude(typeof(GrossWeightMeasureType))]
	[XmlInclude(typeof(GrossVolumeMeasureType))]
	[XmlInclude(typeof(GrossTonnageMeasureType))]
	[XmlInclude(typeof(DurationMeasureType))]
	[XmlInclude(typeof(ComparedValueMeasureType))]
	[XmlInclude(typeof(ChargeableWeightMeasureType))]
	[XmlInclude(typeof(BaseUnitMeasureType))]
	[XmlInclude(typeof(AltitudeMeasureType))]
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
	[Serializable]
	public class MeasureType
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x000032C3 File Offset: 0x000014C3
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x000032CB File Offset: 0x000014CB
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

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x000032DC File Offset: 0x000014DC
		[XmlAttribute(DataType = "normalizedString")]
		public string unitCodeListVersionID
		{
			get
			{
				return this.unitCodeListVersionIDField;
			}
			set
			{
				this.unitCodeListVersionIDField = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x000032E5 File Offset: 0x000014E5
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x000032ED File Offset: 0x000014ED
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

		// Token: 0x04000149 RID: 329
		private string unitCodeField;

		// Token: 0x0400014A RID: 330
		private string unitCodeListVersionIDField;

		// Token: 0x0400014B RID: 331
		private decimal valueField;
	}
}

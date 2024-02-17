using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000280 RID: 640
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ActivityPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class PeriodType
	{
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x00003218 File Offset: 0x00001418
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x00003220 File Offset: 0x00001420
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public StartDateType StartDate
		{
			get
			{
				return this.startDateField;
			}
			set
			{
				this.startDateField = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00003229 File Offset: 0x00001429
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x00003231 File Offset: 0x00001431
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public StartTimeType StartTime
		{
			get
			{
				return this.startTimeField;
			}
			set
			{
				this.startTimeField = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x0000323A File Offset: 0x0000143A
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x00003242 File Offset: 0x00001442
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public EndDateType EndDate
		{
			get
			{
				return this.endDateField;
			}
			set
			{
				this.endDateField = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x0000324B File Offset: 0x0000144B
		// (set) Token: 0x060004BD RID: 1213 RVA: 0x00003253 File Offset: 0x00001453
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public EndTimeType EndTime
		{
			get
			{
				return this.endTimeField;
			}
			set
			{
				this.endTimeField = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x0000325C File Offset: 0x0000145C
		// (set) Token: 0x060004BF RID: 1215 RVA: 0x00003264 File Offset: 0x00001464
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DurationMeasureType DurationMeasure
		{
			get
			{
				return this.durationMeasureField;
			}
			set
			{
				this.durationMeasureField = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x0000326D File Offset: 0x0000146D
		// (set) Token: 0x060004C1 RID: 1217 RVA: 0x00003275 File Offset: 0x00001475
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DescriptionType Description
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

		// Token: 0x04000140 RID: 320
		private StartDateType startDateField;

		// Token: 0x04000141 RID: 321
		private StartTimeType startTimeField;

		// Token: 0x04000142 RID: 322
		private EndDateType endDateField;

		// Token: 0x04000143 RID: 323
		private EndTimeType endTimeField;

		// Token: 0x04000144 RID: 324
		private DurationMeasureType durationMeasureField;

		// Token: 0x04000145 RID: 325
		private DescriptionType descriptionField;
	}
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000466 RID: 1126
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ForecastRevisionLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ForecastRevisionLineType
	{
		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x060010A9 RID: 4265 RVA: 0x000087C8 File Offset: 0x000069C8
		// (set) Token: 0x060010AA RID: 4266 RVA: 0x000087D0 File Offset: 0x000069D0
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IDType ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x060010AB RID: 4267 RVA: 0x000087D9 File Offset: 0x000069D9
		// (set) Token: 0x060010AC RID: 4268 RVA: 0x000087E1 File Offset: 0x000069E1
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

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x060010AD RID: 4269 RVA: 0x000087EA File Offset: 0x000069EA
		// (set) Token: 0x060010AE RID: 4270 RVA: 0x000087F2 File Offset: 0x000069F2
		[XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DescriptionType[] Description
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

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x060010AF RID: 4271 RVA: 0x000087FB File Offset: 0x000069FB
		// (set) Token: 0x060010B0 RID: 4272 RVA: 0x00008803 File Offset: 0x00006A03
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public RevisedForecastLineIDType RevisedForecastLineID
		{
			get
			{
				return this.revisedForecastLineIDField;
			}
			set
			{
				this.revisedForecastLineIDField = value;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x060010B1 RID: 4273 RVA: 0x0000880C File Offset: 0x00006A0C
		// (set) Token: 0x060010B2 RID: 4274 RVA: 0x00008814 File Offset: 0x00006A14
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SourceForecastIssueDateType SourceForecastIssueDate
		{
			get
			{
				return this.sourceForecastIssueDateField;
			}
			set
			{
				this.sourceForecastIssueDateField = value;
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x060010B3 RID: 4275 RVA: 0x0000881D File Offset: 0x00006A1D
		// (set) Token: 0x060010B4 RID: 4276 RVA: 0x00008825 File Offset: 0x00006A25
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SourceForecastIssueTimeType SourceForecastIssueTime
		{
			get
			{
				return this.sourceForecastIssueTimeField;
			}
			set
			{
				this.sourceForecastIssueTimeField = value;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x0000882E File Offset: 0x00006A2E
		// (set) Token: 0x060010B6 RID: 4278 RVA: 0x00008836 File Offset: 0x00006A36
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AdjustmentReasonCodeType AdjustmentReasonCode
		{
			get
			{
				return this.adjustmentReasonCodeField;
			}
			set
			{
				this.adjustmentReasonCodeField = value;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x060010B7 RID: 4279 RVA: 0x0000883F File Offset: 0x00006A3F
		// (set) Token: 0x060010B8 RID: 4280 RVA: 0x00008847 File Offset: 0x00006A47
		public PeriodType ForecastPeriod
		{
			get
			{
				return this.forecastPeriodField;
			}
			set
			{
				this.forecastPeriodField = value;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x00008850 File Offset: 0x00006A50
		// (set) Token: 0x060010BA RID: 4282 RVA: 0x00008858 File Offset: 0x00006A58
		public SalesItemType SalesItem
		{
			get
			{
				return this.salesItemField;
			}
			set
			{
				this.salesItemField = value;
			}
		}

		// Token: 0x04000646 RID: 1606
		private IDType idField;

		// Token: 0x04000647 RID: 1607
		private NoteType[] noteField;

		// Token: 0x04000648 RID: 1608
		private DescriptionType[] descriptionField;

		// Token: 0x04000649 RID: 1609
		private RevisedForecastLineIDType revisedForecastLineIDField;

		// Token: 0x0400064A RID: 1610
		private SourceForecastIssueDateType sourceForecastIssueDateField;

		// Token: 0x0400064B RID: 1611
		private SourceForecastIssueTimeType sourceForecastIssueTimeField;

		// Token: 0x0400064C RID: 1612
		private AdjustmentReasonCodeType adjustmentReasonCodeField;

		// Token: 0x0400064D RID: 1613
		private PeriodType forecastPeriodField;

		// Token: 0x0400064E RID: 1614
		private SalesItemType salesItemField;
	}
}

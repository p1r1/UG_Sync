using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000465 RID: 1125
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ForecastLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ForecastLineType
	{
		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x0600109C RID: 4252 RVA: 0x00008762 File Offset: 0x00006962
		// (set) Token: 0x0600109D RID: 4253 RVA: 0x0000876A File Offset: 0x0000696A
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

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x00008773 File Offset: 0x00006973
		// (set) Token: 0x0600109F RID: 4255 RVA: 0x0000877B File Offset: 0x0000697B
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

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x00008784 File Offset: 0x00006984
		// (set) Token: 0x060010A1 RID: 4257 RVA: 0x0000878C File Offset: 0x0000698C
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public FrozenDocumentIndicatorType FrozenDocumentIndicator
		{
			get
			{
				return this.frozenDocumentIndicatorField;
			}
			set
			{
				this.frozenDocumentIndicatorField = value;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x00008795 File Offset: 0x00006995
		// (set) Token: 0x060010A3 RID: 4259 RVA: 0x0000879D File Offset: 0x0000699D
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ForecastTypeCodeType ForecastTypeCode
		{
			get
			{
				return this.forecastTypeCodeField;
			}
			set
			{
				this.forecastTypeCodeField = value;
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x000087A6 File Offset: 0x000069A6
		// (set) Token: 0x060010A5 RID: 4261 RVA: 0x000087AE File Offset: 0x000069AE
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

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x000087B7 File Offset: 0x000069B7
		// (set) Token: 0x060010A7 RID: 4263 RVA: 0x000087BF File Offset: 0x000069BF
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

		// Token: 0x04000640 RID: 1600
		private IDType idField;

		// Token: 0x04000641 RID: 1601
		private NoteType[] noteField;

		// Token: 0x04000642 RID: 1602
		private FrozenDocumentIndicatorType frozenDocumentIndicatorField;

		// Token: 0x04000643 RID: 1603
		private ForecastTypeCodeType forecastTypeCodeField;

		// Token: 0x04000644 RID: 1604
		private PeriodType forecastPeriodField;

		// Token: 0x04000645 RID: 1605
		private SalesItemType salesItemField;
	}
}

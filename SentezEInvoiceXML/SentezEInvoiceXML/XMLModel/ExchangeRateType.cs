using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200006E RID: 110
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ExchangeRate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ExchangeRateType
	{
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0000300E File Offset: 0x0000120E
		// (set) Token: 0x06000271 RID: 625 RVA: 0x00003016 File Offset: 0x00001216
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SourceCurrencyCodeType SourceCurrencyCode
		{
			get
			{
				return this.sourceCurrencyCodeField;
			}
			set
			{
				this.sourceCurrencyCodeField = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0000301F File Offset: 0x0000121F
		// (set) Token: 0x06000273 RID: 627 RVA: 0x00003027 File Offset: 0x00001227
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TargetCurrencyCodeType TargetCurrencyCode
		{
			get
			{
				return this.targetCurrencyCodeField;
			}
			set
			{
				this.targetCurrencyCodeField = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000274 RID: 628 RVA: 0x00003030 File Offset: 0x00001230
		// (set) Token: 0x06000275 RID: 629 RVA: 0x00003038 File Offset: 0x00001238
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CalculationRateType CalculationRate
		{
			get
			{
				return this.calculationRateField;
			}
			set
			{
				this.calculationRateField = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00003041 File Offset: 0x00001241
		// (set) Token: 0x06000277 RID: 631 RVA: 0x00003049 File Offset: 0x00001249
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DateType1 Date
		{
			get
			{
				return this.dateField;
			}
			set
			{
				this.dateField = value;
			}
		}

		// Token: 0x04000126 RID: 294
		private SourceCurrencyCodeType sourceCurrencyCodeField;

		// Token: 0x04000127 RID: 295
		private TargetCurrencyCodeType targetCurrencyCodeField;

		// Token: 0x04000128 RID: 296
		private CalculationRateType calculationRateField;

		// Token: 0x04000129 RID: 297
		private DateType1 dateField;
	}
}

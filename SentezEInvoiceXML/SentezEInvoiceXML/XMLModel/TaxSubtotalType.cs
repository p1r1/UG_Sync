using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003ED RID: 1005
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("TaxSubtotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class TaxSubtotalType
	{
		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x00004B8D File Offset: 0x00002D8D
		// (set) Token: 0x0600091B RID: 2331 RVA: 0x00004B95 File Offset: 0x00002D95
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TaxableAmountType TaxableAmount
		{
			get
			{
				return this.taxableAmountField;
			}
			set
			{
				this.taxableAmountField = value;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x00004B9E File Offset: 0x00002D9E
		// (set) Token: 0x0600091D RID: 2333 RVA: 0x00004BA6 File Offset: 0x00002DA6
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TaxAmountType TaxAmount
		{
			get
			{
				return this.taxAmountField;
			}
			set
			{
				this.taxAmountField = value;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x00004BAF File Offset: 0x00002DAF
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x00004BB7 File Offset: 0x00002DB7
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CalculationSequenceNumericType CalculationSequenceNumeric
		{
			get
			{
				return this.calculationSequenceNumericField;
			}
			set
			{
				this.calculationSequenceNumericField = value;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x00004BC0 File Offset: 0x00002DC0
		// (set) Token: 0x06000921 RID: 2337 RVA: 0x00004BC8 File Offset: 0x00002DC8
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TransactionCurrencyTaxAmountType TransactionCurrencyTaxAmount
		{
			get
			{
				return this.transactionCurrencyTaxAmountField;
			}
			set
			{
				this.transactionCurrencyTaxAmountField = value;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x00004BD1 File Offset: 0x00002DD1
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x00004BD9 File Offset: 0x00002DD9
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PercentType1 Percent
		{
			get
			{
				return this.percentField;
			}
			set
			{
				this.percentField = value;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x00004BE2 File Offset: 0x00002DE2
		// (set) Token: 0x06000925 RID: 2341 RVA: 0x00004BEA File Offset: 0x00002DEA
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public BaseUnitMeasureType BaseUnitMeasure
		{
			get
			{
				return this.baseUnitMeasureField;
			}
			set
			{
				this.baseUnitMeasureField = value;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x00004BF3 File Offset: 0x00002DF3
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x00004BFB File Offset: 0x00002DFB
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PerUnitAmountType PerUnitAmount
		{
			get
			{
				return this.perUnitAmountField;
			}
			set
			{
				this.perUnitAmountField = value;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x00004C04 File Offset: 0x00002E04
		// (set) Token: 0x06000929 RID: 2345 RVA: 0x00004C0C File Offset: 0x00002E0C
		public TaxCategoryType TaxCategory
		{
			get
			{
				return this.taxCategoryField;
			}
			set
			{
				this.taxCategoryField = value;
			}
		}

		// Token: 0x040002BB RID: 699
		private TaxableAmountType taxableAmountField;

		// Token: 0x040002BC RID: 700
		private TaxAmountType taxAmountField;

		// Token: 0x040002BD RID: 701
		private CalculationSequenceNumericType calculationSequenceNumericField;

		// Token: 0x040002BE RID: 702
		private TransactionCurrencyTaxAmountType transactionCurrencyTaxAmountField;

		// Token: 0x040002BF RID: 703
		private PercentType1 percentField;

		// Token: 0x040002C0 RID: 704
		private BaseUnitMeasureType baseUnitMeasureField;

		// Token: 0x040002C1 RID: 705
		private PerUnitAmountType perUnitAmountField;

		// Token: 0x040002C2 RID: 706
		private TaxCategoryType taxCategoryField;
	}
}

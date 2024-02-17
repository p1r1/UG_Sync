using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200042B RID: 1067
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("RequestedTenderTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class RequestedTenderTotalType
	{
		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x0000671C File Offset: 0x0000491C
		// (set) Token: 0x06000C97 RID: 3223 RVA: 0x00006724 File Offset: 0x00004924
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public EstimatedOverallContractAmountType EstimatedOverallContractAmount
		{
			get
			{
				return this.estimatedOverallContractAmountField;
			}
			set
			{
				this.estimatedOverallContractAmountField = value;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x0000672D File Offset: 0x0000492D
		// (set) Token: 0x06000C99 RID: 3225 RVA: 0x00006735 File Offset: 0x00004935
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TotalAmountType TotalAmount
		{
			get
			{
				return this.totalAmountField;
			}
			set
			{
				this.totalAmountField = value;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000C9A RID: 3226 RVA: 0x0000673E File Offset: 0x0000493E
		// (set) Token: 0x06000C9B RID: 3227 RVA: 0x00006746 File Offset: 0x00004946
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TaxIncludedIndicatorType TaxIncludedIndicator
		{
			get
			{
				return this.taxIncludedIndicatorField;
			}
			set
			{
				this.taxIncludedIndicatorField = value;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000C9C RID: 3228 RVA: 0x0000674F File Offset: 0x0000494F
		// (set) Token: 0x06000C9D RID: 3229 RVA: 0x00006757 File Offset: 0x00004957
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MinimumAmountType MinimumAmount
		{
			get
			{
				return this.minimumAmountField;
			}
			set
			{
				this.minimumAmountField = value;
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000C9E RID: 3230 RVA: 0x00006760 File Offset: 0x00004960
		// (set) Token: 0x06000C9F RID: 3231 RVA: 0x00006768 File Offset: 0x00004968
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MaximumAmountType MaximumAmount
		{
			get
			{
				return this.maximumAmountField;
			}
			set
			{
				this.maximumAmountField = value;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x00006771 File Offset: 0x00004971
		// (set) Token: 0x06000CA1 RID: 3233 RVA: 0x00006779 File Offset: 0x00004979
		[XmlElement("MonetaryScope", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MonetaryScopeType[] MonetaryScope
		{
			get
			{
				return this.monetaryScopeField;
			}
			set
			{
				this.monetaryScopeField = value;
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x00006782 File Offset: 0x00004982
		// (set) Token: 0x06000CA3 RID: 3235 RVA: 0x0000678A File Offset: 0x0000498A
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AverageSubsequentContractAmountType AverageSubsequentContractAmount
		{
			get
			{
				return this.averageSubsequentContractAmountField;
			}
			set
			{
				this.averageSubsequentContractAmountField = value;
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x00006793 File Offset: 0x00004993
		// (set) Token: 0x06000CA5 RID: 3237 RVA: 0x0000679B File Offset: 0x0000499B
		[XmlElement("ApplicableTaxCategory")]
		public TaxCategoryType[] ApplicableTaxCategory
		{
			get
			{
				return this.applicableTaxCategoryField;
			}
			set
			{
				this.applicableTaxCategoryField = value;
			}
		}

		// Token: 0x0400045A RID: 1114
		private EstimatedOverallContractAmountType estimatedOverallContractAmountField;

		// Token: 0x0400045B RID: 1115
		private TotalAmountType totalAmountField;

		// Token: 0x0400045C RID: 1116
		private TaxIncludedIndicatorType taxIncludedIndicatorField;

		// Token: 0x0400045D RID: 1117
		private MinimumAmountType minimumAmountField;

		// Token: 0x0400045E RID: 1118
		private MaximumAmountType maximumAmountField;

		// Token: 0x0400045F RID: 1119
		private MonetaryScopeType[] monetaryScopeField;

		// Token: 0x04000460 RID: 1120
		private AverageSubsequentContractAmountType averageSubsequentContractAmountField;

		// Token: 0x04000461 RID: 1121
		private TaxCategoryType[] applicableTaxCategoryField;
	}
}

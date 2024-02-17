using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000464 RID: 1124
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ForecastException", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ForecastExceptionType
	{
		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x0600108B RID: 4235 RVA: 0x000086DA File Offset: 0x000068DA
		// (set) Token: 0x0600108C RID: 4236 RVA: 0x000086E2 File Offset: 0x000068E2
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ForecastPurposeCodeType ForecastPurposeCode
		{
			get
			{
				return this.forecastPurposeCodeField;
			}
			set
			{
				this.forecastPurposeCodeField = value;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x0600108D RID: 4237 RVA: 0x000086EB File Offset: 0x000068EB
		// (set) Token: 0x0600108E RID: 4238 RVA: 0x000086F3 File Offset: 0x000068F3
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

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x0600108F RID: 4239 RVA: 0x000086FC File Offset: 0x000068FC
		// (set) Token: 0x06001090 RID: 4240 RVA: 0x00008704 File Offset: 0x00006904
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IssueDateType IssueDate
		{
			get
			{
				return this.issueDateField;
			}
			set
			{
				this.issueDateField = value;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x0000870D File Offset: 0x0000690D
		// (set) Token: 0x06001092 RID: 4242 RVA: 0x00008715 File Offset: 0x00006915
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IssueTimeType IssueTime
		{
			get
			{
				return this.issueTimeField;
			}
			set
			{
				this.issueTimeField = value;
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001093 RID: 4243 RVA: 0x0000871E File Offset: 0x0000691E
		// (set) Token: 0x06001094 RID: 4244 RVA: 0x00008726 File Offset: 0x00006926
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DataSourceCodeType DataSourceCode
		{
			get
			{
				return this.dataSourceCodeField;
			}
			set
			{
				this.dataSourceCodeField = value;
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001095 RID: 4245 RVA: 0x0000872F File Offset: 0x0000692F
		// (set) Token: 0x06001096 RID: 4246 RVA: 0x00008737 File Offset: 0x00006937
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ComparisonDataCodeType ComparisonDataCode
		{
			get
			{
				return this.comparisonDataCodeField;
			}
			set
			{
				this.comparisonDataCodeField = value;
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x00008740 File Offset: 0x00006940
		// (set) Token: 0x06001098 RID: 4248 RVA: 0x00008748 File Offset: 0x00006948
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ComparisonForecastIssueTimeType ComparisonForecastIssueTime
		{
			get
			{
				return this.comparisonForecastIssueTimeField;
			}
			set
			{
				this.comparisonForecastIssueTimeField = value;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x00008751 File Offset: 0x00006951
		// (set) Token: 0x0600109A RID: 4250 RVA: 0x00008759 File Offset: 0x00006959
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ComparisonForecastIssueDateType ComparisonForecastIssueDate
		{
			get
			{
				return this.comparisonForecastIssueDateField;
			}
			set
			{
				this.comparisonForecastIssueDateField = value;
			}
		}

		// Token: 0x04000638 RID: 1592
		private ForecastPurposeCodeType forecastPurposeCodeField;

		// Token: 0x04000639 RID: 1593
		private ForecastTypeCodeType forecastTypeCodeField;

		// Token: 0x0400063A RID: 1594
		private IssueDateType issueDateField;

		// Token: 0x0400063B RID: 1595
		private IssueTimeType issueTimeField;

		// Token: 0x0400063C RID: 1596
		private DataSourceCodeType dataSourceCodeField;

		// Token: 0x0400063D RID: 1597
		private ComparisonDataCodeType comparisonDataCodeField;

		// Token: 0x0400063E RID: 1598
		private ComparisonForecastIssueTimeType comparisonForecastIssueTimeField;

		// Token: 0x0400063F RID: 1599
		private ComparisonForecastIssueDateType comparisonForecastIssueDateField;
	}
}

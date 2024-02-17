using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000462 RID: 1122
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ForecastExceptionCriterionLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ForecastExceptionCriterionLineType
	{
		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001061 RID: 4193 RVA: 0x00008586 File Offset: 0x00006786
		// (set) Token: 0x06001062 RID: 4194 RVA: 0x0000858E File Offset: 0x0000678E
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

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001063 RID: 4195 RVA: 0x00008597 File Offset: 0x00006797
		// (set) Token: 0x06001064 RID: 4196 RVA: 0x0000859F File Offset: 0x0000679F
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

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001065 RID: 4197 RVA: 0x000085A8 File Offset: 0x000067A8
		// (set) Token: 0x06001066 RID: 4198 RVA: 0x000085B0 File Offset: 0x000067B0
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ComparisonDataSourceCodeType ComparisonDataSourceCode
		{
			get
			{
				return this.comparisonDataSourceCodeField;
			}
			set
			{
				this.comparisonDataSourceCodeField = value;
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001067 RID: 4199 RVA: 0x000085B9 File Offset: 0x000067B9
		// (set) Token: 0x06001068 RID: 4200 RVA: 0x000085C1 File Offset: 0x000067C1
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

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001069 RID: 4201 RVA: 0x000085CA File Offset: 0x000067CA
		// (set) Token: 0x0600106A RID: 4202 RVA: 0x000085D2 File Offset: 0x000067D2
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TimeDeltaDaysQuantityType TimeDeltaDaysQuantity
		{
			get
			{
				return this.timeDeltaDaysQuantityField;
			}
			set
			{
				this.timeDeltaDaysQuantityField = value;
			}
		}

		// Token: 0x04000624 RID: 1572
		private ForecastPurposeCodeType forecastPurposeCodeField;

		// Token: 0x04000625 RID: 1573
		private ForecastTypeCodeType forecastTypeCodeField;

		// Token: 0x04000626 RID: 1574
		private ComparisonDataSourceCodeType comparisonDataSourceCodeField;

		// Token: 0x04000627 RID: 1575
		private DataSourceCodeType dataSourceCodeField;

		// Token: 0x04000628 RID: 1576
		private TimeDeltaDaysQuantityType timeDeltaDaysQuantityField;
	}
}

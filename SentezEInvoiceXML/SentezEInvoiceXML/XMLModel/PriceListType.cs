using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000479 RID: 1145
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("PreviousPriceList", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class PriceListType
	{
		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x060011D2 RID: 4562 RVA: 0x00009103 File Offset: 0x00007303
		// (set) Token: 0x060011D3 RID: 4563 RVA: 0x0000910B File Offset: 0x0000730B
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

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x00009114 File Offset: 0x00007314
		// (set) Token: 0x060011D5 RID: 4565 RVA: 0x0000911C File Offset: 0x0000731C
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public StatusCodeType StatusCode
		{
			get
			{
				return this.statusCodeField;
			}
			set
			{
				this.statusCodeField = value;
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x00009125 File Offset: 0x00007325
		// (set) Token: 0x060011D7 RID: 4567 RVA: 0x0000912D File Offset: 0x0000732D
		[XmlElement("ValidityPeriod")]
		public PeriodType[] ValidityPeriod
		{
			get
			{
				return this.validityPeriodField;
			}
			set
			{
				this.validityPeriodField = value;
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x060011D8 RID: 4568 RVA: 0x00009136 File Offset: 0x00007336
		// (set) Token: 0x060011D9 RID: 4569 RVA: 0x0000913E File Offset: 0x0000733E
		public PriceListType PreviousPriceList
		{
			get
			{
				return this.previousPriceListField;
			}
			set
			{
				this.previousPriceListField = value;
			}
		}

		// Token: 0x040006D1 RID: 1745
		private IDType idField;

		// Token: 0x040006D2 RID: 1746
		private StatusCodeType statusCodeField;

		// Token: 0x040006D3 RID: 1747
		private PeriodType[] validityPeriodField;

		// Token: 0x040006D4 RID: 1748
		private PriceListType previousPriceListField;
	}
}

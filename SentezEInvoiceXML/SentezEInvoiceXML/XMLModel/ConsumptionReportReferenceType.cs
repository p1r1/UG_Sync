using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000441 RID: 1089
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ConsumptionReportReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ConsumptionReportReferenceType
	{
		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000E34 RID: 3636 RVA: 0x00007420 File Offset: 0x00005620
		// (set) Token: 0x06000E35 RID: 3637 RVA: 0x00007428 File Offset: 0x00005628
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ConsumptionReportIDType ConsumptionReportID
		{
			get
			{
				return this.consumptionReportIDField;
			}
			set
			{
				this.consumptionReportIDField = value;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x00007431 File Offset: 0x00005631
		// (set) Token: 0x06000E37 RID: 3639 RVA: 0x00007439 File Offset: 0x00005639
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ConsumptionTypeType ConsumptionType
		{
			get
			{
				return this.consumptionTypeField;
			}
			set
			{
				this.consumptionTypeField = value;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x00007442 File Offset: 0x00005642
		// (set) Token: 0x06000E39 RID: 3641 RVA: 0x0000744A File Offset: 0x0000564A
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ConsumptionTypeCodeType ConsumptionTypeCode
		{
			get
			{
				return this.consumptionTypeCodeField;
			}
			set
			{
				this.consumptionTypeCodeField = value;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x00007453 File Offset: 0x00005653
		// (set) Token: 0x06000E3B RID: 3643 RVA: 0x0000745B File Offset: 0x0000565B
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TotalConsumedQuantityType TotalConsumedQuantity
		{
			get
			{
				return this.totalConsumedQuantityField;
			}
			set
			{
				this.totalConsumedQuantityField = value;
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x00007464 File Offset: 0x00005664
		// (set) Token: 0x06000E3D RID: 3645 RVA: 0x0000746C File Offset: 0x0000566C
		public PeriodType Period
		{
			get
			{
				return this.periodField;
			}
			set
			{
				this.periodField = value;
			}
		}

		// Token: 0x0400051E RID: 1310
		private ConsumptionReportIDType consumptionReportIDField;

		// Token: 0x0400051F RID: 1311
		private ConsumptionTypeType consumptionTypeField;

		// Token: 0x04000520 RID: 1312
		private ConsumptionTypeCodeType consumptionTypeCodeField;

		// Token: 0x04000521 RID: 1313
		private TotalConsumedQuantityType totalConsumedQuantityField;

		// Token: 0x04000522 RID: 1314
		private PeriodType periodField;
	}
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000442 RID: 1090
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ConsumptionHistory", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ConsumptionHistoryType
	{
		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x00007475 File Offset: 0x00005675
		// (set) Token: 0x06000E40 RID: 3648 RVA: 0x0000747D File Offset: 0x0000567D
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MeterNumberType MeterNumber
		{
			get
			{
				return this.meterNumberField;
			}
			set
			{
				this.meterNumberField = value;
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x00007486 File Offset: 0x00005686
		// (set) Token: 0x06000E42 RID: 3650 RVA: 0x0000748E File Offset: 0x0000568E
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType2 Quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x00007497 File Offset: 0x00005697
		// (set) Token: 0x06000E44 RID: 3652 RVA: 0x0000749F File Offset: 0x0000569F
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AmountType2 Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x000074A8 File Offset: 0x000056A8
		// (set) Token: 0x06000E46 RID: 3654 RVA: 0x000074B0 File Offset: 0x000056B0
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ConsumptionLevelCodeType ConsumptionLevelCode
		{
			get
			{
				return this.consumptionLevelCodeField;
			}
			set
			{
				this.consumptionLevelCodeField = value;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x000074B9 File Offset: 0x000056B9
		// (set) Token: 0x06000E48 RID: 3656 RVA: 0x000074C1 File Offset: 0x000056C1
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ConsumptionLevelType ConsumptionLevel
		{
			get
			{
				return this.consumptionLevelField;
			}
			set
			{
				this.consumptionLevelField = value;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x000074CA File Offset: 0x000056CA
		// (set) Token: 0x06000E4A RID: 3658 RVA: 0x000074D2 File Offset: 0x000056D2
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

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x000074DB File Offset: 0x000056DB
		// (set) Token: 0x06000E4C RID: 3660 RVA: 0x000074E3 File Offset: 0x000056E3
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

		// Token: 0x04000523 RID: 1315
		private MeterNumberType meterNumberField;

		// Token: 0x04000524 RID: 1316
		private QuantityType2 quantityField;

		// Token: 0x04000525 RID: 1317
		private AmountType2 amountField;

		// Token: 0x04000526 RID: 1318
		private ConsumptionLevelCodeType consumptionLevelCodeField;

		// Token: 0x04000527 RID: 1319
		private ConsumptionLevelType consumptionLevelField;

		// Token: 0x04000528 RID: 1320
		private DescriptionType[] descriptionField;

		// Token: 0x04000529 RID: 1321
		private PeriodType periodField;
	}
}

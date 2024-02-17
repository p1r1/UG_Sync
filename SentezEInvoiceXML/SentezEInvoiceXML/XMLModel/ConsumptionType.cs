using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200043E RID: 1086
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("Consumption", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ConsumptionType
	{
		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x00007233 File Offset: 0x00005433
		// (set) Token: 0x06000DF8 RID: 3576 RVA: 0x0000723B File Offset: 0x0000543B
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public UtilityStatementTypeCodeType UtilityStatementTypeCode
		{
			get
			{
				return this.utilityStatementTypeCodeField;
			}
			set
			{
				this.utilityStatementTypeCodeField = value;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x00007244 File Offset: 0x00005444
		// (set) Token: 0x06000DFA RID: 3578 RVA: 0x0000724C File Offset: 0x0000544C
		public PeriodType MainPeriod
		{
			get
			{
				return this.mainPeriodField;
			}
			set
			{
				this.mainPeriodField = value;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000DFB RID: 3579 RVA: 0x00007255 File Offset: 0x00005455
		// (set) Token: 0x06000DFC RID: 3580 RVA: 0x0000725D File Offset: 0x0000545D
		[XmlElement("AllowanceCharge")]
		public AllowanceChargeType[] AllowanceCharge
		{
			get
			{
				return this.allowanceChargeField;
			}
			set
			{
				this.allowanceChargeField = value;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x00007266 File Offset: 0x00005466
		// (set) Token: 0x06000DFE RID: 3582 RVA: 0x0000726E File Offset: 0x0000546E
		[XmlElement("TaxTotal")]
		public TaxTotalType[] TaxTotal
		{
			get
			{
				return this.taxTotalField;
			}
			set
			{
				this.taxTotalField = value;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x00007277 File Offset: 0x00005477
		// (set) Token: 0x06000E00 RID: 3584 RVA: 0x0000727F File Offset: 0x0000547F
		public EnergyWaterSupplyType EnergyWaterSupply
		{
			get
			{
				return this.energyWaterSupplyField;
			}
			set
			{
				this.energyWaterSupplyField = value;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000E01 RID: 3585 RVA: 0x00007288 File Offset: 0x00005488
		// (set) Token: 0x06000E02 RID: 3586 RVA: 0x00007290 File Offset: 0x00005490
		public TelecommunicationsSupplyType TelecommunicationsSupply
		{
			get
			{
				return this.telecommunicationsSupplyField;
			}
			set
			{
				this.telecommunicationsSupplyField = value;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000E03 RID: 3587 RVA: 0x00007299 File Offset: 0x00005499
		// (set) Token: 0x06000E04 RID: 3588 RVA: 0x000072A1 File Offset: 0x000054A1
		public MonetaryTotalType LegalMonetaryTotal
		{
			get
			{
				return this.legalMonetaryTotalField;
			}
			set
			{
				this.legalMonetaryTotalField = value;
			}
		}

		// Token: 0x04000501 RID: 1281
		private UtilityStatementTypeCodeType utilityStatementTypeCodeField;

		// Token: 0x04000502 RID: 1282
		private PeriodType mainPeriodField;

		// Token: 0x04000503 RID: 1283
		private AllowanceChargeType[] allowanceChargeField;

		// Token: 0x04000504 RID: 1284
		private TaxTotalType[] taxTotalField;

		// Token: 0x04000505 RID: 1285
		private EnergyWaterSupplyType energyWaterSupplyField;

		// Token: 0x04000506 RID: 1286
		private TelecommunicationsSupplyType telecommunicationsSupplyField;

		// Token: 0x04000507 RID: 1287
		private MonetaryTotalType legalMonetaryTotalField;
	}
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000443 RID: 1091
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("EnergyTaxReport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class EnergyTaxReportType
	{
		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x000074EC File Offset: 0x000056EC
		// (set) Token: 0x06000E4F RID: 3663 RVA: 0x000074F4 File Offset: 0x000056F4
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TaxEnergyAmountType TaxEnergyAmount
		{
			get
			{
				return this.taxEnergyAmountField;
			}
			set
			{
				this.taxEnergyAmountField = value;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x000074FD File Offset: 0x000056FD
		// (set) Token: 0x06000E51 RID: 3665 RVA: 0x00007505 File Offset: 0x00005705
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TaxEnergyOnAccountAmountType TaxEnergyOnAccountAmount
		{
			get
			{
				return this.taxEnergyOnAccountAmountField;
			}
			set
			{
				this.taxEnergyOnAccountAmountField = value;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x0000750E File Offset: 0x0000570E
		// (set) Token: 0x06000E53 RID: 3667 RVA: 0x00007516 File Offset: 0x00005716
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TaxEnergyBalanceAmountType TaxEnergyBalanceAmount
		{
			get
			{
				return this.taxEnergyBalanceAmountField;
			}
			set
			{
				this.taxEnergyBalanceAmountField = value;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000E54 RID: 3668 RVA: 0x0000751F File Offset: 0x0000571F
		// (set) Token: 0x06000E55 RID: 3669 RVA: 0x00007527 File Offset: 0x00005727
		public TaxSchemeType TaxScheme
		{
			get
			{
				return this.taxSchemeField;
			}
			set
			{
				this.taxSchemeField = value;
			}
		}

		// Token: 0x0400052A RID: 1322
		private TaxEnergyAmountType taxEnergyAmountField;

		// Token: 0x0400052B RID: 1323
		private TaxEnergyOnAccountAmountType taxEnergyOnAccountAmountField;

		// Token: 0x0400052C RID: 1324
		private TaxEnergyBalanceAmountType taxEnergyBalanceAmountField;

		// Token: 0x0400052D RID: 1325
		private TaxSchemeType taxSchemeField;
	}
}

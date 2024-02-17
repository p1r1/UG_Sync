using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020002BE RID: 702
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("FinancialAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class FinancialAccountType
	{
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x0000335C File Offset: 0x0000155C
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x00003364 File Offset: 0x00001564
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

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x0000336D File Offset: 0x0000156D
		// (set) Token: 0x0600051C RID: 1308 RVA: 0x00003375 File Offset: 0x00001575
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CurrencyCodeType CurrencyCode
		{
			get
			{
				return this.currencyCodeField;
			}
			set
			{
				this.currencyCodeField = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x0000337E File Offset: 0x0000157E
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x00003386 File Offset: 0x00001586
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PaymentNoteType PaymentNote
		{
			get
			{
				return this.paymentNoteField;
			}
			set
			{
				this.paymentNoteField = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x0000338F File Offset: 0x0000158F
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x00003397 File Offset: 0x00001597
		public BranchType FinancialInstitutionBranch
		{
			get
			{
				return this.financialInstitutionBranchField;
			}
			set
			{
				this.financialInstitutionBranchField = value;
			}
		}

		// Token: 0x04000152 RID: 338
		private IDType idField;

		// Token: 0x04000153 RID: 339
		private CurrencyCodeType currencyCodeField;

		// Token: 0x04000154 RID: 340
		private PaymentNoteType paymentNoteField;

		// Token: 0x04000155 RID: 341
		private BranchType financialInstitutionBranchField;
	}
}

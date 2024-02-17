using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020001A8 RID: 424
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("BonusPaymentTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class PaymentTermsType
	{
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00003167 File Offset: 0x00001367
		// (set) Token: 0x060003CD RID: 973 RVA: 0x0000316F File Offset: 0x0000136F
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NoteType Note
		{
			get
			{
				return this.noteField;
			}
			set
			{
				this.noteField = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00003178 File Offset: 0x00001378
		// (set) Token: 0x060003CF RID: 975 RVA: 0x00003180 File Offset: 0x00001380
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PenaltySurchargePercentType PenaltySurchargePercent
		{
			get
			{
				return this.penaltySurchargePercentField;
			}
			set
			{
				this.penaltySurchargePercentField = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00003189 File Offset: 0x00001389
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x00003191 File Offset: 0x00001391
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

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x0000319A File Offset: 0x0000139A
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x000031A2 File Offset: 0x000013A2
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PenaltyAmountType PenaltyAmount
		{
			get
			{
				return this.penaltyAmountField;
			}
			set
			{
				this.penaltyAmountField = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x000031AB File Offset: 0x000013AB
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x000031B3 File Offset: 0x000013B3
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PaymentDueDateType PaymentDueDate
		{
			get
			{
				return this.paymentDueDateField;
			}
			set
			{
				this.paymentDueDateField = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x000031BC File Offset: 0x000013BC
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x000031C4 File Offset: 0x000013C4
		public PeriodType SettlementPeriod
		{
			get
			{
				return this.settlementPeriodField;
			}
			set
			{
				this.settlementPeriodField = value;
			}
		}

		// Token: 0x04000137 RID: 311
		private NoteType noteField;

		// Token: 0x04000138 RID: 312
		private PenaltySurchargePercentType penaltySurchargePercentField;

		// Token: 0x04000139 RID: 313
		private AmountType2 amountField;

		// Token: 0x0400013A RID: 314
		private PenaltyAmountType penaltyAmountField;

		// Token: 0x0400013B RID: 315
		private PaymentDueDateType paymentDueDateField;

		// Token: 0x0400013C RID: 316
		private PeriodType settlementPeriodField;
	}
}

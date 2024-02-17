using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020002BD RID: 701
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class PaymentMeansType
	{
		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x000032F6 File Offset: 0x000014F6
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x000032FE File Offset: 0x000014FE
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PaymentMeansCodeType PaymentMeansCode
		{
			get
			{
				return this.paymentMeansCodeField;
			}
			set
			{
				this.paymentMeansCodeField = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x00003307 File Offset: 0x00001507
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x0000330F File Offset: 0x0000150F
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

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00003318 File Offset: 0x00001518
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x00003320 File Offset: 0x00001520
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PaymentChannelCodeType PaymentChannelCode
		{
			get
			{
				return this.paymentChannelCodeField;
			}
			set
			{
				this.paymentChannelCodeField = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x00003329 File Offset: 0x00001529
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x00003331 File Offset: 0x00001531
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public InstructionNoteType InstructionNote
		{
			get
			{
				return this.instructionNoteField;
			}
			set
			{
				this.instructionNoteField = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x0000333A File Offset: 0x0000153A
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x00003342 File Offset: 0x00001542
		public FinancialAccountType PayerFinancialAccount
		{
			get
			{
				return this.payerFinancialAccountField;
			}
			set
			{
				this.payerFinancialAccountField = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x0000334B File Offset: 0x0000154B
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x00003353 File Offset: 0x00001553
		public FinancialAccountType PayeeFinancialAccount
		{
			get
			{
				return this.payeeFinancialAccountField;
			}
			set
			{
				this.payeeFinancialAccountField = value;
			}
		}

		// Token: 0x0400014C RID: 332
		private PaymentMeansCodeType paymentMeansCodeField;

		// Token: 0x0400014D RID: 333
		private PaymentDueDateType paymentDueDateField;

		// Token: 0x0400014E RID: 334
		private PaymentChannelCodeType paymentChannelCodeField;

		// Token: 0x0400014F RID: 335
		private InstructionNoteType instructionNoteField;

		// Token: 0x04000150 RID: 336
		private FinancialAccountType payerFinancialAccountField;

		// Token: 0x04000151 RID: 337
		private FinancialAccountType payeeFinancialAccountField;
	}
}

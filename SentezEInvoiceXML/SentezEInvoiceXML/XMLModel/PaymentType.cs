using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200043D RID: 1085
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("CollectedPayment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class PaymentType
	{
		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000DEA RID: 3562 RVA: 0x000071CD File Offset: 0x000053CD
		// (set) Token: 0x06000DEB RID: 3563 RVA: 0x000071D5 File Offset: 0x000053D5
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

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000DEC RID: 3564 RVA: 0x000071DE File Offset: 0x000053DE
		// (set) Token: 0x06000DED RID: 3565 RVA: 0x000071E6 File Offset: 0x000053E6
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PaidAmountType PaidAmount
		{
			get
			{
				return this.paidAmountField;
			}
			set
			{
				this.paidAmountField = value;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000DEE RID: 3566 RVA: 0x000071EF File Offset: 0x000053EF
		// (set) Token: 0x06000DEF RID: 3567 RVA: 0x000071F7 File Offset: 0x000053F7
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ReceivedDateType ReceivedDate
		{
			get
			{
				return this.receivedDateField;
			}
			set
			{
				this.receivedDateField = value;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000DF0 RID: 3568 RVA: 0x00007200 File Offset: 0x00005400
		// (set) Token: 0x06000DF1 RID: 3569 RVA: 0x00007208 File Offset: 0x00005408
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PaidDateType PaidDate
		{
			get
			{
				return this.paidDateField;
			}
			set
			{
				this.paidDateField = value;
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x00007211 File Offset: 0x00005411
		// (set) Token: 0x06000DF3 RID: 3571 RVA: 0x00007219 File Offset: 0x00005419
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PaidTimeType PaidTime
		{
			get
			{
				return this.paidTimeField;
			}
			set
			{
				this.paidTimeField = value;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000DF4 RID: 3572 RVA: 0x00007222 File Offset: 0x00005422
		// (set) Token: 0x06000DF5 RID: 3573 RVA: 0x0000722A File Offset: 0x0000542A
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public InstructionIDType InstructionID
		{
			get
			{
				return this.instructionIDField;
			}
			set
			{
				this.instructionIDField = value;
			}
		}

		// Token: 0x040004FB RID: 1275
		private IDType idField;

		// Token: 0x040004FC RID: 1276
		private PaidAmountType paidAmountField;

		// Token: 0x040004FD RID: 1277
		private ReceivedDateType receivedDateField;

		// Token: 0x040004FE RID: 1278
		private PaidDateType paidDateField;

		// Token: 0x040004FF RID: 1279
		private PaidTimeType paidTimeField;

		// Token: 0x04000500 RID: 1280
		private InstructionIDType instructionIDField;
	}
}

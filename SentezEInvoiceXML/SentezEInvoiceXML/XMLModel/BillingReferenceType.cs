using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003F5 RID: 1013
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("BillingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class BillingReferenceType
	{
		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x00004D8B File Offset: 0x00002F8B
		// (set) Token: 0x0600095F RID: 2399 RVA: 0x00004D93 File Offset: 0x00002F93
		public DocumentReferenceType InvoiceDocumentReference
		{
			get
			{
				return this.invoiceDocumentReferenceField;
			}
			set
			{
				this.invoiceDocumentReferenceField = value;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x00004D9C File Offset: 0x00002F9C
		// (set) Token: 0x06000961 RID: 2401 RVA: 0x00004DA4 File Offset: 0x00002FA4
		public DocumentReferenceType SelfBilledInvoiceDocumentReference
		{
			get
			{
				return this.selfBilledInvoiceDocumentReferenceField;
			}
			set
			{
				this.selfBilledInvoiceDocumentReferenceField = value;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x00004DAD File Offset: 0x00002FAD
		// (set) Token: 0x06000963 RID: 2403 RVA: 0x00004DB5 File Offset: 0x00002FB5
		public DocumentReferenceType CreditNoteDocumentReference
		{
			get
			{
				return this.creditNoteDocumentReferenceField;
			}
			set
			{
				this.creditNoteDocumentReferenceField = value;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000964 RID: 2404 RVA: 0x00004DBE File Offset: 0x00002FBE
		// (set) Token: 0x06000965 RID: 2405 RVA: 0x00004DC6 File Offset: 0x00002FC6
		public DocumentReferenceType SelfBilledCreditNoteDocumentReference
		{
			get
			{
				return this.selfBilledCreditNoteDocumentReferenceField;
			}
			set
			{
				this.selfBilledCreditNoteDocumentReferenceField = value;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x00004DCF File Offset: 0x00002FCF
		// (set) Token: 0x06000967 RID: 2407 RVA: 0x00004DD7 File Offset: 0x00002FD7
		public DocumentReferenceType DebitNoteDocumentReference
		{
			get
			{
				return this.debitNoteDocumentReferenceField;
			}
			set
			{
				this.debitNoteDocumentReferenceField = value;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x00004DE0 File Offset: 0x00002FE0
		// (set) Token: 0x06000969 RID: 2409 RVA: 0x00004DE8 File Offset: 0x00002FE8
		public DocumentReferenceType ReminderDocumentReference
		{
			get
			{
				return this.reminderDocumentReferenceField;
			}
			set
			{
				this.reminderDocumentReferenceField = value;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x00004DF1 File Offset: 0x00002FF1
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x00004DF9 File Offset: 0x00002FF9
		public DocumentReferenceType AdditionalDocumentReference
		{
			get
			{
				return this.additionalDocumentReferenceField;
			}
			set
			{
				this.additionalDocumentReferenceField = value;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x00004E02 File Offset: 0x00003002
		// (set) Token: 0x0600096D RID: 2413 RVA: 0x00004E0A File Offset: 0x0000300A
		[XmlElement("BillingReferenceLine")]
		public BillingReferenceLineType[] BillingReferenceLine
		{
			get
			{
				return this.billingReferenceLineField;
			}
			set
			{
				this.billingReferenceLineField = value;
			}
		}

		// Token: 0x040002D9 RID: 729
		private DocumentReferenceType invoiceDocumentReferenceField;

		// Token: 0x040002DA RID: 730
		private DocumentReferenceType selfBilledInvoiceDocumentReferenceField;

		// Token: 0x040002DB RID: 731
		private DocumentReferenceType creditNoteDocumentReferenceField;

		// Token: 0x040002DC RID: 732
		private DocumentReferenceType selfBilledCreditNoteDocumentReferenceField;

		// Token: 0x040002DD RID: 733
		private DocumentReferenceType debitNoteDocumentReferenceField;

		// Token: 0x040002DE RID: 734
		private DocumentReferenceType reminderDocumentReferenceField;

		// Token: 0x040002DF RID: 735
		private DocumentReferenceType additionalDocumentReferenceField;

		// Token: 0x040002E0 RID: 736
		private BillingReferenceLineType[] billingReferenceLineField;
	}
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200037E RID: 894
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class DocumentReferenceType
	{
		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x000038F7 File Offset: 0x00001AF7
		// (set) Token: 0x06000680 RID: 1664 RVA: 0x000038FF File Offset: 0x00001AFF
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

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x00003908 File Offset: 0x00001B08
		// (set) Token: 0x06000682 RID: 1666 RVA: 0x00003910 File Offset: 0x00001B10
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IssueDateType IssueDate
		{
			get
			{
				return this.issueDateField;
			}
			set
			{
				this.issueDateField = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x00003919 File Offset: 0x00001B19
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x00003921 File Offset: 0x00001B21
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DocumentTypeCodeType DocumentTypeCode
		{
			get
			{
				return this.documentTypeCodeField;
			}
			set
			{
				this.documentTypeCodeField = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x0000392A File Offset: 0x00001B2A
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x00003932 File Offset: 0x00001B32
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DocumentTypeType DocumentType
		{
			get
			{
				return this.documentTypeField;
			}
			set
			{
				this.documentTypeField = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x0000393B File Offset: 0x00001B3B
		// (set) Token: 0x06000688 RID: 1672 RVA: 0x00003943 File Offset: 0x00001B43
		[XmlElement("DocumentDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DocumentDescriptionType[] DocumentDescription
		{
			get
			{
				return this.documentDescriptionField;
			}
			set
			{
				this.documentDescriptionField = value;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x0000394C File Offset: 0x00001B4C
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x00003954 File Offset: 0x00001B54
		public AttachmentType Attachment
		{
			get
			{
				return this.attachmentField;
			}
			set
			{
				this.attachmentField = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x0000395D File Offset: 0x00001B5D
		// (set) Token: 0x0600068C RID: 1676 RVA: 0x00003965 File Offset: 0x00001B65
		public PeriodType ValidityPeriod
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

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x0000396E File Offset: 0x00001B6E
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x00003976 File Offset: 0x00001B76
		public PartyType IssuerParty
		{
			get
			{
				return this.issuerPartyField;
			}
			set
			{
				this.issuerPartyField = value;
			}
		}

		// Token: 0x040001A5 RID: 421
		private IDType idField;

		// Token: 0x040001A6 RID: 422
		private IssueDateType issueDateField;

		// Token: 0x040001A7 RID: 423
		private DocumentTypeCodeType documentTypeCodeField;

		// Token: 0x040001A8 RID: 424
		private DocumentTypeType documentTypeField;

		// Token: 0x040001A9 RID: 425
		private DocumentDescriptionType[] documentDescriptionField;

		// Token: 0x040001AA RID: 426
		private AttachmentType attachmentField;

		// Token: 0x040001AB RID: 427
		private PeriodType validityPeriodField;

		// Token: 0x040001AC RID: 428
		private PartyType issuerPartyField;
	}
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003F3 RID: 1011
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class SignatureType
	{
		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x00004D25 File Offset: 0x00002F25
		// (set) Token: 0x06000951 RID: 2385 RVA: 0x00004D2D File Offset: 0x00002F2D
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

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x00004D36 File Offset: 0x00002F36
		// (set) Token: 0x06000953 RID: 2387 RVA: 0x00004D3E File Offset: 0x00002F3E
		public PartyType SignatoryParty
		{
			get
			{
				return this.signatoryPartyField;
			}
			set
			{
				this.signatoryPartyField = value;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x00004D47 File Offset: 0x00002F47
		// (set) Token: 0x06000955 RID: 2389 RVA: 0x00004D4F File Offset: 0x00002F4F
		public AttachmentType DigitalSignatureAttachment
		{
			get
			{
				return this.digitalSignatureAttachmentField;
			}
			set
			{
				this.digitalSignatureAttachmentField = value;
			}
		}

		// Token: 0x040002D3 RID: 723
		private IDType idField;

		// Token: 0x040002D4 RID: 724
		private PartyType signatoryPartyField;

		// Token: 0x040002D5 RID: 725
		private AttachmentType digitalSignatureAttachmentField;
	}
}

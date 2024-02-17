using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200037F RID: 895
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("Attachment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class AttachmentType
	{
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x0000397F File Offset: 0x00001B7F
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x00003987 File Offset: 0x00001B87
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public EmbeddedDocumentBinaryObjectType EmbeddedDocumentBinaryObject
		{
			get
			{
				return this.embeddedDocumentBinaryObjectField;
			}
			set
			{
				this.embeddedDocumentBinaryObjectField = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x00003990 File Offset: 0x00001B90
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x00003998 File Offset: 0x00001B98
		public ExternalReferenceType ExternalReference
		{
			get
			{
				return this.externalReferenceField;
			}
			set
			{
				this.externalReferenceField = value;
			}
		}

		// Token: 0x040001AD RID: 429
		private EmbeddedDocumentBinaryObjectType embeddedDocumentBinaryObjectField;

		// Token: 0x040001AE RID: 430
		private ExternalReferenceType externalReferenceField;
	}
}

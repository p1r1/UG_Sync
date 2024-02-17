using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000424 RID: 1060
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("DocumentTenderRequirement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class TenderRequirementType
	{
		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x00006386 File Offset: 0x00004586
		// (set) Token: 0x06000C24 RID: 3108 RVA: 0x0000638E File Offset: 0x0000458E
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NameType1 Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x00006397 File Offset: 0x00004597
		// (set) Token: 0x06000C26 RID: 3110 RVA: 0x0000639F File Offset: 0x0000459F
		[XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DescriptionType[] Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x000063A8 File Offset: 0x000045A8
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x000063B0 File Offset: 0x000045B0
		public DocumentReferenceType TemplateDocumentReference
		{
			get
			{
				return this.templateDocumentReferenceField;
			}
			set
			{
				this.templateDocumentReferenceField = value;
			}
		}

		// Token: 0x04000424 RID: 1060
		private NameType1 nameField;

		// Token: 0x04000425 RID: 1061
		private DescriptionType[] descriptionField;

		// Token: 0x04000426 RID: 1062
		private DocumentReferenceType templateDocumentReferenceField;
	}
}

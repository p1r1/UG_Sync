using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000403 RID: 1027
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("CategorizesClassificationCategory", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ClassificationCategoryType
	{
		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x000053A7 File Offset: 0x000035A7
		// (set) Token: 0x06000A25 RID: 2597 RVA: 0x000053AF File Offset: 0x000035AF
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

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x000053B8 File Offset: 0x000035B8
		// (set) Token: 0x06000A27 RID: 2599 RVA: 0x000053C0 File Offset: 0x000035C0
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeValueType CodeValue
		{
			get
			{
				return this.codeValueField;
			}
			set
			{
				this.codeValueField = value;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x000053C9 File Offset: 0x000035C9
		// (set) Token: 0x06000A29 RID: 2601 RVA: 0x000053D1 File Offset: 0x000035D1
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

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x000053DA File Offset: 0x000035DA
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x000053E2 File Offset: 0x000035E2
		[XmlElement("CategorizesClassificationCategory")]
		public ClassificationCategoryType[] CategorizesClassificationCategory
		{
			get
			{
				return this.categorizesClassificationCategoryField;
			}
			set
			{
				this.categorizesClassificationCategoryField = value;
			}
		}

		// Token: 0x04000335 RID: 821
		private NameType1 nameField;

		// Token: 0x04000336 RID: 822
		private CodeValueType codeValueField;

		// Token: 0x04000337 RID: 823
		private DescriptionType[] descriptionField;

		// Token: 0x04000338 RID: 824
		private ClassificationCategoryType[] categorizesClassificationCategoryField;
	}
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000407 RID: 1031
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("Declaration", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class DeclarationType
	{
		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000A4C RID: 2636 RVA: 0x000054D9 File Offset: 0x000036D9
		// (set) Token: 0x06000A4D RID: 2637 RVA: 0x000054E1 File Offset: 0x000036E1
		[XmlElement("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NameType1[] Name
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

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000A4E RID: 2638 RVA: 0x000054EA File Offset: 0x000036EA
		// (set) Token: 0x06000A4F RID: 2639 RVA: 0x000054F2 File Offset: 0x000036F2
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DeclarationTypeCodeType DeclarationTypeCode
		{
			get
			{
				return this.declarationTypeCodeField;
			}
			set
			{
				this.declarationTypeCodeField = value;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x000054FB File Offset: 0x000036FB
		// (set) Token: 0x06000A51 RID: 2641 RVA: 0x00005503 File Offset: 0x00003703
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

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x0000550C File Offset: 0x0000370C
		// (set) Token: 0x06000A53 RID: 2643 RVA: 0x00005514 File Offset: 0x00003714
		[XmlElement("EvidenceSupplied")]
		public EvidenceSuppliedType[] EvidenceSupplied
		{
			get
			{
				return this.evidenceSuppliedField;
			}
			set
			{
				this.evidenceSuppliedField = value;
			}
		}

		// Token: 0x04000347 RID: 839
		private NameType1[] nameField;

		// Token: 0x04000348 RID: 840
		private DeclarationTypeCodeType declarationTypeCodeField;

		// Token: 0x04000349 RID: 841
		private DescriptionType[] descriptionField;

		// Token: 0x0400034A RID: 842
		private EvidenceSuppliedType[] evidenceSuppliedField;
	}
}

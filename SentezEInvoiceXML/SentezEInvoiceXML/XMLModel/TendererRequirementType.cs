using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000422 RID: 1058
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("SpecificTendererRequirement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class TendererRequirementType
	{
		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000C0B RID: 3083 RVA: 0x000062CB File Offset: 0x000044CB
		// (set) Token: 0x06000C0C RID: 3084 RVA: 0x000062D3 File Offset: 0x000044D3
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

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x000062DC File Offset: 0x000044DC
		// (set) Token: 0x06000C0E RID: 3086 RVA: 0x000062E4 File Offset: 0x000044E4
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TendererRequirementTypeCodeType TendererRequirementTypeCode
		{
			get
			{
				return this.tendererRequirementTypeCodeField;
			}
			set
			{
				this.tendererRequirementTypeCodeField = value;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x000062ED File Offset: 0x000044ED
		// (set) Token: 0x06000C10 RID: 3088 RVA: 0x000062F5 File Offset: 0x000044F5
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

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x000062FE File Offset: 0x000044FE
		// (set) Token: 0x06000C12 RID: 3090 RVA: 0x00006306 File Offset: 0x00004506
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LegalReferenceType LegalReference
		{
			get
			{
				return this.legalReferenceField;
			}
			set
			{
				this.legalReferenceField = value;
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000C13 RID: 3091 RVA: 0x0000630F File Offset: 0x0000450F
		// (set) Token: 0x06000C14 RID: 3092 RVA: 0x00006317 File Offset: 0x00004517
		[XmlElement("SuggestedEvidence")]
		public EvidenceType[] SuggestedEvidence
		{
			get
			{
				return this.suggestedEvidenceField;
			}
			set
			{
				this.suggestedEvidenceField = value;
			}
		}

		// Token: 0x04000419 RID: 1049
		private NameType1[] nameField;

		// Token: 0x0400041A RID: 1050
		private TendererRequirementTypeCodeType tendererRequirementTypeCodeField;

		// Token: 0x0400041B RID: 1051
		private DescriptionType[] descriptionField;

		// Token: 0x0400041C RID: 1052
		private LegalReferenceType legalReferenceField;

		// Token: 0x0400041D RID: 1053
		private EvidenceType[] suggestedEvidenceField;
	}
}

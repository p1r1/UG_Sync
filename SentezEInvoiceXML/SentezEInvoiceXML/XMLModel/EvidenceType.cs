using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000420 RID: 1056
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("Evidence", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class EvidenceType
	{
		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x00006221 File Offset: 0x00004421
		// (set) Token: 0x06000BF6 RID: 3062 RVA: 0x00006229 File Offset: 0x00004429
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

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x00006232 File Offset: 0x00004432
		// (set) Token: 0x06000BF8 RID: 3064 RVA: 0x0000623A File Offset: 0x0000443A
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public EvidenceTypeCodeType EvidenceTypeCode
		{
			get
			{
				return this.evidenceTypeCodeField;
			}
			set
			{
				this.evidenceTypeCodeField = value;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x00006243 File Offset: 0x00004443
		// (set) Token: 0x06000BFA RID: 3066 RVA: 0x0000624B File Offset: 0x0000444B
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

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000BFB RID: 3067 RVA: 0x00006254 File Offset: 0x00004454
		// (set) Token: 0x06000BFC RID: 3068 RVA: 0x0000625C File Offset: 0x0000445C
		[XmlElement("CandidateStatement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CandidateStatementType[] CandidateStatement
		{
			get
			{
				return this.candidateStatementField;
			}
			set
			{
				this.candidateStatementField = value;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x00006265 File Offset: 0x00004465
		// (set) Token: 0x06000BFE RID: 3070 RVA: 0x0000626D File Offset: 0x0000446D
		public PartyType EvidenceIssuingParty
		{
			get
			{
				return this.evidenceIssuingPartyField;
			}
			set
			{
				this.evidenceIssuingPartyField = value;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x00006276 File Offset: 0x00004476
		// (set) Token: 0x06000C00 RID: 3072 RVA: 0x0000627E File Offset: 0x0000447E
		public DocumentReferenceType DocumentReference
		{
			get
			{
				return this.documentReferenceField;
			}
			set
			{
				this.documentReferenceField = value;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000C01 RID: 3073 RVA: 0x00006287 File Offset: 0x00004487
		// (set) Token: 0x06000C02 RID: 3074 RVA: 0x0000628F File Offset: 0x0000448F
		public LanguageType Language
		{
			get
			{
				return this.languageField;
			}
			set
			{
				this.languageField = value;
			}
		}

		// Token: 0x0400040F RID: 1039
		private IDType idField;

		// Token: 0x04000410 RID: 1040
		private EvidenceTypeCodeType evidenceTypeCodeField;

		// Token: 0x04000411 RID: 1041
		private DescriptionType[] descriptionField;

		// Token: 0x04000412 RID: 1042
		private CandidateStatementType[] candidateStatementField;

		// Token: 0x04000413 RID: 1043
		private PartyType evidenceIssuingPartyField;

		// Token: 0x04000414 RID: 1044
		private DocumentReferenceType documentReferenceField;

		// Token: 0x04000415 RID: 1045
		private LanguageType languageField;
	}
}

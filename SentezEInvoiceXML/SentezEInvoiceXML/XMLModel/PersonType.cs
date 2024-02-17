using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200037D RID: 893
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("CrewMemberPerson", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class PersonType
	{
		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x0000386F File Offset: 0x00001A6F
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x00003877 File Offset: 0x00001A77
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public FirstNameType FirstName
		{
			get
			{
				return this.firstNameField;
			}
			set
			{
				this.firstNameField = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x00003880 File Offset: 0x00001A80
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x00003888 File Offset: 0x00001A88
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public FamilyNameType FamilyName
		{
			get
			{
				return this.familyNameField;
			}
			set
			{
				this.familyNameField = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x00003891 File Offset: 0x00001A91
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x00003899 File Offset: 0x00001A99
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TitleType Title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x000038A2 File Offset: 0x00001AA2
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x000038AA File Offset: 0x00001AAA
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MiddleNameType MiddleName
		{
			get
			{
				return this.middleNameField;
			}
			set
			{
				this.middleNameField = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x000038B3 File Offset: 0x00001AB3
		// (set) Token: 0x06000677 RID: 1655 RVA: 0x000038BB File Offset: 0x00001ABB
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NameSuffixType NameSuffix
		{
			get
			{
				return this.nameSuffixField;
			}
			set
			{
				this.nameSuffixField = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x000038C4 File Offset: 0x00001AC4
		// (set) Token: 0x06000679 RID: 1657 RVA: 0x000038CC File Offset: 0x00001ACC
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NationalityIDType NationalityID
		{
			get
			{
				return this.nationalityIDField;
			}
			set
			{
				this.nationalityIDField = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x000038D5 File Offset: 0x00001AD5
		// (set) Token: 0x0600067B RID: 1659 RVA: 0x000038DD File Offset: 0x00001ADD
		public FinancialAccountType FinancialAccount
		{
			get
			{
				return this.financialAccountField;
			}
			set
			{
				this.financialAccountField = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x000038E6 File Offset: 0x00001AE6
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x000038EE File Offset: 0x00001AEE
		public DocumentReferenceType IdentityDocumentReference
		{
			get
			{
				return this.identityDocumentReferenceField;
			}
			set
			{
				this.identityDocumentReferenceField = value;
			}
		}

		// Token: 0x0400019D RID: 413
		private FirstNameType firstNameField;

		// Token: 0x0400019E RID: 414
		private FamilyNameType familyNameField;

		// Token: 0x0400019F RID: 415
		private TitleType titleField;

		// Token: 0x040001A0 RID: 416
		private MiddleNameType middleNameField;

		// Token: 0x040001A1 RID: 417
		private NameSuffixType nameSuffixField;

		// Token: 0x040001A2 RID: 418
		private NationalityIDType nationalityIDField;

		// Token: 0x040001A3 RID: 419
		private FinancialAccountType financialAccountField;

		// Token: 0x040001A4 RID: 420
		private DocumentReferenceType identityDocumentReferenceField;
	}
}

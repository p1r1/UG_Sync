using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000334 RID: 820
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("AdditionalInformationParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class PartyType
	{
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x0000348D File Offset: 0x0000168D
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x00003495 File Offset: 0x00001695
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public WebsiteURIType WebsiteURI
		{
			get
			{
				return this.websiteURIField;
			}
			set
			{
				this.websiteURIField = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x0000349E File Offset: 0x0000169E
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x000034A6 File Offset: 0x000016A6
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public EndpointIDType EndpointID
		{
			get
			{
				return this.endpointIDField;
			}
			set
			{
				this.endpointIDField = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x000034AF File Offset: 0x000016AF
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x000034B7 File Offset: 0x000016B7
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndustryClassificationCodeType IndustryClassificationCode
		{
			get
			{
				return this.industryClassificationCodeField;
			}
			set
			{
				this.industryClassificationCodeField = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x000034C0 File Offset: 0x000016C0
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x000034C8 File Offset: 0x000016C8
		[XmlElement("PartyIdentification")]
		public PartyIdentificationType[] PartyIdentification
		{
			get
			{
				return this.partyIdentificationField;
			}
			set
			{
				this.partyIdentificationField = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x000034D1 File Offset: 0x000016D1
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x000034D9 File Offset: 0x000016D9
		public PartyNameType PartyName
		{
			get
			{
				return this.partyNameField;
			}
			set
			{
				this.partyNameField = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x000034E2 File Offset: 0x000016E2
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x000034EA File Offset: 0x000016EA
		public AddressType PostalAddress
		{
			get
			{
				return this.postalAddressField;
			}
			set
			{
				this.postalAddressField = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x000034F3 File Offset: 0x000016F3
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x000034FB File Offset: 0x000016FB
		public LocationType1 PhysicalLocation
		{
			get
			{
				return this.physicalLocationField;
			}
			set
			{
				this.physicalLocationField = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x00003504 File Offset: 0x00001704
		// (set) Token: 0x060005C0 RID: 1472 RVA: 0x0000350C File Offset: 0x0000170C
		public PartyTaxSchemeType PartyTaxScheme
		{
			get
			{
				return this.partyTaxSchemeField;
			}
			set
			{
				this.partyTaxSchemeField = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x00003515 File Offset: 0x00001715
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x0000351D File Offset: 0x0000171D
		[XmlElement("PartyLegalEntity")]
		public PartyLegalEntityType[] PartyLegalEntity
		{
			get
			{
				return this.partyLegalEntityField;
			}
			set
			{
				this.partyLegalEntityField = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x00003526 File Offset: 0x00001726
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x0000352E File Offset: 0x0000172E
		public ContactType Contact
		{
			get
			{
				return this.contactField;
			}
			set
			{
				this.contactField = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x00003537 File Offset: 0x00001737
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x0000353F File Offset: 0x0000173F
		public PersonType Person
		{
			get
			{
				return this.personField;
			}
			set
			{
				this.personField = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x00003548 File Offset: 0x00001748
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x00003550 File Offset: 0x00001750
		public PartyType AgentParty
		{
			get
			{
				return this.agentPartyField;
			}
			set
			{
				this.agentPartyField = value;
			}
		}

		// Token: 0x04000163 RID: 355
		private WebsiteURIType websiteURIField;

		// Token: 0x04000164 RID: 356
		private EndpointIDType endpointIDField;

		// Token: 0x04000165 RID: 357
		private IndustryClassificationCodeType industryClassificationCodeField;

		// Token: 0x04000166 RID: 358
		private PartyIdentificationType[] partyIdentificationField;

		// Token: 0x04000167 RID: 359
		private PartyNameType partyNameField;

		// Token: 0x04000168 RID: 360
		private AddressType postalAddressField;

		// Token: 0x04000169 RID: 361
		private LocationType1 physicalLocationField;

		// Token: 0x0400016A RID: 362
		private PartyTaxSchemeType partyTaxSchemeField;

		// Token: 0x0400016B RID: 363
		private PartyLegalEntityType[] partyLegalEntityField;

		// Token: 0x0400016C RID: 364
		private ContactType contactField;

		// Token: 0x0400016D RID: 365
		private PersonType personField;

		// Token: 0x0400016E RID: 366
		private PartyType agentPartyField;
	}
}

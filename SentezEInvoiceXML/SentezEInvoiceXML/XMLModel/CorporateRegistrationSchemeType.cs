using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200037A RID: 890
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("CorporateRegistrationScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class CorporateRegistrationSchemeType
	{
		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x000037A3 File Offset: 0x000019A3
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x000037AB File Offset: 0x000019AB
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

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x000037B4 File Offset: 0x000019B4
		// (set) Token: 0x06000656 RID: 1622 RVA: 0x000037BC File Offset: 0x000019BC
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

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x000037C5 File Offset: 0x000019C5
		// (set) Token: 0x06000658 RID: 1624 RVA: 0x000037CD File Offset: 0x000019CD
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CorporateRegistrationTypeCodeType CorporateRegistrationTypeCode
		{
			get
			{
				return this.corporateRegistrationTypeCodeField;
			}
			set
			{
				this.corporateRegistrationTypeCodeField = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x000037D6 File Offset: 0x000019D6
		// (set) Token: 0x0600065A RID: 1626 RVA: 0x000037DE File Offset: 0x000019DE
		[XmlElement("JurisdictionRegionAddress")]
		public AddressType[] JurisdictionRegionAddress
		{
			get
			{
				return this.jurisdictionRegionAddressField;
			}
			set
			{
				this.jurisdictionRegionAddressField = value;
			}
		}

		// Token: 0x04000191 RID: 401
		private IDType idField;

		// Token: 0x04000192 RID: 402
		private NameType1 nameField;

		// Token: 0x04000193 RID: 403
		private CorporateRegistrationTypeCodeType corporateRegistrationTypeCodeField;

		// Token: 0x04000194 RID: 404
		private AddressType[] jurisdictionRegionAddressField;
	}
}

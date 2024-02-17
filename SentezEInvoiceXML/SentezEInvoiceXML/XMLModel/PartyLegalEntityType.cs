using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200033C RID: 828
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("PartyLegalEntity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class PartyLegalEntityType
	{
		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x00003702 File Offset: 0x00001902
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x0000370A File Offset: 0x0000190A
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public RegistrationNameType RegistrationName
		{
			get
			{
				return this.registrationNameField;
			}
			set
			{
				this.registrationNameField = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x00003713 File Offset: 0x00001913
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x0000371B File Offset: 0x0000191B
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CompanyIDType CompanyID
		{
			get
			{
				return this.companyIDField;
			}
			set
			{
				this.companyIDField = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x00003724 File Offset: 0x00001924
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x0000372C File Offset: 0x0000192C
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public RegistrationDateType RegistrationDate
		{
			get
			{
				return this.registrationDateField;
			}
			set
			{
				this.registrationDateField = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x00003735 File Offset: 0x00001935
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x0000373D File Offset: 0x0000193D
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SoleProprietorshipIndicatorType SoleProprietorshipIndicator
		{
			get
			{
				return this.soleProprietorshipIndicatorField;
			}
			set
			{
				this.soleProprietorshipIndicatorField = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x00003746 File Offset: 0x00001946
		// (set) Token: 0x0600060C RID: 1548 RVA: 0x0000374E File Offset: 0x0000194E
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CorporateStockAmountType CorporateStockAmount
		{
			get
			{
				return this.corporateStockAmountField;
			}
			set
			{
				this.corporateStockAmountField = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x00003757 File Offset: 0x00001957
		// (set) Token: 0x0600060E RID: 1550 RVA: 0x0000375F File Offset: 0x0000195F
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public FullyPaidSharesIndicatorType FullyPaidSharesIndicator
		{
			get
			{
				return this.fullyPaidSharesIndicatorField;
			}
			set
			{
				this.fullyPaidSharesIndicatorField = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x00003768 File Offset: 0x00001968
		// (set) Token: 0x06000610 RID: 1552 RVA: 0x00003770 File Offset: 0x00001970
		public CorporateRegistrationSchemeType CorporateRegistrationScheme
		{
			get
			{
				return this.corporateRegistrationSchemeField;
			}
			set
			{
				this.corporateRegistrationSchemeField = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x00003779 File Offset: 0x00001979
		// (set) Token: 0x06000612 RID: 1554 RVA: 0x00003781 File Offset: 0x00001981
		public PartyType HeadOfficeParty
		{
			get
			{
				return this.headOfficePartyField;
			}
			set
			{
				this.headOfficePartyField = value;
			}
		}

		// Token: 0x04000188 RID: 392
		private RegistrationNameType registrationNameField;

		// Token: 0x04000189 RID: 393
		private CompanyIDType companyIDField;

		// Token: 0x0400018A RID: 394
		private RegistrationDateType registrationDateField;

		// Token: 0x0400018B RID: 395
		private SoleProprietorshipIndicatorType soleProprietorshipIndicatorField;

		// Token: 0x0400018C RID: 396
		private CorporateStockAmountType corporateStockAmountField;

		// Token: 0x0400018D RID: 397
		private FullyPaidSharesIndicatorType fullyPaidSharesIndicatorField;

		// Token: 0x0400018E RID: 398
		private CorporateRegistrationSchemeType corporateRegistrationSchemeField;

		// Token: 0x0400018F RID: 399
		private PartyType headOfficePartyField;
	}
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200033A RID: 826
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("PartyTaxScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class PartyTaxSchemeType
	{
		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x0000369C File Offset: 0x0000189C
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x000036A4 File Offset: 0x000018A4
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

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x000036AD File Offset: 0x000018AD
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x000036B5 File Offset: 0x000018B5
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

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x000036BE File Offset: 0x000018BE
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x000036C6 File Offset: 0x000018C6
		public TaxSchemeType TaxScheme
		{
			get
			{
				return this.taxSchemeField;
			}
			set
			{
				this.taxSchemeField = value;
			}
		}

		// Token: 0x04000182 RID: 386
		private RegistrationNameType registrationNameField;

		// Token: 0x04000183 RID: 387
		private CompanyIDType companyIDField;

		// Token: 0x04000184 RID: 388
		private TaxSchemeType taxSchemeField;
	}
}

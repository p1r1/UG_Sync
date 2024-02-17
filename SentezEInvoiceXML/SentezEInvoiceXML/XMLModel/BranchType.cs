using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000331 RID: 817
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("Branch", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class BranchType
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00003438 File Offset: 0x00001638
		// (set) Token: 0x060005A5 RID: 1445 RVA: 0x00003440 File Offset: 0x00001640
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

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x00003449 File Offset: 0x00001649
		// (set) Token: 0x060005A7 RID: 1447 RVA: 0x00003451 File Offset: 0x00001651
		public FinancialInstitutionType FinancialInstitution
		{
			get
			{
				return this.financialInstitutionField;
			}
			set
			{
				this.financialInstitutionField = value;
			}
		}

		// Token: 0x0400015E RID: 350
		private NameType1 nameField;

		// Token: 0x0400015F RID: 351
		private FinancialInstitutionType financialInstitutionField;
	}
}

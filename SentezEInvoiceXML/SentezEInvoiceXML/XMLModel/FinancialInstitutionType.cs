using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000332 RID: 818
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("FinancialInstitution", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class FinancialInstitutionType
	{
		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x0000345A File Offset: 0x0000165A
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x00003462 File Offset: 0x00001662
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

		// Token: 0x04000160 RID: 352
		private NameType1 nameField;
	}
}

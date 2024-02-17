using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000408 RID: 1032
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("EconomicOperatorRole", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class EconomicOperatorRoleType
	{
		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x0000551D File Offset: 0x0000371D
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x00005525 File Offset: 0x00003725
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public RoleCodeType RoleCode
		{
			get
			{
				return this.roleCodeField;
			}
			set
			{
				this.roleCodeField = value;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x0000552E File Offset: 0x0000372E
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x00005536 File Offset: 0x00003736
		[XmlElement("RoleDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public RoleDescriptionType[] RoleDescription
		{
			get
			{
				return this.roleDescriptionField;
			}
			set
			{
				this.roleDescriptionField = value;
			}
		}

		// Token: 0x0400034B RID: 843
		private RoleCodeType roleCodeField;

		// Token: 0x0400034C RID: 844
		private RoleDescriptionType[] roleDescriptionField;
	}
}

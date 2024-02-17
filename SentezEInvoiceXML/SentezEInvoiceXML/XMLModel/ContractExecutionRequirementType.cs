using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000425 RID: 1061
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ContractExecutionRequirement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ContractExecutionRequirementType
	{
		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x000063B9 File Offset: 0x000045B9
		// (set) Token: 0x06000C2B RID: 3115 RVA: 0x000063C1 File Offset: 0x000045C1
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

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x000063CA File Offset: 0x000045CA
		// (set) Token: 0x06000C2D RID: 3117 RVA: 0x000063D2 File Offset: 0x000045D2
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ExecutionRequirementCodeType ExecutionRequirementCode
		{
			get
			{
				return this.executionRequirementCodeField;
			}
			set
			{
				this.executionRequirementCodeField = value;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x000063DB File Offset: 0x000045DB
		// (set) Token: 0x06000C2F RID: 3119 RVA: 0x000063E3 File Offset: 0x000045E3
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

		// Token: 0x04000427 RID: 1063
		private NameType1[] nameField;

		// Token: 0x04000428 RID: 1064
		private ExecutionRequirementCodeType executionRequirementCodeField;

		// Token: 0x04000429 RID: 1065
		private DescriptionType[] descriptionField;
	}
}

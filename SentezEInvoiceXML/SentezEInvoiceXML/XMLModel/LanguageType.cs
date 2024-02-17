using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000421 RID: 1057
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("DefaultLanguage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class LanguageType
	{
		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x00006298 File Offset: 0x00004498
		// (set) Token: 0x06000C05 RID: 3077 RVA: 0x000062A0 File Offset: 0x000044A0
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

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x000062A9 File Offset: 0x000044A9
		// (set) Token: 0x06000C07 RID: 3079 RVA: 0x000062B1 File Offset: 0x000044B1
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

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x000062BA File Offset: 0x000044BA
		// (set) Token: 0x06000C09 RID: 3081 RVA: 0x000062C2 File Offset: 0x000044C2
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LocaleCodeType LocaleCode
		{
			get
			{
				return this.localeCodeField;
			}
			set
			{
				this.localeCodeField = value;
			}
		}

		// Token: 0x04000416 RID: 1046
		private IDType idField;

		// Token: 0x04000417 RID: 1047
		private NameType1 nameField;

		// Token: 0x04000418 RID: 1048
		private LocaleCodeType localeCodeField;
	}
}

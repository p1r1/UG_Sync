using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000025 RID: 37
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
	[XmlRoot("UBLExtension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", IsNullable = false)]
	[Serializable]
	public class UBLExtensionType
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00002F27 File Offset: 0x00001127
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00002F2F File Offset: 0x0000112F
		public ExtensionContentType ExtensionContent
		{
			get
			{
				return this.extensionContentField;
			}
			set
			{
				this.extensionContentField = value;
			}
		}

		// Token: 0x04000119 RID: 281
		private ExtensionContentType extensionContentField;
	}
}

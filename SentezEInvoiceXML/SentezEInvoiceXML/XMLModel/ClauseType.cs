using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200041C RID: 1052
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("Clause", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ClauseType
	{
		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x00006067 File Offset: 0x00004267
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x0000606F File Offset: 0x0000426F
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

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x00006078 File Offset: 0x00004278
		// (set) Token: 0x06000BC0 RID: 3008 RVA: 0x00006080 File Offset: 0x00004280
		[XmlElement("Content", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ContentType[] Content
		{
			get
			{
				return this.contentField;
			}
			set
			{
				this.contentField = value;
			}
		}

		// Token: 0x040003F5 RID: 1013
		private IDType idField;

		// Token: 0x040003F6 RID: 1014
		private ContentType[] contentField;
	}
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000405 RID: 1029
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("EvidenceSupplied", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class EvidenceSuppliedType
	{
		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000A3A RID: 2618 RVA: 0x00005451 File Offset: 0x00003651
		// (set) Token: 0x06000A3B RID: 2619 RVA: 0x00005459 File Offset: 0x00003659
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

		// Token: 0x0400033F RID: 831
		private IDType idField;
	}
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000387 RID: 903
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ExternalReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ExternalReferenceType
	{
		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x00003A28 File Offset: 0x00001C28
		// (set) Token: 0x060006AB RID: 1707 RVA: 0x00003A30 File Offset: 0x00001C30
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public URIType URI
		{
			get
			{
				return this.uRIField;
			}
			set
			{
				this.uRIField = value;
			}
		}

		// Token: 0x040001B6 RID: 438
		private URIType uRIField;
	}
}

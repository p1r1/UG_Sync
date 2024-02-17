using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML {
	// Token: 0x02000455 RID: 1109
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("CreditAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class CreditAccountType {
		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000F78 RID: 3960 RVA: 0x00007E38 File Offset: 0x00006038
		// (set) Token: 0x06000F79 RID: 3961 RVA: 0x00007E40 File Offset: 0x00006040
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AccountIDType AccountID {
			get {
				return this.accountIDField;
			}
			set {
				this.accountIDField = value;
			}
		}

		// Token: 0x040005B6 RID: 1462
		private AccountIDType accountIDField;
	}
}

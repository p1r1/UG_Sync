using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003F1 RID: 1009
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("AccountingCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class CustomerPartyType
	{
		// Token: 0x17000207 RID: 519
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x00004D03 File Offset: 0x00002F03
		// (set) Token: 0x0600094B RID: 2379 RVA: 0x00004D0B File Offset: 0x00002F0B
		public PartyType Party
		{
			get
			{
				return this.partyField;
			}
			set
			{
				this.partyField = value;
			}
		}

		// Token: 0x040002D1 RID: 721
		private PartyType partyField;
	}
}

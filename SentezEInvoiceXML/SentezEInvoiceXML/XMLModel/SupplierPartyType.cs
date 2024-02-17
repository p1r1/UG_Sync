using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003F2 RID: 1010
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("AccountingSupplierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class SupplierPartyType
	{
		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x00004D14 File Offset: 0x00002F14
		// (set) Token: 0x0600094E RID: 2382 RVA: 0x00004D1C File Offset: 0x00002F1C
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

		// Token: 0x040002D2 RID: 722
		private PartyType partyField;
	}
}

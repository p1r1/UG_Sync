using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000454 RID: 1108
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ContractingPartyType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ContractingPartyTypeType
	{
		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000F73 RID: 3955 RVA: 0x00007E16 File Offset: 0x00006016
		// (set) Token: 0x06000F74 RID: 3956 RVA: 0x00007E1E File Offset: 0x0000601E
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PartyTypeCodeType PartyTypeCode
		{
			get
			{
				return this.partyTypeCodeField;
			}
			set
			{
				this.partyTypeCodeField = value;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000F75 RID: 3957 RVA: 0x00007E27 File Offset: 0x00006027
		// (set) Token: 0x06000F76 RID: 3958 RVA: 0x00007E2F File Offset: 0x0000602F
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PartyTypeType PartyType
		{
			get
			{
				return this.partyTypeField;
			}
			set
			{
				this.partyTypeField = value;
			}
		}

		// Token: 0x040005B4 RID: 1460
		private PartyTypeCodeType partyTypeCodeField;

		// Token: 0x040005B5 RID: 1461
		private PartyTypeType partyTypeField;
	}
}

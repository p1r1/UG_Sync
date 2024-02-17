using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000333 RID: 819
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("CustomsDeclaration", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class CustomsDeclarationType
	{
		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x0000346B File Offset: 0x0000166B
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x00003473 File Offset: 0x00001673
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

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x0000347C File Offset: 0x0000167C
		// (set) Token: 0x060005AF RID: 1455 RVA: 0x00003484 File Offset: 0x00001684
		public PartyType IssuerParty
		{
			get
			{
				return this.issuerPartyField;
			}
			set
			{
				this.issuerPartyField = value;
			}
		}

		// Token: 0x04000161 RID: 353
		private IDType idField;

		// Token: 0x04000162 RID: 354
		private PartyType issuerPartyField;
	}
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000339 RID: 825
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(TypeName = "LocationType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ActivityFinalLocation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class LocationType1
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x0000367A File Offset: 0x0000187A
		// (set) Token: 0x060005F1 RID: 1521 RVA: 0x00003682 File Offset: 0x00001882
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

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x0000368B File Offset: 0x0000188B
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x00003693 File Offset: 0x00001893
		public AddressType Address
		{
			get
			{
				return this.addressField;
			}
			set
			{
				this.addressField = value;
			}
		}

		// Token: 0x04000180 RID: 384
		private IDType idField;

		// Token: 0x04000181 RID: 385
		private AddressType addressField;
	}
}

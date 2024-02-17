using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003E9 RID: 1001
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("RoadTransport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class RoadTransportType
	{
		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x00004AB0 File Offset: 0x00002CB0
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x00004AB8 File Offset: 0x00002CB8
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LicensePlateIDType LicensePlateID
		{
			get
			{
				return this.licensePlateIDField;
			}
			set
			{
				this.licensePlateIDField = value;
			}
		}

		// Token: 0x040002AE RID: 686
		private LicensePlateIDType licensePlateIDField;
	}
}

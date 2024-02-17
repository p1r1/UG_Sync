using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003E8 RID: 1000
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("AirTransport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class AirTransportType
	{
		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x00004A9F File Offset: 0x00002C9F
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x00004AA7 File Offset: 0x00002CA7
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AircraftIDType AircraftID
		{
			get
			{
				return this.aircraftIDField;
			}
			set
			{
				this.aircraftIDField = value;
			}
		}

		// Token: 0x040002AD RID: 685
		private AircraftIDType aircraftIDField;
	}
}

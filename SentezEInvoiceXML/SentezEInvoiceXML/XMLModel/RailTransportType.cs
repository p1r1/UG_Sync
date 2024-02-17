using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003EA RID: 1002
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("RailTransport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class RailTransportType
	{
		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x00004AC1 File Offset: 0x00002CC1
		// (set) Token: 0x06000900 RID: 2304 RVA: 0x00004AC9 File Offset: 0x00002CC9
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TrainIDType TrainID
		{
			get
			{
				return this.trainIDField;
			}
			set
			{
				this.trainIDField = value;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000901 RID: 2305 RVA: 0x00004AD2 File Offset: 0x00002CD2
		// (set) Token: 0x06000902 RID: 2306 RVA: 0x00004ADA File Offset: 0x00002CDA
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public RailCarIDType RailCarID
		{
			get
			{
				return this.railCarIDField;
			}
			set
			{
				this.railCarIDField = value;
			}
		}

		// Token: 0x040002AF RID: 687
		private TrainIDType trainIDField;

		// Token: 0x040002B0 RID: 688
		private RailCarIDType railCarIDField;
	}
}

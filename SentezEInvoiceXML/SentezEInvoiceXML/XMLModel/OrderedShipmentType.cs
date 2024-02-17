using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000410 RID: 1040
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("OrderedShipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class OrderedShipmentType
	{
		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x00005A07 File Offset: 0x00003C07
		// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x00005A0F File Offset: 0x00003C0F
		public ShipmentType Shipment
		{
			get
			{
				return this.shipmentField;
			}
			set
			{
				this.shipmentField = value;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x00005A18 File Offset: 0x00003C18
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x00005A20 File Offset: 0x00003C20
		[XmlElement("Package")]
		public PackageType[] Package
		{
			get
			{
				return this.packageField;
			}
			set
			{
				this.packageField = value;
			}
		}

		// Token: 0x04000395 RID: 917
		private ShipmentType shipmentField;

		// Token: 0x04000396 RID: 918
		private PackageType[] packageField;
	}
}

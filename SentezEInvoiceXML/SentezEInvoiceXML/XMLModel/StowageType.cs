using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003E7 RID: 999
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("Stowage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class StowageType
	{
		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x00004A6C File Offset: 0x00002C6C
		// (set) Token: 0x060008F3 RID: 2291 RVA: 0x00004A74 File Offset: 0x00002C74
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LocationIDType LocationID
		{
			get
			{
				return this.locationIDField;
			}
			set
			{
				this.locationIDField = value;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x00004A7D File Offset: 0x00002C7D
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x00004A85 File Offset: 0x00002C85
		[XmlElement("Location", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LocationType[] Location
		{
			get
			{
				return this.locationField;
			}
			set
			{
				this.locationField = value;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x00004A8E File Offset: 0x00002C8E
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x00004A96 File Offset: 0x00002C96
		[XmlElement("MeasurementDimension")]
		public DimensionType[] MeasurementDimension
		{
			get
			{
				return this.measurementDimensionField;
			}
			set
			{
				this.measurementDimensionField = value;
			}
		}

		// Token: 0x040002AA RID: 682
		private LocationIDType locationIDField;

		// Token: 0x040002AB RID: 683
		private LocationType[] locationField;

		// Token: 0x040002AC RID: 684
		private DimensionType[] measurementDimensionField;
	}
}

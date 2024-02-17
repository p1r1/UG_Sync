using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003EB RID: 1003
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("MaritimeTransport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class MaritimeTransportType
	{
		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x00004AE3 File Offset: 0x00002CE3
		// (set) Token: 0x06000905 RID: 2309 RVA: 0x00004AEB File Offset: 0x00002CEB
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public VesselIDType VesselID
		{
			get
			{
				return this.vesselIDField;
			}
			set
			{
				this.vesselIDField = value;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x00004AF4 File Offset: 0x00002CF4
		// (set) Token: 0x06000907 RID: 2311 RVA: 0x00004AFC File Offset: 0x00002CFC
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public VesselNameType VesselName
		{
			get
			{
				return this.vesselNameField;
			}
			set
			{
				this.vesselNameField = value;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x00004B05 File Offset: 0x00002D05
		// (set) Token: 0x06000909 RID: 2313 RVA: 0x00004B0D File Offset: 0x00002D0D
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public RadioCallSignIDType RadioCallSignID
		{
			get
			{
				return this.radioCallSignIDField;
			}
			set
			{
				this.radioCallSignIDField = value;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x00004B16 File Offset: 0x00002D16
		// (set) Token: 0x0600090B RID: 2315 RVA: 0x00004B1E File Offset: 0x00002D1E
		[XmlElement("ShipsRequirements", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ShipsRequirementsType[] ShipsRequirements
		{
			get
			{
				return this.shipsRequirementsField;
			}
			set
			{
				this.shipsRequirementsField = value;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x00004B27 File Offset: 0x00002D27
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x00004B2F File Offset: 0x00002D2F
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public GrossTonnageMeasureType GrossTonnageMeasure
		{
			get
			{
				return this.grossTonnageMeasureField;
			}
			set
			{
				this.grossTonnageMeasureField = value;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x00004B38 File Offset: 0x00002D38
		// (set) Token: 0x0600090F RID: 2319 RVA: 0x00004B40 File Offset: 0x00002D40
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NetTonnageMeasureType NetTonnageMeasure
		{
			get
			{
				return this.netTonnageMeasureField;
			}
			set
			{
				this.netTonnageMeasureField = value;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x00004B49 File Offset: 0x00002D49
		// (set) Token: 0x06000911 RID: 2321 RVA: 0x00004B51 File Offset: 0x00002D51
		public DocumentReferenceType RegistryCertificateDocumentReference
		{
			get
			{
				return this.registryCertificateDocumentReferenceField;
			}
			set
			{
				this.registryCertificateDocumentReferenceField = value;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x00004B5A File Offset: 0x00002D5A
		// (set) Token: 0x06000913 RID: 2323 RVA: 0x00004B62 File Offset: 0x00002D62
		public LocationType1 RegistryPortLocation
		{
			get
			{
				return this.registryPortLocationField;
			}
			set
			{
				this.registryPortLocationField = value;
			}
		}

		// Token: 0x040002B1 RID: 689
		private VesselIDType vesselIDField;

		// Token: 0x040002B2 RID: 690
		private VesselNameType vesselNameField;

		// Token: 0x040002B3 RID: 691
		private RadioCallSignIDType radioCallSignIDField;

		// Token: 0x040002B4 RID: 692
		private ShipsRequirementsType[] shipsRequirementsField;

		// Token: 0x040002B5 RID: 693
		private GrossTonnageMeasureType grossTonnageMeasureField;

		// Token: 0x040002B6 RID: 694
		private NetTonnageMeasureType netTonnageMeasureField;

		// Token: 0x040002B7 RID: 695
		private DocumentReferenceType registryCertificateDocumentReferenceField;

		// Token: 0x040002B8 RID: 696
		private LocationType1 registryPortLocationField;
	}
}

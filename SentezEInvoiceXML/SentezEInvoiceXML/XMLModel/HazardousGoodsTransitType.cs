using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000388 RID: 904
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("HazardousGoodsTransit", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class HazardousGoodsTransitType
	{
		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x00003A39 File Offset: 0x00001C39
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x00003A41 File Offset: 0x00001C41
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TransportEmergencyCardCodeType TransportEmergencyCardCode
		{
			get
			{
				return this.transportEmergencyCardCodeField;
			}
			set
			{
				this.transportEmergencyCardCodeField = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x00003A4A File Offset: 0x00001C4A
		// (set) Token: 0x060006B0 RID: 1712 RVA: 0x00003A52 File Offset: 0x00001C52
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PackingCriteriaCodeType PackingCriteriaCode
		{
			get
			{
				return this.packingCriteriaCodeField;
			}
			set
			{
				this.packingCriteriaCodeField = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x00003A5B File Offset: 0x00001C5B
		// (set) Token: 0x060006B2 RID: 1714 RVA: 0x00003A63 File Offset: 0x00001C63
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public HazardousRegulationCodeType HazardousRegulationCode
		{
			get
			{
				return this.hazardousRegulationCodeField;
			}
			set
			{
				this.hazardousRegulationCodeField = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x00003A6C File Offset: 0x00001C6C
		// (set) Token: 0x060006B4 RID: 1716 RVA: 0x00003A74 File Offset: 0x00001C74
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public InhalationToxicityZoneCodeType InhalationToxicityZoneCode
		{
			get
			{
				return this.inhalationToxicityZoneCodeField;
			}
			set
			{
				this.inhalationToxicityZoneCodeField = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x00003A7D File Offset: 0x00001C7D
		// (set) Token: 0x060006B6 RID: 1718 RVA: 0x00003A85 File Offset: 0x00001C85
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TransportAuthorizationCodeType TransportAuthorizationCode
		{
			get
			{
				return this.transportAuthorizationCodeField;
			}
			set
			{
				this.transportAuthorizationCodeField = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x00003A8E File Offset: 0x00001C8E
		// (set) Token: 0x060006B8 RID: 1720 RVA: 0x00003A96 File Offset: 0x00001C96
		public TemperatureType MaximumTemperature
		{
			get
			{
				return this.maximumTemperatureField;
			}
			set
			{
				this.maximumTemperatureField = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x00003A9F File Offset: 0x00001C9F
		// (set) Token: 0x060006BA RID: 1722 RVA: 0x00003AA7 File Offset: 0x00001CA7
		public TemperatureType MinimumTemperature
		{
			get
			{
				return this.minimumTemperatureField;
			}
			set
			{
				this.minimumTemperatureField = value;
			}
		}

		// Token: 0x040001B7 RID: 439
		private TransportEmergencyCardCodeType transportEmergencyCardCodeField;

		// Token: 0x040001B8 RID: 440
		private PackingCriteriaCodeType packingCriteriaCodeField;

		// Token: 0x040001B9 RID: 441
		private HazardousRegulationCodeType hazardousRegulationCodeField;

		// Token: 0x040001BA RID: 442
		private InhalationToxicityZoneCodeType inhalationToxicityZoneCodeField;

		// Token: 0x040001BB RID: 443
		private TransportAuthorizationCodeType transportAuthorizationCodeField;

		// Token: 0x040001BC RID: 444
		private TemperatureType maximumTemperatureField;

		// Token: 0x040001BD RID: 445
		private TemperatureType minimumTemperatureField;
	}
}

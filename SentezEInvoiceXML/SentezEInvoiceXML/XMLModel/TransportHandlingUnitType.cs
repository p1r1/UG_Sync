using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200038A RID: 906
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("PackagedTransportHandlingUnit", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class TransportHandlingUnitType
	{
		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x00003AE3 File Offset: 0x00001CE3
		// (set) Token: 0x060006C4 RID: 1732 RVA: 0x00003AEB File Offset: 0x00001CEB
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

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x00003AF4 File Offset: 0x00001CF4
		// (set) Token: 0x060006C6 RID: 1734 RVA: 0x00003AFC File Offset: 0x00001CFC
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TransportHandlingUnitTypeCodeType TransportHandlingUnitTypeCode
		{
			get
			{
				return this.transportHandlingUnitTypeCodeField;
			}
			set
			{
				this.transportHandlingUnitTypeCodeField = value;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x00003B05 File Offset: 0x00001D05
		// (set) Token: 0x060006C8 RID: 1736 RVA: 0x00003B0D File Offset: 0x00001D0D
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public HandlingCodeType HandlingCode
		{
			get
			{
				return this.handlingCodeField;
			}
			set
			{
				this.handlingCodeField = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x00003B16 File Offset: 0x00001D16
		// (set) Token: 0x060006CA RID: 1738 RVA: 0x00003B1E File Offset: 0x00001D1E
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public HandlingInstructionsType HandlingInstructions
		{
			get
			{
				return this.handlingInstructionsField;
			}
			set
			{
				this.handlingInstructionsField = value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x00003B27 File Offset: 0x00001D27
		// (set) Token: 0x060006CC RID: 1740 RVA: 0x00003B2F File Offset: 0x00001D2F
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public HazardousRiskIndicatorType HazardousRiskIndicator
		{
			get
			{
				return this.hazardousRiskIndicatorField;
			}
			set
			{
				this.hazardousRiskIndicatorField = value;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x00003B38 File Offset: 0x00001D38
		// (set) Token: 0x060006CE RID: 1742 RVA: 0x00003B40 File Offset: 0x00001D40
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TotalGoodsItemQuantityType TotalGoodsItemQuantity
		{
			get
			{
				return this.totalGoodsItemQuantityField;
			}
			set
			{
				this.totalGoodsItemQuantityField = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x00003B49 File Offset: 0x00001D49
		// (set) Token: 0x060006D0 RID: 1744 RVA: 0x00003B51 File Offset: 0x00001D51
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TotalPackageQuantityType TotalPackageQuantity
		{
			get
			{
				return this.totalPackageQuantityField;
			}
			set
			{
				this.totalPackageQuantityField = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x00003B5A File Offset: 0x00001D5A
		// (set) Token: 0x060006D2 RID: 1746 RVA: 0x00003B62 File Offset: 0x00001D62
		[XmlElement("DamageRemarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DamageRemarksType[] DamageRemarks
		{
			get
			{
				return this.damageRemarksField;
			}
			set
			{
				this.damageRemarksField = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x00003B6B File Offset: 0x00001D6B
		// (set) Token: 0x060006D4 RID: 1748 RVA: 0x00003B73 File Offset: 0x00001D73
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TraceIDType TraceID
		{
			get
			{
				return this.traceIDField;
			}
			set
			{
				this.traceIDField = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x00003B7C File Offset: 0x00001D7C
		// (set) Token: 0x060006D6 RID: 1750 RVA: 0x00003B84 File Offset: 0x00001D84
		[XmlElement("ActualPackage")]
		public PackageType[] ActualPackage
		{
			get
			{
				return this.actualPackageField;
			}
			set
			{
				this.actualPackageField = value;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x00003B8D File Offset: 0x00001D8D
		// (set) Token: 0x060006D8 RID: 1752 RVA: 0x00003B95 File Offset: 0x00001D95
		[XmlElement("TransportEquipment")]
		public TransportEquipmentType[] TransportEquipment
		{
			get
			{
				return this.transportEquipmentField;
			}
			set
			{
				this.transportEquipmentField = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x00003B9E File Offset: 0x00001D9E
		// (set) Token: 0x060006DA RID: 1754 RVA: 0x00003BA6 File Offset: 0x00001DA6
		[XmlElement("TransportMeans")]
		public TransportMeansType[] TransportMeans
		{
			get
			{
				return this.transportMeansField;
			}
			set
			{
				this.transportMeansField = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x00003BAF File Offset: 0x00001DAF
		// (set) Token: 0x060006DC RID: 1756 RVA: 0x00003BB7 File Offset: 0x00001DB7
		[XmlElement("HazardousGoodsTransit")]
		public HazardousGoodsTransitType[] HazardousGoodsTransit
		{
			get
			{
				return this.hazardousGoodsTransitField;
			}
			set
			{
				this.hazardousGoodsTransitField = value;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x00003BC0 File Offset: 0x00001DC0
		// (set) Token: 0x060006DE RID: 1758 RVA: 0x00003BC8 File Offset: 0x00001DC8
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

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x00003BD1 File Offset: 0x00001DD1
		// (set) Token: 0x060006E0 RID: 1760 RVA: 0x00003BD9 File Offset: 0x00001DD9
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

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x00003BE2 File Offset: 0x00001DE2
		// (set) Token: 0x060006E2 RID: 1762 RVA: 0x00003BEA File Offset: 0x00001DEA
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

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x00003BF3 File Offset: 0x00001DF3
		// (set) Token: 0x060006E4 RID: 1764 RVA: 0x00003BFB File Offset: 0x00001DFB
		public DimensionType FloorSpaceMeasurementDimension
		{
			get
			{
				return this.floorSpaceMeasurementDimensionField;
			}
			set
			{
				this.floorSpaceMeasurementDimensionField = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00003C04 File Offset: 0x00001E04
		// (set) Token: 0x060006E6 RID: 1766 RVA: 0x00003C0C File Offset: 0x00001E0C
		public DimensionType PalletSpaceMeasurementDimension
		{
			get
			{
				return this.palletSpaceMeasurementDimensionField;
			}
			set
			{
				this.palletSpaceMeasurementDimensionField = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x00003C15 File Offset: 0x00001E15
		// (set) Token: 0x060006E8 RID: 1768 RVA: 0x00003C1D File Offset: 0x00001E1D
		[XmlElement("ShipmentDocumentReference")]
		public DocumentReferenceType[] ShipmentDocumentReference
		{
			get
			{
				return this.shipmentDocumentReferenceField;
			}
			set
			{
				this.shipmentDocumentReferenceField = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x00003C26 File Offset: 0x00001E26
		// (set) Token: 0x060006EA RID: 1770 RVA: 0x00003C2E File Offset: 0x00001E2E
		[XmlElement("CustomsDeclaration")]
		public CustomsDeclarationType[] CustomsDeclaration
		{
			get
			{
				return this.customsDeclarationField;
			}
			set
			{
				this.customsDeclarationField = value;
			}
		}

		// Token: 0x040001C1 RID: 449
		private IDType idField;

		// Token: 0x040001C2 RID: 450
		private TransportHandlingUnitTypeCodeType transportHandlingUnitTypeCodeField;

		// Token: 0x040001C3 RID: 451
		private HandlingCodeType handlingCodeField;

		// Token: 0x040001C4 RID: 452
		private HandlingInstructionsType handlingInstructionsField;

		// Token: 0x040001C5 RID: 453
		private HazardousRiskIndicatorType hazardousRiskIndicatorField;

		// Token: 0x040001C6 RID: 454
		private TotalGoodsItemQuantityType totalGoodsItemQuantityField;

		// Token: 0x040001C7 RID: 455
		private TotalPackageQuantityType totalPackageQuantityField;

		// Token: 0x040001C8 RID: 456
		private DamageRemarksType[] damageRemarksField;

		// Token: 0x040001C9 RID: 457
		private TraceIDType traceIDField;

		// Token: 0x040001CA RID: 458
		private PackageType[] actualPackageField;

		// Token: 0x040001CB RID: 459
		private TransportEquipmentType[] transportEquipmentField;

		// Token: 0x040001CC RID: 460
		private TransportMeansType[] transportMeansField;

		// Token: 0x040001CD RID: 461
		private HazardousGoodsTransitType[] hazardousGoodsTransitField;

		// Token: 0x040001CE RID: 462
		private DimensionType[] measurementDimensionField;

		// Token: 0x040001CF RID: 463
		private TemperatureType minimumTemperatureField;

		// Token: 0x040001D0 RID: 464
		private TemperatureType maximumTemperatureField;

		// Token: 0x040001D1 RID: 465
		private DimensionType floorSpaceMeasurementDimensionField;

		// Token: 0x040001D2 RID: 466
		private DimensionType palletSpaceMeasurementDimensionField;

		// Token: 0x040001D3 RID: 467
		private DocumentReferenceType[] shipmentDocumentReferenceField;

		// Token: 0x040001D4 RID: 468
		private CustomsDeclarationType[] customsDeclarationField;
	}
}

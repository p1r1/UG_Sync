using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003CF RID: 975
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ContainedGoodsItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class GoodsItemType
	{
		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x00003D35 File Offset: 0x00001F35
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x00003D3D File Offset: 0x00001F3D
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

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x00003D46 File Offset: 0x00001F46
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x00003D4E File Offset: 0x00001F4E
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SequenceNumberIDType SequenceNumberID
		{
			get
			{
				return this.sequenceNumberIDField;
			}
			set
			{
				this.sequenceNumberIDField = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x00003D57 File Offset: 0x00001F57
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x00003D5F File Offset: 0x00001F5F
		[XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DescriptionType[] Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x00003D68 File Offset: 0x00001F68
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x00003D70 File Offset: 0x00001F70
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

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x00003D79 File Offset: 0x00001F79
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x00003D81 File Offset: 0x00001F81
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DeclaredCustomsValueAmountType DeclaredCustomsValueAmount
		{
			get
			{
				return this.declaredCustomsValueAmountField;
			}
			set
			{
				this.declaredCustomsValueAmountField = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x00003D8A File Offset: 0x00001F8A
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x00003D92 File Offset: 0x00001F92
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DeclaredForCarriageValueAmountType DeclaredForCarriageValueAmount
		{
			get
			{
				return this.declaredForCarriageValueAmountField;
			}
			set
			{
				this.declaredForCarriageValueAmountField = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x00003D9B File Offset: 0x00001F9B
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x00003DA3 File Offset: 0x00001FA3
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DeclaredStatisticsValueAmountType DeclaredStatisticsValueAmount
		{
			get
			{
				return this.declaredStatisticsValueAmountField;
			}
			set
			{
				this.declaredStatisticsValueAmountField = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x00003DAC File Offset: 0x00001FAC
		// (set) Token: 0x0600075B RID: 1883 RVA: 0x00003DB4 File Offset: 0x00001FB4
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public FreeOnBoardValueAmountType FreeOnBoardValueAmount
		{
			get
			{
				return this.freeOnBoardValueAmountField;
			}
			set
			{
				this.freeOnBoardValueAmountField = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x00003DBD File Offset: 0x00001FBD
		// (set) Token: 0x0600075D RID: 1885 RVA: 0x00003DC5 File Offset: 0x00001FC5
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public InsuranceValueAmountType InsuranceValueAmount
		{
			get
			{
				return this.insuranceValueAmountField;
			}
			set
			{
				this.insuranceValueAmountField = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x00003DCE File Offset: 0x00001FCE
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x00003DD6 File Offset: 0x00001FD6
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ValueAmountType ValueAmount
		{
			get
			{
				return this.valueAmountField;
			}
			set
			{
				this.valueAmountField = value;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x00003DDF File Offset: 0x00001FDF
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x00003DE7 File Offset: 0x00001FE7
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public GrossWeightMeasureType GrossWeightMeasure
		{
			get
			{
				return this.grossWeightMeasureField;
			}
			set
			{
				this.grossWeightMeasureField = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x00003DF0 File Offset: 0x00001FF0
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x00003DF8 File Offset: 0x00001FF8
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NetWeightMeasureType NetWeightMeasure
		{
			get
			{
				return this.netWeightMeasureField;
			}
			set
			{
				this.netWeightMeasureField = value;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x00003E01 File Offset: 0x00002001
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x00003E09 File Offset: 0x00002009
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NetNetWeightMeasureType NetNetWeightMeasure
		{
			get
			{
				return this.netNetWeightMeasureField;
			}
			set
			{
				this.netNetWeightMeasureField = value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x00003E12 File Offset: 0x00002012
		// (set) Token: 0x06000767 RID: 1895 RVA: 0x00003E1A File Offset: 0x0000201A
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ChargeableWeightMeasureType ChargeableWeightMeasure
		{
			get
			{
				return this.chargeableWeightMeasureField;
			}
			set
			{
				this.chargeableWeightMeasureField = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x00003E23 File Offset: 0x00002023
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x00003E2B File Offset: 0x0000202B
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public GrossVolumeMeasureType GrossVolumeMeasure
		{
			get
			{
				return this.grossVolumeMeasureField;
			}
			set
			{
				this.grossVolumeMeasureField = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x00003E34 File Offset: 0x00002034
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x00003E3C File Offset: 0x0000203C
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NetVolumeMeasureType NetVolumeMeasure
		{
			get
			{
				return this.netVolumeMeasureField;
			}
			set
			{
				this.netVolumeMeasureField = value;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x00003E45 File Offset: 0x00002045
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x00003E4D File Offset: 0x0000204D
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType2 Quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x00003E56 File Offset: 0x00002056
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x00003E5E File Offset: 0x0000205E
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PreferenceCriterionCodeType PreferenceCriterionCode
		{
			get
			{
				return this.preferenceCriterionCodeField;
			}
			set
			{
				this.preferenceCriterionCodeField = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x00003E67 File Offset: 0x00002067
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x00003E6F File Offset: 0x0000206F
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public RequiredCustomsIDType RequiredCustomsID
		{
			get
			{
				return this.requiredCustomsIDField;
			}
			set
			{
				this.requiredCustomsIDField = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x00003E78 File Offset: 0x00002078
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x00003E80 File Offset: 0x00002080
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CustomsStatusCodeType CustomsStatusCode
		{
			get
			{
				return this.customsStatusCodeField;
			}
			set
			{
				this.customsStatusCodeField = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x00003E89 File Offset: 0x00002089
		// (set) Token: 0x06000775 RID: 1909 RVA: 0x00003E91 File Offset: 0x00002091
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CustomsTariffQuantityType CustomsTariffQuantity
		{
			get
			{
				return this.customsTariffQuantityField;
			}
			set
			{
				this.customsTariffQuantityField = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x00003E9A File Offset: 0x0000209A
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x00003EA2 File Offset: 0x000020A2
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CustomsImportClassifiedIndicatorType CustomsImportClassifiedIndicator
		{
			get
			{
				return this.customsImportClassifiedIndicatorField;
			}
			set
			{
				this.customsImportClassifiedIndicatorField = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x00003EAB File Offset: 0x000020AB
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x00003EB3 File Offset: 0x000020B3
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ChargeableQuantityType ChargeableQuantity
		{
			get
			{
				return this.chargeableQuantityField;
			}
			set
			{
				this.chargeableQuantityField = value;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x00003EBC File Offset: 0x000020BC
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x00003EC4 File Offset: 0x000020C4
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ReturnableQuantityType ReturnableQuantity
		{
			get
			{
				return this.returnableQuantityField;
			}
			set
			{
				this.returnableQuantityField = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x00003ECD File Offset: 0x000020CD
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x00003ED5 File Offset: 0x000020D5
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

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x00003EDE File Offset: 0x000020DE
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x00003EE6 File Offset: 0x000020E6
		[XmlElement("Item")]
		public ItemType[] Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x00003EEF File Offset: 0x000020EF
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x00003EF7 File Offset: 0x000020F7
		[XmlElement("GoodsItemContainer")]
		public GoodsItemContainerType[] GoodsItemContainer
		{
			get
			{
				return this.goodsItemContainerField;
			}
			set
			{
				this.goodsItemContainerField = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x00003F00 File Offset: 0x00002100
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x00003F08 File Offset: 0x00002108
		[XmlElement("FreightAllowanceCharge")]
		public AllowanceChargeType[] FreightAllowanceCharge
		{
			get
			{
				return this.freightAllowanceChargeField;
			}
			set
			{
				this.freightAllowanceChargeField = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x00003F11 File Offset: 0x00002111
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x00003F19 File Offset: 0x00002119
		[XmlElement("InvoiceLine")]
		public InvoiceLineType[] InvoiceLine
		{
			get
			{
				return this.invoiceLineField;
			}
			set
			{
				this.invoiceLineField = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x00003F22 File Offset: 0x00002122
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x00003F2A File Offset: 0x0000212A
		[XmlElement("Temperature")]
		public TemperatureType[] Temperature
		{
			get
			{
				return this.temperatureField;
			}
			set
			{
				this.temperatureField = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x00003F33 File Offset: 0x00002133
		// (set) Token: 0x06000789 RID: 1929 RVA: 0x00003F3B File Offset: 0x0000213B
		[XmlElement("ContainedGoodsItem")]
		public GoodsItemType[] ContainedGoodsItem
		{
			get
			{
				return this.containedGoodsItemField;
			}
			set
			{
				this.containedGoodsItemField = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x00003F44 File Offset: 0x00002144
		// (set) Token: 0x0600078B RID: 1931 RVA: 0x00003F4C File Offset: 0x0000214C
		public AddressType OriginAddress
		{
			get
			{
				return this.originAddressField;
			}
			set
			{
				this.originAddressField = value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x00003F55 File Offset: 0x00002155
		// (set) Token: 0x0600078D RID: 1933 RVA: 0x00003F5D File Offset: 0x0000215D
		public DeliveryType Delivery
		{
			get
			{
				return this.deliveryField;
			}
			set
			{
				this.deliveryField = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x00003F66 File Offset: 0x00002166
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x00003F6E File Offset: 0x0000216E
		public PickupType Pickup
		{
			get
			{
				return this.pickupField;
			}
			set
			{
				this.pickupField = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x00003F77 File Offset: 0x00002177
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x00003F7F File Offset: 0x0000217F
		public DespatchType Despatch
		{
			get
			{
				return this.despatchField;
			}
			set
			{
				this.despatchField = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x00003F88 File Offset: 0x00002188
		// (set) Token: 0x06000793 RID: 1939 RVA: 0x00003F90 File Offset: 0x00002190
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

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x00003F99 File Offset: 0x00002199
		// (set) Token: 0x06000795 RID: 1941 RVA: 0x00003FA1 File Offset: 0x000021A1
		[XmlElement("ContainingPackage")]
		public PackageType[] ContainingPackage
		{
			get
			{
				return this.containingPackageField;
			}
			set
			{
				this.containingPackageField = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x00003FAA File Offset: 0x000021AA
		// (set) Token: 0x06000797 RID: 1943 RVA: 0x00003FB2 File Offset: 0x000021B2
		public DocumentReferenceType ShipmentDocumentReference
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

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x00003FBB File Offset: 0x000021BB
		// (set) Token: 0x06000799 RID: 1945 RVA: 0x00003FC3 File Offset: 0x000021C3
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

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x00003FCC File Offset: 0x000021CC
		// (set) Token: 0x0600079B RID: 1947 RVA: 0x00003FD4 File Offset: 0x000021D4
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

		// Token: 0x040001E3 RID: 483
		private IDType idField;

		// Token: 0x040001E4 RID: 484
		private SequenceNumberIDType sequenceNumberIDField;

		// Token: 0x040001E5 RID: 485
		private DescriptionType[] descriptionField;

		// Token: 0x040001E6 RID: 486
		private HazardousRiskIndicatorType hazardousRiskIndicatorField;

		// Token: 0x040001E7 RID: 487
		private DeclaredCustomsValueAmountType declaredCustomsValueAmountField;

		// Token: 0x040001E8 RID: 488
		private DeclaredForCarriageValueAmountType declaredForCarriageValueAmountField;

		// Token: 0x040001E9 RID: 489
		private DeclaredStatisticsValueAmountType declaredStatisticsValueAmountField;

		// Token: 0x040001EA RID: 490
		private FreeOnBoardValueAmountType freeOnBoardValueAmountField;

		// Token: 0x040001EB RID: 491
		private InsuranceValueAmountType insuranceValueAmountField;

		// Token: 0x040001EC RID: 492
		private ValueAmountType valueAmountField;

		// Token: 0x040001ED RID: 493
		private GrossWeightMeasureType grossWeightMeasureField;

		// Token: 0x040001EE RID: 494
		private NetWeightMeasureType netWeightMeasureField;

		// Token: 0x040001EF RID: 495
		private NetNetWeightMeasureType netNetWeightMeasureField;

		// Token: 0x040001F0 RID: 496
		private ChargeableWeightMeasureType chargeableWeightMeasureField;

		// Token: 0x040001F1 RID: 497
		private GrossVolumeMeasureType grossVolumeMeasureField;

		// Token: 0x040001F2 RID: 498
		private NetVolumeMeasureType netVolumeMeasureField;

		// Token: 0x040001F3 RID: 499
		private QuantityType2 quantityField;

		// Token: 0x040001F4 RID: 500
		private PreferenceCriterionCodeType preferenceCriterionCodeField;

		// Token: 0x040001F5 RID: 501
		private RequiredCustomsIDType requiredCustomsIDField;

		// Token: 0x040001F6 RID: 502
		private CustomsStatusCodeType customsStatusCodeField;

		// Token: 0x040001F7 RID: 503
		private CustomsTariffQuantityType customsTariffQuantityField;

		// Token: 0x040001F8 RID: 504
		private CustomsImportClassifiedIndicatorType customsImportClassifiedIndicatorField;

		// Token: 0x040001F9 RID: 505
		private ChargeableQuantityType chargeableQuantityField;

		// Token: 0x040001FA RID: 506
		private ReturnableQuantityType returnableQuantityField;

		// Token: 0x040001FB RID: 507
		private TraceIDType traceIDField;

		// Token: 0x040001FC RID: 508
		private ItemType[] itemField;

		// Token: 0x040001FD RID: 509
		private GoodsItemContainerType[] goodsItemContainerField;

		// Token: 0x040001FE RID: 510
		private AllowanceChargeType[] freightAllowanceChargeField;

		// Token: 0x040001FF RID: 511
		private InvoiceLineType[] invoiceLineField;

		// Token: 0x04000200 RID: 512
		private TemperatureType[] temperatureField;

		// Token: 0x04000201 RID: 513
		private GoodsItemType[] containedGoodsItemField;

		// Token: 0x04000202 RID: 514
		private AddressType originAddressField;

		// Token: 0x04000203 RID: 515
		private DeliveryType deliveryField;

		// Token: 0x04000204 RID: 516
		private PickupType pickupField;

		// Token: 0x04000205 RID: 517
		private DespatchType despatchField;

		// Token: 0x04000206 RID: 518
		private DimensionType[] measurementDimensionField;

		// Token: 0x04000207 RID: 519
		private PackageType[] containingPackageField;

		// Token: 0x04000208 RID: 520
		private DocumentReferenceType shipmentDocumentReferenceField;

		// Token: 0x04000209 RID: 521
		private TemperatureType minimumTemperatureField;

		// Token: 0x0400020A RID: 522
		private TemperatureType maximumTemperatureField;
	}
}

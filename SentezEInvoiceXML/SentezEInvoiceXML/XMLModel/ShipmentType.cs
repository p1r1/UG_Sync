using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003E3 RID: 995
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ConsolidatedShipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ShipmentType
	{
		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x0000475E File Offset: 0x0000295E
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x00004766 File Offset: 0x00002966
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

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x0000476F File Offset: 0x0000296F
		// (set) Token: 0x06000895 RID: 2197 RVA: 0x00004777 File Offset: 0x00002977
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

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x00004780 File Offset: 0x00002980
		// (set) Token: 0x06000897 RID: 2199 RVA: 0x00004788 File Offset: 0x00002988
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

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x00004791 File Offset: 0x00002991
		// (set) Token: 0x06000899 RID: 2201 RVA: 0x00004799 File Offset: 0x00002999
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

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x000047A2 File Offset: 0x000029A2
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x000047AA File Offset: 0x000029AA
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

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x000047B3 File Offset: 0x000029B3
		// (set) Token: 0x0600089D RID: 2205 RVA: 0x000047BB File Offset: 0x000029BB
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

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x000047C4 File Offset: 0x000029C4
		// (set) Token: 0x0600089F RID: 2207 RVA: 0x000047CC File Offset: 0x000029CC
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

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x000047D5 File Offset: 0x000029D5
		// (set) Token: 0x060008A1 RID: 2209 RVA: 0x000047DD File Offset: 0x000029DD
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

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x000047E6 File Offset: 0x000029E6
		// (set) Token: 0x060008A3 RID: 2211 RVA: 0x000047EE File Offset: 0x000029EE
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TotalTransportHandlingUnitQuantityType TotalTransportHandlingUnitQuantity
		{
			get
			{
				return this.totalTransportHandlingUnitQuantityField;
			}
			set
			{
				this.totalTransportHandlingUnitQuantityField = value;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x000047F7 File Offset: 0x000029F7
		// (set) Token: 0x060008A5 RID: 2213 RVA: 0x000047FF File Offset: 0x000029FF
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

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x00004808 File Offset: 0x00002A08
		// (set) Token: 0x060008A7 RID: 2215 RVA: 0x00004810 File Offset: 0x00002A10
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

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x00004819 File Offset: 0x00002A19
		// (set) Token: 0x060008A9 RID: 2217 RVA: 0x00004821 File Offset: 0x00002A21
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

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x0000482A File Offset: 0x00002A2A
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x00004832 File Offset: 0x00002A32
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

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x0000483B File Offset: 0x00002A3B
		// (set) Token: 0x060008AD RID: 2221 RVA: 0x00004843 File Offset: 0x00002A43
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

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x0000484C File Offset: 0x00002A4C
		// (set) Token: 0x060008AF RID: 2223 RVA: 0x00004854 File Offset: 0x00002A54
		[XmlElement("SpecialInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SpecialInstructionsType[] SpecialInstructions
		{
			get
			{
				return this.specialInstructionsField;
			}
			set
			{
				this.specialInstructionsField = value;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x0000485D File Offset: 0x00002A5D
		// (set) Token: 0x060008B1 RID: 2225 RVA: 0x00004865 File Offset: 0x00002A65
		[XmlElement("Consignment")]
		public ConsignmentType[] Consignment
		{
			get
			{
				return this.consignmentField;
			}
			set
			{
				this.consignmentField = value;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x0000486E File Offset: 0x00002A6E
		// (set) Token: 0x060008B3 RID: 2227 RVA: 0x00004876 File Offset: 0x00002A76
		[XmlElement("GoodsItem")]
		public GoodsItemType[] GoodsItem
		{
			get
			{
				return this.goodsItemField;
			}
			set
			{
				this.goodsItemField = value;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x0000487F File Offset: 0x00002A7F
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x00004887 File Offset: 0x00002A87
		[XmlElement("ShipmentStage")]
		public ShipmentStageType[] ShipmentStage
		{
			get
			{
				return this.shipmentStageField;
			}
			set
			{
				this.shipmentStageField = value;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x00004890 File Offset: 0x00002A90
		// (set) Token: 0x060008B7 RID: 2231 RVA: 0x00004898 File Offset: 0x00002A98
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

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x000048A1 File Offset: 0x00002AA1
		// (set) Token: 0x060008B9 RID: 2233 RVA: 0x000048A9 File Offset: 0x00002AA9
		[XmlElement("TransportHandlingUnit")]
		public TransportHandlingUnitType[] TransportHandlingUnit
		{
			get
			{
				return this.transportHandlingUnitField;
			}
			set
			{
				this.transportHandlingUnitField = value;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x000048B2 File Offset: 0x00002AB2
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x000048BA File Offset: 0x00002ABA
		public AddressType ReturnAddress
		{
			get
			{
				return this.returnAddressField;
			}
			set
			{
				this.returnAddressField = value;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x000048C3 File Offset: 0x00002AC3
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x000048CB File Offset: 0x00002ACB
		public LocationType1 FirstArrivalPortLocation
		{
			get
			{
				return this.firstArrivalPortLocationField;
			}
			set
			{
				this.firstArrivalPortLocationField = value;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x000048D4 File Offset: 0x00002AD4
		// (set) Token: 0x060008BF RID: 2239 RVA: 0x000048DC File Offset: 0x00002ADC
		public LocationType1 LastExitPortLocation
		{
			get
			{
				return this.lastExitPortLocationField;
			}
			set
			{
				this.lastExitPortLocationField = value;
			}
		}

		// Token: 0x0400027C RID: 636
		private IDType idField;

		// Token: 0x0400027D RID: 637
		private HandlingCodeType handlingCodeField;

		// Token: 0x0400027E RID: 638
		private HandlingInstructionsType handlingInstructionsField;

		// Token: 0x0400027F RID: 639
		private GrossWeightMeasureType grossWeightMeasureField;

		// Token: 0x04000280 RID: 640
		private NetWeightMeasureType netWeightMeasureField;

		// Token: 0x04000281 RID: 641
		private GrossVolumeMeasureType grossVolumeMeasureField;

		// Token: 0x04000282 RID: 642
		private NetVolumeMeasureType netVolumeMeasureField;

		// Token: 0x04000283 RID: 643
		private TotalGoodsItemQuantityType totalGoodsItemQuantityField;

		// Token: 0x04000284 RID: 644
		private TotalTransportHandlingUnitQuantityType totalTransportHandlingUnitQuantityField;

		// Token: 0x04000285 RID: 645
		private InsuranceValueAmountType insuranceValueAmountField;

		// Token: 0x04000286 RID: 646
		private DeclaredCustomsValueAmountType declaredCustomsValueAmountField;

		// Token: 0x04000287 RID: 647
		private DeclaredForCarriageValueAmountType declaredForCarriageValueAmountField;

		// Token: 0x04000288 RID: 648
		private DeclaredStatisticsValueAmountType declaredStatisticsValueAmountField;

		// Token: 0x04000289 RID: 649
		private FreeOnBoardValueAmountType freeOnBoardValueAmountField;

		// Token: 0x0400028A RID: 650
		private SpecialInstructionsType[] specialInstructionsField;

		// Token: 0x0400028B RID: 651
		private ConsignmentType[] consignmentField;

		// Token: 0x0400028C RID: 652
		private GoodsItemType[] goodsItemField;

		// Token: 0x0400028D RID: 653
		private ShipmentStageType[] shipmentStageField;

		// Token: 0x0400028E RID: 654
		private DeliveryType deliveryField;

		// Token: 0x0400028F RID: 655
		private TransportHandlingUnitType[] transportHandlingUnitField;

		// Token: 0x04000290 RID: 656
		private AddressType returnAddressField;

		// Token: 0x04000291 RID: 657
		private LocationType1 firstArrivalPortLocationField;

		// Token: 0x04000292 RID: 658
		private LocationType1 lastExitPortLocationField;
	}
}

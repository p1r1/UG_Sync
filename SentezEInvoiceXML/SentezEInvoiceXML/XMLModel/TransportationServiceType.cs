using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000409 RID: 1033
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("AdditionalTransportationService", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class TransportationServiceType
	{
		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x0000553F File Offset: 0x0000373F
		// (set) Token: 0x06000A5B RID: 2651 RVA: 0x00005547 File Offset: 0x00003747
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TransportServiceCodeType TransportServiceCode
		{
			get
			{
				return this.transportServiceCodeField;
			}
			set
			{
				this.transportServiceCodeField = value;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x00005550 File Offset: 0x00003750
		// (set) Token: 0x06000A5D RID: 2653 RVA: 0x00005558 File Offset: 0x00003758
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TariffClassCodeType TariffClassCode
		{
			get
			{
				return this.tariffClassCodeField;
			}
			set
			{
				this.tariffClassCodeField = value;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x00005561 File Offset: 0x00003761
		// (set) Token: 0x06000A5F RID: 2655 RVA: 0x00005569 File Offset: 0x00003769
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PriorityType Priority
		{
			get
			{
				return this.priorityField;
			}
			set
			{
				this.priorityField = value;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x00005572 File Offset: 0x00003772
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x0000557A File Offset: 0x0000377A
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public FreightRateClassCodeType FreightRateClassCode
		{
			get
			{
				return this.freightRateClassCodeField;
			}
			set
			{
				this.freightRateClassCodeField = value;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x00005583 File Offset: 0x00003783
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x0000558B File Offset: 0x0000378B
		[XmlElement("TransportationServiceDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TransportationServiceDescriptionType[] TransportationServiceDescription
		{
			get
			{
				return this.transportationServiceDescriptionField;
			}
			set
			{
				this.transportationServiceDescriptionField = value;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x00005594 File Offset: 0x00003794
		// (set) Token: 0x06000A65 RID: 2661 RVA: 0x0000559C File Offset: 0x0000379C
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TransportationServiceDetailsURIType TransportationServiceDetailsURI
		{
			get
			{
				return this.transportationServiceDetailsURIField;
			}
			set
			{
				this.transportationServiceDetailsURIField = value;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x000055A5 File Offset: 0x000037A5
		// (set) Token: 0x06000A67 RID: 2663 RVA: 0x000055AD File Offset: 0x000037AD
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NominationDateType NominationDate
		{
			get
			{
				return this.nominationDateField;
			}
			set
			{
				this.nominationDateField = value;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x000055B6 File Offset: 0x000037B6
		// (set) Token: 0x06000A69 RID: 2665 RVA: 0x000055BE File Offset: 0x000037BE
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NominationTimeType NominationTime
		{
			get
			{
				return this.nominationTimeField;
			}
			set
			{
				this.nominationTimeField = value;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x000055C7 File Offset: 0x000037C7
		// (set) Token: 0x06000A6B RID: 2667 RVA: 0x000055CF File Offset: 0x000037CF
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NameType1 Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x000055D8 File Offset: 0x000037D8
		// (set) Token: 0x06000A6D RID: 2669 RVA: 0x000055E0 File Offset: 0x000037E0
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SequenceNumericType SequenceNumeric
		{
			get
			{
				return this.sequenceNumericField;
			}
			set
			{
				this.sequenceNumericField = value;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x000055E9 File Offset: 0x000037E9
		// (set) Token: 0x06000A6F RID: 2671 RVA: 0x000055F1 File Offset: 0x000037F1
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

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x000055FA File Offset: 0x000037FA
		// (set) Token: 0x06000A71 RID: 2673 RVA: 0x00005602 File Offset: 0x00003802
		[XmlElement("SupportedTransportEquipment")]
		public TransportEquipmentType[] SupportedTransportEquipment
		{
			get
			{
				return this.supportedTransportEquipmentField;
			}
			set
			{
				this.supportedTransportEquipmentField = value;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x0000560B File Offset: 0x0000380B
		// (set) Token: 0x06000A73 RID: 2675 RVA: 0x00005613 File Offset: 0x00003813
		[XmlElement("UnsupportedTransportEquipment")]
		public TransportEquipmentType[] UnsupportedTransportEquipment
		{
			get
			{
				return this.unsupportedTransportEquipmentField;
			}
			set
			{
				this.unsupportedTransportEquipmentField = value;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x0000561C File Offset: 0x0000381C
		// (set) Token: 0x06000A75 RID: 2677 RVA: 0x00005624 File Offset: 0x00003824
		[XmlElement("CommodityClassification")]
		public CommodityClassificationType[] CommodityClassification
		{
			get
			{
				return this.commodityClassificationField;
			}
			set
			{
				this.commodityClassificationField = value;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x0000562D File Offset: 0x0000382D
		// (set) Token: 0x06000A77 RID: 2679 RVA: 0x00005635 File Offset: 0x00003835
		[XmlElement("SupportedCommodityClassification")]
		public CommodityClassificationType[] SupportedCommodityClassification
		{
			get
			{
				return this.supportedCommodityClassificationField;
			}
			set
			{
				this.supportedCommodityClassificationField = value;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x0000563E File Offset: 0x0000383E
		// (set) Token: 0x06000A79 RID: 2681 RVA: 0x00005646 File Offset: 0x00003846
		[XmlElement("UnsupportedCommodityClassification")]
		public CommodityClassificationType[] UnsupportedCommodityClassification
		{
			get
			{
				return this.unsupportedCommodityClassificationField;
			}
			set
			{
				this.unsupportedCommodityClassificationField = value;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x0000564F File Offset: 0x0000384F
		// (set) Token: 0x06000A7B RID: 2683 RVA: 0x00005657 File Offset: 0x00003857
		public DimensionType TotalCapacityDimension
		{
			get
			{
				return this.totalCapacityDimensionField;
			}
			set
			{
				this.totalCapacityDimensionField = value;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x00005660 File Offset: 0x00003860
		// (set) Token: 0x06000A7D RID: 2685 RVA: 0x00005668 File Offset: 0x00003868
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

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x00005671 File Offset: 0x00003871
		// (set) Token: 0x06000A7F RID: 2687 RVA: 0x00005679 File Offset: 0x00003879
		[XmlElement("TransportEvent")]
		public TransportEventType[] TransportEvent
		{
			get
			{
				return this.transportEventField;
			}
			set
			{
				this.transportEventField = value;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x00005682 File Offset: 0x00003882
		// (set) Token: 0x06000A81 RID: 2689 RVA: 0x0000568A File Offset: 0x0000388A
		public PartyType ResponsibleTransportServiceProviderParty
		{
			get
			{
				return this.responsibleTransportServiceProviderPartyField;
			}
			set
			{
				this.responsibleTransportServiceProviderPartyField = value;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x00005693 File Offset: 0x00003893
		// (set) Token: 0x06000A83 RID: 2691 RVA: 0x0000569B File Offset: 0x0000389B
		[XmlElement("EnvironmentalEmission")]
		public EnvironmentalEmissionType[] EnvironmentalEmission
		{
			get
			{
				return this.environmentalEmissionField;
			}
			set
			{
				this.environmentalEmissionField = value;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x000056A4 File Offset: 0x000038A4
		// (set) Token: 0x06000A85 RID: 2693 RVA: 0x000056AC File Offset: 0x000038AC
		public PeriodType EstimatedDurationPeriod
		{
			get
			{
				return this.estimatedDurationPeriodField;
			}
			set
			{
				this.estimatedDurationPeriodField = value;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x000056B5 File Offset: 0x000038B5
		// (set) Token: 0x06000A87 RID: 2695 RVA: 0x000056BD File Offset: 0x000038BD
		[XmlElement("ScheduledServiceFrequency")]
		public ServiceFrequencyType[] ScheduledServiceFrequency
		{
			get
			{
				return this.scheduledServiceFrequencyField;
			}
			set
			{
				this.scheduledServiceFrequencyField = value;
			}
		}

		// Token: 0x0400034D RID: 845
		private TransportServiceCodeType transportServiceCodeField;

		// Token: 0x0400034E RID: 846
		private TariffClassCodeType tariffClassCodeField;

		// Token: 0x0400034F RID: 847
		private PriorityType priorityField;

		// Token: 0x04000350 RID: 848
		private FreightRateClassCodeType freightRateClassCodeField;

		// Token: 0x04000351 RID: 849
		private TransportationServiceDescriptionType[] transportationServiceDescriptionField;

		// Token: 0x04000352 RID: 850
		private TransportationServiceDetailsURIType transportationServiceDetailsURIField;

		// Token: 0x04000353 RID: 851
		private NominationDateType nominationDateField;

		// Token: 0x04000354 RID: 852
		private NominationTimeType nominationTimeField;

		// Token: 0x04000355 RID: 853
		private NameType1 nameField;

		// Token: 0x04000356 RID: 854
		private SequenceNumericType sequenceNumericField;

		// Token: 0x04000357 RID: 855
		private TransportEquipmentType[] transportEquipmentField;

		// Token: 0x04000358 RID: 856
		private TransportEquipmentType[] supportedTransportEquipmentField;

		// Token: 0x04000359 RID: 857
		private TransportEquipmentType[] unsupportedTransportEquipmentField;

		// Token: 0x0400035A RID: 858
		private CommodityClassificationType[] commodityClassificationField;

		// Token: 0x0400035B RID: 859
		private CommodityClassificationType[] supportedCommodityClassificationField;

		// Token: 0x0400035C RID: 860
		private CommodityClassificationType[] unsupportedCommodityClassificationField;

		// Token: 0x0400035D RID: 861
		private DimensionType totalCapacityDimensionField;

		// Token: 0x0400035E RID: 862
		private ShipmentStageType[] shipmentStageField;

		// Token: 0x0400035F RID: 863
		private TransportEventType[] transportEventField;

		// Token: 0x04000360 RID: 864
		private PartyType responsibleTransportServiceProviderPartyField;

		// Token: 0x04000361 RID: 865
		private EnvironmentalEmissionType[] environmentalEmissionField;

		// Token: 0x04000362 RID: 866
		private PeriodType estimatedDurationPeriodField;

		// Token: 0x04000363 RID: 867
		private ServiceFrequencyType[] scheduledServiceFrequencyField;
	}
}

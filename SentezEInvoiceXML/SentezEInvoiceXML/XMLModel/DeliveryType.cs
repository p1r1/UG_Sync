using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003E0 RID: 992
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ContractualDelivery", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class DeliveryType
	{
		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x000045A4 File Offset: 0x000027A4
		// (set) Token: 0x0600085C RID: 2140 RVA: 0x000045AC File Offset: 0x000027AC
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

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x000045B5 File Offset: 0x000027B5
		// (set) Token: 0x0600085E RID: 2142 RVA: 0x000045BD File Offset: 0x000027BD
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

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x000045C6 File Offset: 0x000027C6
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x000045CE File Offset: 0x000027CE
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ActualDeliveryDateType ActualDeliveryDate
		{
			get
			{
				return this.actualDeliveryDateField;
			}
			set
			{
				this.actualDeliveryDateField = value;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x000045D7 File Offset: 0x000027D7
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x000045DF File Offset: 0x000027DF
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ActualDeliveryTimeType ActualDeliveryTime
		{
			get
			{
				return this.actualDeliveryTimeField;
			}
			set
			{
				this.actualDeliveryTimeField = value;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x000045E8 File Offset: 0x000027E8
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x000045F0 File Offset: 0x000027F0
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LatestDeliveryDateType LatestDeliveryDate
		{
			get
			{
				return this.latestDeliveryDateField;
			}
			set
			{
				this.latestDeliveryDateField = value;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x000045F9 File Offset: 0x000027F9
		// (set) Token: 0x06000866 RID: 2150 RVA: 0x00004601 File Offset: 0x00002801
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LatestDeliveryTimeType LatestDeliveryTime
		{
			get
			{
				return this.latestDeliveryTimeField;
			}
			set
			{
				this.latestDeliveryTimeField = value;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x0000460A File Offset: 0x0000280A
		// (set) Token: 0x06000868 RID: 2152 RVA: 0x00004612 File Offset: 0x00002812
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TrackingIDType TrackingID
		{
			get
			{
				return this.trackingIDField;
			}
			set
			{
				this.trackingIDField = value;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x0000461B File Offset: 0x0000281B
		// (set) Token: 0x0600086A RID: 2154 RVA: 0x00004623 File Offset: 0x00002823
		public AddressType DeliveryAddress
		{
			get
			{
				return this.deliveryAddressField;
			}
			set
			{
				this.deliveryAddressField = value;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x0000462C File Offset: 0x0000282C
		// (set) Token: 0x0600086C RID: 2156 RVA: 0x00004634 File Offset: 0x00002834
		public LocationType1 AlternativeDeliveryLocation
		{
			get
			{
				return this.alternativeDeliveryLocationField;
			}
			set
			{
				this.alternativeDeliveryLocationField = value;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x0000463D File Offset: 0x0000283D
		// (set) Token: 0x0600086E RID: 2158 RVA: 0x00004645 File Offset: 0x00002845
		public PeriodType EstimatedDeliveryPeriod
		{
			get
			{
				return this.estimatedDeliveryPeriodField;
			}
			set
			{
				this.estimatedDeliveryPeriodField = value;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x0000464E File Offset: 0x0000284E
		// (set) Token: 0x06000870 RID: 2160 RVA: 0x00004656 File Offset: 0x00002856
		public PartyType CarrierParty
		{
			get
			{
				return this.carrierPartyField;
			}
			set
			{
				this.carrierPartyField = value;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x0000465F File Offset: 0x0000285F
		// (set) Token: 0x06000872 RID: 2162 RVA: 0x00004667 File Offset: 0x00002867
		public PartyType DeliveryParty
		{
			get
			{
				return this.deliveryPartyField;
			}
			set
			{
				this.deliveryPartyField = value;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x00004670 File Offset: 0x00002870
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x00004678 File Offset: 0x00002878
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

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x00004681 File Offset: 0x00002881
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x00004689 File Offset: 0x00002889
		[XmlElement("DeliveryTerms")]
		public DeliveryTermsType[] DeliveryTerms
		{
			get
			{
				return this.deliveryTermsField;
			}
			set
			{
				this.deliveryTermsField = value;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x00004692 File Offset: 0x00002892
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x0000469A File Offset: 0x0000289A
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

		// Token: 0x04000262 RID: 610
		private IDType idField;

		// Token: 0x04000263 RID: 611
		private QuantityType2 quantityField;

		// Token: 0x04000264 RID: 612
		private ActualDeliveryDateType actualDeliveryDateField;

		// Token: 0x04000265 RID: 613
		private ActualDeliveryTimeType actualDeliveryTimeField;

		// Token: 0x04000266 RID: 614
		private LatestDeliveryDateType latestDeliveryDateField;

		// Token: 0x04000267 RID: 615
		private LatestDeliveryTimeType latestDeliveryTimeField;

		// Token: 0x04000268 RID: 616
		private TrackingIDType trackingIDField;

		// Token: 0x04000269 RID: 617
		private AddressType deliveryAddressField;

		// Token: 0x0400026A RID: 618
		private LocationType1 alternativeDeliveryLocationField;

		// Token: 0x0400026B RID: 619
		private PeriodType estimatedDeliveryPeriodField;

		// Token: 0x0400026C RID: 620
		private PartyType carrierPartyField;

		// Token: 0x0400026D RID: 621
		private PartyType deliveryPartyField;

		// Token: 0x0400026E RID: 622
		private DespatchType despatchField;

		// Token: 0x0400026F RID: 623
		private DeliveryTermsType[] deliveryTermsField;

		// Token: 0x04000270 RID: 624
		private ShipmentType shipmentField;
	}
}

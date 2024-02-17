using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003E6 RID: 998
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ApplicableTransportMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class TransportMeansType
	{
		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x0000498F File Offset: 0x00002B8F
		// (set) Token: 0x060008D8 RID: 2264 RVA: 0x00004997 File Offset: 0x00002B97
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public JourneyIDType JourneyID
		{
			get
			{
				return this.journeyIDField;
			}
			set
			{
				this.journeyIDField = value;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x000049A0 File Offset: 0x00002BA0
		// (set) Token: 0x060008DA RID: 2266 RVA: 0x000049A8 File Offset: 0x00002BA8
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public RegistrationNationalityIDType RegistrationNationalityID
		{
			get
			{
				return this.registrationNationalityIDField;
			}
			set
			{
				this.registrationNationalityIDField = value;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x000049B1 File Offset: 0x00002BB1
		// (set) Token: 0x060008DC RID: 2268 RVA: 0x000049B9 File Offset: 0x00002BB9
		[XmlElement("RegistrationNationality", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public RegistrationNationalityType[] RegistrationNationality
		{
			get
			{
				return this.registrationNationalityField;
			}
			set
			{
				this.registrationNationalityField = value;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x000049C2 File Offset: 0x00002BC2
		// (set) Token: 0x060008DE RID: 2270 RVA: 0x000049CA File Offset: 0x00002BCA
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DirectionCodeType DirectionCode
		{
			get
			{
				return this.directionCodeField;
			}
			set
			{
				this.directionCodeField = value;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x000049D3 File Offset: 0x00002BD3
		// (set) Token: 0x060008E0 RID: 2272 RVA: 0x000049DB File Offset: 0x00002BDB
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TransportMeansTypeCodeType TransportMeansTypeCode
		{
			get
			{
				return this.transportMeansTypeCodeField;
			}
			set
			{
				this.transportMeansTypeCodeField = value;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060008E1 RID: 2273 RVA: 0x000049E4 File Offset: 0x00002BE4
		// (set) Token: 0x060008E2 RID: 2274 RVA: 0x000049EC File Offset: 0x00002BEC
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TradeServiceCodeType TradeServiceCode
		{
			get
			{
				return this.tradeServiceCodeField;
			}
			set
			{
				this.tradeServiceCodeField = value;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x000049F5 File Offset: 0x00002BF5
		// (set) Token: 0x060008E4 RID: 2276 RVA: 0x000049FD File Offset: 0x00002BFD
		public StowageType Stowage
		{
			get
			{
				return this.stowageField;
			}
			set
			{
				this.stowageField = value;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x00004A06 File Offset: 0x00002C06
		// (set) Token: 0x060008E6 RID: 2278 RVA: 0x00004A0E File Offset: 0x00002C0E
		public AirTransportType AirTransport
		{
			get
			{
				return this.airTransportField;
			}
			set
			{
				this.airTransportField = value;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x00004A17 File Offset: 0x00002C17
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x00004A1F File Offset: 0x00002C1F
		public RoadTransportType RoadTransport
		{
			get
			{
				return this.roadTransportField;
			}
			set
			{
				this.roadTransportField = value;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x00004A28 File Offset: 0x00002C28
		// (set) Token: 0x060008EA RID: 2282 RVA: 0x00004A30 File Offset: 0x00002C30
		public RailTransportType RailTransport
		{
			get
			{
				return this.railTransportField;
			}
			set
			{
				this.railTransportField = value;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x00004A39 File Offset: 0x00002C39
		// (set) Token: 0x060008EC RID: 2284 RVA: 0x00004A41 File Offset: 0x00002C41
		public MaritimeTransportType MaritimeTransport
		{
			get
			{
				return this.maritimeTransportField;
			}
			set
			{
				this.maritimeTransportField = value;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x00004A4A File Offset: 0x00002C4A
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x00004A52 File Offset: 0x00002C52
		public PartyType OwnerParty
		{
			get
			{
				return this.ownerPartyField;
			}
			set
			{
				this.ownerPartyField = value;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x00004A5B File Offset: 0x00002C5B
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x00004A63 File Offset: 0x00002C63
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

		// Token: 0x0400029D RID: 669
		private JourneyIDType journeyIDField;

		// Token: 0x0400029E RID: 670
		private RegistrationNationalityIDType registrationNationalityIDField;

		// Token: 0x0400029F RID: 671
		private RegistrationNationalityType[] registrationNationalityField;

		// Token: 0x040002A0 RID: 672
		private DirectionCodeType directionCodeField;

		// Token: 0x040002A1 RID: 673
		private TransportMeansTypeCodeType transportMeansTypeCodeField;

		// Token: 0x040002A2 RID: 674
		private TradeServiceCodeType tradeServiceCodeField;

		// Token: 0x040002A3 RID: 675
		private StowageType stowageField;

		// Token: 0x040002A4 RID: 676
		private AirTransportType airTransportField;

		// Token: 0x040002A5 RID: 677
		private RoadTransportType roadTransportField;

		// Token: 0x040002A6 RID: 678
		private RailTransportType railTransportField;

		// Token: 0x040002A7 RID: 679
		private MaritimeTransportType maritimeTransportField;

		// Token: 0x040002A8 RID: 680
		private PartyType ownerPartyField;

		// Token: 0x040002A9 RID: 681
		private DimensionType[] measurementDimensionField;
	}
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000337 RID: 823
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("Address", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class AddressType
	{
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x0000357B File Offset: 0x0000177B
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x00003583 File Offset: 0x00001783
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

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x0000358C File Offset: 0x0000178C
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x00003594 File Offset: 0x00001794
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PostboxType Postbox
		{
			get
			{
				return this.postboxField;
			}
			set
			{
				this.postboxField = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x0000359D File Offset: 0x0000179D
		// (set) Token: 0x060005D5 RID: 1493 RVA: 0x000035A5 File Offset: 0x000017A5
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public RoomType Room
		{
			get
			{
				return this.roomField;
			}
			set
			{
				this.roomField = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x000035AE File Offset: 0x000017AE
		// (set) Token: 0x060005D7 RID: 1495 RVA: 0x000035B6 File Offset: 0x000017B6
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public StreetNameType StreetName
		{
			get
			{
				return this.streetNameField;
			}
			set
			{
				this.streetNameField = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x000035BF File Offset: 0x000017BF
		// (set) Token: 0x060005D9 RID: 1497 RVA: 0x000035C7 File Offset: 0x000017C7
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public BlockNameType BlockName
		{
			get
			{
				return this.blockNameField;
			}
			set
			{
				this.blockNameField = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x000035D0 File Offset: 0x000017D0
		// (set) Token: 0x060005DB RID: 1499 RVA: 0x000035D8 File Offset: 0x000017D8
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public BuildingNameType BuildingName
		{
			get
			{
				return this.buildingNameField;
			}
			set
			{
				this.buildingNameField = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x000035E1 File Offset: 0x000017E1
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x000035E9 File Offset: 0x000017E9
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public BuildingNumberType BuildingNumber
		{
			get
			{
				return this.buildingNumberField;
			}
			set
			{
				this.buildingNumberField = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x000035F2 File Offset: 0x000017F2
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x000035FA File Offset: 0x000017FA
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CitySubdivisionNameType CitySubdivisionName
		{
			get
			{
				return this.citySubdivisionNameField;
			}
			set
			{
				this.citySubdivisionNameField = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x00003603 File Offset: 0x00001803
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x0000360B File Offset: 0x0000180B
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CityNameType CityName
		{
			get
			{
				return this.cityNameField;
			}
			set
			{
				this.cityNameField = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x00003614 File Offset: 0x00001814
		// (set) Token: 0x060005E3 RID: 1507 RVA: 0x0000361C File Offset: 0x0000181C
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PostalZoneType PostalZone
		{
			get
			{
				return this.postalZoneField;
			}
			set
			{
				this.postalZoneField = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x00003625 File Offset: 0x00001825
		// (set) Token: 0x060005E5 RID: 1509 RVA: 0x0000362D File Offset: 0x0000182D
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public RegionType Region
		{
			get
			{
				return this.regionField;
			}
			set
			{
				this.regionField = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x00003636 File Offset: 0x00001836
		// (set) Token: 0x060005E7 RID: 1511 RVA: 0x0000363E File Offset: 0x0000183E
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DistrictType District
		{
			get
			{
				return this.districtField;
			}
			set
			{
				this.districtField = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00003647 File Offset: 0x00001847
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x0000364F File Offset: 0x0000184F
		public CountryType Country
		{
			get
			{
				return this.countryField;
			}
			set
			{
				this.countryField = value;
			}
		}

		// Token: 0x04000171 RID: 369
		private IDType idField;

		// Token: 0x04000172 RID: 370
		private PostboxType postboxField;

		// Token: 0x04000173 RID: 371
		private RoomType roomField;

		// Token: 0x04000174 RID: 372
		private StreetNameType streetNameField;

		// Token: 0x04000175 RID: 373
		private BlockNameType blockNameField;

		// Token: 0x04000176 RID: 374
		private BuildingNameType buildingNameField;

		// Token: 0x04000177 RID: 375
		private BuildingNumberType buildingNumberField;

		// Token: 0x04000178 RID: 376
		private CitySubdivisionNameType citySubdivisionNameField;

		// Token: 0x04000179 RID: 377
		private CityNameType cityNameField;

		// Token: 0x0400017A RID: 378
		private PostalZoneType postalZoneField;

		// Token: 0x0400017B RID: 379
		private RegionType regionField;

		// Token: 0x0400017C RID: 380
		private DistrictType districtField;

		// Token: 0x0400017D RID: 381
		private CountryType countryField;
	}
}

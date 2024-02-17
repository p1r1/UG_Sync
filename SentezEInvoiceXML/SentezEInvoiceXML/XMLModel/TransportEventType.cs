using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003F7 RID: 1015
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("AcceptanceTransportEvent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class TransportEventType
	{
		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x00004E24 File Offset: 0x00003024
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x00004E2C File Offset: 0x0000302C
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentificationIDType IdentificationID
		{
			get
			{
				return this.identificationIDField;
			}
			set
			{
				this.identificationIDField = value;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x00004E35 File Offset: 0x00003035
		// (set) Token: 0x06000975 RID: 2421 RVA: 0x00004E3D File Offset: 0x0000303D
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public OccurrenceDateType OccurrenceDate
		{
			get
			{
				return this.occurrenceDateField;
			}
			set
			{
				this.occurrenceDateField = value;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x00004E46 File Offset: 0x00003046
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x00004E4E File Offset: 0x0000304E
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public OccurrenceTimeType OccurrenceTime
		{
			get
			{
				return this.occurrenceTimeField;
			}
			set
			{
				this.occurrenceTimeField = value;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x00004E57 File Offset: 0x00003057
		// (set) Token: 0x06000979 RID: 2425 RVA: 0x00004E5F File Offset: 0x0000305F
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TransportEventTypeCodeType TransportEventTypeCode
		{
			get
			{
				return this.transportEventTypeCodeField;
			}
			set
			{
				this.transportEventTypeCodeField = value;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x00004E68 File Offset: 0x00003068
		// (set) Token: 0x0600097B RID: 2427 RVA: 0x00004E70 File Offset: 0x00003070
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

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x00004E79 File Offset: 0x00003079
		// (set) Token: 0x0600097D RID: 2429 RVA: 0x00004E81 File Offset: 0x00003081
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CompletionIndicatorType CompletionIndicator
		{
			get
			{
				return this.completionIndicatorField;
			}
			set
			{
				this.completionIndicatorField = value;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x00004E8A File Offset: 0x0000308A
		// (set) Token: 0x0600097F RID: 2431 RVA: 0x00004E92 File Offset: 0x00003092
		public ShipmentType ReportedShipment
		{
			get
			{
				return this.reportedShipmentField;
			}
			set
			{
				this.reportedShipmentField = value;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x00004E9B File Offset: 0x0000309B
		// (set) Token: 0x06000981 RID: 2433 RVA: 0x00004EA3 File Offset: 0x000030A3
		[XmlElement("CurrentStatus")]
		public StatusType[] CurrentStatus
		{
			get
			{
				return this.currentStatusField;
			}
			set
			{
				this.currentStatusField = value;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x00004EAC File Offset: 0x000030AC
		// (set) Token: 0x06000983 RID: 2435 RVA: 0x00004EB4 File Offset: 0x000030B4
		[XmlElement("Contact")]
		public ContactType[] Contact
		{
			get
			{
				return this.contactField;
			}
			set
			{
				this.contactField = value;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x00004EBD File Offset: 0x000030BD
		// (set) Token: 0x06000985 RID: 2437 RVA: 0x00004EC5 File Offset: 0x000030C5
		public LocationType1 Location
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

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x00004ECE File Offset: 0x000030CE
		// (set) Token: 0x06000987 RID: 2439 RVA: 0x00004ED6 File Offset: 0x000030D6
		public SignatureType Signature
		{
			get
			{
				return this.signatureField;
			}
			set
			{
				this.signatureField = value;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x00004EDF File Offset: 0x000030DF
		// (set) Token: 0x06000989 RID: 2441 RVA: 0x00004EE7 File Offset: 0x000030E7
		[XmlElement("Period")]
		public PeriodType[] Period
		{
			get
			{
				return this.periodField;
			}
			set
			{
				this.periodField = value;
			}
		}

		// Token: 0x040002E2 RID: 738
		private IdentificationIDType identificationIDField;

		// Token: 0x040002E3 RID: 739
		private OccurrenceDateType occurrenceDateField;

		// Token: 0x040002E4 RID: 740
		private OccurrenceTimeType occurrenceTimeField;

		// Token: 0x040002E5 RID: 741
		private TransportEventTypeCodeType transportEventTypeCodeField;

		// Token: 0x040002E6 RID: 742
		private DescriptionType[] descriptionField;

		// Token: 0x040002E7 RID: 743
		private CompletionIndicatorType completionIndicatorField;

		// Token: 0x040002E8 RID: 744
		private ShipmentType reportedShipmentField;

		// Token: 0x040002E9 RID: 745
		private StatusType[] currentStatusField;

		// Token: 0x040002EA RID: 746
		private ContactType[] contactField;

		// Token: 0x040002EB RID: 747
		private LocationType1 locationField;

		// Token: 0x040002EC RID: 748
		private SignatureType signatureField;

		// Token: 0x040002ED RID: 749
		private PeriodType[] periodField;
	}
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003F0 RID: 1008
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("Pickup", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class PickupType
	{
		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x00004C6A File Offset: 0x00002E6A
		// (set) Token: 0x06000938 RID: 2360 RVA: 0x00004C72 File Offset: 0x00002E72
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

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x00004C7B File Offset: 0x00002E7B
		// (set) Token: 0x0600093A RID: 2362 RVA: 0x00004C83 File Offset: 0x00002E83
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ActualPickupDateType ActualPickupDate
		{
			get
			{
				return this.actualPickupDateField;
			}
			set
			{
				this.actualPickupDateField = value;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x00004C8C File Offset: 0x00002E8C
		// (set) Token: 0x0600093C RID: 2364 RVA: 0x00004C94 File Offset: 0x00002E94
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ActualPickupTimeType ActualPickupTime
		{
			get
			{
				return this.actualPickupTimeField;
			}
			set
			{
				this.actualPickupTimeField = value;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x00004C9D File Offset: 0x00002E9D
		// (set) Token: 0x0600093E RID: 2366 RVA: 0x00004CA5 File Offset: 0x00002EA5
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public EarliestPickupDateType EarliestPickupDate
		{
			get
			{
				return this.earliestPickupDateField;
			}
			set
			{
				this.earliestPickupDateField = value;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x00004CAE File Offset: 0x00002EAE
		// (set) Token: 0x06000940 RID: 2368 RVA: 0x00004CB6 File Offset: 0x00002EB6
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public EarliestPickupTimeType EarliestPickupTime
		{
			get
			{
				return this.earliestPickupTimeField;
			}
			set
			{
				this.earliestPickupTimeField = value;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x00004CBF File Offset: 0x00002EBF
		// (set) Token: 0x06000942 RID: 2370 RVA: 0x00004CC7 File Offset: 0x00002EC7
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LatestPickupDateType LatestPickupDate
		{
			get
			{
				return this.latestPickupDateField;
			}
			set
			{
				this.latestPickupDateField = value;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x00004CD0 File Offset: 0x00002ED0
		// (set) Token: 0x06000944 RID: 2372 RVA: 0x00004CD8 File Offset: 0x00002ED8
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LatestPickupTimeType LatestPickupTime
		{
			get
			{
				return this.latestPickupTimeField;
			}
			set
			{
				this.latestPickupTimeField = value;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x00004CE1 File Offset: 0x00002EE1
		// (set) Token: 0x06000946 RID: 2374 RVA: 0x00004CE9 File Offset: 0x00002EE9
		public LocationType1 PickupLocation
		{
			get
			{
				return this.pickupLocationField;
			}
			set
			{
				this.pickupLocationField = value;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x00004CF2 File Offset: 0x00002EF2
		// (set) Token: 0x06000948 RID: 2376 RVA: 0x00004CFA File Offset: 0x00002EFA
		public PartyType PickupParty
		{
			get
			{
				return this.pickupPartyField;
			}
			set
			{
				this.pickupPartyField = value;
			}
		}

		// Token: 0x040002C8 RID: 712
		private IDType idField;

		// Token: 0x040002C9 RID: 713
		private ActualPickupDateType actualPickupDateField;

		// Token: 0x040002CA RID: 714
		private ActualPickupTimeType actualPickupTimeField;

		// Token: 0x040002CB RID: 715
		private EarliestPickupDateType earliestPickupDateField;

		// Token: 0x040002CC RID: 716
		private EarliestPickupTimeType earliestPickupTimeField;

		// Token: 0x040002CD RID: 717
		private LatestPickupDateType latestPickupDateField;

		// Token: 0x040002CE RID: 718
		private LatestPickupTimeType latestPickupTimeField;

		// Token: 0x040002CF RID: 719
		private LocationType1 pickupLocationField;

		// Token: 0x040002D0 RID: 720
		private PartyType pickupPartyField;
	}
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200045B RID: 1115
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("Event", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class EventType
	{
		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x0600100A RID: 4106 RVA: 0x000082DE File Offset: 0x000064DE
		// (set) Token: 0x0600100B RID: 4107 RVA: 0x000082E6 File Offset: 0x000064E6
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

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x0600100C RID: 4108 RVA: 0x000082EF File Offset: 0x000064EF
		// (set) Token: 0x0600100D RID: 4109 RVA: 0x000082F7 File Offset: 0x000064F7
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

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x0600100E RID: 4110 RVA: 0x00008300 File Offset: 0x00006500
		// (set) Token: 0x0600100F RID: 4111 RVA: 0x00008308 File Offset: 0x00006508
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

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x00008311 File Offset: 0x00006511
		// (set) Token: 0x06001011 RID: 4113 RVA: 0x00008319 File Offset: 0x00006519
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TypeCodeType TypeCode
		{
			get
			{
				return this.typeCodeField;
			}
			set
			{
				this.typeCodeField = value;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06001012 RID: 4114 RVA: 0x00008322 File Offset: 0x00006522
		// (set) Token: 0x06001013 RID: 4115 RVA: 0x0000832A File Offset: 0x0000652A
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

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x00008333 File Offset: 0x00006533
		// (set) Token: 0x06001015 RID: 4117 RVA: 0x0000833B File Offset: 0x0000653B
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

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x00008344 File Offset: 0x00006544
		// (set) Token: 0x06001017 RID: 4119 RVA: 0x0000834C File Offset: 0x0000654C
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

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x00008355 File Offset: 0x00006555
		// (set) Token: 0x06001019 RID: 4121 RVA: 0x0000835D File Offset: 0x0000655D
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

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x0600101A RID: 4122 RVA: 0x00008366 File Offset: 0x00006566
		// (set) Token: 0x0600101B RID: 4123 RVA: 0x0000836E File Offset: 0x0000656E
		public LocationType1 OccurenceLocation
		{
			get
			{
				return this.occurenceLocationField;
			}
			set
			{
				this.occurenceLocationField = value;
			}
		}

		// Token: 0x040005FC RID: 1532
		private IdentificationIDType identificationIDField;

		// Token: 0x040005FD RID: 1533
		private OccurrenceDateType occurrenceDateField;

		// Token: 0x040005FE RID: 1534
		private OccurrenceTimeType occurrenceTimeField;

		// Token: 0x040005FF RID: 1535
		private TypeCodeType typeCodeField;

		// Token: 0x04000600 RID: 1536
		private DescriptionType[] descriptionField;

		// Token: 0x04000601 RID: 1537
		private CompletionIndicatorType completionIndicatorField;

		// Token: 0x04000602 RID: 1538
		private StatusType[] currentStatusField;

		// Token: 0x04000603 RID: 1539
		private ContactType[] contactField;

		// Token: 0x04000604 RID: 1540
		private LocationType1 occurenceLocationField;
	}
}

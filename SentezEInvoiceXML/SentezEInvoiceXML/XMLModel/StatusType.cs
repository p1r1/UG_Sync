using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003F8 RID: 1016
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("CurrentStatus", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class StatusType
	{
		// Token: 0x17000224 RID: 548
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x00004EF0 File Offset: 0x000030F0
		// (set) Token: 0x0600098C RID: 2444 RVA: 0x00004EF8 File Offset: 0x000030F8
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ConditionCodeType ConditionCode
		{
			get
			{
				return this.conditionCodeField;
			}
			set
			{
				this.conditionCodeField = value;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x00004F01 File Offset: 0x00003101
		// (set) Token: 0x0600098E RID: 2446 RVA: 0x00004F09 File Offset: 0x00003109
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ReferenceDateType ReferenceDate
		{
			get
			{
				return this.referenceDateField;
			}
			set
			{
				this.referenceDateField = value;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x00004F12 File Offset: 0x00003112
		// (set) Token: 0x06000990 RID: 2448 RVA: 0x00004F1A File Offset: 0x0000311A
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ReferenceTimeType ReferenceTime
		{
			get
			{
				return this.referenceTimeField;
			}
			set
			{
				this.referenceTimeField = value;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x00004F23 File Offset: 0x00003123
		// (set) Token: 0x06000992 RID: 2450 RVA: 0x00004F2B File Offset: 0x0000312B
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

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x00004F34 File Offset: 0x00003134
		// (set) Token: 0x06000994 RID: 2452 RVA: 0x00004F3C File Offset: 0x0000313C
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public StatusReasonCodeType StatusReasonCode
		{
			get
			{
				return this.statusReasonCodeField;
			}
			set
			{
				this.statusReasonCodeField = value;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x00004F45 File Offset: 0x00003145
		// (set) Token: 0x06000996 RID: 2454 RVA: 0x00004F4D File Offset: 0x0000314D
		[XmlElement("StatusReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public StatusReasonType[] StatusReason
		{
			get
			{
				return this.statusReasonField;
			}
			set
			{
				this.statusReasonField = value;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x00004F56 File Offset: 0x00003156
		// (set) Token: 0x06000998 RID: 2456 RVA: 0x00004F5E File Offset: 0x0000315E
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SequenceIDType SequenceID
		{
			get
			{
				return this.sequenceIDField;
			}
			set
			{
				this.sequenceIDField = value;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x00004F67 File Offset: 0x00003167
		// (set) Token: 0x0600099A RID: 2458 RVA: 0x00004F6F File Offset: 0x0000316F
		[XmlElement("Text", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType2[] Text
		{
			get
			{
				return this.textField;
			}
			set
			{
				this.textField = value;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x00004F78 File Offset: 0x00003178
		// (set) Token: 0x0600099C RID: 2460 RVA: 0x00004F80 File Offset: 0x00003180
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicationIndicatorType IndicationIndicator
		{
			get
			{
				return this.indicationIndicatorField;
			}
			set
			{
				this.indicationIndicatorField = value;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x00004F89 File Offset: 0x00003189
		// (set) Token: 0x0600099E RID: 2462 RVA: 0x00004F91 File Offset: 0x00003191
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PercentType1 Percent
		{
			get
			{
				return this.percentField;
			}
			set
			{
				this.percentField = value;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x00004F9A File Offset: 0x0000319A
		// (set) Token: 0x060009A0 RID: 2464 RVA: 0x00004FA2 File Offset: 0x000031A2
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ReliabilityPercentType ReliabilityPercent
		{
			get
			{
				return this.reliabilityPercentField;
			}
			set
			{
				this.reliabilityPercentField = value;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x00004FAB File Offset: 0x000031AB
		// (set) Token: 0x060009A2 RID: 2466 RVA: 0x00004FB3 File Offset: 0x000031B3
		[XmlElement("Condition")]
		public ConditionType1[] Condition
		{
			get
			{
				return this.conditionField;
			}
			set
			{
				this.conditionField = value;
			}
		}

		// Token: 0x040002EE RID: 750
		private ConditionCodeType conditionCodeField;

		// Token: 0x040002EF RID: 751
		private ReferenceDateType referenceDateField;

		// Token: 0x040002F0 RID: 752
		private ReferenceTimeType referenceTimeField;

		// Token: 0x040002F1 RID: 753
		private DescriptionType[] descriptionField;

		// Token: 0x040002F2 RID: 754
		private StatusReasonCodeType statusReasonCodeField;

		// Token: 0x040002F3 RID: 755
		private StatusReasonType[] statusReasonField;

		// Token: 0x040002F4 RID: 756
		private SequenceIDType sequenceIDField;

		// Token: 0x040002F5 RID: 757
		private TextType2[] textField;

		// Token: 0x040002F6 RID: 758
		private IndicationIndicatorType indicationIndicatorField;

		// Token: 0x040002F7 RID: 759
		private PercentType1 percentField;

		// Token: 0x040002F8 RID: 760
		private ReliabilityPercentType reliabilityPercentField;

		// Token: 0x040002F9 RID: 761
		private ConditionType1[] conditionField;
	}
}

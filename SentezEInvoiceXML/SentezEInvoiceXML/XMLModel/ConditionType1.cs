using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003F9 RID: 1017
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(TypeName = "ConditionType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("Condition", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ConditionType1
	{
		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x00004FBC File Offset: 0x000031BC
		// (set) Token: 0x060009A5 RID: 2469 RVA: 0x00004FC4 File Offset: 0x000031C4
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AttributeIDType AttributeID
		{
			get
			{
				return this.attributeIDField;
			}
			set
			{
				this.attributeIDField = value;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x00004FCD File Offset: 0x000031CD
		// (set) Token: 0x060009A7 RID: 2471 RVA: 0x00004FD5 File Offset: 0x000031D5
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MeasureType2 Measure
		{
			get
			{
				return this.measureField;
			}
			set
			{
				this.measureField = value;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x00004FDE File Offset: 0x000031DE
		// (set) Token: 0x060009A9 RID: 2473 RVA: 0x00004FE6 File Offset: 0x000031E6
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

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x00004FEF File Offset: 0x000031EF
		// (set) Token: 0x060009AB RID: 2475 RVA: 0x00004FF7 File Offset: 0x000031F7
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MinimumMeasureType MinimumMeasure
		{
			get
			{
				return this.minimumMeasureField;
			}
			set
			{
				this.minimumMeasureField = value;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x00005000 File Offset: 0x00003200
		// (set) Token: 0x060009AD RID: 2477 RVA: 0x00005008 File Offset: 0x00003208
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MaximumMeasureType MaximumMeasure
		{
			get
			{
				return this.maximumMeasureField;
			}
			set
			{
				this.maximumMeasureField = value;
			}
		}

		// Token: 0x040002FA RID: 762
		private AttributeIDType attributeIDField;

		// Token: 0x040002FB RID: 763
		private MeasureType2 measureField;

		// Token: 0x040002FC RID: 764
		private DescriptionType[] descriptionField;

		// Token: 0x040002FD RID: 765
		private MinimumMeasureType minimumMeasureField;

		// Token: 0x040002FE RID: 766
		private MaximumMeasureType maximumMeasureField;
	}
}

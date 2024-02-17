using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200045D RID: 1117
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("EventLineItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class EventLineItemType
	{
		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x000083AA File Offset: 0x000065AA
		// (set) Token: 0x06001025 RID: 4133 RVA: 0x000083B2 File Offset: 0x000065B2
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LineNumberNumericType LineNumberNumeric
		{
			get
			{
				return this.lineNumberNumericField;
			}
			set
			{
				this.lineNumberNumericField = value;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001026 RID: 4134 RVA: 0x000083BB File Offset: 0x000065BB
		// (set) Token: 0x06001027 RID: 4135 RVA: 0x000083C3 File Offset: 0x000065C3
		public LocationType1 ParticipatingLocationsLocation
		{
			get
			{
				return this.participatingLocationsLocationField;
			}
			set
			{
				this.participatingLocationsLocationField = value;
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x000083CC File Offset: 0x000065CC
		// (set) Token: 0x06001029 RID: 4137 RVA: 0x000083D4 File Offset: 0x000065D4
		[XmlElement("RetailPlannedImpact")]
		public RetailPlannedImpactType[] RetailPlannedImpact
		{
			get
			{
				return this.retailPlannedImpactField;
			}
			set
			{
				this.retailPlannedImpactField = value;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x0600102A RID: 4138 RVA: 0x000083DD File Offset: 0x000065DD
		// (set) Token: 0x0600102B RID: 4139 RVA: 0x000083E5 File Offset: 0x000065E5
		public ItemType SupplyItem
		{
			get
			{
				return this.supplyItemField;
			}
			set
			{
				this.supplyItemField = value;
			}
		}

		// Token: 0x04000608 RID: 1544
		private LineNumberNumericType lineNumberNumericField;

		// Token: 0x04000609 RID: 1545
		private LocationType1 participatingLocationsLocationField;

		// Token: 0x0400060A RID: 1546
		private RetailPlannedImpactType[] retailPlannedImpactField;

		// Token: 0x0400060B RID: 1547
		private ItemType supplyItemField;
	}
}

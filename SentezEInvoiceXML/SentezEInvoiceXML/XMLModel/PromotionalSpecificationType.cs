using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200047E RID: 1150
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("PromotionalSpecification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class PromotionalSpecificationType
	{
		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001207 RID: 4615 RVA: 0x0000929B File Offset: 0x0000749B
		// (set) Token: 0x06001208 RID: 4616 RVA: 0x000092A3 File Offset: 0x000074A3
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SpecificationIDType SpecificationID
		{
			get
			{
				return this.specificationIDField;
			}
			set
			{
				this.specificationIDField = value;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x000092AC File Offset: 0x000074AC
		// (set) Token: 0x0600120A RID: 4618 RVA: 0x000092B4 File Offset: 0x000074B4
		[XmlElement("PromotionalEventLineItem")]
		public PromotionalEventLineItemType[] PromotionalEventLineItem
		{
			get
			{
				return this.promotionalEventLineItemField;
			}
			set
			{
				this.promotionalEventLineItemField = value;
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x0600120B RID: 4619 RVA: 0x000092BD File Offset: 0x000074BD
		// (set) Token: 0x0600120C RID: 4620 RVA: 0x000092C5 File Offset: 0x000074C5
		[XmlElement("EventTactic")]
		public EventTacticType[] EventTactic
		{
			get
			{
				return this.eventTacticField;
			}
			set
			{
				this.eventTacticField = value;
			}
		}

		// Token: 0x040006E9 RID: 1769
		private SpecificationIDType specificationIDField;

		// Token: 0x040006EA RID: 1770
		private PromotionalEventLineItemType[] promotionalEventLineItemField;

		// Token: 0x040006EB RID: 1771
		private EventTacticType[] eventTacticField;
	}
}

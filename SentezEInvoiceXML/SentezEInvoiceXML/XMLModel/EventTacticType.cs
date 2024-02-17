using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200045F RID: 1119
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("EventTactic", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class EventTacticType
	{
		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001036 RID: 4150 RVA: 0x00008432 File Offset: 0x00006632
		// (set) Token: 0x06001037 RID: 4151 RVA: 0x0000843A File Offset: 0x0000663A
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CommentType Comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x00008443 File Offset: 0x00006643
		// (set) Token: 0x06001039 RID: 4153 RVA: 0x0000844B File Offset: 0x0000664B
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

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x00008454 File Offset: 0x00006654
		// (set) Token: 0x0600103B RID: 4155 RVA: 0x0000845C File Offset: 0x0000665C
		public EventTacticEnumerationType EventTacticEnumeration
		{
			get
			{
				return this.eventTacticEnumerationField;
			}
			set
			{
				this.eventTacticEnumerationField = value;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x00008465 File Offset: 0x00006665
		// (set) Token: 0x0600103D RID: 4157 RVA: 0x0000846D File Offset: 0x0000666D
		public PeriodType Period
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

		// Token: 0x04000610 RID: 1552
		private CommentType commentField;

		// Token: 0x04000611 RID: 1553
		private QuantityType2 quantityField;

		// Token: 0x04000612 RID: 1554
		private EventTacticEnumerationType eventTacticEnumerationField;

		// Token: 0x04000613 RID: 1555
		private PeriodType periodField;
	}
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200047A RID: 1146
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ProcessJustification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ProcessJustificationType
	{
		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x060011DB RID: 4571 RVA: 0x00009147 File Offset: 0x00007347
		// (set) Token: 0x060011DC RID: 4572 RVA: 0x0000914F File Offset: 0x0000734F
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PreviousCancellationReasonCodeType PreviousCancellationReasonCode
		{
			get
			{
				return this.previousCancellationReasonCodeField;
			}
			set
			{
				this.previousCancellationReasonCodeField = value;
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x060011DD RID: 4573 RVA: 0x00009158 File Offset: 0x00007358
		// (set) Token: 0x060011DE RID: 4574 RVA: 0x00009160 File Offset: 0x00007360
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ProcessReasonCodeType ProcessReasonCode
		{
			get
			{
				return this.processReasonCodeField;
			}
			set
			{
				this.processReasonCodeField = value;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x060011DF RID: 4575 RVA: 0x00009169 File Offset: 0x00007369
		// (set) Token: 0x060011E0 RID: 4576 RVA: 0x00009171 File Offset: 0x00007371
		[XmlElement("ProcessReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ProcessReasonType[] ProcessReason
		{
			get
			{
				return this.processReasonField;
			}
			set
			{
				this.processReasonField = value;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x060011E1 RID: 4577 RVA: 0x0000917A File Offset: 0x0000737A
		// (set) Token: 0x060011E2 RID: 4578 RVA: 0x00009182 File Offset: 0x00007382
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

		// Token: 0x040006D5 RID: 1749
		private PreviousCancellationReasonCodeType previousCancellationReasonCodeField;

		// Token: 0x040006D6 RID: 1750
		private ProcessReasonCodeType processReasonCodeField;

		// Token: 0x040006D7 RID: 1751
		private ProcessReasonType[] processReasonField;

		// Token: 0x040006D8 RID: 1752
		private DescriptionType[] descriptionField;
	}
}

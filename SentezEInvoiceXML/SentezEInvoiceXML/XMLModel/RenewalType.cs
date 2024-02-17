using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200042D RID: 1069
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("Renewal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class RenewalType
	{
		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x000067F9 File Offset: 0x000049F9
		// (set) Token: 0x06000CB3 RID: 3251 RVA: 0x00006801 File Offset: 0x00004A01
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AmountType2 Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x0000680A File Offset: 0x00004A0A
		// (set) Token: 0x06000CB5 RID: 3253 RVA: 0x00006812 File Offset: 0x00004A12
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

		// Token: 0x04000467 RID: 1127
		private AmountType2 amountField;

		// Token: 0x04000468 RID: 1128
		private PeriodType periodField;
	}
}

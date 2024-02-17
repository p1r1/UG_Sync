using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003E2 RID: 994
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("DeliveryTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class DeliveryTermsType
	{
		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x0000472B File Offset: 0x0000292B
		// (set) Token: 0x0600088C RID: 2188 RVA: 0x00004733 File Offset: 0x00002933
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

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x0000473C File Offset: 0x0000293C
		// (set) Token: 0x0600088E RID: 2190 RVA: 0x00004744 File Offset: 0x00002944
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SpecialTermsType SpecialTerms
		{
			get
			{
				return this.specialTermsField;
			}
			set
			{
				this.specialTermsField = value;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x0000474D File Offset: 0x0000294D
		// (set) Token: 0x06000890 RID: 2192 RVA: 0x00004755 File Offset: 0x00002955
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

		// Token: 0x04000279 RID: 633
		private IDType idField;

		// Token: 0x0400027A RID: 634
		private SpecialTermsType specialTermsField;

		// Token: 0x0400027B RID: 635
		private AmountType2 amountField;
	}
}

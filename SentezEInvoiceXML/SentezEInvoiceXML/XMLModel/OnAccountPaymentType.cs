using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000471 RID: 1137
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("MainOnAccountPayment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class OnAccountPaymentType
	{
		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001168 RID: 4456 RVA: 0x00008DC2 File Offset: 0x00006FC2
		// (set) Token: 0x06001169 RID: 4457 RVA: 0x00008DCA File Offset: 0x00006FCA
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public EstimatedConsumedQuantityType EstimatedConsumedQuantity
		{
			get
			{
				return this.estimatedConsumedQuantityField;
			}
			set
			{
				this.estimatedConsumedQuantityField = value;
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x0600116A RID: 4458 RVA: 0x00008DD3 File Offset: 0x00006FD3
		// (set) Token: 0x0600116B RID: 4459 RVA: 0x00008DDB File Offset: 0x00006FDB
		[XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NoteType[] Note
		{
			get
			{
				return this.noteField;
			}
			set
			{
				this.noteField = value;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x0600116C RID: 4460 RVA: 0x00008DE4 File Offset: 0x00006FE4
		// (set) Token: 0x0600116D RID: 4461 RVA: 0x00008DEC File Offset: 0x00006FEC
		[XmlElement("PaymentTerms")]
		public PaymentTermsType[] PaymentTerms
		{
			get
			{
				return this.paymentTermsField;
			}
			set
			{
				this.paymentTermsField = value;
			}
		}

		// Token: 0x040006A0 RID: 1696
		private EstimatedConsumedQuantityType estimatedConsumedQuantityField;

		// Token: 0x040006A1 RID: 1697
		private NoteType[] noteField;

		// Token: 0x040006A2 RID: 1698
		private PaymentTermsType[] paymentTermsField;
	}
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200044C RID: 1100
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("UnstructuredPrice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class UnstructuredPriceType
	{
		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000F11 RID: 3857 RVA: 0x00007B19 File Offset: 0x00005D19
		// (set) Token: 0x06000F12 RID: 3858 RVA: 0x00007B21 File Offset: 0x00005D21
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PriceAmountType PriceAmount
		{
			get
			{
				return this.priceAmountField;
			}
			set
			{
				this.priceAmountField = value;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000F13 RID: 3859 RVA: 0x00007B2A File Offset: 0x00005D2A
		// (set) Token: 0x06000F14 RID: 3860 RVA: 0x00007B32 File Offset: 0x00005D32
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TimeAmountType TimeAmount
		{
			get
			{
				return this.timeAmountField;
			}
			set
			{
				this.timeAmountField = value;
			}
		}

		// Token: 0x04000587 RID: 1415
		private PriceAmountType priceAmountField;

		// Token: 0x04000588 RID: 1416
		private TimeAmountType timeAmountField;
	}
}

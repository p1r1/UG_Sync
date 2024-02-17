using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003F4 RID: 1012
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("BillingReferenceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class BillingReferenceLineType
	{
		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x00004D58 File Offset: 0x00002F58
		// (set) Token: 0x06000958 RID: 2392 RVA: 0x00004D60 File Offset: 0x00002F60
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

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x00004D69 File Offset: 0x00002F69
		// (set) Token: 0x0600095A RID: 2394 RVA: 0x00004D71 File Offset: 0x00002F71
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

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x00004D7A File Offset: 0x00002F7A
		// (set) Token: 0x0600095C RID: 2396 RVA: 0x00004D82 File Offset: 0x00002F82
		[XmlElement("AllowanceCharge")]
		public AllowanceChargeType[] AllowanceCharge
		{
			get
			{
				return this.allowanceChargeField;
			}
			set
			{
				this.allowanceChargeField = value;
			}
		}

		// Token: 0x040002D6 RID: 726
		private IDType idField;

		// Token: 0x040002D7 RID: 727
		private AmountType2 amountField;

		// Token: 0x040002D8 RID: 728
		private AllowanceChargeType[] allowanceChargeField;
	}
}

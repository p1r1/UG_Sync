using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000027 RID: 39
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("AnticipatedMonetaryTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class MonetaryTotalType
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000215 RID: 533 RVA: 0x00002F54 File Offset: 0x00001154
		// (set) Token: 0x06000216 RID: 534 RVA: 0x00002F5C File Offset: 0x0000115C
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LineExtensionAmountType LineExtensionAmount
		{
			get
			{
				return this.lineExtensionAmountField;
			}
			set
			{
				this.lineExtensionAmountField = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00002F65 File Offset: 0x00001165
		// (set) Token: 0x06000218 RID: 536 RVA: 0x00002F6D File Offset: 0x0000116D
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TaxExclusiveAmountType TaxExclusiveAmount
		{
			get
			{
				return this.taxExclusiveAmountField;
			}
			set
			{
				this.taxExclusiveAmountField = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00002F76 File Offset: 0x00001176
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00002F7E File Offset: 0x0000117E
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TaxInclusiveAmountType TaxInclusiveAmount
		{
			get
			{
				return this.taxInclusiveAmountField;
			}
			set
			{
				this.taxInclusiveAmountField = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00002F87 File Offset: 0x00001187
		// (set) Token: 0x0600021C RID: 540 RVA: 0x00002F8F File Offset: 0x0000118F
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AllowanceTotalAmountType AllowanceTotalAmount
		{
			get
			{
				return this.allowanceTotalAmountField;
			}
			set
			{
				this.allowanceTotalAmountField = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00002F98 File Offset: 0x00001198
		// (set) Token: 0x0600021E RID: 542 RVA: 0x00002FA0 File Offset: 0x000011A0
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ChargeTotalAmountType ChargeTotalAmount
		{
			get
			{
				return this.chargeTotalAmountField;
			}
			set
			{
				this.chargeTotalAmountField = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00002FA9 File Offset: 0x000011A9
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00002FB1 File Offset: 0x000011B1
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PayableRoundingAmountType PayableRoundingAmount
		{
			get
			{
				return this.payableRoundingAmountField;
			}
			set
			{
				this.payableRoundingAmountField = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00002FBA File Offset: 0x000011BA
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00002FC2 File Offset: 0x000011C2
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PayableAmountType PayableAmount
		{
			get
			{
				return this.payableAmountField;
			}
			set
			{
				this.payableAmountField = value;
			}
		}

		// Token: 0x0400011C RID: 284
		private LineExtensionAmountType lineExtensionAmountField;

		// Token: 0x0400011D RID: 285
		private TaxExclusiveAmountType taxExclusiveAmountField;

		// Token: 0x0400011E RID: 286
		private TaxInclusiveAmountType taxInclusiveAmountField;

		// Token: 0x0400011F RID: 287
		private AllowanceTotalAmountType allowanceTotalAmountField;

		// Token: 0x04000120 RID: 288
		private ChargeTotalAmountType chargeTotalAmountField;

		// Token: 0x04000121 RID: 289
		private PayableRoundingAmountType payableRoundingAmountField;

		// Token: 0x04000122 RID: 290
		private PayableAmountType payableAmountField;
	}
}

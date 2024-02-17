using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000431 RID: 1073
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(TypeName = "DutyType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("CallDuty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class DutyType1
	{
		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x00006B07 File Offset: 0x00004D07
		// (set) Token: 0x06000D13 RID: 3347 RVA: 0x00006B0F File Offset: 0x00004D0F
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

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000D14 RID: 3348 RVA: 0x00006B18 File Offset: 0x00004D18
		// (set) Token: 0x06000D15 RID: 3349 RVA: 0x00006B20 File Offset: 0x00004D20
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DutyType Duty
		{
			get
			{
				return this.dutyField;
			}
			set
			{
				this.dutyField = value;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x00006B29 File Offset: 0x00004D29
		// (set) Token: 0x06000D17 RID: 3351 RVA: 0x00006B31 File Offset: 0x00004D31
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DutyCodeType DutyCode
		{
			get
			{
				return this.dutyCodeField;
			}
			set
			{
				this.dutyCodeField = value;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x00006B3A File Offset: 0x00004D3A
		// (set) Token: 0x06000D19 RID: 3353 RVA: 0x00006B42 File Offset: 0x00004D42
		public TaxCategoryType TaxCategory
		{
			get
			{
				return this.taxCategoryField;
			}
			set
			{
				this.taxCategoryField = value;
			}
		}

		// Token: 0x04000495 RID: 1173
		private AmountType2 amountField;

		// Token: 0x04000496 RID: 1174
		private DutyType dutyField;

		// Token: 0x04000497 RID: 1175
		private DutyCodeType dutyCodeField;

		// Token: 0x04000498 RID: 1176
		private TaxCategoryType taxCategoryField;
	}
}

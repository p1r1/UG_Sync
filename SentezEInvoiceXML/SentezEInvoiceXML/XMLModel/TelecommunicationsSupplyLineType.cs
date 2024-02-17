using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000447 RID: 1095
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("TelecommunicationsSupplyLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class TelecommunicationsSupplyLineType
	{
		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000E82 RID: 3714 RVA: 0x00007684 File Offset: 0x00005884
		// (set) Token: 0x06000E83 RID: 3715 RVA: 0x0000768C File Offset: 0x0000588C
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

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x00007695 File Offset: 0x00005895
		// (set) Token: 0x06000E85 RID: 3717 RVA: 0x0000769D File Offset: 0x0000589D
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PhoneNumberType PhoneNumber
		{
			get
			{
				return this.phoneNumberField;
			}
			set
			{
				this.phoneNumberField = value;
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x000076A6 File Offset: 0x000058A6
		// (set) Token: 0x06000E87 RID: 3719 RVA: 0x000076AE File Offset: 0x000058AE
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

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x000076B7 File Offset: 0x000058B7
		// (set) Token: 0x06000E89 RID: 3721 RVA: 0x000076BF File Offset: 0x000058BF
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

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x000076C8 File Offset: 0x000058C8
		// (set) Token: 0x06000E8B RID: 3723 RVA: 0x000076D0 File Offset: 0x000058D0
		[XmlElement("ExchangeRate")]
		public ExchangeRateType[] ExchangeRate
		{
			get
			{
				return this.exchangeRateField;
			}
			set
			{
				this.exchangeRateField = value;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x000076D9 File Offset: 0x000058D9
		// (set) Token: 0x06000E8D RID: 3725 RVA: 0x000076E1 File Offset: 0x000058E1
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

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000E8E RID: 3726 RVA: 0x000076EA File Offset: 0x000058EA
		// (set) Token: 0x06000E8F RID: 3727 RVA: 0x000076F2 File Offset: 0x000058F2
		[XmlElement("TaxTotal")]
		public TaxTotalType[] TaxTotal
		{
			get
			{
				return this.taxTotalField;
			}
			set
			{
				this.taxTotalField = value;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x000076FB File Offset: 0x000058FB
		// (set) Token: 0x06000E91 RID: 3729 RVA: 0x00007703 File Offset: 0x00005903
		[XmlElement("TelecommunicationsService")]
		public TelecommunicationsServiceType[] TelecommunicationsService
		{
			get
			{
				return this.telecommunicationsServiceField;
			}
			set
			{
				this.telecommunicationsServiceField = value;
			}
		}

		// Token: 0x04000542 RID: 1346
		private IDType idField;

		// Token: 0x04000543 RID: 1347
		private PhoneNumberType phoneNumberField;

		// Token: 0x04000544 RID: 1348
		private DescriptionType[] descriptionField;

		// Token: 0x04000545 RID: 1349
		private LineExtensionAmountType lineExtensionAmountField;

		// Token: 0x04000546 RID: 1350
		private ExchangeRateType[] exchangeRateField;

		// Token: 0x04000547 RID: 1351
		private AllowanceChargeType[] allowanceChargeField;

		// Token: 0x04000548 RID: 1352
		private TaxTotalType[] taxTotalField;

		// Token: 0x04000549 RID: 1353
		private TelecommunicationsServiceType[] telecommunicationsServiceField;
	}
}

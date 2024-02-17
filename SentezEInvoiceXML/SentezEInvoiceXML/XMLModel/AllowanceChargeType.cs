using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003DB RID: 987
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class AllowanceChargeType
	{
		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x00004362 File Offset: 0x00002562
		// (set) Token: 0x06000813 RID: 2067 RVA: 0x0000436A File Offset: 0x0000256A
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ChargeIndicatorType ChargeIndicator
		{
			get
			{
				return this.chargeIndicatorField;
			}
			set
			{
				this.chargeIndicatorField = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x00004373 File Offset: 0x00002573
		// (set) Token: 0x06000815 RID: 2069 RVA: 0x0000437B File Offset: 0x0000257B
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AllowanceChargeReasonType AllowanceChargeReason
		{
			get
			{
				return this.allowanceChargeReasonField;
			}
			set
			{
				this.allowanceChargeReasonField = value;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x00004384 File Offset: 0x00002584
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x0000438C File Offset: 0x0000258C
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MultiplierFactorNumericType MultiplierFactorNumeric
		{
			get
			{
				return this.multiplierFactorNumericField;
			}
			set
			{
				this.multiplierFactorNumericField = value;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x00004395 File Offset: 0x00002595
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x0000439D File Offset: 0x0000259D
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SequenceNumericType SequenceNumeric
		{
			get
			{
				return this.sequenceNumericField;
			}
			set
			{
				this.sequenceNumericField = value;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x000043A6 File Offset: 0x000025A6
		// (set) Token: 0x0600081B RID: 2075 RVA: 0x000043AE File Offset: 0x000025AE
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

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600081C RID: 2076 RVA: 0x000043B7 File Offset: 0x000025B7
		// (set) Token: 0x0600081D RID: 2077 RVA: 0x000043BF File Offset: 0x000025BF
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public BaseAmountType BaseAmount
		{
			get
			{
				return this.baseAmountField;
			}
			set
			{
				this.baseAmountField = value;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x000043C8 File Offset: 0x000025C8
		// (set) Token: 0x0600081F RID: 2079 RVA: 0x000043D0 File Offset: 0x000025D0
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PerUnitAmountType PerUnitAmount
		{
			get
			{
				return this.perUnitAmountField;
			}
			set
			{
				this.perUnitAmountField = value;
			}
		}

		// Token: 0x04000240 RID: 576
		private ChargeIndicatorType chargeIndicatorField;

		// Token: 0x04000241 RID: 577
		private AllowanceChargeReasonType allowanceChargeReasonField;

		// Token: 0x04000242 RID: 578
		private MultiplierFactorNumericType multiplierFactorNumericField;

		// Token: 0x04000243 RID: 579
		private SequenceNumericType sequenceNumericField;

		// Token: 0x04000244 RID: 580
		private AmountType2 amountField;

		// Token: 0x04000245 RID: 581
		private BaseAmountType baseAmountField;

		// Token: 0x04000246 RID: 582
		private PerUnitAmountType perUnitAmountField;
	}
}

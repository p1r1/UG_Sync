using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200041D RID: 1053
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("FinalFinancialGuarantee", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class FinancialGuaranteeType
	{
		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x00006089 File Offset: 0x00004289
		// (set) Token: 0x06000BC3 RID: 3011 RVA: 0x00006091 File Offset: 0x00004291
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public GuaranteeTypeCodeType GuaranteeTypeCode
		{
			get
			{
				return this.guaranteeTypeCodeField;
			}
			set
			{
				this.guaranteeTypeCodeField = value;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x0000609A File Offset: 0x0000429A
		// (set) Token: 0x06000BC5 RID: 3013 RVA: 0x000060A2 File Offset: 0x000042A2
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

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x000060AB File Offset: 0x000042AB
		// (set) Token: 0x06000BC7 RID: 3015 RVA: 0x000060B3 File Offset: 0x000042B3
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LiabilityAmountType LiabilityAmount
		{
			get
			{
				return this.liabilityAmountField;
			}
			set
			{
				this.liabilityAmountField = value;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x000060BC File Offset: 0x000042BC
		// (set) Token: 0x06000BC9 RID: 3017 RVA: 0x000060C4 File Offset: 0x000042C4
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AmountRateType AmountRate
		{
			get
			{
				return this.amountRateField;
			}
			set
			{
				this.amountRateField = value;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x000060CD File Offset: 0x000042CD
		// (set) Token: 0x06000BCB RID: 3019 RVA: 0x000060D5 File Offset: 0x000042D5
		public PeriodType ConstitutionPeriod
		{
			get
			{
				return this.constitutionPeriodField;
			}
			set
			{
				this.constitutionPeriodField = value;
			}
		}

		// Token: 0x040003F7 RID: 1015
		private GuaranteeTypeCodeType guaranteeTypeCodeField;

		// Token: 0x040003F8 RID: 1016
		private DescriptionType[] descriptionField;

		// Token: 0x040003F9 RID: 1017
		private LiabilityAmountType liabilityAmountField;

		// Token: 0x040003FA RID: 1018
		private AmountRateType amountRateField;

		// Token: 0x040003FB RID: 1019
		private PeriodType constitutionPeriodField;
	}
}

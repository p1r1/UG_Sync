using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000448 RID: 1096
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("TelecommunicationsService", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class TelecommunicationsServiceType
	{
		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000E93 RID: 3731 RVA: 0x0000770C File Offset: 0x0000590C
		// (set) Token: 0x06000E94 RID: 3732 RVA: 0x00007714 File Offset: 0x00005914
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

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000E95 RID: 3733 RVA: 0x0000771D File Offset: 0x0000591D
		// (set) Token: 0x06000E96 RID: 3734 RVA: 0x00007725 File Offset: 0x00005925
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CallDateType CallDate
		{
			get
			{
				return this.callDateField;
			}
			set
			{
				this.callDateField = value;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000E97 RID: 3735 RVA: 0x0000772E File Offset: 0x0000592E
		// (set) Token: 0x06000E98 RID: 3736 RVA: 0x00007736 File Offset: 0x00005936
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CallTimeType CallTime
		{
			get
			{
				return this.callTimeField;
			}
			set
			{
				this.callTimeField = value;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x0000773F File Offset: 0x0000593F
		// (set) Token: 0x06000E9A RID: 3738 RVA: 0x00007747 File Offset: 0x00005947
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ServiceNumberCalledType ServiceNumberCalled
		{
			get
			{
				return this.serviceNumberCalledField;
			}
			set
			{
				this.serviceNumberCalledField = value;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000E9B RID: 3739 RVA: 0x00007750 File Offset: 0x00005950
		// (set) Token: 0x06000E9C RID: 3740 RVA: 0x00007758 File Offset: 0x00005958
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TelecommunicationsServiceCategoryType TelecommunicationsServiceCategory
		{
			get
			{
				return this.telecommunicationsServiceCategoryField;
			}
			set
			{
				this.telecommunicationsServiceCategoryField = value;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000E9D RID: 3741 RVA: 0x00007761 File Offset: 0x00005961
		// (set) Token: 0x06000E9E RID: 3742 RVA: 0x00007769 File Offset: 0x00005969
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TelecommunicationsServiceCategoryCodeType TelecommunicationsServiceCategoryCode
		{
			get
			{
				return this.telecommunicationsServiceCategoryCodeField;
			}
			set
			{
				this.telecommunicationsServiceCategoryCodeField = value;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000E9F RID: 3743 RVA: 0x00007772 File Offset: 0x00005972
		// (set) Token: 0x06000EA0 RID: 3744 RVA: 0x0000777A File Offset: 0x0000597A
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MovieTitleType MovieTitle
		{
			get
			{
				return this.movieTitleField;
			}
			set
			{
				this.movieTitleField = value;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x00007783 File Offset: 0x00005983
		// (set) Token: 0x06000EA2 RID: 3746 RVA: 0x0000778B File Offset: 0x0000598B
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public RoamingPartnerNameType RoamingPartnerName
		{
			get
			{
				return this.roamingPartnerNameField;
			}
			set
			{
				this.roamingPartnerNameField = value;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x00007794 File Offset: 0x00005994
		// (set) Token: 0x06000EA4 RID: 3748 RVA: 0x0000779C File Offset: 0x0000599C
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PayPerViewType PayPerView
		{
			get
			{
				return this.payPerViewField;
			}
			set
			{
				this.payPerViewField = value;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x000077A5 File Offset: 0x000059A5
		// (set) Token: 0x06000EA6 RID: 3750 RVA: 0x000077AD File Offset: 0x000059AD
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType2 Quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x000077B6 File Offset: 0x000059B6
		// (set) Token: 0x06000EA8 RID: 3752 RVA: 0x000077BE File Offset: 0x000059BE
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TelecommunicationsServiceCallType TelecommunicationsServiceCall
		{
			get
			{
				return this.telecommunicationsServiceCallField;
			}
			set
			{
				this.telecommunicationsServiceCallField = value;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x000077C7 File Offset: 0x000059C7
		// (set) Token: 0x06000EAA RID: 3754 RVA: 0x000077CF File Offset: 0x000059CF
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TelecommunicationsServiceCallCodeType TelecommunicationsServiceCallCode
		{
			get
			{
				return this.telecommunicationsServiceCallCodeField;
			}
			set
			{
				this.telecommunicationsServiceCallCodeField = value;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x000077D8 File Offset: 0x000059D8
		// (set) Token: 0x06000EAC RID: 3756 RVA: 0x000077E0 File Offset: 0x000059E0
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CallBaseAmountType CallBaseAmount
		{
			get
			{
				return this.callBaseAmountField;
			}
			set
			{
				this.callBaseAmountField = value;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x000077E9 File Offset: 0x000059E9
		// (set) Token: 0x06000EAE RID: 3758 RVA: 0x000077F1 File Offset: 0x000059F1
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CallExtensionAmountType CallExtensionAmount
		{
			get
			{
				return this.callExtensionAmountField;
			}
			set
			{
				this.callExtensionAmountField = value;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x000077FA File Offset: 0x000059FA
		// (set) Token: 0x06000EB0 RID: 3760 RVA: 0x00007802 File Offset: 0x00005A02
		public PriceType Price
		{
			get
			{
				return this.priceField;
			}
			set
			{
				this.priceField = value;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x0000780B File Offset: 0x00005A0B
		// (set) Token: 0x06000EB2 RID: 3762 RVA: 0x00007813 File Offset: 0x00005A13
		public CountryType Country
		{
			get
			{
				return this.countryField;
			}
			set
			{
				this.countryField = value;
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x0000781C File Offset: 0x00005A1C
		// (set) Token: 0x06000EB4 RID: 3764 RVA: 0x00007824 File Offset: 0x00005A24
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

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x0000782D File Offset: 0x00005A2D
		// (set) Token: 0x06000EB6 RID: 3766 RVA: 0x00007835 File Offset: 0x00005A35
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

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x0000783E File Offset: 0x00005A3E
		// (set) Token: 0x06000EB8 RID: 3768 RVA: 0x00007846 File Offset: 0x00005A46
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

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x0000784F File Offset: 0x00005A4F
		// (set) Token: 0x06000EBA RID: 3770 RVA: 0x00007857 File Offset: 0x00005A57
		[XmlElement("CallDuty")]
		public DutyType1[] CallDuty
		{
			get
			{
				return this.callDutyField;
			}
			set
			{
				this.callDutyField = value;
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000EBB RID: 3771 RVA: 0x00007860 File Offset: 0x00005A60
		// (set) Token: 0x06000EBC RID: 3772 RVA: 0x00007868 File Offset: 0x00005A68
		[XmlElement("TimeDuty")]
		public DutyType1[] TimeDuty
		{
			get
			{
				return this.timeDutyField;
			}
			set
			{
				this.timeDutyField = value;
			}
		}

		// Token: 0x0400054A RID: 1354
		private IDType idField;

		// Token: 0x0400054B RID: 1355
		private CallDateType callDateField;

		// Token: 0x0400054C RID: 1356
		private CallTimeType callTimeField;

		// Token: 0x0400054D RID: 1357
		private ServiceNumberCalledType serviceNumberCalledField;

		// Token: 0x0400054E RID: 1358
		private TelecommunicationsServiceCategoryType telecommunicationsServiceCategoryField;

		// Token: 0x0400054F RID: 1359
		private TelecommunicationsServiceCategoryCodeType telecommunicationsServiceCategoryCodeField;

		// Token: 0x04000550 RID: 1360
		private MovieTitleType movieTitleField;

		// Token: 0x04000551 RID: 1361
		private RoamingPartnerNameType roamingPartnerNameField;

		// Token: 0x04000552 RID: 1362
		private PayPerViewType payPerViewField;

		// Token: 0x04000553 RID: 1363
		private QuantityType2 quantityField;

		// Token: 0x04000554 RID: 1364
		private TelecommunicationsServiceCallType telecommunicationsServiceCallField;

		// Token: 0x04000555 RID: 1365
		private TelecommunicationsServiceCallCodeType telecommunicationsServiceCallCodeField;

		// Token: 0x04000556 RID: 1366
		private CallBaseAmountType callBaseAmountField;

		// Token: 0x04000557 RID: 1367
		private CallExtensionAmountType callExtensionAmountField;

		// Token: 0x04000558 RID: 1368
		private PriceType priceField;

		// Token: 0x04000559 RID: 1369
		private CountryType countryField;

		// Token: 0x0400055A RID: 1370
		private ExchangeRateType[] exchangeRateField;

		// Token: 0x0400055B RID: 1371
		private AllowanceChargeType[] allowanceChargeField;

		// Token: 0x0400055C RID: 1372
		private TaxTotalType[] taxTotalField;

		// Token: 0x0400055D RID: 1373
		private DutyType1[] callDutyField;

		// Token: 0x0400055E RID: 1374
		private DutyType1[] timeDutyField;
	}
}

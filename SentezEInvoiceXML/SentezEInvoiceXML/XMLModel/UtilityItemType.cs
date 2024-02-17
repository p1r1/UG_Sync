using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200044A RID: 1098
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("UtilityItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class UtilityItemType
	{
		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x0000792C File Offset: 0x00005B2C
		// (set) Token: 0x06000ED6 RID: 3798 RVA: 0x00007934 File Offset: 0x00005B34
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

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x0000793D File Offset: 0x00005B3D
		// (set) Token: 0x06000ED8 RID: 3800 RVA: 0x00007945 File Offset: 0x00005B45
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SubscriberIDType SubscriberID
		{
			get
			{
				return this.subscriberIDField;
			}
			set
			{
				this.subscriberIDField = value;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x0000794E File Offset: 0x00005B4E
		// (set) Token: 0x06000EDA RID: 3802 RVA: 0x00007956 File Offset: 0x00005B56
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SubscriberTypeType SubscriberType
		{
			get
			{
				return this.subscriberTypeField;
			}
			set
			{
				this.subscriberTypeField = value;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000EDB RID: 3803 RVA: 0x0000795F File Offset: 0x00005B5F
		// (set) Token: 0x06000EDC RID: 3804 RVA: 0x00007967 File Offset: 0x00005B67
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SubscriberTypeCodeType SubscriberTypeCode
		{
			get
			{
				return this.subscriberTypeCodeField;
			}
			set
			{
				this.subscriberTypeCodeField = value;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000EDD RID: 3805 RVA: 0x00007970 File Offset: 0x00005B70
		// (set) Token: 0x06000EDE RID: 3806 RVA: 0x00007978 File Offset: 0x00005B78
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

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000EDF RID: 3807 RVA: 0x00007981 File Offset: 0x00005B81
		// (set) Token: 0x06000EE0 RID: 3808 RVA: 0x00007989 File Offset: 0x00005B89
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PackQuantityType PackQuantity
		{
			get
			{
				return this.packQuantityField;
			}
			set
			{
				this.packQuantityField = value;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000EE1 RID: 3809 RVA: 0x00007992 File Offset: 0x00005B92
		// (set) Token: 0x06000EE2 RID: 3810 RVA: 0x0000799A File Offset: 0x00005B9A
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PackSizeNumericType PackSizeNumeric
		{
			get
			{
				return this.packSizeNumericField;
			}
			set
			{
				this.packSizeNumericField = value;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000EE3 RID: 3811 RVA: 0x000079A3 File Offset: 0x00005BA3
		// (set) Token: 0x06000EE4 RID: 3812 RVA: 0x000079AB File Offset: 0x00005BAB
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ConsumptionTypeType ConsumptionType
		{
			get
			{
				return this.consumptionTypeField;
			}
			set
			{
				this.consumptionTypeField = value;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x000079B4 File Offset: 0x00005BB4
		// (set) Token: 0x06000EE6 RID: 3814 RVA: 0x000079BC File Offset: 0x00005BBC
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ConsumptionTypeCodeType ConsumptionTypeCode
		{
			get
			{
				return this.consumptionTypeCodeField;
			}
			set
			{
				this.consumptionTypeCodeField = value;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x000079C5 File Offset: 0x00005BC5
		// (set) Token: 0x06000EE8 RID: 3816 RVA: 0x000079CD File Offset: 0x00005BCD
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CurrentChargeTypeType CurrentChargeType
		{
			get
			{
				return this.currentChargeTypeField;
			}
			set
			{
				this.currentChargeTypeField = value;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x000079D6 File Offset: 0x00005BD6
		// (set) Token: 0x06000EEA RID: 3818 RVA: 0x000079DE File Offset: 0x00005BDE
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CurrentChargeTypeCodeType CurrentChargeTypeCode
		{
			get
			{
				return this.currentChargeTypeCodeField;
			}
			set
			{
				this.currentChargeTypeCodeField = value;
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x000079E7 File Offset: 0x00005BE7
		// (set) Token: 0x06000EEC RID: 3820 RVA: 0x000079EF File Offset: 0x00005BEF
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public OneTimeChargeTypeType OneTimeChargeType
		{
			get
			{
				return this.oneTimeChargeTypeField;
			}
			set
			{
				this.oneTimeChargeTypeField = value;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000EED RID: 3821 RVA: 0x000079F8 File Offset: 0x00005BF8
		// (set) Token: 0x06000EEE RID: 3822 RVA: 0x00007A00 File Offset: 0x00005C00
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public OneTimeChargeTypeCodeType OneTimeChargeTypeCode
		{
			get
			{
				return this.oneTimeChargeTypeCodeField;
			}
			set
			{
				this.oneTimeChargeTypeCodeField = value;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000EEF RID: 3823 RVA: 0x00007A09 File Offset: 0x00005C09
		// (set) Token: 0x06000EF0 RID: 3824 RVA: 0x00007A11 File Offset: 0x00005C11
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

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000EF1 RID: 3825 RVA: 0x00007A1A File Offset: 0x00005C1A
		// (set) Token: 0x06000EF2 RID: 3826 RVA: 0x00007A22 File Offset: 0x00005C22
		public ContractType Contract
		{
			get
			{
				return this.contractField;
			}
			set
			{
				this.contractField = value;
			}
		}

		// Token: 0x0400056A RID: 1386
		private IDType idField;

		// Token: 0x0400056B RID: 1387
		private SubscriberIDType subscriberIDField;

		// Token: 0x0400056C RID: 1388
		private SubscriberTypeType subscriberTypeField;

		// Token: 0x0400056D RID: 1389
		private SubscriberTypeCodeType subscriberTypeCodeField;

		// Token: 0x0400056E RID: 1390
		private DescriptionType[] descriptionField;

		// Token: 0x0400056F RID: 1391
		private PackQuantityType packQuantityField;

		// Token: 0x04000570 RID: 1392
		private PackSizeNumericType packSizeNumericField;

		// Token: 0x04000571 RID: 1393
		private ConsumptionTypeType consumptionTypeField;

		// Token: 0x04000572 RID: 1394
		private ConsumptionTypeCodeType consumptionTypeCodeField;

		// Token: 0x04000573 RID: 1395
		private CurrentChargeTypeType currentChargeTypeField;

		// Token: 0x04000574 RID: 1396
		private CurrentChargeTypeCodeType currentChargeTypeCodeField;

		// Token: 0x04000575 RID: 1397
		private OneTimeChargeTypeType oneTimeChargeTypeField;

		// Token: 0x04000576 RID: 1398
		private OneTimeChargeTypeCodeType oneTimeChargeTypeCodeField;

		// Token: 0x04000577 RID: 1399
		private TaxCategoryType taxCategoryField;

		// Token: 0x04000578 RID: 1400
		private ContractType contractField;
	}
}

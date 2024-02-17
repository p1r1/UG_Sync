using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000412 RID: 1042
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ItemLocationQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ItemLocationQuantityType
	{
		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x00005A4B File Offset: 0x00003C4B
		// (set) Token: 0x06000AFC RID: 2812 RVA: 0x00005A53 File Offset: 0x00003C53
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LeadTimeMeasureType LeadTimeMeasure
		{
			get
			{
				return this.leadTimeMeasureField;
			}
			set
			{
				this.leadTimeMeasureField = value;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x00005A5C File Offset: 0x00003C5C
		// (set) Token: 0x06000AFE RID: 2814 RVA: 0x00005A64 File Offset: 0x00003C64
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MinimumQuantityType MinimumQuantity
		{
			get
			{
				return this.minimumQuantityField;
			}
			set
			{
				this.minimumQuantityField = value;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x00005A6D File Offset: 0x00003C6D
		// (set) Token: 0x06000B00 RID: 2816 RVA: 0x00005A75 File Offset: 0x00003C75
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MaximumQuantityType MaximumQuantity
		{
			get
			{
				return this.maximumQuantityField;
			}
			set
			{
				this.maximumQuantityField = value;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x00005A7E File Offset: 0x00003C7E
		// (set) Token: 0x06000B02 RID: 2818 RVA: 0x00005A86 File Offset: 0x00003C86
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public HazardousRiskIndicatorType HazardousRiskIndicator
		{
			get
			{
				return this.hazardousRiskIndicatorField;
			}
			set
			{
				this.hazardousRiskIndicatorField = value;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x00005A8F File Offset: 0x00003C8F
		// (set) Token: 0x06000B04 RID: 2820 RVA: 0x00005A97 File Offset: 0x00003C97
		[XmlElement("TradingRestrictions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TradingRestrictionsType[] TradingRestrictions
		{
			get
			{
				return this.tradingRestrictionsField;
			}
			set
			{
				this.tradingRestrictionsField = value;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x00005AA0 File Offset: 0x00003CA0
		// (set) Token: 0x06000B06 RID: 2822 RVA: 0x00005AA8 File Offset: 0x00003CA8
		[XmlElement("ApplicableTerritoryAddress")]
		public AddressType[] ApplicableTerritoryAddress
		{
			get
			{
				return this.applicableTerritoryAddressField;
			}
			set
			{
				this.applicableTerritoryAddressField = value;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x00005AB1 File Offset: 0x00003CB1
		// (set) Token: 0x06000B08 RID: 2824 RVA: 0x00005AB9 File Offset: 0x00003CB9
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

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x00005AC2 File Offset: 0x00003CC2
		// (set) Token: 0x06000B0A RID: 2826 RVA: 0x00005ACA File Offset: 0x00003CCA
		[XmlElement("DeliveryUnit")]
		public DeliveryUnitType[] DeliveryUnit
		{
			get
			{
				return this.deliveryUnitField;
			}
			set
			{
				this.deliveryUnitField = value;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x00005AD3 File Offset: 0x00003CD3
		// (set) Token: 0x06000B0C RID: 2828 RVA: 0x00005ADB File Offset: 0x00003CDB
		[XmlElement("ApplicableTaxCategory")]
		public TaxCategoryType[] ApplicableTaxCategory
		{
			get
			{
				return this.applicableTaxCategoryField;
			}
			set
			{
				this.applicableTaxCategoryField = value;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x00005AE4 File Offset: 0x00003CE4
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x00005AEC File Offset: 0x00003CEC
		public PackageType Package
		{
			get
			{
				return this.packageField;
			}
			set
			{
				this.packageField = value;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x00005AF5 File Offset: 0x00003CF5
		// (set) Token: 0x06000B10 RID: 2832 RVA: 0x00005AFD File Offset: 0x00003CFD
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

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x00005B06 File Offset: 0x00003D06
		// (set) Token: 0x06000B12 RID: 2834 RVA: 0x00005B0E File Offset: 0x00003D0E
		public DependentPriceReferenceType DependentPriceReference
		{
			get
			{
				return this.dependentPriceReferenceField;
			}
			set
			{
				this.dependentPriceReferenceField = value;
			}
		}

		// Token: 0x04000399 RID: 921
		private LeadTimeMeasureType leadTimeMeasureField;

		// Token: 0x0400039A RID: 922
		private MinimumQuantityType minimumQuantityField;

		// Token: 0x0400039B RID: 923
		private MaximumQuantityType maximumQuantityField;

		// Token: 0x0400039C RID: 924
		private HazardousRiskIndicatorType hazardousRiskIndicatorField;

		// Token: 0x0400039D RID: 925
		private TradingRestrictionsType[] tradingRestrictionsField;

		// Token: 0x0400039E RID: 926
		private AddressType[] applicableTerritoryAddressField;

		// Token: 0x0400039F RID: 927
		private PriceType priceField;

		// Token: 0x040003A0 RID: 928
		private DeliveryUnitType[] deliveryUnitField;

		// Token: 0x040003A1 RID: 929
		private TaxCategoryType[] applicableTaxCategoryField;

		// Token: 0x040003A2 RID: 930
		private PackageType packageField;

		// Token: 0x040003A3 RID: 931
		private AllowanceChargeType[] allowanceChargeField;

		// Token: 0x040003A4 RID: 932
		private DependentPriceReferenceType dependentPriceReferenceField;
	}
}

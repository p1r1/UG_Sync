using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200040F RID: 1039
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("AlternativeLineItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class LineItemType
	{
		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x000057E7 File Offset: 0x000039E7
		// (set) Token: 0x06000AB1 RID: 2737 RVA: 0x000057EF File Offset: 0x000039EF
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

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x000057F8 File Offset: 0x000039F8
		// (set) Token: 0x06000AB3 RID: 2739 RVA: 0x00005800 File Offset: 0x00003A00
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SalesOrderIDType SalesOrderID
		{
			get
			{
				return this.salesOrderIDField;
			}
			set
			{
				this.salesOrderIDField = value;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x00005809 File Offset: 0x00003A09
		// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x00005811 File Offset: 0x00003A11
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public UUIDType UUID
		{
			get
			{
				return this.uUIDField;
			}
			set
			{
				this.uUIDField = value;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x0000581A File Offset: 0x00003A1A
		// (set) Token: 0x06000AB7 RID: 2743 RVA: 0x00005822 File Offset: 0x00003A22
		[XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NoteType[] Note
		{
			get
			{
				return this.noteField;
			}
			set
			{
				this.noteField = value;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x0000582B File Offset: 0x00003A2B
		// (set) Token: 0x06000AB9 RID: 2745 RVA: 0x00005833 File Offset: 0x00003A33
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LineStatusCodeType LineStatusCode
		{
			get
			{
				return this.lineStatusCodeField;
			}
			set
			{
				this.lineStatusCodeField = value;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x0000583C File Offset: 0x00003A3C
		// (set) Token: 0x06000ABB RID: 2747 RVA: 0x00005844 File Offset: 0x00003A44
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

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x0000584D File Offset: 0x00003A4D
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x00005855 File Offset: 0x00003A55
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

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x0000585E File Offset: 0x00003A5E
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x00005866 File Offset: 0x00003A66
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TotalTaxAmountType TotalTaxAmount
		{
			get
			{
				return this.totalTaxAmountField;
			}
			set
			{
				this.totalTaxAmountField = value;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x0000586F File Offset: 0x00003A6F
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x00005877 File Offset: 0x00003A77
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

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x00005880 File Offset: 0x00003A80
		// (set) Token: 0x06000AC3 RID: 2755 RVA: 0x00005888 File Offset: 0x00003A88
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

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x00005891 File Offset: 0x00003A91
		// (set) Token: 0x06000AC5 RID: 2757 RVA: 0x00005899 File Offset: 0x00003A99
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MinimumBackorderQuantityType MinimumBackorderQuantity
		{
			get
			{
				return this.minimumBackorderQuantityField;
			}
			set
			{
				this.minimumBackorderQuantityField = value;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x000058A2 File Offset: 0x00003AA2
		// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x000058AA File Offset: 0x00003AAA
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MaximumBackorderQuantityType MaximumBackorderQuantity
		{
			get
			{
				return this.maximumBackorderQuantityField;
			}
			set
			{
				this.maximumBackorderQuantityField = value;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x000058B3 File Offset: 0x00003AB3
		// (set) Token: 0x06000AC9 RID: 2761 RVA: 0x000058BB File Offset: 0x00003ABB
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public InspectionMethodCodeType InspectionMethodCode
		{
			get
			{
				return this.inspectionMethodCodeField;
			}
			set
			{
				this.inspectionMethodCodeField = value;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000ACA RID: 2762 RVA: 0x000058C4 File Offset: 0x00003AC4
		// (set) Token: 0x06000ACB RID: 2763 RVA: 0x000058CC File Offset: 0x00003ACC
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PartialDeliveryIndicatorType PartialDeliveryIndicator
		{
			get
			{
				return this.partialDeliveryIndicatorField;
			}
			set
			{
				this.partialDeliveryIndicatorField = value;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x000058D5 File Offset: 0x00003AD5
		// (set) Token: 0x06000ACD RID: 2765 RVA: 0x000058DD File Offset: 0x00003ADD
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public BackOrderAllowedIndicatorType BackOrderAllowedIndicator
		{
			get
			{
				return this.backOrderAllowedIndicatorField;
			}
			set
			{
				this.backOrderAllowedIndicatorField = value;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x000058E6 File Offset: 0x00003AE6
		// (set) Token: 0x06000ACF RID: 2767 RVA: 0x000058EE File Offset: 0x00003AEE
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AccountingCostCodeType AccountingCostCode
		{
			get
			{
				return this.accountingCostCodeField;
			}
			set
			{
				this.accountingCostCodeField = value;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x000058F7 File Offset: 0x00003AF7
		// (set) Token: 0x06000AD1 RID: 2769 RVA: 0x000058FF File Offset: 0x00003AFF
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AccountingCostType AccountingCost
		{
			get
			{
				return this.accountingCostField;
			}
			set
			{
				this.accountingCostField = value;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x00005908 File Offset: 0x00003B08
		// (set) Token: 0x06000AD3 RID: 2771 RVA: 0x00005910 File Offset: 0x00003B10
		[XmlElement("WarrantyInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public WarrantyInformationType[] WarrantyInformation
		{
			get
			{
				return this.warrantyInformationField;
			}
			set
			{
				this.warrantyInformationField = value;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x00005919 File Offset: 0x00003B19
		// (set) Token: 0x06000AD5 RID: 2773 RVA: 0x00005921 File Offset: 0x00003B21
		[XmlElement("Delivery")]
		public DeliveryType[] Delivery
		{
			get
			{
				return this.deliveryField;
			}
			set
			{
				this.deliveryField = value;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x0000592A File Offset: 0x00003B2A
		// (set) Token: 0x06000AD7 RID: 2775 RVA: 0x00005932 File Offset: 0x00003B32
		public DeliveryTermsType DeliveryTerms
		{
			get
			{
				return this.deliveryTermsField;
			}
			set
			{
				this.deliveryTermsField = value;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x0000593B File Offset: 0x00003B3B
		// (set) Token: 0x06000AD9 RID: 2777 RVA: 0x00005943 File Offset: 0x00003B43
		public PartyType OriginatorParty
		{
			get
			{
				return this.originatorPartyField;
			}
			set
			{
				this.originatorPartyField = value;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x0000594C File Offset: 0x00003B4C
		// (set) Token: 0x06000ADB RID: 2779 RVA: 0x00005954 File Offset: 0x00003B54
		[XmlElement("OrderedShipment")]
		public OrderedShipmentType[] OrderedShipment
		{
			get
			{
				return this.orderedShipmentField;
			}
			set
			{
				this.orderedShipmentField = value;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x0000595D File Offset: 0x00003B5D
		// (set) Token: 0x06000ADD RID: 2781 RVA: 0x00005965 File Offset: 0x00003B65
		public PricingReferenceType PricingReference
		{
			get
			{
				return this.pricingReferenceField;
			}
			set
			{
				this.pricingReferenceField = value;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x0000596E File Offset: 0x00003B6E
		// (set) Token: 0x06000ADF RID: 2783 RVA: 0x00005976 File Offset: 0x00003B76
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

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x0000597F File Offset: 0x00003B7F
		// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x00005987 File Offset: 0x00003B87
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

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x00005990 File Offset: 0x00003B90
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x00005998 File Offset: 0x00003B98
		public ItemType Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x000059A1 File Offset: 0x00003BA1
		// (set) Token: 0x06000AE5 RID: 2789 RVA: 0x000059A9 File Offset: 0x00003BA9
		[XmlElement("SubLineItem")]
		public LineItemType[] SubLineItem
		{
			get
			{
				return this.subLineItemField;
			}
			set
			{
				this.subLineItemField = value;
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x000059B2 File Offset: 0x00003BB2
		// (set) Token: 0x06000AE7 RID: 2791 RVA: 0x000059BA File Offset: 0x00003BBA
		public PeriodType WarrantyValidityPeriod
		{
			get
			{
				return this.warrantyValidityPeriodField;
			}
			set
			{
				this.warrantyValidityPeriodField = value;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x000059C3 File Offset: 0x00003BC3
		// (set) Token: 0x06000AE9 RID: 2793 RVA: 0x000059CB File Offset: 0x00003BCB
		public PartyType WarrantyParty
		{
			get
			{
				return this.warrantyPartyField;
			}
			set
			{
				this.warrantyPartyField = value;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x000059D4 File Offset: 0x00003BD4
		// (set) Token: 0x06000AEB RID: 2795 RVA: 0x000059DC File Offset: 0x00003BDC
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

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x000059E5 File Offset: 0x00003BE5
		// (set) Token: 0x06000AED RID: 2797 RVA: 0x000059ED File Offset: 0x00003BED
		public PriceExtensionType ItemPriceExtension
		{
			get
			{
				return this.itemPriceExtensionField;
			}
			set
			{
				this.itemPriceExtensionField = value;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000AEE RID: 2798 RVA: 0x000059F6 File Offset: 0x00003BF6
		// (set) Token: 0x06000AEF RID: 2799 RVA: 0x000059FE File Offset: 0x00003BFE
		[XmlElement("LineReference")]
		public LineReferenceType[] LineReference
		{
			get
			{
				return this.lineReferenceField;
			}
			set
			{
				this.lineReferenceField = value;
			}
		}

		// Token: 0x04000375 RID: 885
		private IDType idField;

		// Token: 0x04000376 RID: 886
		private SalesOrderIDType salesOrderIDField;

		// Token: 0x04000377 RID: 887
		private UUIDType uUIDField;

		// Token: 0x04000378 RID: 888
		private NoteType[] noteField;

		// Token: 0x04000379 RID: 889
		private LineStatusCodeType lineStatusCodeField;

		// Token: 0x0400037A RID: 890
		private QuantityType2 quantityField;

		// Token: 0x0400037B RID: 891
		private LineExtensionAmountType lineExtensionAmountField;

		// Token: 0x0400037C RID: 892
		private TotalTaxAmountType totalTaxAmountField;

		// Token: 0x0400037D RID: 893
		private MinimumQuantityType minimumQuantityField;

		// Token: 0x0400037E RID: 894
		private MaximumQuantityType maximumQuantityField;

		// Token: 0x0400037F RID: 895
		private MinimumBackorderQuantityType minimumBackorderQuantityField;

		// Token: 0x04000380 RID: 896
		private MaximumBackorderQuantityType maximumBackorderQuantityField;

		// Token: 0x04000381 RID: 897
		private InspectionMethodCodeType inspectionMethodCodeField;

		// Token: 0x04000382 RID: 898
		private PartialDeliveryIndicatorType partialDeliveryIndicatorField;

		// Token: 0x04000383 RID: 899
		private BackOrderAllowedIndicatorType backOrderAllowedIndicatorField;

		// Token: 0x04000384 RID: 900
		private AccountingCostCodeType accountingCostCodeField;

		// Token: 0x04000385 RID: 901
		private AccountingCostType accountingCostField;

		// Token: 0x04000386 RID: 902
		private WarrantyInformationType[] warrantyInformationField;

		// Token: 0x04000387 RID: 903
		private DeliveryType[] deliveryField;

		// Token: 0x04000388 RID: 904
		private DeliveryTermsType deliveryTermsField;

		// Token: 0x04000389 RID: 905
		private PartyType originatorPartyField;

		// Token: 0x0400038A RID: 906
		private OrderedShipmentType[] orderedShipmentField;

		// Token: 0x0400038B RID: 907
		private PricingReferenceType pricingReferenceField;

		// Token: 0x0400038C RID: 908
		private AllowanceChargeType[] allowanceChargeField;

		// Token: 0x0400038D RID: 909
		private PriceType priceField;

		// Token: 0x0400038E RID: 910
		private ItemType itemField;

		// Token: 0x0400038F RID: 911
		private LineItemType[] subLineItemField;

		// Token: 0x04000390 RID: 912
		private PeriodType warrantyValidityPeriodField;

		// Token: 0x04000391 RID: 913
		private PartyType warrantyPartyField;

		// Token: 0x04000392 RID: 914
		private TaxTotalType[] taxTotalField;

		// Token: 0x04000393 RID: 915
		private PriceExtensionType itemPriceExtensionField;

		// Token: 0x04000394 RID: 916
		private LineReferenceType[] lineReferenceField;
	}
}

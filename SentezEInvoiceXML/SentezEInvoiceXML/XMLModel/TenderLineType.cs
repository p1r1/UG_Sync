using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200042F RID: 1071
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("SubTenderLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class TenderLineType
	{
		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x0000692B File Offset: 0x00004B2B
		// (set) Token: 0x06000CD9 RID: 3289 RVA: 0x00006933 File Offset: 0x00004B33
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

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x0000693C File Offset: 0x00004B3C
		// (set) Token: 0x06000CDB RID: 3291 RVA: 0x00006944 File Offset: 0x00004B44
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

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000CDC RID: 3292 RVA: 0x0000694D File Offset: 0x00004B4D
		// (set) Token: 0x06000CDD RID: 3293 RVA: 0x00006955 File Offset: 0x00004B55
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

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x0000695E File Offset: 0x00004B5E
		// (set) Token: 0x06000CDF RID: 3295 RVA: 0x00006966 File Offset: 0x00004B66
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

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x0000696F File Offset: 0x00004B6F
		// (set) Token: 0x06000CE1 RID: 3297 RVA: 0x00006977 File Offset: 0x00004B77
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

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x00006980 File Offset: 0x00004B80
		// (set) Token: 0x06000CE3 RID: 3299 RVA: 0x00006988 File Offset: 0x00004B88
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public OrderableUnitType OrderableUnit
		{
			get
			{
				return this.orderableUnitField;
			}
			set
			{
				this.orderableUnitField = value;
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x00006991 File Offset: 0x00004B91
		// (set) Token: 0x06000CE5 RID: 3301 RVA: 0x00006999 File Offset: 0x00004B99
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ContentUnitQuantityType ContentUnitQuantity
		{
			get
			{
				return this.contentUnitQuantityField;
			}
			set
			{
				this.contentUnitQuantityField = value;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x000069A2 File Offset: 0x00004BA2
		// (set) Token: 0x06000CE7 RID: 3303 RVA: 0x000069AA File Offset: 0x00004BAA
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public OrderQuantityIncrementNumericType OrderQuantityIncrementNumeric
		{
			get
			{
				return this.orderQuantityIncrementNumericField;
			}
			set
			{
				this.orderQuantityIncrementNumericField = value;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x000069B3 File Offset: 0x00004BB3
		// (set) Token: 0x06000CE9 RID: 3305 RVA: 0x000069BB File Offset: 0x00004BBB
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MinimumOrderQuantityType MinimumOrderQuantity
		{
			get
			{
				return this.minimumOrderQuantityField;
			}
			set
			{
				this.minimumOrderQuantityField = value;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x000069C4 File Offset: 0x00004BC4
		// (set) Token: 0x06000CEB RID: 3307 RVA: 0x000069CC File Offset: 0x00004BCC
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MaximumOrderQuantityType MaximumOrderQuantity
		{
			get
			{
				return this.maximumOrderQuantityField;
			}
			set
			{
				this.maximumOrderQuantityField = value;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000CEC RID: 3308 RVA: 0x000069D5 File Offset: 0x00004BD5
		// (set) Token: 0x06000CED RID: 3309 RVA: 0x000069DD File Offset: 0x00004BDD
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

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x000069E6 File Offset: 0x00004BE6
		// (set) Token: 0x06000CEF RID: 3311 RVA: 0x000069EE File Offset: 0x00004BEE
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PackLevelCodeType PackLevelCode
		{
			get
			{
				return this.packLevelCodeField;
			}
			set
			{
				this.packLevelCodeField = value;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x000069F7 File Offset: 0x00004BF7
		// (set) Token: 0x06000CF1 RID: 3313 RVA: 0x000069FF File Offset: 0x00004BFF
		[XmlElement("DocumentReference")]
		public DocumentReferenceType[] DocumentReference
		{
			get
			{
				return this.documentReferenceField;
			}
			set
			{
				this.documentReferenceField = value;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x00006A08 File Offset: 0x00004C08
		// (set) Token: 0x06000CF3 RID: 3315 RVA: 0x00006A10 File Offset: 0x00004C10
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

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x00006A19 File Offset: 0x00004C19
		// (set) Token: 0x06000CF5 RID: 3317 RVA: 0x00006A21 File Offset: 0x00004C21
		[XmlElement("OfferedItemLocationQuantity")]
		public ItemLocationQuantityType[] OfferedItemLocationQuantity
		{
			get
			{
				return this.offeredItemLocationQuantityField;
			}
			set
			{
				this.offeredItemLocationQuantityField = value;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x00006A2A File Offset: 0x00004C2A
		// (set) Token: 0x06000CF7 RID: 3319 RVA: 0x00006A32 File Offset: 0x00004C32
		[XmlElement("ReplacementRelatedItem")]
		public RelatedItemType[] ReplacementRelatedItem
		{
			get
			{
				return this.replacementRelatedItemField;
			}
			set
			{
				this.replacementRelatedItemField = value;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x00006A3B File Offset: 0x00004C3B
		// (set) Token: 0x06000CF9 RID: 3321 RVA: 0x00006A43 File Offset: 0x00004C43
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

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000CFA RID: 3322 RVA: 0x00006A4C File Offset: 0x00004C4C
		// (set) Token: 0x06000CFB RID: 3323 RVA: 0x00006A54 File Offset: 0x00004C54
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

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x00006A5D File Offset: 0x00004C5D
		// (set) Token: 0x06000CFD RID: 3325 RVA: 0x00006A65 File Offset: 0x00004C65
		[XmlElement("SubTenderLine")]
		public TenderLineType[] SubTenderLine
		{
			get
			{
				return this.subTenderLineField;
			}
			set
			{
				this.subTenderLineField = value;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x00006A6E File Offset: 0x00004C6E
		// (set) Token: 0x06000CFF RID: 3327 RVA: 0x00006A76 File Offset: 0x00004C76
		public LineReferenceType CallForTendersLineReference
		{
			get
			{
				return this.callForTendersLineReferenceField;
			}
			set
			{
				this.callForTendersLineReferenceField = value;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000D00 RID: 3328 RVA: 0x00006A7F File Offset: 0x00004C7F
		// (set) Token: 0x06000D01 RID: 3329 RVA: 0x00006A87 File Offset: 0x00004C87
		public DocumentReferenceType CallForTendersDocumentReference
		{
			get
			{
				return this.callForTendersDocumentReferenceField;
			}
			set
			{
				this.callForTendersDocumentReferenceField = value;
			}
		}

		// Token: 0x04000479 RID: 1145
		private IDType idField;

		// Token: 0x0400047A RID: 1146
		private NoteType[] noteField;

		// Token: 0x0400047B RID: 1147
		private QuantityType2 quantityField;

		// Token: 0x0400047C RID: 1148
		private LineExtensionAmountType lineExtensionAmountField;

		// Token: 0x0400047D RID: 1149
		private TotalTaxAmountType totalTaxAmountField;

		// Token: 0x0400047E RID: 1150
		private OrderableUnitType orderableUnitField;

		// Token: 0x0400047F RID: 1151
		private ContentUnitQuantityType contentUnitQuantityField;

		// Token: 0x04000480 RID: 1152
		private OrderQuantityIncrementNumericType orderQuantityIncrementNumericField;

		// Token: 0x04000481 RID: 1153
		private MinimumOrderQuantityType minimumOrderQuantityField;

		// Token: 0x04000482 RID: 1154
		private MaximumOrderQuantityType maximumOrderQuantityField;

		// Token: 0x04000483 RID: 1155
		private WarrantyInformationType[] warrantyInformationField;

		// Token: 0x04000484 RID: 1156
		private PackLevelCodeType packLevelCodeField;

		// Token: 0x04000485 RID: 1157
		private DocumentReferenceType[] documentReferenceField;

		// Token: 0x04000486 RID: 1158
		private ItemType itemField;

		// Token: 0x04000487 RID: 1159
		private ItemLocationQuantityType[] offeredItemLocationQuantityField;

		// Token: 0x04000488 RID: 1160
		private RelatedItemType[] replacementRelatedItemField;

		// Token: 0x04000489 RID: 1161
		private PartyType warrantyPartyField;

		// Token: 0x0400048A RID: 1162
		private PeriodType warrantyValidityPeriodField;

		// Token: 0x0400048B RID: 1163
		private TenderLineType[] subTenderLineField;

		// Token: 0x0400048C RID: 1164
		private LineReferenceType callForTendersLineReferenceField;

		// Token: 0x0400048D RID: 1165
		private DocumentReferenceType callForTendersDocumentReferenceField;
	}
}

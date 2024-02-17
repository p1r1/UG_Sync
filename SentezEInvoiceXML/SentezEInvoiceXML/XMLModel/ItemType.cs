using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003D0 RID: 976
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("Item", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ItemType
	{
		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x00003FDD File Offset: 0x000021DD
		// (set) Token: 0x0600079E RID: 1950 RVA: 0x00003FE5 File Offset: 0x000021E5
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DescriptionType Description
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

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x00003FEE File Offset: 0x000021EE
		// (set) Token: 0x060007A0 RID: 1952 RVA: 0x00003FF6 File Offset: 0x000021F6
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NameType1 Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x00003FFF File Offset: 0x000021FF
		// (set) Token: 0x060007A2 RID: 1954 RVA: 0x00004007 File Offset: 0x00002207
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public KeywordType Keyword
		{
			get
			{
				return this.keywordField;
			}
			set
			{
				this.keywordField = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x00004010 File Offset: 0x00002210
		// (set) Token: 0x060007A4 RID: 1956 RVA: 0x00004018 File Offset: 0x00002218
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public BrandNameType BrandName
		{
			get
			{
				return this.brandNameField;
			}
			set
			{
				this.brandNameField = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x00004021 File Offset: 0x00002221
		// (set) Token: 0x060007A6 RID: 1958 RVA: 0x00004029 File Offset: 0x00002229
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ModelNameType ModelName
		{
			get
			{
				return this.modelNameField;
			}
			set
			{
				this.modelNameField = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x00004032 File Offset: 0x00002232
		// (set) Token: 0x060007A8 RID: 1960 RVA: 0x0000403A File Offset: 0x0000223A
		public ItemIdentificationType BuyersItemIdentification
		{
			get
			{
				return this.buyersItemIdentificationField;
			}
			set
			{
				this.buyersItemIdentificationField = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x00004043 File Offset: 0x00002243
		// (set) Token: 0x060007AA RID: 1962 RVA: 0x0000404B File Offset: 0x0000224B
		public ItemIdentificationType SellersItemIdentification
		{
			get
			{
				return this.sellersItemIdentificationField;
			}
			set
			{
				this.sellersItemIdentificationField = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x00004054 File Offset: 0x00002254
		// (set) Token: 0x060007AC RID: 1964 RVA: 0x0000405C File Offset: 0x0000225C
		public ItemIdentificationType ManufacturersItemIdentification
		{
			get
			{
				return this.manufacturersItemIdentificationField;
			}
			set
			{
				this.manufacturersItemIdentificationField = value;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060007AD RID: 1965 RVA: 0x00004065 File Offset: 0x00002265
		// (set) Token: 0x060007AE RID: 1966 RVA: 0x0000406D File Offset: 0x0000226D
		[XmlElement("AdditionalItemIdentification")]
		public ItemIdentificationType[] AdditionalItemIdentification
		{
			get
			{
				return this.additionalItemIdentificationField;
			}
			set
			{
				this.additionalItemIdentificationField = value;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x00004076 File Offset: 0x00002276
		// (set) Token: 0x060007B0 RID: 1968 RVA: 0x0000407E File Offset: 0x0000227E
		[XmlElement("CommodityClassification")]
		public CommodityClassificationType[] CommodityClassification
		{
			get
			{
				return this.commodityClassificationField;
			}
			set
			{
				this.commodityClassificationField = value;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060007B1 RID: 1969 RVA: 0x00004087 File Offset: 0x00002287
		// (set) Token: 0x060007B2 RID: 1970 RVA: 0x0000408F File Offset: 0x0000228F
		[XmlElement("ItemInstance")]
		public ItemInstanceType[] ItemInstance
		{
			get
			{
				return this.itemInstanceField;
			}
			set
			{
				this.itemInstanceField = value;
			}
		}

		// Token: 0x0400020B RID: 523
		private DescriptionType descriptionField;

		// Token: 0x0400020C RID: 524
		private NameType1 nameField;

		// Token: 0x0400020D RID: 525
		private KeywordType keywordField;

		// Token: 0x0400020E RID: 526
		private BrandNameType brandNameField;

		// Token: 0x0400020F RID: 527
		private ModelNameType modelNameField;

		// Token: 0x04000210 RID: 528
		private ItemIdentificationType buyersItemIdentificationField;

		// Token: 0x04000211 RID: 529
		private ItemIdentificationType sellersItemIdentificationField;

		// Token: 0x04000212 RID: 530
		private ItemIdentificationType manufacturersItemIdentificationField;

		// Token: 0x04000213 RID: 531
		private ItemIdentificationType[] additionalItemIdentificationField;

		// Token: 0x04000214 RID: 532
		private CommodityClassificationType[] commodityClassificationField;

		// Token: 0x04000215 RID: 533
		private ItemInstanceType[] itemInstanceField;
	}
}

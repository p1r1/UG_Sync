using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003CE RID: 974
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ActualPackage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class PackageType
	{
		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x00003C9C File Offset: 0x00001E9C
		// (set) Token: 0x0600073A RID: 1850 RVA: 0x00003CA4 File Offset: 0x00001EA4
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

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x00003CAD File Offset: 0x00001EAD
		// (set) Token: 0x0600073C RID: 1852 RVA: 0x00003CB5 File Offset: 0x00001EB5
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

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x00003CBE File Offset: 0x00001EBE
		// (set) Token: 0x0600073E RID: 1854 RVA: 0x00003CC6 File Offset: 0x00001EC6
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ReturnableMaterialIndicatorType ReturnableMaterialIndicator
		{
			get
			{
				return this.returnableMaterialIndicatorField;
			}
			set
			{
				this.returnableMaterialIndicatorField = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x00003CCF File Offset: 0x00001ECF
		// (set) Token: 0x06000740 RID: 1856 RVA: 0x00003CD7 File Offset: 0x00001ED7
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PackageLevelCodeType PackageLevelCode
		{
			get
			{
				return this.packageLevelCodeField;
			}
			set
			{
				this.packageLevelCodeField = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x00003CE0 File Offset: 0x00001EE0
		// (set) Token: 0x06000742 RID: 1858 RVA: 0x00003CE8 File Offset: 0x00001EE8
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PackagingTypeCodeType PackagingTypeCode
		{
			get
			{
				return this.packagingTypeCodeField;
			}
			set
			{
				this.packagingTypeCodeField = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x00003CF1 File Offset: 0x00001EF1
		// (set) Token: 0x06000744 RID: 1860 RVA: 0x00003CF9 File Offset: 0x00001EF9
		[XmlElement("PackingMaterial", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PackingMaterialType[] PackingMaterial
		{
			get
			{
				return this.packingMaterialField;
			}
			set
			{
				this.packingMaterialField = value;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x00003D02 File Offset: 0x00001F02
		// (set) Token: 0x06000746 RID: 1862 RVA: 0x00003D0A File Offset: 0x00001F0A
		[XmlElement("ContainedPackage")]
		public PackageType[] ContainedPackage
		{
			get
			{
				return this.containedPackageField;
			}
			set
			{
				this.containedPackageField = value;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x00003D13 File Offset: 0x00001F13
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x00003D1B File Offset: 0x00001F1B
		[XmlElement("GoodsItem")]
		public GoodsItemType[] GoodsItem
		{
			get
			{
				return this.goodsItemField;
			}
			set
			{
				this.goodsItemField = value;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x00003D24 File Offset: 0x00001F24
		// (set) Token: 0x0600074A RID: 1866 RVA: 0x00003D2C File Offset: 0x00001F2C
		[XmlElement("MeasurementDimension")]
		public DimensionType[] MeasurementDimension
		{
			get
			{
				return this.measurementDimensionField;
			}
			set
			{
				this.measurementDimensionField = value;
			}
		}

		// Token: 0x040001DA RID: 474
		private IDType idField;

		// Token: 0x040001DB RID: 475
		private QuantityType2 quantityField;

		// Token: 0x040001DC RID: 476
		private ReturnableMaterialIndicatorType returnableMaterialIndicatorField;

		// Token: 0x040001DD RID: 477
		private PackageLevelCodeType packageLevelCodeField;

		// Token: 0x040001DE RID: 478
		private PackagingTypeCodeType packagingTypeCodeField;

		// Token: 0x040001DF RID: 479
		private PackingMaterialType[] packingMaterialField;

		// Token: 0x040001E0 RID: 480
		private PackageType[] containedPackageField;

		// Token: 0x040001E1 RID: 481
		private GoodsItemType[] goodsItemField;

		// Token: 0x040001E2 RID: 482
		private DimensionType[] measurementDimensionField;
	}
}

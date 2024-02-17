using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003D4 RID: 980
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("AdditionalItemProperty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ItemPropertyType
	{
		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x00004142 File Offset: 0x00002342
		// (set) Token: 0x060007CC RID: 1996 RVA: 0x0000414A File Offset: 0x0000234A
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

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x00004153 File Offset: 0x00002353
		// (set) Token: 0x060007CE RID: 1998 RVA: 0x0000415B File Offset: 0x0000235B
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

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x00004164 File Offset: 0x00002364
		// (set) Token: 0x060007D0 RID: 2000 RVA: 0x0000416C File Offset: 0x0000236C
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NameCodeType NameCode
		{
			get
			{
				return this.nameCodeField;
			}
			set
			{
				this.nameCodeField = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x00004175 File Offset: 0x00002375
		// (set) Token: 0x060007D2 RID: 2002 RVA: 0x0000417D File Offset: 0x0000237D
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TestMethodType TestMethod
		{
			get
			{
				return this.testMethodField;
			}
			set
			{
				this.testMethodField = value;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x00004186 File Offset: 0x00002386
		// (set) Token: 0x060007D4 RID: 2004 RVA: 0x0000418E File Offset: 0x0000238E
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ValueType Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x00004197 File Offset: 0x00002397
		// (set) Token: 0x060007D6 RID: 2006 RVA: 0x0000419F File Offset: 0x0000239F
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ValueQuantityType ValueQuantity
		{
			get
			{
				return this.valueQuantityField;
			}
			set
			{
				this.valueQuantityField = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x000041A8 File Offset: 0x000023A8
		// (set) Token: 0x060007D8 RID: 2008 RVA: 0x000041B0 File Offset: 0x000023B0
		[XmlElement("ValueQualifier", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ValueQualifierType[] ValueQualifier
		{
			get
			{
				return this.valueQualifierField;
			}
			set
			{
				this.valueQualifierField = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x000041B9 File Offset: 0x000023B9
		// (set) Token: 0x060007DA RID: 2010 RVA: 0x000041C1 File Offset: 0x000023C1
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ImportanceCodeType ImportanceCode
		{
			get
			{
				return this.importanceCodeField;
			}
			set
			{
				this.importanceCodeField = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x000041CA File Offset: 0x000023CA
		// (set) Token: 0x060007DC RID: 2012 RVA: 0x000041D2 File Offset: 0x000023D2
		[XmlElement("ListValue", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ListValueType[] ListValue
		{
			get
			{
				return this.listValueField;
			}
			set
			{
				this.listValueField = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060007DD RID: 2013 RVA: 0x000041DB File Offset: 0x000023DB
		// (set) Token: 0x060007DE RID: 2014 RVA: 0x000041E3 File Offset: 0x000023E3
		public PeriodType UsabilityPeriod
		{
			get
			{
				return this.usabilityPeriodField;
			}
			set
			{
				this.usabilityPeriodField = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060007DF RID: 2015 RVA: 0x000041EC File Offset: 0x000023EC
		// (set) Token: 0x060007E0 RID: 2016 RVA: 0x000041F4 File Offset: 0x000023F4
		[XmlElement("ItemPropertyGroup")]
		public ItemPropertyGroupType[] ItemPropertyGroup
		{
			get
			{
				return this.itemPropertyGroupField;
			}
			set
			{
				this.itemPropertyGroupField = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x000041FD File Offset: 0x000023FD
		// (set) Token: 0x060007E2 RID: 2018 RVA: 0x00004205 File Offset: 0x00002405
		public DimensionType RangeDimension
		{
			get
			{
				return this.rangeDimensionField;
			}
			set
			{
				this.rangeDimensionField = value;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x0000420E File Offset: 0x0000240E
		// (set) Token: 0x060007E4 RID: 2020 RVA: 0x00004216 File Offset: 0x00002416
		public ItemPropertyRangeType ItemPropertyRange
		{
			get
			{
				return this.itemPropertyRangeField;
			}
			set
			{
				this.itemPropertyRangeField = value;
			}
		}

		// Token: 0x04000220 RID: 544
		private IDType idField;

		// Token: 0x04000221 RID: 545
		private NameType1 nameField;

		// Token: 0x04000222 RID: 546
		private NameCodeType nameCodeField;

		// Token: 0x04000223 RID: 547
		private TestMethodType testMethodField;

		// Token: 0x04000224 RID: 548
		private ValueType valueField;

		// Token: 0x04000225 RID: 549
		private ValueQuantityType valueQuantityField;

		// Token: 0x04000226 RID: 550
		private ValueQualifierType[] valueQualifierField;

		// Token: 0x04000227 RID: 551
		private ImportanceCodeType importanceCodeField;

		// Token: 0x04000228 RID: 552
		private ListValueType[] listValueField;

		// Token: 0x04000229 RID: 553
		private PeriodType usabilityPeriodField;

		// Token: 0x0400022A RID: 554
		private ItemPropertyGroupType[] itemPropertyGroupField;

		// Token: 0x0400022B RID: 555
		private DimensionType rangeDimensionField;

		// Token: 0x0400022C RID: 556
		private ItemPropertyRangeType itemPropertyRangeField;
	}
}

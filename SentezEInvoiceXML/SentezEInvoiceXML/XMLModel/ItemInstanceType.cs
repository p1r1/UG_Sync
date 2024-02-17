using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003D3 RID: 979
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ItemInstance", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ItemInstanceType
	{
		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x000040BA File Offset: 0x000022BA
		// (set) Token: 0x060007BB RID: 1979 RVA: 0x000040C2 File Offset: 0x000022C2
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ProductTraceIDType ProductTraceID
		{
			get
			{
				return this.productTraceIDField;
			}
			set
			{
				this.productTraceIDField = value;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x000040CB File Offset: 0x000022CB
		// (set) Token: 0x060007BD RID: 1981 RVA: 0x000040D3 File Offset: 0x000022D3
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ManufactureDateType ManufactureDate
		{
			get
			{
				return this.manufactureDateField;
			}
			set
			{
				this.manufactureDateField = value;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x000040DC File Offset: 0x000022DC
		// (set) Token: 0x060007BF RID: 1983 RVA: 0x000040E4 File Offset: 0x000022E4
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ManufactureTimeType ManufactureTime
		{
			get
			{
				return this.manufactureTimeField;
			}
			set
			{
				this.manufactureTimeField = value;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x000040ED File Offset: 0x000022ED
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x000040F5 File Offset: 0x000022F5
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public BestBeforeDateType BestBeforeDate
		{
			get
			{
				return this.bestBeforeDateField;
			}
			set
			{
				this.bestBeforeDateField = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x000040FE File Offset: 0x000022FE
		// (set) Token: 0x060007C3 RID: 1987 RVA: 0x00004106 File Offset: 0x00002306
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public RegistrationIDType RegistrationID
		{
			get
			{
				return this.registrationIDField;
			}
			set
			{
				this.registrationIDField = value;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x0000410F File Offset: 0x0000230F
		// (set) Token: 0x060007C5 RID: 1989 RVA: 0x00004117 File Offset: 0x00002317
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SerialIDType SerialID
		{
			get
			{
				return this.serialIDField;
			}
			set
			{
				this.serialIDField = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x00004120 File Offset: 0x00002320
		// (set) Token: 0x060007C7 RID: 1991 RVA: 0x00004128 File Offset: 0x00002328
		[XmlElement("AdditionalItemProperty")]
		public ItemPropertyType[] AdditionalItemProperty
		{
			get
			{
				return this.additionalItemPropertyField;
			}
			set
			{
				this.additionalItemPropertyField = value;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x00004131 File Offset: 0x00002331
		// (set) Token: 0x060007C9 RID: 1993 RVA: 0x00004139 File Offset: 0x00002339
		public LotIdentificationType LotIdentification
		{
			get
			{
				return this.lotIdentificationField;
			}
			set
			{
				this.lotIdentificationField = value;
			}
		}

		// Token: 0x04000218 RID: 536
		private ProductTraceIDType productTraceIDField;

		// Token: 0x04000219 RID: 537
		private ManufactureDateType manufactureDateField;

		// Token: 0x0400021A RID: 538
		private ManufactureTimeType manufactureTimeField;

		// Token: 0x0400021B RID: 539
		private BestBeforeDateType bestBeforeDateField;

		// Token: 0x0400021C RID: 540
		private RegistrationIDType registrationIDField;

		// Token: 0x0400021D RID: 541
		private SerialIDType serialIDField;

		// Token: 0x0400021E RID: 542
		private ItemPropertyType[] additionalItemPropertyField;

		// Token: 0x0400021F RID: 543
		private LotIdentificationType lotIdentificationField;
	}
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003FA RID: 1018
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("AccessoryRelatedItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class RelatedItemType
	{
		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x00005011 File Offset: 0x00003211
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x00005019 File Offset: 0x00003219
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

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x00005022 File Offset: 0x00003222
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x0000502A File Offset: 0x0000322A
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

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x00005033 File Offset: 0x00003233
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x0000503B File Offset: 0x0000323B
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

		// Token: 0x040002FF RID: 767
		private IDType idField;

		// Token: 0x04000300 RID: 768
		private QuantityType2 quantityField;

		// Token: 0x04000301 RID: 769
		private DescriptionType[] descriptionField;
	}
}

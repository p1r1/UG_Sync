using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003D5 RID: 981
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ItemPropertyGroup", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ItemPropertyGroupType
	{
		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x0000421F File Offset: 0x0000241F
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x00004227 File Offset: 0x00002427
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

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x00004230 File Offset: 0x00002430
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x00004238 File Offset: 0x00002438
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

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x00004241 File Offset: 0x00002441
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x00004249 File Offset: 0x00002449
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

		// Token: 0x0400022D RID: 557
		private IDType idField;

		// Token: 0x0400022E RID: 558
		private NameType1 nameField;

		// Token: 0x0400022F RID: 559
		private ImportanceCodeType importanceCodeField;
	}
}

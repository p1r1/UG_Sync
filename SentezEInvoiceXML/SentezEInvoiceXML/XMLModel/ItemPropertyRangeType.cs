using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003D7 RID: 983
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ItemPropertyRange", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ItemPropertyRangeType
	{
		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x000042A7 File Offset: 0x000024A7
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x000042AF File Offset: 0x000024AF
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MinimumValueType MinimumValue
		{
			get
			{
				return this.minimumValueField;
			}
			set
			{
				this.minimumValueField = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x000042B8 File Offset: 0x000024B8
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x000042C0 File Offset: 0x000024C0
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MaximumValueType MaximumValue
		{
			get
			{
				return this.maximumValueField;
			}
			set
			{
				this.maximumValueField = value;
			}
		}

		// Token: 0x04000235 RID: 565
		private MinimumValueType minimumValueField;

		// Token: 0x04000236 RID: 566
		private MaximumValueType maximumValueField;
	}
}

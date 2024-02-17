using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003D2 RID: 978
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("AdditionalCommodityClassification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class CommodityClassificationType
	{
		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x000040A9 File Offset: 0x000022A9
		// (set) Token: 0x060007B8 RID: 1976 RVA: 0x000040B1 File Offset: 0x000022B1
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ItemClassificationCodeType ItemClassificationCode
		{
			get
			{
				return this.itemClassificationCodeField;
			}
			set
			{
				this.itemClassificationCodeField = value;
			}
		}

		// Token: 0x04000217 RID: 535
		private ItemClassificationCodeType itemClassificationCodeField;
	}
}

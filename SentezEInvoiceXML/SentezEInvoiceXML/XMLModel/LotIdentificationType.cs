using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003D8 RID: 984
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("LotIdentification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class LotIdentificationType
	{
		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x000042C9 File Offset: 0x000024C9
		// (set) Token: 0x060007FE RID: 2046 RVA: 0x000042D1 File Offset: 0x000024D1
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LotNumberIDType LotNumberID
		{
			get
			{
				return this.lotNumberIDField;
			}
			set
			{
				this.lotNumberIDField = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x000042DA File Offset: 0x000024DA
		// (set) Token: 0x06000800 RID: 2048 RVA: 0x000042E2 File Offset: 0x000024E2
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ExpiryDateType ExpiryDate
		{
			get
			{
				return this.expiryDateField;
			}
			set
			{
				this.expiryDateField = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x000042EB File Offset: 0x000024EB
		// (set) Token: 0x06000802 RID: 2050 RVA: 0x000042F3 File Offset: 0x000024F3
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

		// Token: 0x04000237 RID: 567
		private LotNumberIDType lotNumberIDField;

		// Token: 0x04000238 RID: 568
		private ExpiryDateType expiryDateField;

		// Token: 0x04000239 RID: 569
		private ItemPropertyType[] additionalItemPropertyField;
	}
}

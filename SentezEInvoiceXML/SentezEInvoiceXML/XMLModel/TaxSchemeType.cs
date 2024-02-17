using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200033B RID: 827
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("TaxScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class TaxSchemeType
	{
		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x000036CF File Offset: 0x000018CF
		// (set) Token: 0x060005FD RID: 1533 RVA: 0x000036D7 File Offset: 0x000018D7
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

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x000036E0 File Offset: 0x000018E0
		// (set) Token: 0x060005FF RID: 1535 RVA: 0x000036E8 File Offset: 0x000018E8
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

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x000036F1 File Offset: 0x000018F1
		// (set) Token: 0x06000601 RID: 1537 RVA: 0x000036F9 File Offset: 0x000018F9
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TaxTypeCodeType TaxTypeCode
		{
			get
			{
				return this.taxTypeCodeField;
			}
			set
			{
				this.taxTypeCodeField = value;
			}
		}

		// Token: 0x04000185 RID: 389
		private IDType idField;

		// Token: 0x04000186 RID: 390
		private NameType1 nameField;

		// Token: 0x04000187 RID: 391
		private TaxTypeCodeType taxTypeCodeField;
	}
}

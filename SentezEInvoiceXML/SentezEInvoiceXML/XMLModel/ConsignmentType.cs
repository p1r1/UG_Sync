using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003E4 RID: 996
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ChildConsignment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ConsignmentType
	{
		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x000048E5 File Offset: 0x00002AE5
		// (set) Token: 0x060008C2 RID: 2242 RVA: 0x000048ED File Offset: 0x00002AED
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

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x000048F6 File Offset: 0x00002AF6
		// (set) Token: 0x060008C4 RID: 2244 RVA: 0x000048FE File Offset: 0x00002AFE
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TotalInvoiceAmountType TotalInvoiceAmount
		{
			get
			{
				return this.totalInvoiceAmountField;
			}
			set
			{
				this.totalInvoiceAmountField = value;
			}
		}

		// Token: 0x04000293 RID: 659
		private IDType idField;

		// Token: 0x04000294 RID: 660
		private TotalInvoiceAmountType totalInvoiceAmountField;
	}
}

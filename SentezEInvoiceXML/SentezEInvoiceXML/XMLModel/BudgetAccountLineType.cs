using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000428 RID: 1064
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("BudgetAccountLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class BudgetAccountLineType
	{
		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x00006584 File Offset: 0x00004784
		// (set) Token: 0x06000C64 RID: 3172 RVA: 0x0000658C File Offset: 0x0000478C
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

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000C65 RID: 3173 RVA: 0x00006595 File Offset: 0x00004795
		// (set) Token: 0x06000C66 RID: 3174 RVA: 0x0000659D File Offset: 0x0000479D
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TotalAmountType TotalAmount
		{
			get
			{
				return this.totalAmountField;
			}
			set
			{
				this.totalAmountField = value;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x000065A6 File Offset: 0x000047A6
		// (set) Token: 0x06000C68 RID: 3176 RVA: 0x000065AE File Offset: 0x000047AE
		[XmlElement("BudgetAccount")]
		public BudgetAccountType[] BudgetAccount
		{
			get
			{
				return this.budgetAccountField;
			}
			set
			{
				this.budgetAccountField = value;
			}
		}

		// Token: 0x04000442 RID: 1090
		private IDType idField;

		// Token: 0x04000443 RID: 1091
		private TotalAmountType totalAmountField;

		// Token: 0x04000444 RID: 1092
		private BudgetAccountType[] budgetAccountField;
	}
}

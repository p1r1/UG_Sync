using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000429 RID: 1065
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("BudgetAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class BudgetAccountType
	{
		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000C6A RID: 3178 RVA: 0x000065B7 File Offset: 0x000047B7
		// (set) Token: 0x06000C6B RID: 3179 RVA: 0x000065BF File Offset: 0x000047BF
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

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000C6C RID: 3180 RVA: 0x000065C8 File Offset: 0x000047C8
		// (set) Token: 0x06000C6D RID: 3181 RVA: 0x000065D0 File Offset: 0x000047D0
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public BudgetYearNumericType BudgetYearNumeric
		{
			get
			{
				return this.budgetYearNumericField;
			}
			set
			{
				this.budgetYearNumericField = value;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000C6E RID: 3182 RVA: 0x000065D9 File Offset: 0x000047D9
		// (set) Token: 0x06000C6F RID: 3183 RVA: 0x000065E1 File Offset: 0x000047E1
		public ClassificationSchemeType RequiredClassificationScheme
		{
			get
			{
				return this.requiredClassificationSchemeField;
			}
			set
			{
				this.requiredClassificationSchemeField = value;
			}
		}

		// Token: 0x04000445 RID: 1093
		private IDType idField;

		// Token: 0x04000446 RID: 1094
		private BudgetYearNumericType budgetYearNumericField;

		// Token: 0x04000447 RID: 1095
		private ClassificationSchemeType requiredClassificationSchemeField;
	}
}

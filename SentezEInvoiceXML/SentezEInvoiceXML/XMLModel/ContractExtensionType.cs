using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200042C RID: 1068
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ContractExtension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ContractExtensionType
	{
		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x000067A4 File Offset: 0x000049A4
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x000067AC File Offset: 0x000049AC
		[XmlElement("OptionsDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public OptionsDescriptionType[] OptionsDescription
		{
			get
			{
				return this.optionsDescriptionField;
			}
			set
			{
				this.optionsDescriptionField = value;
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x000067B5 File Offset: 0x000049B5
		// (set) Token: 0x06000CAA RID: 3242 RVA: 0x000067BD File Offset: 0x000049BD
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MinimumNumberNumericType MinimumNumberNumeric
		{
			get
			{
				return this.minimumNumberNumericField;
			}
			set
			{
				this.minimumNumberNumericField = value;
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x000067C6 File Offset: 0x000049C6
		// (set) Token: 0x06000CAC RID: 3244 RVA: 0x000067CE File Offset: 0x000049CE
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MaximumNumberNumericType MaximumNumberNumeric
		{
			get
			{
				return this.maximumNumberNumericField;
			}
			set
			{
				this.maximumNumberNumericField = value;
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x000067D7 File Offset: 0x000049D7
		// (set) Token: 0x06000CAE RID: 3246 RVA: 0x000067DF File Offset: 0x000049DF
		public PeriodType OptionValidityPeriod
		{
			get
			{
				return this.optionValidityPeriodField;
			}
			set
			{
				this.optionValidityPeriodField = value;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x000067E8 File Offset: 0x000049E8
		// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x000067F0 File Offset: 0x000049F0
		[XmlElement("Renewal")]
		public RenewalType[] Renewal
		{
			get
			{
				return this.renewalField;
			}
			set
			{
				this.renewalField = value;
			}
		}

		// Token: 0x04000462 RID: 1122
		private OptionsDescriptionType[] optionsDescriptionField;

		// Token: 0x04000463 RID: 1123
		private MinimumNumberNumericType minimumNumberNumericField;

		// Token: 0x04000464 RID: 1124
		private MaximumNumberNumericType maximumNumberNumericField;

		// Token: 0x04000465 RID: 1125
		private PeriodType optionValidityPeriodField;

		// Token: 0x04000466 RID: 1126
		private RenewalType[] renewalField;
	}
}

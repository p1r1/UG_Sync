using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000338 RID: 824
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("Country", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class CountryType
	{
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x00003658 File Offset: 0x00001858
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x00003660 File Offset: 0x00001860
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentificationCodeType IdentificationCode
		{
			get
			{
				return this.identificationCodeField;
			}
			set
			{
				this.identificationCodeField = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x00003669 File Offset: 0x00001869
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x00003671 File Offset: 0x00001871
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

		// Token: 0x0400017E RID: 382
		private IdentificationCodeType identificationCodeField;

		// Token: 0x0400017F RID: 383
		private NameType1 nameField;
	}
}

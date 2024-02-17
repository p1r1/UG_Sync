using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003FD RID: 1021
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ActivityProperty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ActivityPropertyType
	{
		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x00005121 File Offset: 0x00003321
		// (set) Token: 0x060009D3 RID: 2515 RVA: 0x00005129 File Offset: 0x00003329
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

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x00005132 File Offset: 0x00003332
		// (set) Token: 0x060009D5 RID: 2517 RVA: 0x0000513A File Offset: 0x0000333A
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ValueType Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}

		// Token: 0x0400030F RID: 783
		private NameType1 nameField;

		// Token: 0x04000310 RID: 784
		private ValueType valueField;
	}
}

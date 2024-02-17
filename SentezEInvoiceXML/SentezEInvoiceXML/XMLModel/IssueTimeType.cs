using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000293 RID: 659
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
	[XmlRoot("IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
	[Serializable]
	public class IssueTimeType : INotifyPropertyChanged
	{
		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00003297 File Offset: 0x00001497
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x0000329F File Offset: 0x0000149F
		[XmlText]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
				this.RaisePropertyChanged("Value");
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060004D9 RID: 1241 RVA: 0x00068D5C File Offset: 0x00066F5C
		// (remove) Token: 0x060004DA RID: 1242 RVA: 0x00068D94 File Offset: 0x00066F94
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x060004DB RID: 1243 RVA: 0x00068DCC File Offset: 0x00066FCC
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04000147 RID: 327
		private string valueField;
	}
}

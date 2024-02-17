using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000026 RID: 38
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
	[XmlRoot("ExtensionContent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", IsNullable = false)]
	[Serializable]
	public class ExtensionContentType : INotifyPropertyChanged
	{
		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600020F RID: 527 RVA: 0x00002F38 File Offset: 0x00001138
		// (set) Token: 0x06000210 RID: 528 RVA: 0x00002F40 File Offset: 0x00001140
		[XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public SignatureType Signature
		{
			get
			{
				return this.signatureField;
			}
			set
			{
				this.signatureField = value;
				this.RaisePropertyChanged("Signature");
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000211 RID: 529 RVA: 0x00068CC8 File Offset: 0x00066EC8
		// (remove) Token: 0x06000212 RID: 530 RVA: 0x00068D00 File Offset: 0x00066F00
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000213 RID: 531 RVA: 0x00068D38 File Offset: 0x00066F38
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0400011A RID: 282
		private SignatureType signatureField;
	}
}

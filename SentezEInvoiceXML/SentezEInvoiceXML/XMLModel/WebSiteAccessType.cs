using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200044E RID: 1102
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("WebSiteAccess", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class WebSiteAccessType
	{
		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000F29 RID: 3881 RVA: 0x00007BD4 File Offset: 0x00005DD4
		// (set) Token: 0x06000F2A RID: 3882 RVA: 0x00007BDC File Offset: 0x00005DDC
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public URIType URI
		{
			get
			{
				return this.uRIField;
			}
			set
			{
				this.uRIField = value;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x00007BE5 File Offset: 0x00005DE5
		// (set) Token: 0x06000F2C RID: 3884 RVA: 0x00007BED File Offset: 0x00005DED
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PasswordType Password
		{
			get
			{
				return this.passwordField;
			}
			set
			{
				this.passwordField = value;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x00007BF6 File Offset: 0x00005DF6
		// (set) Token: 0x06000F2E RID: 3886 RVA: 0x00007BFE File Offset: 0x00005DFE
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LoginType Login
		{
			get
			{
				return this.loginField;
			}
			set
			{
				this.loginField = value;
			}
		}

		// Token: 0x04000592 RID: 1426
		private URIType uRIField;

		// Token: 0x04000593 RID: 1427
		private PasswordType passwordField;

		// Token: 0x04000594 RID: 1428
		private LoginType loginField;
	}
}

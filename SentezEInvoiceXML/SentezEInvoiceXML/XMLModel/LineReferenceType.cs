using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003DF RID: 991
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("CallForTendersLineReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class LineReferenceType
	{
		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x00004571 File Offset: 0x00002771
		// (set) Token: 0x06000855 RID: 2133 RVA: 0x00004579 File Offset: 0x00002779
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LineIDType LineID
		{
			get
			{
				return this.lineIDField;
			}
			set
			{
				this.lineIDField = value;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x00004582 File Offset: 0x00002782
		// (set) Token: 0x06000857 RID: 2135 RVA: 0x0000458A File Offset: 0x0000278A
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LineStatusCodeType LineStatusCode
		{
			get
			{
				return this.lineStatusCodeField;
			}
			set
			{
				this.lineStatusCodeField = value;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x00004593 File Offset: 0x00002793
		// (set) Token: 0x06000859 RID: 2137 RVA: 0x0000459B File Offset: 0x0000279B
		public DocumentReferenceType DocumentReference
		{
			get
			{
				return this.documentReferenceField;
			}
			set
			{
				this.documentReferenceField = value;
			}
		}

		// Token: 0x0400025F RID: 607
		private LineIDType lineIDField;

		// Token: 0x04000260 RID: 608
		private LineStatusCodeType lineStatusCodeField;

		// Token: 0x04000261 RID: 609
		private DocumentReferenceType documentReferenceField;
	}
}

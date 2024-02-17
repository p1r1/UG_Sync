using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000382 RID: 898
	[XmlInclude(typeof(VideoType))]
	[XmlInclude(typeof(SoundType))]
	[XmlInclude(typeof(PictureType))]
	[XmlInclude(typeof(GraphicType))]
	[XmlInclude(typeof(BinaryObjectType1))]
	[XmlInclude(typeof(EmbeddedDocumentBinaryObjectType))]
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
	[Serializable]
	public class BinaryObjectType
	{
		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x000039B1 File Offset: 0x00001BB1
		// (set) Token: 0x06000698 RID: 1688 RVA: 0x000039B9 File Offset: 0x00001BB9
		[XmlAttribute]
		public string format
		{
			get
			{
				return this.formatField;
			}
			set
			{
				this.formatField = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x000039C2 File Offset: 0x00001BC2
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x000039CA File Offset: 0x00001BCA
		[XmlAttribute(DataType = "normalizedString")]
		public string mimeCode
		{
			get
			{
				return this.mimeCodeField;
			}
			set
			{
				this.mimeCodeField = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x000039D3 File Offset: 0x00001BD3
		// (set) Token: 0x0600069C RID: 1692 RVA: 0x000039DB File Offset: 0x00001BDB
		[XmlAttribute(DataType = "normalizedString")]
		public string encodingCode
		{
			get
			{
				return this.encodingCodeField;
			}
			set
			{
				this.encodingCodeField = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x000039E4 File Offset: 0x00001BE4
		// (set) Token: 0x0600069E RID: 1694 RVA: 0x000039EC File Offset: 0x00001BEC
		[XmlAttribute(DataType = "normalizedString")]
		public string characterSetCode
		{
			get
			{
				return this.characterSetCodeField;
			}
			set
			{
				this.characterSetCodeField = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x000039F5 File Offset: 0x00001BF5
		// (set) Token: 0x060006A0 RID: 1696 RVA: 0x000039FD File Offset: 0x00001BFD
		[XmlAttribute(DataType = "anyURI")]
		public string uri
		{
			get
			{
				return this.uriField;
			}
			set
			{
				this.uriField = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00003A06 File Offset: 0x00001C06
		// (set) Token: 0x060006A2 RID: 1698 RVA: 0x00003A0E File Offset: 0x00001C0E
		[XmlAttribute]
		public string filename
		{
			get
			{
				return this.filenameField;
			}
			set
			{
				this.filenameField = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x00003A17 File Offset: 0x00001C17
		// (set) Token: 0x060006A4 RID: 1700 RVA: 0x00003A1F File Offset: 0x00001C1F
		[XmlText(DataType = "base64Binary")]
		public byte[] Value
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

		// Token: 0x040001AF RID: 431
		private string formatField;

		// Token: 0x040001B0 RID: 432
		private string mimeCodeField;

		// Token: 0x040001B1 RID: 433
		private string encodingCodeField;

		// Token: 0x040001B2 RID: 434
		private string characterSetCodeField;

		// Token: 0x040001B3 RID: 435
		private string uriField;

		// Token: 0x040001B4 RID: 436
		private string filenameField;

		// Token: 0x040001B5 RID: 437
		private byte[] valueField;
	}
}

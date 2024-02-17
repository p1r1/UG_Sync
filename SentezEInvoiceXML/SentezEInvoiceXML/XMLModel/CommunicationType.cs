using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200037C RID: 892
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("Communication", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class CommunicationType
	{
		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x0000383C File Offset: 0x00001A3C
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x00003844 File Offset: 0x00001A44
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ChannelCodeType ChannelCode
		{
			get
			{
				return this.channelCodeField;
			}
			set
			{
				this.channelCodeField = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x0000384D File Offset: 0x00001A4D
		// (set) Token: 0x0600066A RID: 1642 RVA: 0x00003855 File Offset: 0x00001A55
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ChannelType Channel
		{
			get
			{
				return this.channelField;
			}
			set
			{
				this.channelField = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x0000385E File Offset: 0x00001A5E
		// (set) Token: 0x0600066C RID: 1644 RVA: 0x00003866 File Offset: 0x00001A66
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

		// Token: 0x0400019A RID: 410
		private ChannelCodeType channelCodeField;

		// Token: 0x0400019B RID: 411
		private ChannelType channelField;

		// Token: 0x0400019C RID: 412
		private ValueType valueField;
	}
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003FF RID: 1023
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("DiscrepancyResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ResponseType
	{
		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x00005176 File Offset: 0x00003376
		// (set) Token: 0x060009DF RID: 2527 RVA: 0x0000517E File Offset: 0x0000337E
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ReferenceIDType ReferenceID
		{
			get
			{
				return this.referenceIDField;
			}
			set
			{
				this.referenceIDField = value;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x00005187 File Offset: 0x00003387
		// (set) Token: 0x060009E1 RID: 2529 RVA: 0x0000518F File Offset: 0x0000338F
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ResponseCodeType ResponseCode
		{
			get
			{
				return this.responseCodeField;
			}
			set
			{
				this.responseCodeField = value;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x00005198 File Offset: 0x00003398
		// (set) Token: 0x060009E3 RID: 2531 RVA: 0x000051A0 File Offset: 0x000033A0
		[XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DescriptionType[] Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		// Token: 0x04000314 RID: 788
		private ReferenceIDType referenceIDField;

		// Token: 0x04000315 RID: 789
		private ResponseCodeType responseCodeField;

		// Token: 0x04000316 RID: 790
		private DescriptionType[] descriptionField;
	}
}

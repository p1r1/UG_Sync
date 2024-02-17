using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003DA RID: 986
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("AttachedTransportEquipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class TransportEquipmentType
	{
		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x0000432F File Offset: 0x0000252F
		// (set) Token: 0x0600080C RID: 2060 RVA: 0x00004337 File Offset: 0x00002537
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IDType ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x00004340 File Offset: 0x00002540
		// (set) Token: 0x0600080E RID: 2062 RVA: 0x00004348 File Offset: 0x00002548
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TransportEquipmentTypeCodeType TransportEquipmentTypeCode
		{
			get
			{
				return this.transportEquipmentTypeCodeField;
			}
			set
			{
				this.transportEquipmentTypeCodeField = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00004351 File Offset: 0x00002551
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x00004359 File Offset: 0x00002559
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DescriptionType Description
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

		// Token: 0x0400023D RID: 573
		private IDType idField;

		// Token: 0x0400023E RID: 574
		private TransportEquipmentTypeCodeType transportEquipmentTypeCodeField;

		// Token: 0x0400023F RID: 575
		private DescriptionType descriptionField;
	}
}

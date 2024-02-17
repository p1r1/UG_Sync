using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003D9 RID: 985
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("GoodsItemContainer", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class GoodsItemContainerType
	{
		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x000042FC File Offset: 0x000024FC
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x00004304 File Offset: 0x00002504
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

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x0000430D File Offset: 0x0000250D
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x00004315 File Offset: 0x00002515
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType2 Quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x0000431E File Offset: 0x0000251E
		// (set) Token: 0x06000809 RID: 2057 RVA: 0x00004326 File Offset: 0x00002526
		[XmlElement("TransportEquipment")]
		public TransportEquipmentType[] TransportEquipment
		{
			get
			{
				return this.transportEquipmentField;
			}
			set
			{
				this.transportEquipmentField = value;
			}
		}

		// Token: 0x0400023A RID: 570
		private IDType idField;

		// Token: 0x0400023B RID: 571
		private QuantityType2 quantityField;

		// Token: 0x0400023C RID: 572
		private TransportEquipmentType[] transportEquipmentField;
	}
}

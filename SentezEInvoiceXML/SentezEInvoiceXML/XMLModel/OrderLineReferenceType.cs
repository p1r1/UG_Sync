using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003DD RID: 989
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("OrderLineReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class OrderLineReferenceType
	{
		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x000044C7 File Offset: 0x000026C7
		// (set) Token: 0x0600083F RID: 2111 RVA: 0x000044CF File Offset: 0x000026CF
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

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000840 RID: 2112 RVA: 0x000044D8 File Offset: 0x000026D8
		// (set) Token: 0x06000841 RID: 2113 RVA: 0x000044E0 File Offset: 0x000026E0
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SalesOrderLineIDType SalesOrderLineID
		{
			get
			{
				return this.salesOrderLineIDField;
			}
			set
			{
				this.salesOrderLineIDField = value;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x000044E9 File Offset: 0x000026E9
		// (set) Token: 0x06000843 RID: 2115 RVA: 0x000044F1 File Offset: 0x000026F1
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public UUIDType UUID
		{
			get
			{
				return this.uUIDField;
			}
			set
			{
				this.uUIDField = value;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x000044FA File Offset: 0x000026FA
		// (set) Token: 0x06000845 RID: 2117 RVA: 0x00004502 File Offset: 0x00002702
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

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x0000450B File Offset: 0x0000270B
		// (set) Token: 0x06000847 RID: 2119 RVA: 0x00004513 File Offset: 0x00002713
		public OrderReferenceType OrderReference
		{
			get
			{
				return this.orderReferenceField;
			}
			set
			{
				this.orderReferenceField = value;
			}
		}

		// Token: 0x04000255 RID: 597
		private LineIDType lineIDField;

		// Token: 0x04000256 RID: 598
		private SalesOrderLineIDType salesOrderLineIDField;

		// Token: 0x04000257 RID: 599
		private UUIDType uUIDField;

		// Token: 0x04000258 RID: 600
		private LineStatusCodeType lineStatusCodeField;

		// Token: 0x04000259 RID: 601
		private OrderReferenceType orderReferenceField;
	}
}

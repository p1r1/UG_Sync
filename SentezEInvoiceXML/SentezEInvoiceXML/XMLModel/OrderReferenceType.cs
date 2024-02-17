using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003DE RID: 990
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("OrderReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class OrderReferenceType
	{
		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x0000451C File Offset: 0x0000271C
		// (set) Token: 0x0600084A RID: 2122 RVA: 0x00004524 File Offset: 0x00002724
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

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x0000452D File Offset: 0x0000272D
		// (set) Token: 0x0600084C RID: 2124 RVA: 0x00004535 File Offset: 0x00002735
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SalesOrderIDType SalesOrderID
		{
			get
			{
				return this.salesOrderIDField;
			}
			set
			{
				this.salesOrderIDField = value;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x0000453E File Offset: 0x0000273E
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x00004546 File Offset: 0x00002746
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IssueDateType IssueDate
		{
			get
			{
				return this.issueDateField;
			}
			set
			{
				this.issueDateField = value;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x0000454F File Offset: 0x0000274F
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x00004557 File Offset: 0x00002757
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public OrderTypeCodeType OrderTypeCode
		{
			get
			{
				return this.orderTypeCodeField;
			}
			set
			{
				this.orderTypeCodeField = value;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x00004560 File Offset: 0x00002760
		// (set) Token: 0x06000852 RID: 2130 RVA: 0x00004568 File Offset: 0x00002768
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

		// Token: 0x0400025A RID: 602
		private IDType idField;

		// Token: 0x0400025B RID: 603
		private SalesOrderIDType salesOrderIDField;

		// Token: 0x0400025C RID: 604
		private IssueDateType issueDateField;

		// Token: 0x0400025D RID: 605
		private OrderTypeCodeType orderTypeCodeField;

		// Token: 0x0400025E RID: 606
		private DocumentReferenceType documentReferenceField;
	}
}

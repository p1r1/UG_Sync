using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000449 RID: 1097
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ConsumptionLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ConsumptionLineType
	{
		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x00007871 File Offset: 0x00005A71
		// (set) Token: 0x06000EBF RID: 3775 RVA: 0x00007879 File Offset: 0x00005A79
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

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x00007882 File Offset: 0x00005A82
		// (set) Token: 0x06000EC1 RID: 3777 RVA: 0x0000788A File Offset: 0x00005A8A
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ParentDocumentLineReferenceIDType ParentDocumentLineReferenceID
		{
			get
			{
				return this.parentDocumentLineReferenceIDField;
			}
			set
			{
				this.parentDocumentLineReferenceIDField = value;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x00007893 File Offset: 0x00005A93
		// (set) Token: 0x06000EC3 RID: 3779 RVA: 0x0000789B File Offset: 0x00005A9B
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public InvoicedQuantityType InvoicedQuantity
		{
			get
			{
				return this.invoicedQuantityField;
			}
			set
			{
				this.invoicedQuantityField = value;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x000078A4 File Offset: 0x00005AA4
		// (set) Token: 0x06000EC5 RID: 3781 RVA: 0x000078AC File Offset: 0x00005AAC
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LineExtensionAmountType LineExtensionAmount
		{
			get
			{
				return this.lineExtensionAmountField;
			}
			set
			{
				this.lineExtensionAmountField = value;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x000078B5 File Offset: 0x00005AB5
		// (set) Token: 0x06000EC7 RID: 3783 RVA: 0x000078BD File Offset: 0x00005ABD
		public PeriodType Period
		{
			get
			{
				return this.periodField;
			}
			set
			{
				this.periodField = value;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x000078C6 File Offset: 0x00005AC6
		// (set) Token: 0x06000EC9 RID: 3785 RVA: 0x000078CE File Offset: 0x00005ACE
		[XmlElement("Delivery")]
		public DeliveryType[] Delivery
		{
			get
			{
				return this.deliveryField;
			}
			set
			{
				this.deliveryField = value;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x000078D7 File Offset: 0x00005AD7
		// (set) Token: 0x06000ECB RID: 3787 RVA: 0x000078DF File Offset: 0x00005ADF
		[XmlElement("AllowanceCharge")]
		public AllowanceChargeType[] AllowanceCharge
		{
			get
			{
				return this.allowanceChargeField;
			}
			set
			{
				this.allowanceChargeField = value;
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000ECC RID: 3788 RVA: 0x000078E8 File Offset: 0x00005AE8
		// (set) Token: 0x06000ECD RID: 3789 RVA: 0x000078F0 File Offset: 0x00005AF0
		[XmlElement("TaxTotal")]
		public TaxTotalType[] TaxTotal
		{
			get
			{
				return this.taxTotalField;
			}
			set
			{
				this.taxTotalField = value;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000ECE RID: 3790 RVA: 0x000078F9 File Offset: 0x00005AF9
		// (set) Token: 0x06000ECF RID: 3791 RVA: 0x00007901 File Offset: 0x00005B01
		public UtilityItemType UtilityItem
		{
			get
			{
				return this.utilityItemField;
			}
			set
			{
				this.utilityItemField = value;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x0000790A File Offset: 0x00005B0A
		// (set) Token: 0x06000ED1 RID: 3793 RVA: 0x00007912 File Offset: 0x00005B12
		public PriceType Price
		{
			get
			{
				return this.priceField;
			}
			set
			{
				this.priceField = value;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x0000791B File Offset: 0x00005B1B
		// (set) Token: 0x06000ED3 RID: 3795 RVA: 0x00007923 File Offset: 0x00005B23
		public UnstructuredPriceType UnstructuredPrice
		{
			get
			{
				return this.unstructuredPriceField;
			}
			set
			{
				this.unstructuredPriceField = value;
			}
		}

		// Token: 0x0400055F RID: 1375
		private IDType idField;

		// Token: 0x04000560 RID: 1376
		private ParentDocumentLineReferenceIDType parentDocumentLineReferenceIDField;

		// Token: 0x04000561 RID: 1377
		private InvoicedQuantityType invoicedQuantityField;

		// Token: 0x04000562 RID: 1378
		private LineExtensionAmountType lineExtensionAmountField;

		// Token: 0x04000563 RID: 1379
		private PeriodType periodField;

		// Token: 0x04000564 RID: 1380
		private DeliveryType[] deliveryField;

		// Token: 0x04000565 RID: 1381
		private AllowanceChargeType[] allowanceChargeField;

		// Token: 0x04000566 RID: 1382
		private TaxTotalType[] taxTotalField;

		// Token: 0x04000567 RID: 1383
		private UtilityItemType utilityItemField;

		// Token: 0x04000568 RID: 1384
		private PriceType priceField;

		// Token: 0x04000569 RID: 1385
		private UnstructuredPriceType unstructuredPriceField;
	}
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200042E RID: 1070
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("RequestForTenderLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class RequestForTenderLineType
	{
		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x0000681B File Offset: 0x00004A1B
		// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x00006823 File Offset: 0x00004A23
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

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x0000682C File Offset: 0x00004A2C
		// (set) Token: 0x06000CBA RID: 3258 RVA: 0x00006834 File Offset: 0x00004A34
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

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x0000683D File Offset: 0x00004A3D
		// (set) Token: 0x06000CBC RID: 3260 RVA: 0x00006845 File Offset: 0x00004A45
		[XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NoteType[] Note
		{
			get
			{
				return this.noteField;
			}
			set
			{
				this.noteField = value;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x0000684E File Offset: 0x00004A4E
		// (set) Token: 0x06000CBE RID: 3262 RVA: 0x00006856 File Offset: 0x00004A56
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

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x0000685F File Offset: 0x00004A5F
		// (set) Token: 0x06000CC0 RID: 3264 RVA: 0x00006867 File Offset: 0x00004A67
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MinimumQuantityType MinimumQuantity
		{
			get
			{
				return this.minimumQuantityField;
			}
			set
			{
				this.minimumQuantityField = value;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x00006870 File Offset: 0x00004A70
		// (set) Token: 0x06000CC2 RID: 3266 RVA: 0x00006878 File Offset: 0x00004A78
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MaximumQuantityType MaximumQuantity
		{
			get
			{
				return this.maximumQuantityField;
			}
			set
			{
				this.maximumQuantityField = value;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x00006881 File Offset: 0x00004A81
		// (set) Token: 0x06000CC4 RID: 3268 RVA: 0x00006889 File Offset: 0x00004A89
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TaxIncludedIndicatorType TaxIncludedIndicator
		{
			get
			{
				return this.taxIncludedIndicatorField;
			}
			set
			{
				this.taxIncludedIndicatorField = value;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x00006892 File Offset: 0x00004A92
		// (set) Token: 0x06000CC6 RID: 3270 RVA: 0x0000689A File Offset: 0x00004A9A
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MinimumAmountType MinimumAmount
		{
			get
			{
				return this.minimumAmountField;
			}
			set
			{
				this.minimumAmountField = value;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x000068A3 File Offset: 0x00004AA3
		// (set) Token: 0x06000CC8 RID: 3272 RVA: 0x000068AB File Offset: 0x00004AAB
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MaximumAmountType MaximumAmount
		{
			get
			{
				return this.maximumAmountField;
			}
			set
			{
				this.maximumAmountField = value;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x000068B4 File Offset: 0x00004AB4
		// (set) Token: 0x06000CCA RID: 3274 RVA: 0x000068BC File Offset: 0x00004ABC
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public EstimatedAmountType EstimatedAmount
		{
			get
			{
				return this.estimatedAmountField;
			}
			set
			{
				this.estimatedAmountField = value;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x000068C5 File Offset: 0x00004AC5
		// (set) Token: 0x06000CCC RID: 3276 RVA: 0x000068CD File Offset: 0x00004ACD
		[XmlElement("DocumentReference")]
		public DocumentReferenceType[] DocumentReference
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

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x000068D6 File Offset: 0x00004AD6
		// (set) Token: 0x06000CCE RID: 3278 RVA: 0x000068DE File Offset: 0x00004ADE
		[XmlElement("DeliveryPeriod")]
		public PeriodType[] DeliveryPeriod
		{
			get
			{
				return this.deliveryPeriodField;
			}
			set
			{
				this.deliveryPeriodField = value;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x000068E7 File Offset: 0x00004AE7
		// (set) Token: 0x06000CD0 RID: 3280 RVA: 0x000068EF File Offset: 0x00004AEF
		[XmlElement("RequiredItemLocationQuantity")]
		public ItemLocationQuantityType[] RequiredItemLocationQuantity
		{
			get
			{
				return this.requiredItemLocationQuantityField;
			}
			set
			{
				this.requiredItemLocationQuantityField = value;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x000068F8 File Offset: 0x00004AF8
		// (set) Token: 0x06000CD2 RID: 3282 RVA: 0x00006900 File Offset: 0x00004B00
		public PeriodType WarrantyValidityPeriod
		{
			get
			{
				return this.warrantyValidityPeriodField;
			}
			set
			{
				this.warrantyValidityPeriodField = value;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x00006909 File Offset: 0x00004B09
		// (set) Token: 0x06000CD4 RID: 3284 RVA: 0x00006911 File Offset: 0x00004B11
		public ItemType Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x0000691A File Offset: 0x00004B1A
		// (set) Token: 0x06000CD6 RID: 3286 RVA: 0x00006922 File Offset: 0x00004B22
		[XmlElement("SubRequestForTenderLine")]
		public RequestForTenderLineType[] SubRequestForTenderLine
		{
			get
			{
				return this.subRequestForTenderLineField;
			}
			set
			{
				this.subRequestForTenderLineField = value;
			}
		}

		// Token: 0x04000469 RID: 1129
		private IDType idField;

		// Token: 0x0400046A RID: 1130
		private UUIDType uUIDField;

		// Token: 0x0400046B RID: 1131
		private NoteType[] noteField;

		// Token: 0x0400046C RID: 1132
		private QuantityType2 quantityField;

		// Token: 0x0400046D RID: 1133
		private MinimumQuantityType minimumQuantityField;

		// Token: 0x0400046E RID: 1134
		private MaximumQuantityType maximumQuantityField;

		// Token: 0x0400046F RID: 1135
		private TaxIncludedIndicatorType taxIncludedIndicatorField;

		// Token: 0x04000470 RID: 1136
		private MinimumAmountType minimumAmountField;

		// Token: 0x04000471 RID: 1137
		private MaximumAmountType maximumAmountField;

		// Token: 0x04000472 RID: 1138
		private EstimatedAmountType estimatedAmountField;

		// Token: 0x04000473 RID: 1139
		private DocumentReferenceType[] documentReferenceField;

		// Token: 0x04000474 RID: 1140
		private PeriodType[] deliveryPeriodField;

		// Token: 0x04000475 RID: 1141
		private ItemLocationQuantityType[] requiredItemLocationQuantityField;

		// Token: 0x04000476 RID: 1142
		private PeriodType warrantyValidityPeriodField;

		// Token: 0x04000477 RID: 1143
		private ItemType itemField;

		// Token: 0x04000478 RID: 1144
		private RequestForTenderLineType[] subRequestForTenderLineField;
	}
}

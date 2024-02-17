using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200042A RID: 1066
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ProcurementProject", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ProcurementProjectType
	{
		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x000065EA File Offset: 0x000047EA
		// (set) Token: 0x06000C72 RID: 3186 RVA: 0x000065F2 File Offset: 0x000047F2
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

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x000065FB File Offset: 0x000047FB
		// (set) Token: 0x06000C74 RID: 3188 RVA: 0x00006603 File Offset: 0x00004803
		[XmlElement("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NameType1[] Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x0000660C File Offset: 0x0000480C
		// (set) Token: 0x06000C76 RID: 3190 RVA: 0x00006614 File Offset: 0x00004814
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

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x0000661D File Offset: 0x0000481D
		// (set) Token: 0x06000C78 RID: 3192 RVA: 0x00006625 File Offset: 0x00004825
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ProcurementTypeCodeType ProcurementTypeCode
		{
			get
			{
				return this.procurementTypeCodeField;
			}
			set
			{
				this.procurementTypeCodeField = value;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x0000662E File Offset: 0x0000482E
		// (set) Token: 0x06000C7A RID: 3194 RVA: 0x00006636 File Offset: 0x00004836
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ProcurementSubTypeCodeType ProcurementSubTypeCode
		{
			get
			{
				return this.procurementSubTypeCodeField;
			}
			set
			{
				this.procurementSubTypeCodeField = value;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x0000663F File Offset: 0x0000483F
		// (set) Token: 0x06000C7C RID: 3196 RVA: 0x00006647 File Offset: 0x00004847
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QualityControlCodeType QualityControlCode
		{
			get
			{
				return this.qualityControlCodeField;
			}
			set
			{
				this.qualityControlCodeField = value;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x00006650 File Offset: 0x00004850
		// (set) Token: 0x06000C7E RID: 3198 RVA: 0x00006658 File Offset: 0x00004858
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public RequiredFeeAmountType RequiredFeeAmount
		{
			get
			{
				return this.requiredFeeAmountField;
			}
			set
			{
				this.requiredFeeAmountField = value;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000C7F RID: 3199 RVA: 0x00006661 File Offset: 0x00004861
		// (set) Token: 0x06000C80 RID: 3200 RVA: 0x00006669 File Offset: 0x00004869
		[XmlElement("FeeDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public FeeDescriptionType[] FeeDescription
		{
			get
			{
				return this.feeDescriptionField;
			}
			set
			{
				this.feeDescriptionField = value;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x00006672 File Offset: 0x00004872
		// (set) Token: 0x06000C82 RID: 3202 RVA: 0x0000667A File Offset: 0x0000487A
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public RequestedDeliveryDateType RequestedDeliveryDate
		{
			get
			{
				return this.requestedDeliveryDateField;
			}
			set
			{
				this.requestedDeliveryDateField = value;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x00006683 File Offset: 0x00004883
		// (set) Token: 0x06000C84 RID: 3204 RVA: 0x0000668B File Offset: 0x0000488B
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public EstimatedOverallContractQuantityType EstimatedOverallContractQuantity
		{
			get
			{
				return this.estimatedOverallContractQuantityField;
			}
			set
			{
				this.estimatedOverallContractQuantityField = value;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x00006694 File Offset: 0x00004894
		// (set) Token: 0x06000C86 RID: 3206 RVA: 0x0000669C File Offset: 0x0000489C
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

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x000066A5 File Offset: 0x000048A5
		// (set) Token: 0x06000C88 RID: 3208 RVA: 0x000066AD File Offset: 0x000048AD
		public RequestedTenderTotalType RequestedTenderTotal
		{
			get
			{
				return this.requestedTenderTotalField;
			}
			set
			{
				this.requestedTenderTotalField = value;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000C89 RID: 3209 RVA: 0x000066B6 File Offset: 0x000048B6
		// (set) Token: 0x06000C8A RID: 3210 RVA: 0x000066BE File Offset: 0x000048BE
		public CommodityClassificationType MainCommodityClassification
		{
			get
			{
				return this.mainCommodityClassificationField;
			}
			set
			{
				this.mainCommodityClassificationField = value;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000C8B RID: 3211 RVA: 0x000066C7 File Offset: 0x000048C7
		// (set) Token: 0x06000C8C RID: 3212 RVA: 0x000066CF File Offset: 0x000048CF
		[XmlElement("AdditionalCommodityClassification")]
		public CommodityClassificationType[] AdditionalCommodityClassification
		{
			get
			{
				return this.additionalCommodityClassificationField;
			}
			set
			{
				this.additionalCommodityClassificationField = value;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000C8D RID: 3213 RVA: 0x000066D8 File Offset: 0x000048D8
		// (set) Token: 0x06000C8E RID: 3214 RVA: 0x000066E0 File Offset: 0x000048E0
		[XmlElement("RealizedLocation")]
		public LocationType1[] RealizedLocation
		{
			get
			{
				return this.realizedLocationField;
			}
			set
			{
				this.realizedLocationField = value;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000C8F RID: 3215 RVA: 0x000066E9 File Offset: 0x000048E9
		// (set) Token: 0x06000C90 RID: 3216 RVA: 0x000066F1 File Offset: 0x000048F1
		public PeriodType PlannedPeriod
		{
			get
			{
				return this.plannedPeriodField;
			}
			set
			{
				this.plannedPeriodField = value;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000C91 RID: 3217 RVA: 0x000066FA File Offset: 0x000048FA
		// (set) Token: 0x06000C92 RID: 3218 RVA: 0x00006702 File Offset: 0x00004902
		public ContractExtensionType ContractExtension
		{
			get
			{
				return this.contractExtensionField;
			}
			set
			{
				this.contractExtensionField = value;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x0000670B File Offset: 0x0000490B
		// (set) Token: 0x06000C94 RID: 3220 RVA: 0x00006713 File Offset: 0x00004913
		[XmlElement("RequestForTenderLine")]
		public RequestForTenderLineType[] RequestForTenderLine
		{
			get
			{
				return this.requestForTenderLineField;
			}
			set
			{
				this.requestForTenderLineField = value;
			}
		}

		// Token: 0x04000448 RID: 1096
		private IDType idField;

		// Token: 0x04000449 RID: 1097
		private NameType1[] nameField;

		// Token: 0x0400044A RID: 1098
		private DescriptionType[] descriptionField;

		// Token: 0x0400044B RID: 1099
		private ProcurementTypeCodeType procurementTypeCodeField;

		// Token: 0x0400044C RID: 1100
		private ProcurementSubTypeCodeType procurementSubTypeCodeField;

		// Token: 0x0400044D RID: 1101
		private QualityControlCodeType qualityControlCodeField;

		// Token: 0x0400044E RID: 1102
		private RequiredFeeAmountType requiredFeeAmountField;

		// Token: 0x0400044F RID: 1103
		private FeeDescriptionType[] feeDescriptionField;

		// Token: 0x04000450 RID: 1104
		private RequestedDeliveryDateType requestedDeliveryDateField;

		// Token: 0x04000451 RID: 1105
		private EstimatedOverallContractQuantityType estimatedOverallContractQuantityField;

		// Token: 0x04000452 RID: 1106
		private NoteType[] noteField;

		// Token: 0x04000453 RID: 1107
		private RequestedTenderTotalType requestedTenderTotalField;

		// Token: 0x04000454 RID: 1108
		private CommodityClassificationType mainCommodityClassificationField;

		// Token: 0x04000455 RID: 1109
		private CommodityClassificationType[] additionalCommodityClassificationField;

		// Token: 0x04000456 RID: 1110
		private LocationType1[] realizedLocationField;

		// Token: 0x04000457 RID: 1111
		private PeriodType plannedPeriodField;

		// Token: 0x04000458 RID: 1112
		private ContractExtensionType contractExtensionField;

		// Token: 0x04000459 RID: 1113
		private RequestForTenderLineType[] requestForTenderLineField;
	}
}

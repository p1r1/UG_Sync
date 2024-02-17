using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000463 RID: 1123
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ExceptionNotificationLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ExceptionNotificationLineType
	{
		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x0600106C RID: 4204 RVA: 0x000085DB File Offset: 0x000067DB
		// (set) Token: 0x0600106D RID: 4205 RVA: 0x000085E3 File Offset: 0x000067E3
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

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x0600106E RID: 4206 RVA: 0x000085EC File Offset: 0x000067EC
		// (set) Token: 0x0600106F RID: 4207 RVA: 0x000085F4 File Offset: 0x000067F4
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

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001070 RID: 4208 RVA: 0x000085FD File Offset: 0x000067FD
		// (set) Token: 0x06001071 RID: 4209 RVA: 0x00008605 File Offset: 0x00006805
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

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001072 RID: 4210 RVA: 0x0000860E File Offset: 0x0000680E
		// (set) Token: 0x06001073 RID: 4211 RVA: 0x00008616 File Offset: 0x00006816
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ExceptionStatusCodeType ExceptionStatusCode
		{
			get
			{
				return this.exceptionStatusCodeField;
			}
			set
			{
				this.exceptionStatusCodeField = value;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001074 RID: 4212 RVA: 0x0000861F File Offset: 0x0000681F
		// (set) Token: 0x06001075 RID: 4213 RVA: 0x00008627 File Offset: 0x00006827
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CollaborationPriorityCodeType CollaborationPriorityCode
		{
			get
			{
				return this.collaborationPriorityCodeField;
			}
			set
			{
				this.collaborationPriorityCodeField = value;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001076 RID: 4214 RVA: 0x00008630 File Offset: 0x00006830
		// (set) Token: 0x06001077 RID: 4215 RVA: 0x00008638 File Offset: 0x00006838
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ResolutionCodeType ResolutionCode
		{
			get
			{
				return this.resolutionCodeField;
			}
			set
			{
				this.resolutionCodeField = value;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001078 RID: 4216 RVA: 0x00008641 File Offset: 0x00006841
		// (set) Token: 0x06001079 RID: 4217 RVA: 0x00008649 File Offset: 0x00006849
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ComparedValueMeasureType ComparedValueMeasure
		{
			get
			{
				return this.comparedValueMeasureField;
			}
			set
			{
				this.comparedValueMeasureField = value;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x0600107A RID: 4218 RVA: 0x00008652 File Offset: 0x00006852
		// (set) Token: 0x0600107B RID: 4219 RVA: 0x0000865A File Offset: 0x0000685A
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SourceValueMeasureType SourceValueMeasure
		{
			get
			{
				return this.sourceValueMeasureField;
			}
			set
			{
				this.sourceValueMeasureField = value;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x0600107C RID: 4220 RVA: 0x00008663 File Offset: 0x00006863
		// (set) Token: 0x0600107D RID: 4221 RVA: 0x0000866B File Offset: 0x0000686B
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public VarianceQuantityType VarianceQuantity
		{
			get
			{
				return this.varianceQuantityField;
			}
			set
			{
				this.varianceQuantityField = value;
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x0600107E RID: 4222 RVA: 0x00008674 File Offset: 0x00006874
		// (set) Token: 0x0600107F RID: 4223 RVA: 0x0000867C File Offset: 0x0000687C
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SupplyChainActivityTypeCodeType SupplyChainActivityTypeCode
		{
			get
			{
				return this.supplyChainActivityTypeCodeField;
			}
			set
			{
				this.supplyChainActivityTypeCodeField = value;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001080 RID: 4224 RVA: 0x00008685 File Offset: 0x00006885
		// (set) Token: 0x06001081 RID: 4225 RVA: 0x0000868D File Offset: 0x0000688D
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PerformanceMetricTypeCodeType PerformanceMetricTypeCode
		{
			get
			{
				return this.performanceMetricTypeCodeField;
			}
			set
			{
				this.performanceMetricTypeCodeField = value;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001082 RID: 4226 RVA: 0x00008696 File Offset: 0x00006896
		// (set) Token: 0x06001083 RID: 4227 RVA: 0x0000869E File Offset: 0x0000689E
		public PeriodType ExceptionObservationPeriod
		{
			get
			{
				return this.exceptionObservationPeriodField;
			}
			set
			{
				this.exceptionObservationPeriodField = value;
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001084 RID: 4228 RVA: 0x000086A7 File Offset: 0x000068A7
		// (set) Token: 0x06001085 RID: 4229 RVA: 0x000086AF File Offset: 0x000068AF
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

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001086 RID: 4230 RVA: 0x000086B8 File Offset: 0x000068B8
		// (set) Token: 0x06001087 RID: 4231 RVA: 0x000086C0 File Offset: 0x000068C0
		public ForecastExceptionType ForecastException
		{
			get
			{
				return this.forecastExceptionField;
			}
			set
			{
				this.forecastExceptionField = value;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001088 RID: 4232 RVA: 0x000086C9 File Offset: 0x000068C9
		// (set) Token: 0x06001089 RID: 4233 RVA: 0x000086D1 File Offset: 0x000068D1
		public ItemType SupplyItem
		{
			get
			{
				return this.supplyItemField;
			}
			set
			{
				this.supplyItemField = value;
			}
		}

		// Token: 0x04000629 RID: 1577
		private IDType idField;

		// Token: 0x0400062A RID: 1578
		private NoteType[] noteField;

		// Token: 0x0400062B RID: 1579
		private DescriptionType[] descriptionField;

		// Token: 0x0400062C RID: 1580
		private ExceptionStatusCodeType exceptionStatusCodeField;

		// Token: 0x0400062D RID: 1581
		private CollaborationPriorityCodeType collaborationPriorityCodeField;

		// Token: 0x0400062E RID: 1582
		private ResolutionCodeType resolutionCodeField;

		// Token: 0x0400062F RID: 1583
		private ComparedValueMeasureType comparedValueMeasureField;

		// Token: 0x04000630 RID: 1584
		private SourceValueMeasureType sourceValueMeasureField;

		// Token: 0x04000631 RID: 1585
		private VarianceQuantityType varianceQuantityField;

		// Token: 0x04000632 RID: 1586
		private SupplyChainActivityTypeCodeType supplyChainActivityTypeCodeField;

		// Token: 0x04000633 RID: 1587
		private PerformanceMetricTypeCodeType performanceMetricTypeCodeField;

		// Token: 0x04000634 RID: 1588
		private PeriodType exceptionObservationPeriodField;

		// Token: 0x04000635 RID: 1589
		private DocumentReferenceType[] documentReferenceField;

		// Token: 0x04000636 RID: 1590
		private ForecastExceptionType forecastExceptionField;

		// Token: 0x04000637 RID: 1591
		private ItemType supplyItemField;
	}
}

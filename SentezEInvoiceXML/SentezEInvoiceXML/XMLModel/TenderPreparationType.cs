using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000423 RID: 1059
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("TenderPreparation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class TenderPreparationType
	{
		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x00006320 File Offset: 0x00004520
		// (set) Token: 0x06000C17 RID: 3095 RVA: 0x00006328 File Offset: 0x00004528
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TenderEnvelopeIDType TenderEnvelopeID
		{
			get
			{
				return this.tenderEnvelopeIDField;
			}
			set
			{
				this.tenderEnvelopeIDField = value;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000C18 RID: 3096 RVA: 0x00006331 File Offset: 0x00004531
		// (set) Token: 0x06000C19 RID: 3097 RVA: 0x00006339 File Offset: 0x00004539
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TenderEnvelopeTypeCodeType TenderEnvelopeTypeCode
		{
			get
			{
				return this.tenderEnvelopeTypeCodeField;
			}
			set
			{
				this.tenderEnvelopeTypeCodeField = value;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000C1A RID: 3098 RVA: 0x00006342 File Offset: 0x00004542
		// (set) Token: 0x06000C1B RID: 3099 RVA: 0x0000634A File Offset: 0x0000454A
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

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000C1C RID: 3100 RVA: 0x00006353 File Offset: 0x00004553
		// (set) Token: 0x06000C1D RID: 3101 RVA: 0x0000635B File Offset: 0x0000455B
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public OpenTenderIDType OpenTenderID
		{
			get
			{
				return this.openTenderIDField;
			}
			set
			{
				this.openTenderIDField = value;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000C1E RID: 3102 RVA: 0x00006364 File Offset: 0x00004564
		// (set) Token: 0x06000C1F RID: 3103 RVA: 0x0000636C File Offset: 0x0000456C
		[XmlElement("ProcurementProjectLot")]
		public ProcurementProjectLotType[] ProcurementProjectLot
		{
			get
			{
				return this.procurementProjectLotField;
			}
			set
			{
				this.procurementProjectLotField = value;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000C20 RID: 3104 RVA: 0x00006375 File Offset: 0x00004575
		// (set) Token: 0x06000C21 RID: 3105 RVA: 0x0000637D File Offset: 0x0000457D
		[XmlElement("DocumentTenderRequirement")]
		public TenderRequirementType[] DocumentTenderRequirement
		{
			get
			{
				return this.documentTenderRequirementField;
			}
			set
			{
				this.documentTenderRequirementField = value;
			}
		}

		// Token: 0x0400041E RID: 1054
		private TenderEnvelopeIDType tenderEnvelopeIDField;

		// Token: 0x0400041F RID: 1055
		private TenderEnvelopeTypeCodeType tenderEnvelopeTypeCodeField;

		// Token: 0x04000420 RID: 1056
		private DescriptionType[] descriptionField;

		// Token: 0x04000421 RID: 1057
		private OpenTenderIDType openTenderIDField;

		// Token: 0x04000422 RID: 1058
		private ProcurementProjectLotType[] procurementProjectLotField;

		// Token: 0x04000423 RID: 1059
		private TenderRequirementType[] documentTenderRequirementField;
	}
}

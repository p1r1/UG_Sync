using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200044B RID: 1099
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("Contract", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ContractType
	{
		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x00007A2B File Offset: 0x00005C2B
		// (set) Token: 0x06000EF5 RID: 3829 RVA: 0x00007A33 File Offset: 0x00005C33
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

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x00007A3C File Offset: 0x00005C3C
		// (set) Token: 0x06000EF7 RID: 3831 RVA: 0x00007A44 File Offset: 0x00005C44
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

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x00007A4D File Offset: 0x00005C4D
		// (set) Token: 0x06000EF9 RID: 3833 RVA: 0x00007A55 File Offset: 0x00005C55
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IssueTimeType IssueTime
		{
			get
			{
				return this.issueTimeField;
			}
			set
			{
				this.issueTimeField = value;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000EFA RID: 3834 RVA: 0x00007A5E File Offset: 0x00005C5E
		// (set) Token: 0x06000EFB RID: 3835 RVA: 0x00007A66 File Offset: 0x00005C66
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NominationDateType NominationDate
		{
			get
			{
				return this.nominationDateField;
			}
			set
			{
				this.nominationDateField = value;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000EFC RID: 3836 RVA: 0x00007A6F File Offset: 0x00005C6F
		// (set) Token: 0x06000EFD RID: 3837 RVA: 0x00007A77 File Offset: 0x00005C77
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NominationTimeType NominationTime
		{
			get
			{
				return this.nominationTimeField;
			}
			set
			{
				this.nominationTimeField = value;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000EFE RID: 3838 RVA: 0x00007A80 File Offset: 0x00005C80
		// (set) Token: 0x06000EFF RID: 3839 RVA: 0x00007A88 File Offset: 0x00005C88
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ContractTypeCodeType ContractTypeCode
		{
			get
			{
				return this.contractTypeCodeField;
			}
			set
			{
				this.contractTypeCodeField = value;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x00007A91 File Offset: 0x00005C91
		// (set) Token: 0x06000F01 RID: 3841 RVA: 0x00007A99 File Offset: 0x00005C99
		[XmlElement("ContractType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ContractTypeType ContractType1
		{
			get
			{
				return this.contractType1Field;
			}
			set
			{
				this.contractType1Field = value;
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x00007AA2 File Offset: 0x00005CA2
		// (set) Token: 0x06000F03 RID: 3843 RVA: 0x00007AAA File Offset: 0x00005CAA
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

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000F04 RID: 3844 RVA: 0x00007AB3 File Offset: 0x00005CB3
		// (set) Token: 0x06000F05 RID: 3845 RVA: 0x00007ABB File Offset: 0x00005CBB
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public VersionIDType VersionID
		{
			get
			{
				return this.versionIDField;
			}
			set
			{
				this.versionIDField = value;
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000F06 RID: 3846 RVA: 0x00007AC4 File Offset: 0x00005CC4
		// (set) Token: 0x06000F07 RID: 3847 RVA: 0x00007ACC File Offset: 0x00005CCC
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

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000F08 RID: 3848 RVA: 0x00007AD5 File Offset: 0x00005CD5
		// (set) Token: 0x06000F09 RID: 3849 RVA: 0x00007ADD File Offset: 0x00005CDD
		public PeriodType ValidityPeriod
		{
			get
			{
				return this.validityPeriodField;
			}
			set
			{
				this.validityPeriodField = value;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000F0A RID: 3850 RVA: 0x00007AE6 File Offset: 0x00005CE6
		// (set) Token: 0x06000F0B RID: 3851 RVA: 0x00007AEE File Offset: 0x00005CEE
		[XmlElement("ContractDocumentReference")]
		public DocumentReferenceType[] ContractDocumentReference
		{
			get
			{
				return this.contractDocumentReferenceField;
			}
			set
			{
				this.contractDocumentReferenceField = value;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000F0C RID: 3852 RVA: 0x00007AF7 File Offset: 0x00005CF7
		// (set) Token: 0x06000F0D RID: 3853 RVA: 0x00007AFF File Offset: 0x00005CFF
		public PeriodType NominationPeriod
		{
			get
			{
				return this.nominationPeriodField;
			}
			set
			{
				this.nominationPeriodField = value;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x00007B08 File Offset: 0x00005D08
		// (set) Token: 0x06000F0F RID: 3855 RVA: 0x00007B10 File Offset: 0x00005D10
		public DeliveryType ContractualDelivery
		{
			get
			{
				return this.contractualDeliveryField;
			}
			set
			{
				this.contractualDeliveryField = value;
			}
		}

		// Token: 0x04000579 RID: 1401
		private IDType idField;

		// Token: 0x0400057A RID: 1402
		private IssueDateType issueDateField;

		// Token: 0x0400057B RID: 1403
		private IssueTimeType issueTimeField;

		// Token: 0x0400057C RID: 1404
		private NominationDateType nominationDateField;

		// Token: 0x0400057D RID: 1405
		private NominationTimeType nominationTimeField;

		// Token: 0x0400057E RID: 1406
		private ContractTypeCodeType contractTypeCodeField;

		// Token: 0x0400057F RID: 1407
		private ContractTypeType contractType1Field;

		// Token: 0x04000580 RID: 1408
		private NoteType[] noteField;

		// Token: 0x04000581 RID: 1409
		private VersionIDType versionIDField;

		// Token: 0x04000582 RID: 1410
		private DescriptionType[] descriptionField;

		// Token: 0x04000583 RID: 1411
		private PeriodType validityPeriodField;

		// Token: 0x04000584 RID: 1412
		private DocumentReferenceType[] contractDocumentReferenceField;

		// Token: 0x04000585 RID: 1413
		private PeriodType nominationPeriodField;

		// Token: 0x04000586 RID: 1414
		private DeliveryType contractualDeliveryField;
	}
}

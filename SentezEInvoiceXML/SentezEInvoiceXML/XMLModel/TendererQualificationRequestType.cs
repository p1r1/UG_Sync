using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200041E RID: 1054
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("TendererQualificationRequest", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class TendererQualificationRequestType
	{
		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x000060DE File Offset: 0x000042DE
		// (set) Token: 0x06000BCE RID: 3022 RVA: 0x000060E6 File Offset: 0x000042E6
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CompanyLegalFormCodeType CompanyLegalFormCode
		{
			get
			{
				return this.companyLegalFormCodeField;
			}
			set
			{
				this.companyLegalFormCodeField = value;
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x000060EF File Offset: 0x000042EF
		// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x000060F7 File Offset: 0x000042F7
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CompanyLegalFormType CompanyLegalForm
		{
			get
			{
				return this.companyLegalFormField;
			}
			set
			{
				this.companyLegalFormField = value;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x00006100 File Offset: 0x00004300
		// (set) Token: 0x06000BD2 RID: 3026 RVA: 0x00006108 File Offset: 0x00004308
		[XmlElement("PersonalSituation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PersonalSituationType[] PersonalSituation
		{
			get
			{
				return this.personalSituationField;
			}
			set
			{
				this.personalSituationField = value;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x00006111 File Offset: 0x00004311
		// (set) Token: 0x06000BD4 RID: 3028 RVA: 0x00006119 File Offset: 0x00004319
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public OperatingYearsQuantityType OperatingYearsQuantity
		{
			get
			{
				return this.operatingYearsQuantityField;
			}
			set
			{
				this.operatingYearsQuantityField = value;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000BD5 RID: 3029 RVA: 0x00006122 File Offset: 0x00004322
		// (set) Token: 0x06000BD6 RID: 3030 RVA: 0x0000612A File Offset: 0x0000432A
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public EmployeeQuantityType EmployeeQuantity
		{
			get
			{
				return this.employeeQuantityField;
			}
			set
			{
				this.employeeQuantityField = value;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x00006133 File Offset: 0x00004333
		// (set) Token: 0x06000BD8 RID: 3032 RVA: 0x0000613B File Offset: 0x0000433B
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

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x00006144 File Offset: 0x00004344
		// (set) Token: 0x06000BDA RID: 3034 RVA: 0x0000614C File Offset: 0x0000434C
		[XmlElement("RequiredBusinessClassificationScheme")]
		public ClassificationSchemeType[] RequiredBusinessClassificationScheme
		{
			get
			{
				return this.requiredBusinessClassificationSchemeField;
			}
			set
			{
				this.requiredBusinessClassificationSchemeField = value;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x00006155 File Offset: 0x00004355
		// (set) Token: 0x06000BDC RID: 3036 RVA: 0x0000615D File Offset: 0x0000435D
		[XmlElement("TechnicalEvaluationCriterion")]
		public EvaluationCriterionType[] TechnicalEvaluationCriterion
		{
			get
			{
				return this.technicalEvaluationCriterionField;
			}
			set
			{
				this.technicalEvaluationCriterionField = value;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x00006166 File Offset: 0x00004366
		// (set) Token: 0x06000BDE RID: 3038 RVA: 0x0000616E File Offset: 0x0000436E
		[XmlElement("FinancialEvaluationCriterion")]
		public EvaluationCriterionType[] FinancialEvaluationCriterion
		{
			get
			{
				return this.financialEvaluationCriterionField;
			}
			set
			{
				this.financialEvaluationCriterionField = value;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x00006177 File Offset: 0x00004377
		// (set) Token: 0x06000BE0 RID: 3040 RVA: 0x0000617F File Offset: 0x0000437F
		[XmlElement("SpecificTendererRequirement")]
		public TendererRequirementType[] SpecificTendererRequirement
		{
			get
			{
				return this.specificTendererRequirementField;
			}
			set
			{
				this.specificTendererRequirementField = value;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x00006188 File Offset: 0x00004388
		// (set) Token: 0x06000BE2 RID: 3042 RVA: 0x00006190 File Offset: 0x00004390
		[XmlElement("EconomicOperatorRole")]
		public EconomicOperatorRoleType[] EconomicOperatorRole
		{
			get
			{
				return this.economicOperatorRoleField;
			}
			set
			{
				this.economicOperatorRoleField = value;
			}
		}

		// Token: 0x040003FC RID: 1020
		private CompanyLegalFormCodeType companyLegalFormCodeField;

		// Token: 0x040003FD RID: 1021
		private CompanyLegalFormType companyLegalFormField;

		// Token: 0x040003FE RID: 1022
		private PersonalSituationType[] personalSituationField;

		// Token: 0x040003FF RID: 1023
		private OperatingYearsQuantityType operatingYearsQuantityField;

		// Token: 0x04000400 RID: 1024
		private EmployeeQuantityType employeeQuantityField;

		// Token: 0x04000401 RID: 1025
		private DescriptionType[] descriptionField;

		// Token: 0x04000402 RID: 1026
		private ClassificationSchemeType[] requiredBusinessClassificationSchemeField;

		// Token: 0x04000403 RID: 1027
		private EvaluationCriterionType[] technicalEvaluationCriterionField;

		// Token: 0x04000404 RID: 1028
		private EvaluationCriterionType[] financialEvaluationCriterionField;

		// Token: 0x04000405 RID: 1029
		private TendererRequirementType[] specificTendererRequirementField;

		// Token: 0x04000406 RID: 1030
		private EconomicOperatorRoleType[] economicOperatorRoleField;
	}
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000401 RID: 1025
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("AdditionalQualifyingParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class QualifyingPartyType
	{
		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x000051CB File Offset: 0x000033CB
		// (set) Token: 0x060009EB RID: 2539 RVA: 0x000051D3 File Offset: 0x000033D3
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ParticipationPercentType ParticipationPercent
		{
			get
			{
				return this.participationPercentField;
			}
			set
			{
				this.participationPercentField = value;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x000051DC File Offset: 0x000033DC
		// (set) Token: 0x060009ED RID: 2541 RVA: 0x000051E4 File Offset: 0x000033E4
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

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x000051ED File Offset: 0x000033ED
		// (set) Token: 0x060009EF RID: 2543 RVA: 0x000051F5 File Offset: 0x000033F5
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

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x000051FE File Offset: 0x000033FE
		// (set) Token: 0x060009F1 RID: 2545 RVA: 0x00005206 File Offset: 0x00003406
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

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x0000520F File Offset: 0x0000340F
		// (set) Token: 0x060009F3 RID: 2547 RVA: 0x00005217 File Offset: 0x00003417
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public BusinessClassificationEvidenceIDType BusinessClassificationEvidenceID
		{
			get
			{
				return this.businessClassificationEvidenceIDField;
			}
			set
			{
				this.businessClassificationEvidenceIDField = value;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x00005220 File Offset: 0x00003420
		// (set) Token: 0x060009F5 RID: 2549 RVA: 0x00005228 File Offset: 0x00003428
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public BusinessIdentityEvidenceIDType BusinessIdentityEvidenceID
		{
			get
			{
				return this.businessIdentityEvidenceIDField;
			}
			set
			{
				this.businessIdentityEvidenceIDField = value;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x00005231 File Offset: 0x00003431
		// (set) Token: 0x060009F7 RID: 2551 RVA: 0x00005239 File Offset: 0x00003439
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TendererRoleCodeType TendererRoleCode
		{
			get
			{
				return this.tendererRoleCodeField;
			}
			set
			{
				this.tendererRoleCodeField = value;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x00005242 File Offset: 0x00003442
		// (set) Token: 0x060009F9 RID: 2553 RVA: 0x0000524A File Offset: 0x0000344A
		public ClassificationSchemeType BusinessClassificationScheme
		{
			get
			{
				return this.businessClassificationSchemeField;
			}
			set
			{
				this.businessClassificationSchemeField = value;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x00005253 File Offset: 0x00003453
		// (set) Token: 0x060009FB RID: 2555 RVA: 0x0000525B File Offset: 0x0000345B
		[XmlElement("TechnicalCapability")]
		public CapabilityType[] TechnicalCapability
		{
			get
			{
				return this.technicalCapabilityField;
			}
			set
			{
				this.technicalCapabilityField = value;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x00005264 File Offset: 0x00003464
		// (set) Token: 0x060009FD RID: 2557 RVA: 0x0000526C File Offset: 0x0000346C
		[XmlElement("FinancialCapability")]
		public CapabilityType[] FinancialCapability
		{
			get
			{
				return this.financialCapabilityField;
			}
			set
			{
				this.financialCapabilityField = value;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x00005275 File Offset: 0x00003475
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x0000527D File Offset: 0x0000347D
		[XmlElement("CompletedTask")]
		public CompletedTaskType[] CompletedTask
		{
			get
			{
				return this.completedTaskField;
			}
			set
			{
				this.completedTaskField = value;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x00005286 File Offset: 0x00003486
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x0000528E File Offset: 0x0000348E
		[XmlElement("Declaration")]
		public DeclarationType[] Declaration
		{
			get
			{
				return this.declarationField;
			}
			set
			{
				this.declarationField = value;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x00005297 File Offset: 0x00003497
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x0000529F File Offset: 0x0000349F
		public PartyType Party
		{
			get
			{
				return this.partyField;
			}
			set
			{
				this.partyField = value;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x000052A8 File Offset: 0x000034A8
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x000052B0 File Offset: 0x000034B0
		public EconomicOperatorRoleType EconomicOperatorRole
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

		// Token: 0x04000319 RID: 793
		private ParticipationPercentType participationPercentField;

		// Token: 0x0400031A RID: 794
		private PersonalSituationType[] personalSituationField;

		// Token: 0x0400031B RID: 795
		private OperatingYearsQuantityType operatingYearsQuantityField;

		// Token: 0x0400031C RID: 796
		private EmployeeQuantityType employeeQuantityField;

		// Token: 0x0400031D RID: 797
		private BusinessClassificationEvidenceIDType businessClassificationEvidenceIDField;

		// Token: 0x0400031E RID: 798
		private BusinessIdentityEvidenceIDType businessIdentityEvidenceIDField;

		// Token: 0x0400031F RID: 799
		private TendererRoleCodeType tendererRoleCodeField;

		// Token: 0x04000320 RID: 800
		private ClassificationSchemeType businessClassificationSchemeField;

		// Token: 0x04000321 RID: 801
		private CapabilityType[] technicalCapabilityField;

		// Token: 0x04000322 RID: 802
		private CapabilityType[] financialCapabilityField;

		// Token: 0x04000323 RID: 803
		private CompletedTaskType[] completedTaskField;

		// Token: 0x04000324 RID: 804
		private DeclarationType[] declarationField;

		// Token: 0x04000325 RID: 805
		private PartyType partyField;

		// Token: 0x04000326 RID: 806
		private EconomicOperatorRoleType economicOperatorRoleField;
	}
}

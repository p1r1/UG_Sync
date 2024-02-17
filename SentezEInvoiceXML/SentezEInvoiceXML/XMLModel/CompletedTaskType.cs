using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000406 RID: 1030
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("CompletedTask", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class CompletedTaskType
	{
		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x00005462 File Offset: 0x00003662
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x0000546A File Offset: 0x0000366A
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AnnualAverageAmountType AnnualAverageAmount
		{
			get
			{
				return this.annualAverageAmountField;
			}
			set
			{
				this.annualAverageAmountField = value;
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x00005473 File Offset: 0x00003673
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x0000547B File Offset: 0x0000367B
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TotalTaskAmountType TotalTaskAmount
		{
			get
			{
				return this.totalTaskAmountField;
			}
			set
			{
				this.totalTaskAmountField = value;
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x00005484 File Offset: 0x00003684
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x0000548C File Offset: 0x0000368C
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PartyCapacityAmountType PartyCapacityAmount
		{
			get
			{
				return this.partyCapacityAmountField;
			}
			set
			{
				this.partyCapacityAmountField = value;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x00005495 File Offset: 0x00003695
		// (set) Token: 0x06000A44 RID: 2628 RVA: 0x0000549D File Offset: 0x0000369D
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

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x000054A6 File Offset: 0x000036A6
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x000054AE File Offset: 0x000036AE
		[XmlElement("EvidenceSupplied")]
		public EvidenceSuppliedType[] EvidenceSupplied
		{
			get
			{
				return this.evidenceSuppliedField;
			}
			set
			{
				this.evidenceSuppliedField = value;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x000054B7 File Offset: 0x000036B7
		// (set) Token: 0x06000A48 RID: 2632 RVA: 0x000054BF File Offset: 0x000036BF
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

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x000054C8 File Offset: 0x000036C8
		// (set) Token: 0x06000A4A RID: 2634 RVA: 0x000054D0 File Offset: 0x000036D0
		public CustomerPartyType RecipientCustomerParty
		{
			get
			{
				return this.recipientCustomerPartyField;
			}
			set
			{
				this.recipientCustomerPartyField = value;
			}
		}

		// Token: 0x04000340 RID: 832
		private AnnualAverageAmountType annualAverageAmountField;

		// Token: 0x04000341 RID: 833
		private TotalTaskAmountType totalTaskAmountField;

		// Token: 0x04000342 RID: 834
		private PartyCapacityAmountType partyCapacityAmountField;

		// Token: 0x04000343 RID: 835
		private DescriptionType[] descriptionField;

		// Token: 0x04000344 RID: 836
		private EvidenceSuppliedType[] evidenceSuppliedField;

		// Token: 0x04000345 RID: 837
		private PeriodType periodField;

		// Token: 0x04000346 RID: 838
		private CustomerPartyType recipientCustomerPartyField;
	}
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000404 RID: 1028
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("Capability", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class CapabilityType
	{
		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x000053EB File Offset: 0x000035EB
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x000053F3 File Offset: 0x000035F3
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CapabilityTypeCodeType CapabilityTypeCode
		{
			get
			{
				return this.capabilityTypeCodeField;
			}
			set
			{
				this.capabilityTypeCodeField = value;
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x000053FC File Offset: 0x000035FC
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x00005404 File Offset: 0x00003604
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

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x0000540D File Offset: 0x0000360D
		// (set) Token: 0x06000A32 RID: 2610 RVA: 0x00005415 File Offset: 0x00003615
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ValueAmountType ValueAmount
		{
			get
			{
				return this.valueAmountField;
			}
			set
			{
				this.valueAmountField = value;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x0000541E File Offset: 0x0000361E
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x00005426 File Offset: 0x00003626
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ValueQuantityType ValueQuantity
		{
			get
			{
				return this.valueQuantityField;
			}
			set
			{
				this.valueQuantityField = value;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x0000542F File Offset: 0x0000362F
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x00005437 File Offset: 0x00003637
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

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x00005440 File Offset: 0x00003640
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x00005448 File Offset: 0x00003648
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

		// Token: 0x04000339 RID: 825
		private CapabilityTypeCodeType capabilityTypeCodeField;

		// Token: 0x0400033A RID: 826
		private DescriptionType[] descriptionField;

		// Token: 0x0400033B RID: 827
		private ValueAmountType valueAmountField;

		// Token: 0x0400033C RID: 828
		private ValueQuantityType valueQuantityField;

		// Token: 0x0400033D RID: 829
		private EvidenceSuppliedType[] evidenceSuppliedField;

		// Token: 0x0400033E RID: 830
		private PeriodType validityPeriodField;
	}
}

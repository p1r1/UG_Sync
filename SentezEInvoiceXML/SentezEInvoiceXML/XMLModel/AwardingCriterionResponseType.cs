using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000430 RID: 1072
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("AwardingCriterionResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class AwardingCriterionResponseType
	{
		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000D03 RID: 3331 RVA: 0x00006A90 File Offset: 0x00004C90
		// (set) Token: 0x06000D04 RID: 3332 RVA: 0x00006A98 File Offset: 0x00004C98
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

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000D05 RID: 3333 RVA: 0x00006AA1 File Offset: 0x00004CA1
		// (set) Token: 0x06000D06 RID: 3334 RVA: 0x00006AA9 File Offset: 0x00004CA9
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AwardingCriterionIDType AwardingCriterionID
		{
			get
			{
				return this.awardingCriterionIDField;
			}
			set
			{
				this.awardingCriterionIDField = value;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000D07 RID: 3335 RVA: 0x00006AB2 File Offset: 0x00004CB2
		// (set) Token: 0x06000D08 RID: 3336 RVA: 0x00006ABA File Offset: 0x00004CBA
		[XmlElement("AwardingCriterionDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AwardingCriterionDescriptionType[] AwardingCriterionDescription
		{
			get
			{
				return this.awardingCriterionDescriptionField;
			}
			set
			{
				this.awardingCriterionDescriptionField = value;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000D09 RID: 3337 RVA: 0x00006AC3 File Offset: 0x00004CC3
		// (set) Token: 0x06000D0A RID: 3338 RVA: 0x00006ACB File Offset: 0x00004CCB
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

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x00006AD4 File Offset: 0x00004CD4
		// (set) Token: 0x06000D0C RID: 3340 RVA: 0x00006ADC File Offset: 0x00004CDC
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

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x00006AE5 File Offset: 0x00004CE5
		// (set) Token: 0x06000D0E RID: 3342 RVA: 0x00006AED File Offset: 0x00004CED
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AmountType2 Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x00006AF6 File Offset: 0x00004CF6
		// (set) Token: 0x06000D10 RID: 3344 RVA: 0x00006AFE File Offset: 0x00004CFE
		[XmlElement("SubordinateAwardingCriterionResponse")]
		public AwardingCriterionResponseType[] SubordinateAwardingCriterionResponse
		{
			get
			{
				return this.subordinateAwardingCriterionResponseField;
			}
			set
			{
				this.subordinateAwardingCriterionResponseField = value;
			}
		}

		// Token: 0x0400048E RID: 1166
		private IDType idField;

		// Token: 0x0400048F RID: 1167
		private AwardingCriterionIDType awardingCriterionIDField;

		// Token: 0x04000490 RID: 1168
		private AwardingCriterionDescriptionType[] awardingCriterionDescriptionField;

		// Token: 0x04000491 RID: 1169
		private DescriptionType[] descriptionField;

		// Token: 0x04000492 RID: 1170
		private QuantityType2 quantityField;

		// Token: 0x04000493 RID: 1171
		private AmountType2 amountField;

		// Token: 0x04000494 RID: 1172
		private AwardingCriterionResponseType[] subordinateAwardingCriterionResponseField;
	}
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200040E RID: 1038
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("AllowedSubcontractTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class SubcontractTermsType
	{
		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x00005770 File Offset: 0x00003970
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x00005778 File Offset: 0x00003978
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public RateType1 Rate
		{
			get
			{
				return this.rateField;
			}
			set
			{
				this.rateField = value;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x00005781 File Offset: 0x00003981
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x00005789 File Offset: 0x00003989
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public UnknownPriceIndicatorType UnknownPriceIndicator
		{
			get
			{
				return this.unknownPriceIndicatorField;
			}
			set
			{
				this.unknownPriceIndicatorField = value;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x00005792 File Offset: 0x00003992
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x0000579A File Offset: 0x0000399A
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

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x000057A3 File Offset: 0x000039A3
		// (set) Token: 0x06000AA8 RID: 2728 RVA: 0x000057AB File Offset: 0x000039AB
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

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x000057B4 File Offset: 0x000039B4
		// (set) Token: 0x06000AAA RID: 2730 RVA: 0x000057BC File Offset: 0x000039BC
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SubcontractingConditionsCodeType SubcontractingConditionsCode
		{
			get
			{
				return this.subcontractingConditionsCodeField;
			}
			set
			{
				this.subcontractingConditionsCodeField = value;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x000057C5 File Offset: 0x000039C5
		// (set) Token: 0x06000AAC RID: 2732 RVA: 0x000057CD File Offset: 0x000039CD
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MaximumPercentType MaximumPercent
		{
			get
			{
				return this.maximumPercentField;
			}
			set
			{
				this.maximumPercentField = value;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x000057D6 File Offset: 0x000039D6
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x000057DE File Offset: 0x000039DE
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MinimumPercentType MinimumPercent
		{
			get
			{
				return this.minimumPercentField;
			}
			set
			{
				this.minimumPercentField = value;
			}
		}

		// Token: 0x0400036E RID: 878
		private RateType1 rateField;

		// Token: 0x0400036F RID: 879
		private UnknownPriceIndicatorType unknownPriceIndicatorField;

		// Token: 0x04000370 RID: 880
		private DescriptionType[] descriptionField;

		// Token: 0x04000371 RID: 881
		private AmountType2 amountField;

		// Token: 0x04000372 RID: 882
		private SubcontractingConditionsCodeType subcontractingConditionsCodeField;

		// Token: 0x04000373 RID: 883
		private MaximumPercentType maximumPercentField;

		// Token: 0x04000374 RID: 884
		private MinimumPercentType minimumPercentField;
	}
}

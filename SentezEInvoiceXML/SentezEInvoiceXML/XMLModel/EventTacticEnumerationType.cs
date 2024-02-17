using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000460 RID: 1120
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("EventTacticEnumeration", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class EventTacticEnumerationType
	{
		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x0600103F RID: 4159 RVA: 0x00008476 File Offset: 0x00006676
		// (set) Token: 0x06001040 RID: 4160 RVA: 0x0000847E File Offset: 0x0000667E
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ConsumerIncentiveTacticTypeCodeType ConsumerIncentiveTacticTypeCode
		{
			get
			{
				return this.consumerIncentiveTacticTypeCodeField;
			}
			set
			{
				this.consumerIncentiveTacticTypeCodeField = value;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x00008487 File Offset: 0x00006687
		// (set) Token: 0x06001042 RID: 4162 RVA: 0x0000848F File Offset: 0x0000668F
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DisplayTacticTypeCodeType DisplayTacticTypeCode
		{
			get
			{
				return this.displayTacticTypeCodeField;
			}
			set
			{
				this.displayTacticTypeCodeField = value;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001043 RID: 4163 RVA: 0x00008498 File Offset: 0x00006698
		// (set) Token: 0x06001044 RID: 4164 RVA: 0x000084A0 File Offset: 0x000066A0
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public FeatureTacticTypeCodeType FeatureTacticTypeCode
		{
			get
			{
				return this.featureTacticTypeCodeField;
			}
			set
			{
				this.featureTacticTypeCodeField = value;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001045 RID: 4165 RVA: 0x000084A9 File Offset: 0x000066A9
		// (set) Token: 0x06001046 RID: 4166 RVA: 0x000084B1 File Offset: 0x000066B1
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TradeItemPackingLabelingTypeCodeType TradeItemPackingLabelingTypeCode
		{
			get
			{
				return this.tradeItemPackingLabelingTypeCodeField;
			}
			set
			{
				this.tradeItemPackingLabelingTypeCodeField = value;
			}
		}

		// Token: 0x04000614 RID: 1556
		private ConsumerIncentiveTacticTypeCodeType consumerIncentiveTacticTypeCodeField;

		// Token: 0x04000615 RID: 1557
		private DisplayTacticTypeCodeType displayTacticTypeCodeField;

		// Token: 0x04000616 RID: 1558
		private FeatureTacticTypeCodeType featureTacticTypeCodeField;

		// Token: 0x04000617 RID: 1559
		private TradeItemPackingLabelingTypeCodeType tradeItemPackingLabelingTypeCodeField;
	}
}

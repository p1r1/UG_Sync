using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000445 RID: 1093
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ConsumptionCorrection", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ConsumptionCorrectionType
	{
		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x00007552 File Offset: 0x00005752
		// (set) Token: 0x06000E5D RID: 3677 RVA: 0x0000755A File Offset: 0x0000575A
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CorrectionTypeType CorrectionType
		{
			get
			{
				return this.correctionTypeField;
			}
			set
			{
				this.correctionTypeField = value;
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x00007563 File Offset: 0x00005763
		// (set) Token: 0x06000E5F RID: 3679 RVA: 0x0000756B File Offset: 0x0000576B
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CorrectionTypeCodeType CorrectionTypeCode
		{
			get
			{
				return this.correctionTypeCodeField;
			}
			set
			{
				this.correctionTypeCodeField = value;
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x00007574 File Offset: 0x00005774
		// (set) Token: 0x06000E61 RID: 3681 RVA: 0x0000757C File Offset: 0x0000577C
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MeterNumberType MeterNumber
		{
			get
			{
				return this.meterNumberField;
			}
			set
			{
				this.meterNumberField = value;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x00007585 File Offset: 0x00005785
		// (set) Token: 0x06000E63 RID: 3683 RVA: 0x0000758D File Offset: 0x0000578D
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public GasPressureQuantityType GasPressureQuantity
		{
			get
			{
				return this.gasPressureQuantityField;
			}
			set
			{
				this.gasPressureQuantityField = value;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x00007596 File Offset: 0x00005796
		// (set) Token: 0x06000E65 RID: 3685 RVA: 0x0000759E File Offset: 0x0000579E
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ActualTemperatureReductionQuantityType ActualTemperatureReductionQuantity
		{
			get
			{
				return this.actualTemperatureReductionQuantityField;
			}
			set
			{
				this.actualTemperatureReductionQuantityField = value;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x000075A7 File Offset: 0x000057A7
		// (set) Token: 0x06000E67 RID: 3687 RVA: 0x000075AF File Offset: 0x000057AF
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NormalTemperatureReductionQuantityType NormalTemperatureReductionQuantity
		{
			get
			{
				return this.normalTemperatureReductionQuantityField;
			}
			set
			{
				this.normalTemperatureReductionQuantityField = value;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x000075B8 File Offset: 0x000057B8
		// (set) Token: 0x06000E69 RID: 3689 RVA: 0x000075C0 File Offset: 0x000057C0
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DifferenceTemperatureReductionQuantityType DifferenceTemperatureReductionQuantity
		{
			get
			{
				return this.differenceTemperatureReductionQuantityField;
			}
			set
			{
				this.differenceTemperatureReductionQuantityField = value;
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x000075C9 File Offset: 0x000057C9
		// (set) Token: 0x06000E6B RID: 3691 RVA: 0x000075D1 File Offset: 0x000057D1
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

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x000075DA File Offset: 0x000057DA
		// (set) Token: 0x06000E6D RID: 3693 RVA: 0x000075E2 File Offset: 0x000057E2
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CorrectionUnitAmountType CorrectionUnitAmount
		{
			get
			{
				return this.correctionUnitAmountField;
			}
			set
			{
				this.correctionUnitAmountField = value;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x000075EB File Offset: 0x000057EB
		// (set) Token: 0x06000E6F RID: 3695 RVA: 0x000075F3 File Offset: 0x000057F3
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ConsumptionEnergyQuantityType ConsumptionEnergyQuantity
		{
			get
			{
				return this.consumptionEnergyQuantityField;
			}
			set
			{
				this.consumptionEnergyQuantityField = value;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x000075FC File Offset: 0x000057FC
		// (set) Token: 0x06000E71 RID: 3697 RVA: 0x00007604 File Offset: 0x00005804
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ConsumptionWaterQuantityType ConsumptionWaterQuantity
		{
			get
			{
				return this.consumptionWaterQuantityField;
			}
			set
			{
				this.consumptionWaterQuantityField = value;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x0000760D File Offset: 0x0000580D
		// (set) Token: 0x06000E73 RID: 3699 RVA: 0x00007615 File Offset: 0x00005815
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CorrectionAmountType CorrectionAmount
		{
			get
			{
				return this.correctionAmountField;
			}
			set
			{
				this.correctionAmountField = value;
			}
		}

		// Token: 0x04000530 RID: 1328
		private CorrectionTypeType correctionTypeField;

		// Token: 0x04000531 RID: 1329
		private CorrectionTypeCodeType correctionTypeCodeField;

		// Token: 0x04000532 RID: 1330
		private MeterNumberType meterNumberField;

		// Token: 0x04000533 RID: 1331
		private GasPressureQuantityType gasPressureQuantityField;

		// Token: 0x04000534 RID: 1332
		private ActualTemperatureReductionQuantityType actualTemperatureReductionQuantityField;

		// Token: 0x04000535 RID: 1333
		private NormalTemperatureReductionQuantityType normalTemperatureReductionQuantityField;

		// Token: 0x04000536 RID: 1334
		private DifferenceTemperatureReductionQuantityType differenceTemperatureReductionQuantityField;

		// Token: 0x04000537 RID: 1335
		private DescriptionType[] descriptionField;

		// Token: 0x04000538 RID: 1336
		private CorrectionUnitAmountType correctionUnitAmountField;

		// Token: 0x04000539 RID: 1337
		private ConsumptionEnergyQuantityType consumptionEnergyQuantityField;

		// Token: 0x0400053A RID: 1338
		private ConsumptionWaterQuantityType consumptionWaterQuantityField;

		// Token: 0x0400053B RID: 1339
		private CorrectionAmountType correctionAmountField;
	}
}

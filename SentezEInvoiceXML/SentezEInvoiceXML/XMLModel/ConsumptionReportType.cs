using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000440 RID: 1088
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ConsumptionReport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ConsumptionReportType
	{
		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000E0F RID: 3599 RVA: 0x000072EE File Offset: 0x000054EE
		// (set) Token: 0x06000E10 RID: 3600 RVA: 0x000072F6 File Offset: 0x000054F6
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

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000E11 RID: 3601 RVA: 0x000072FF File Offset: 0x000054FF
		// (set) Token: 0x06000E12 RID: 3602 RVA: 0x00007307 File Offset: 0x00005507
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ConsumptionTypeType ConsumptionType
		{
			get
			{
				return this.consumptionTypeField;
			}
			set
			{
				this.consumptionTypeField = value;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000E13 RID: 3603 RVA: 0x00007310 File Offset: 0x00005510
		// (set) Token: 0x06000E14 RID: 3604 RVA: 0x00007318 File Offset: 0x00005518
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ConsumptionTypeCodeType ConsumptionTypeCode
		{
			get
			{
				return this.consumptionTypeCodeField;
			}
			set
			{
				this.consumptionTypeCodeField = value;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000E15 RID: 3605 RVA: 0x00007321 File Offset: 0x00005521
		// (set) Token: 0x06000E16 RID: 3606 RVA: 0x00007329 File Offset: 0x00005529
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

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000E17 RID: 3607 RVA: 0x00007332 File Offset: 0x00005532
		// (set) Token: 0x06000E18 RID: 3608 RVA: 0x0000733A File Offset: 0x0000553A
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TotalConsumedQuantityType TotalConsumedQuantity
		{
			get
			{
				return this.totalConsumedQuantityField;
			}
			set
			{
				this.totalConsumedQuantityField = value;
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000E19 RID: 3609 RVA: 0x00007343 File Offset: 0x00005543
		// (set) Token: 0x06000E1A RID: 3610 RVA: 0x0000734B File Offset: 0x0000554B
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public BasicConsumedQuantityType BasicConsumedQuantity
		{
			get
			{
				return this.basicConsumedQuantityField;
			}
			set
			{
				this.basicConsumedQuantityField = value;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000E1B RID: 3611 RVA: 0x00007354 File Offset: 0x00005554
		// (set) Token: 0x06000E1C RID: 3612 RVA: 0x0000735C File Offset: 0x0000555C
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ResidentOccupantsNumericType ResidentOccupantsNumeric
		{
			get
			{
				return this.residentOccupantsNumericField;
			}
			set
			{
				this.residentOccupantsNumericField = value;
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000E1D RID: 3613 RVA: 0x00007365 File Offset: 0x00005565
		// (set) Token: 0x06000E1E RID: 3614 RVA: 0x0000736D File Offset: 0x0000556D
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ConsumersEnergyLevelCodeType ConsumersEnergyLevelCode
		{
			get
			{
				return this.consumersEnergyLevelCodeField;
			}
			set
			{
				this.consumersEnergyLevelCodeField = value;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x00007376 File Offset: 0x00005576
		// (set) Token: 0x06000E20 RID: 3616 RVA: 0x0000737E File Offset: 0x0000557E
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ConsumersEnergyLevelType ConsumersEnergyLevel
		{
			get
			{
				return this.consumersEnergyLevelField;
			}
			set
			{
				this.consumersEnergyLevelField = value;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000E21 RID: 3617 RVA: 0x00007387 File Offset: 0x00005587
		// (set) Token: 0x06000E22 RID: 3618 RVA: 0x0000738F File Offset: 0x0000558F
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ResidenceTypeType ResidenceType
		{
			get
			{
				return this.residenceTypeField;
			}
			set
			{
				this.residenceTypeField = value;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000E23 RID: 3619 RVA: 0x00007398 File Offset: 0x00005598
		// (set) Token: 0x06000E24 RID: 3620 RVA: 0x000073A0 File Offset: 0x000055A0
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ResidenceTypeCodeType ResidenceTypeCode
		{
			get
			{
				return this.residenceTypeCodeField;
			}
			set
			{
				this.residenceTypeCodeField = value;
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000E25 RID: 3621 RVA: 0x000073A9 File Offset: 0x000055A9
		// (set) Token: 0x06000E26 RID: 3622 RVA: 0x000073B1 File Offset: 0x000055B1
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public HeatingTypeType HeatingType
		{
			get
			{
				return this.heatingTypeField;
			}
			set
			{
				this.heatingTypeField = value;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000E27 RID: 3623 RVA: 0x000073BA File Offset: 0x000055BA
		// (set) Token: 0x06000E28 RID: 3624 RVA: 0x000073C2 File Offset: 0x000055C2
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public HeatingTypeCodeType HeatingTypeCode
		{
			get
			{
				return this.heatingTypeCodeField;
			}
			set
			{
				this.heatingTypeCodeField = value;
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x000073CB File Offset: 0x000055CB
		// (set) Token: 0x06000E2A RID: 3626 RVA: 0x000073D3 File Offset: 0x000055D3
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

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x000073DC File Offset: 0x000055DC
		// (set) Token: 0x06000E2C RID: 3628 RVA: 0x000073E4 File Offset: 0x000055E4
		public DocumentReferenceType GuidanceDocumentReference
		{
			get
			{
				return this.guidanceDocumentReferenceField;
			}
			set
			{
				this.guidanceDocumentReferenceField = value;
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x000073ED File Offset: 0x000055ED
		// (set) Token: 0x06000E2E RID: 3630 RVA: 0x000073F5 File Offset: 0x000055F5
		public DocumentReferenceType DocumentReference
		{
			get
			{
				return this.documentReferenceField;
			}
			set
			{
				this.documentReferenceField = value;
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000E2F RID: 3631 RVA: 0x000073FE File Offset: 0x000055FE
		// (set) Token: 0x06000E30 RID: 3632 RVA: 0x00007406 File Offset: 0x00005606
		[XmlElement("ConsumptionReportReference")]
		public ConsumptionReportReferenceType[] ConsumptionReportReference
		{
			get
			{
				return this.consumptionReportReferenceField;
			}
			set
			{
				this.consumptionReportReferenceField = value;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000E31 RID: 3633 RVA: 0x0000740F File Offset: 0x0000560F
		// (set) Token: 0x06000E32 RID: 3634 RVA: 0x00007417 File Offset: 0x00005617
		[XmlElement("ConsumptionHistory")]
		public ConsumptionHistoryType[] ConsumptionHistory
		{
			get
			{
				return this.consumptionHistoryField;
			}
			set
			{
				this.consumptionHistoryField = value;
			}
		}

		// Token: 0x0400050C RID: 1292
		private IDType idField;

		// Token: 0x0400050D RID: 1293
		private ConsumptionTypeType consumptionTypeField;

		// Token: 0x0400050E RID: 1294
		private ConsumptionTypeCodeType consumptionTypeCodeField;

		// Token: 0x0400050F RID: 1295
		private DescriptionType[] descriptionField;

		// Token: 0x04000510 RID: 1296
		private TotalConsumedQuantityType totalConsumedQuantityField;

		// Token: 0x04000511 RID: 1297
		private BasicConsumedQuantityType basicConsumedQuantityField;

		// Token: 0x04000512 RID: 1298
		private ResidentOccupantsNumericType residentOccupantsNumericField;

		// Token: 0x04000513 RID: 1299
		private ConsumersEnergyLevelCodeType consumersEnergyLevelCodeField;

		// Token: 0x04000514 RID: 1300
		private ConsumersEnergyLevelType consumersEnergyLevelField;

		// Token: 0x04000515 RID: 1301
		private ResidenceTypeType residenceTypeField;

		// Token: 0x04000516 RID: 1302
		private ResidenceTypeCodeType residenceTypeCodeField;

		// Token: 0x04000517 RID: 1303
		private HeatingTypeType heatingTypeField;

		// Token: 0x04000518 RID: 1304
		private HeatingTypeCodeType heatingTypeCodeField;

		// Token: 0x04000519 RID: 1305
		private PeriodType periodField;

		// Token: 0x0400051A RID: 1306
		private DocumentReferenceType guidanceDocumentReferenceField;

		// Token: 0x0400051B RID: 1307
		private DocumentReferenceType documentReferenceField;

		// Token: 0x0400051C RID: 1308
		private ConsumptionReportReferenceType[] consumptionReportReferenceField;

		// Token: 0x0400051D RID: 1309
		private ConsumptionHistoryType[] consumptionHistoryField;
	}
}

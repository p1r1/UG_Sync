using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200040A RID: 1034
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("EnvironmentalEmission", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class EnvironmentalEmissionType
	{
		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x000056C6 File Offset: 0x000038C6
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x000056CE File Offset: 0x000038CE
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public EnvironmentalEmissionTypeCodeType EnvironmentalEmissionTypeCode
		{
			get
			{
				return this.environmentalEmissionTypeCodeField;
			}
			set
			{
				this.environmentalEmissionTypeCodeField = value;
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x000056D7 File Offset: 0x000038D7
		// (set) Token: 0x06000A8C RID: 2700 RVA: 0x000056DF File Offset: 0x000038DF
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ValueMeasureType ValueMeasure
		{
			get
			{
				return this.valueMeasureField;
			}
			set
			{
				this.valueMeasureField = value;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x000056E8 File Offset: 0x000038E8
		// (set) Token: 0x06000A8E RID: 2702 RVA: 0x000056F0 File Offset: 0x000038F0
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

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x000056F9 File Offset: 0x000038F9
		// (set) Token: 0x06000A90 RID: 2704 RVA: 0x00005701 File Offset: 0x00003901
		[XmlElement("EmissionCalculationMethod")]
		public EmissionCalculationMethodType[] EmissionCalculationMethod
		{
			get
			{
				return this.emissionCalculationMethodField;
			}
			set
			{
				this.emissionCalculationMethodField = value;
			}
		}

		// Token: 0x04000364 RID: 868
		private EnvironmentalEmissionTypeCodeType environmentalEmissionTypeCodeField;

		// Token: 0x04000365 RID: 869
		private ValueMeasureType valueMeasureField;

		// Token: 0x04000366 RID: 870
		private DescriptionType[] descriptionField;

		// Token: 0x04000367 RID: 871
		private EmissionCalculationMethodType[] emissionCalculationMethodField;
	}
}

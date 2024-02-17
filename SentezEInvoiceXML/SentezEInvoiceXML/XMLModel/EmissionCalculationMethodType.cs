using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200040B RID: 1035
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("EmissionCalculationMethod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class EmissionCalculationMethodType
	{
		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x0000570A File Offset: 0x0000390A
		// (set) Token: 0x06000A93 RID: 2707 RVA: 0x00005712 File Offset: 0x00003912
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CalculationMethodCodeType CalculationMethodCode
		{
			get
			{
				return this.calculationMethodCodeField;
			}
			set
			{
				this.calculationMethodCodeField = value;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x0000571B File Offset: 0x0000391B
		// (set) Token: 0x06000A95 RID: 2709 RVA: 0x00005723 File Offset: 0x00003923
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public FullnessIndicationCodeType FullnessIndicationCode
		{
			get
			{
				return this.fullnessIndicationCodeField;
			}
			set
			{
				this.fullnessIndicationCodeField = value;
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x0000572C File Offset: 0x0000392C
		// (set) Token: 0x06000A97 RID: 2711 RVA: 0x00005734 File Offset: 0x00003934
		public LocationType1 MeasurementFromLocation
		{
			get
			{
				return this.measurementFromLocationField;
			}
			set
			{
				this.measurementFromLocationField = value;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x0000573D File Offset: 0x0000393D
		// (set) Token: 0x06000A99 RID: 2713 RVA: 0x00005745 File Offset: 0x00003945
		public LocationType1 MeasurementToLocation
		{
			get
			{
				return this.measurementToLocationField;
			}
			set
			{
				this.measurementToLocationField = value;
			}
		}

		// Token: 0x04000368 RID: 872
		private CalculationMethodCodeType calculationMethodCodeField;

		// Token: 0x04000369 RID: 873
		private FullnessIndicationCodeType fullnessIndicationCodeField;

		// Token: 0x0400036A RID: 874
		private LocationType1 measurementFromLocationField;

		// Token: 0x0400036B RID: 875
		private LocationType1 measurementToLocationField;
	}
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200044F RID: 1103
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("Meter", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class MeterType
	{
		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000F30 RID: 3888 RVA: 0x00007C07 File Offset: 0x00005E07
		// (set) Token: 0x06000F31 RID: 3889 RVA: 0x00007C0F File Offset: 0x00005E0F
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

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000F32 RID: 3890 RVA: 0x00007C18 File Offset: 0x00005E18
		// (set) Token: 0x06000F33 RID: 3891 RVA: 0x00007C20 File Offset: 0x00005E20
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MeterNameType MeterName
		{
			get
			{
				return this.meterNameField;
			}
			set
			{
				this.meterNameField = value;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000F34 RID: 3892 RVA: 0x00007C29 File Offset: 0x00005E29
		// (set) Token: 0x06000F35 RID: 3893 RVA: 0x00007C31 File Offset: 0x00005E31
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MeterConstantType MeterConstant
		{
			get
			{
				return this.meterConstantField;
			}
			set
			{
				this.meterConstantField = value;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000F36 RID: 3894 RVA: 0x00007C3A File Offset: 0x00005E3A
		// (set) Token: 0x06000F37 RID: 3895 RVA: 0x00007C42 File Offset: 0x00005E42
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MeterConstantCodeType MeterConstantCode
		{
			get
			{
				return this.meterConstantCodeField;
			}
			set
			{
				this.meterConstantCodeField = value;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000F38 RID: 3896 RVA: 0x00007C4B File Offset: 0x00005E4B
		// (set) Token: 0x06000F39 RID: 3897 RVA: 0x00007C53 File Offset: 0x00005E53
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TotalDeliveredQuantityType TotalDeliveredQuantity
		{
			get
			{
				return this.totalDeliveredQuantityField;
			}
			set
			{
				this.totalDeliveredQuantityField = value;
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000F3A RID: 3898 RVA: 0x00007C5C File Offset: 0x00005E5C
		// (set) Token: 0x06000F3B RID: 3899 RVA: 0x00007C64 File Offset: 0x00005E64
		[XmlElement("MeterReading")]
		public MeterReadingType[] MeterReading
		{
			get
			{
				return this.meterReadingField;
			}
			set
			{
				this.meterReadingField = value;
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x00007C6D File Offset: 0x00005E6D
		// (set) Token: 0x06000F3D RID: 3901 RVA: 0x00007C75 File Offset: 0x00005E75
		[XmlElement("MeterProperty")]
		public MeterPropertyType[] MeterProperty
		{
			get
			{
				return this.meterPropertyField;
			}
			set
			{
				this.meterPropertyField = value;
			}
		}

		// Token: 0x04000595 RID: 1429
		private MeterNumberType meterNumberField;

		// Token: 0x04000596 RID: 1430
		private MeterNameType meterNameField;

		// Token: 0x04000597 RID: 1431
		private MeterConstantType meterConstantField;

		// Token: 0x04000598 RID: 1432
		private MeterConstantCodeType meterConstantCodeField;

		// Token: 0x04000599 RID: 1433
		private TotalDeliveredQuantityType totalDeliveredQuantityField;

		// Token: 0x0400059A RID: 1434
		private MeterReadingType[] meterReadingField;

		// Token: 0x0400059B RID: 1435
		private MeterPropertyType[] meterPropertyField;
	}
}

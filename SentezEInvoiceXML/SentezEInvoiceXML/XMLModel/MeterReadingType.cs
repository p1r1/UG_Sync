using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000450 RID: 1104
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("MeterReading", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class MeterReadingType
	{
		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x00007C7E File Offset: 0x00005E7E
		// (set) Token: 0x06000F40 RID: 3904 RVA: 0x00007C86 File Offset: 0x00005E86
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

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x00007C8F File Offset: 0x00005E8F
		// (set) Token: 0x06000F42 RID: 3906 RVA: 0x00007C97 File Offset: 0x00005E97
		[XmlElement("MeterReadingType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MeterReadingTypeType MeterReadingType1
		{
			get
			{
				return this.meterReadingType1Field;
			}
			set
			{
				this.meterReadingType1Field = value;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x00007CA0 File Offset: 0x00005EA0
		// (set) Token: 0x06000F44 RID: 3908 RVA: 0x00007CA8 File Offset: 0x00005EA8
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MeterReadingTypeCodeType MeterReadingTypeCode
		{
			get
			{
				return this.meterReadingTypeCodeField;
			}
			set
			{
				this.meterReadingTypeCodeField = value;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000F45 RID: 3909 RVA: 0x00007CB1 File Offset: 0x00005EB1
		// (set) Token: 0x06000F46 RID: 3910 RVA: 0x00007CB9 File Offset: 0x00005EB9
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PreviousMeterReadingDateType PreviousMeterReadingDate
		{
			get
			{
				return this.previousMeterReadingDateField;
			}
			set
			{
				this.previousMeterReadingDateField = value;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x00007CC2 File Offset: 0x00005EC2
		// (set) Token: 0x06000F48 RID: 3912 RVA: 0x00007CCA File Offset: 0x00005ECA
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PreviousMeterQuantityType PreviousMeterQuantity
		{
			get
			{
				return this.previousMeterQuantityField;
			}
			set
			{
				this.previousMeterQuantityField = value;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000F49 RID: 3913 RVA: 0x00007CD3 File Offset: 0x00005ED3
		// (set) Token: 0x06000F4A RID: 3914 RVA: 0x00007CDB File Offset: 0x00005EDB
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LatestMeterReadingDateType LatestMeterReadingDate
		{
			get
			{
				return this.latestMeterReadingDateField;
			}
			set
			{
				this.latestMeterReadingDateField = value;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000F4B RID: 3915 RVA: 0x00007CE4 File Offset: 0x00005EE4
		// (set) Token: 0x06000F4C RID: 3916 RVA: 0x00007CEC File Offset: 0x00005EEC
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LatestMeterQuantityType LatestMeterQuantity
		{
			get
			{
				return this.latestMeterQuantityField;
			}
			set
			{
				this.latestMeterQuantityField = value;
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x00007CF5 File Offset: 0x00005EF5
		// (set) Token: 0x06000F4E RID: 3918 RVA: 0x00007CFD File Offset: 0x00005EFD
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PreviousMeterReadingMethodType PreviousMeterReadingMethod
		{
			get
			{
				return this.previousMeterReadingMethodField;
			}
			set
			{
				this.previousMeterReadingMethodField = value;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000F4F RID: 3919 RVA: 0x00007D06 File Offset: 0x00005F06
		// (set) Token: 0x06000F50 RID: 3920 RVA: 0x00007D0E File Offset: 0x00005F0E
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PreviousMeterReadingMethodCodeType PreviousMeterReadingMethodCode
		{
			get
			{
				return this.previousMeterReadingMethodCodeField;
			}
			set
			{
				this.previousMeterReadingMethodCodeField = value;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000F51 RID: 3921 RVA: 0x00007D17 File Offset: 0x00005F17
		// (set) Token: 0x06000F52 RID: 3922 RVA: 0x00007D1F File Offset: 0x00005F1F
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LatestMeterReadingMethodType LatestMeterReadingMethod
		{
			get
			{
				return this.latestMeterReadingMethodField;
			}
			set
			{
				this.latestMeterReadingMethodField = value;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000F53 RID: 3923 RVA: 0x00007D28 File Offset: 0x00005F28
		// (set) Token: 0x06000F54 RID: 3924 RVA: 0x00007D30 File Offset: 0x00005F30
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LatestMeterReadingMethodCodeType LatestMeterReadingMethodCode
		{
			get
			{
				return this.latestMeterReadingMethodCodeField;
			}
			set
			{
				this.latestMeterReadingMethodCodeField = value;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000F55 RID: 3925 RVA: 0x00007D39 File Offset: 0x00005F39
		// (set) Token: 0x06000F56 RID: 3926 RVA: 0x00007D41 File Offset: 0x00005F41
		[XmlElement("MeterReadingComments", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MeterReadingCommentsType[] MeterReadingComments
		{
			get
			{
				return this.meterReadingCommentsField;
			}
			set
			{
				this.meterReadingCommentsField = value;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000F57 RID: 3927 RVA: 0x00007D4A File Offset: 0x00005F4A
		// (set) Token: 0x06000F58 RID: 3928 RVA: 0x00007D52 File Offset: 0x00005F52
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DeliveredQuantityType DeliveredQuantity
		{
			get
			{
				return this.deliveredQuantityField;
			}
			set
			{
				this.deliveredQuantityField = value;
			}
		}

		// Token: 0x0400059C RID: 1436
		private IDType idField;

		// Token: 0x0400059D RID: 1437
		private MeterReadingTypeType meterReadingType1Field;

		// Token: 0x0400059E RID: 1438
		private MeterReadingTypeCodeType meterReadingTypeCodeField;

		// Token: 0x0400059F RID: 1439
		private PreviousMeterReadingDateType previousMeterReadingDateField;

		// Token: 0x040005A0 RID: 1440
		private PreviousMeterQuantityType previousMeterQuantityField;

		// Token: 0x040005A1 RID: 1441
		private LatestMeterReadingDateType latestMeterReadingDateField;

		// Token: 0x040005A2 RID: 1442
		private LatestMeterQuantityType latestMeterQuantityField;

		// Token: 0x040005A3 RID: 1443
		private PreviousMeterReadingMethodType previousMeterReadingMethodField;

		// Token: 0x040005A4 RID: 1444
		private PreviousMeterReadingMethodCodeType previousMeterReadingMethodCodeField;

		// Token: 0x040005A5 RID: 1445
		private LatestMeterReadingMethodType latestMeterReadingMethodField;

		// Token: 0x040005A6 RID: 1446
		private LatestMeterReadingMethodCodeType latestMeterReadingMethodCodeField;

		// Token: 0x040005A7 RID: 1447
		private MeterReadingCommentsType[] meterReadingCommentsField;

		// Token: 0x040005A8 RID: 1448
		private DeliveredQuantityType deliveredQuantityField;
	}
}

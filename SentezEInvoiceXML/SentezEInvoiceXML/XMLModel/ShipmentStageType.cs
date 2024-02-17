using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003E5 RID: 997
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("MainCarriageShipmentStage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ShipmentStageType
	{
		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x00004907 File Offset: 0x00002B07
		// (set) Token: 0x060008C7 RID: 2247 RVA: 0x0000490F File Offset: 0x00002B0F
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

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x00004918 File Offset: 0x00002B18
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x00004920 File Offset: 0x00002B20
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TransportModeCodeType TransportModeCode
		{
			get
			{
				return this.transportModeCodeField;
			}
			set
			{
				this.transportModeCodeField = value;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x00004929 File Offset: 0x00002B29
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x00004931 File Offset: 0x00002B31
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TransportMeansTypeCodeType TransportMeansTypeCode
		{
			get
			{
				return this.transportMeansTypeCodeField;
			}
			set
			{
				this.transportMeansTypeCodeField = value;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x0000493A File Offset: 0x00002B3A
		// (set) Token: 0x060008CD RID: 2253 RVA: 0x00004942 File Offset: 0x00002B42
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TransitDirectionCodeType TransitDirectionCode
		{
			get
			{
				return this.transitDirectionCodeField;
			}
			set
			{
				this.transitDirectionCodeField = value;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x0000494B File Offset: 0x00002B4B
		// (set) Token: 0x060008CF RID: 2255 RVA: 0x00004953 File Offset: 0x00002B53
		[XmlElement("Instructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public InstructionsType[] Instructions
		{
			get
			{
				return this.instructionsField;
			}
			set
			{
				this.instructionsField = value;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x0000495C File Offset: 0x00002B5C
		// (set) Token: 0x060008D1 RID: 2257 RVA: 0x00004964 File Offset: 0x00002B64
		public PeriodType TransitPeriod
		{
			get
			{
				return this.transitPeriodField;
			}
			set
			{
				this.transitPeriodField = value;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x0000496D File Offset: 0x00002B6D
		// (set) Token: 0x060008D3 RID: 2259 RVA: 0x00004975 File Offset: 0x00002B75
		public TransportMeansType TransportMeans
		{
			get
			{
				return this.transportMeansField;
			}
			set
			{
				this.transportMeansField = value;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x0000497E File Offset: 0x00002B7E
		// (set) Token: 0x060008D5 RID: 2261 RVA: 0x00004986 File Offset: 0x00002B86
		[XmlElement("DriverPerson")]
		public PersonType[] DriverPerson
		{
			get
			{
				return this.driverPersonField;
			}
			set
			{
				this.driverPersonField = value;
			}
		}

		// Token: 0x04000295 RID: 661
		private IDType idField;

		// Token: 0x04000296 RID: 662
		private TransportModeCodeType transportModeCodeField;

		// Token: 0x04000297 RID: 663
		private TransportMeansTypeCodeType transportMeansTypeCodeField;

		// Token: 0x04000298 RID: 664
		private TransitDirectionCodeType transitDirectionCodeField;

		// Token: 0x04000299 RID: 665
		private InstructionsType[] instructionsField;

		// Token: 0x0400029A RID: 666
		private PeriodType transitPeriodField;

		// Token: 0x0400029B RID: 667
		private TransportMeansType transportMeansField;

		// Token: 0x0400029C RID: 668
		private PersonType[] driverPersonField;
	}
}

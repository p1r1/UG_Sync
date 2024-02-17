using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003E1 RID: 993
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("Despatch", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class DespatchType
	{
		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x000046A3 File Offset: 0x000028A3
		// (set) Token: 0x0600087B RID: 2171 RVA: 0x000046AB File Offset: 0x000028AB
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

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x000046B4 File Offset: 0x000028B4
		// (set) Token: 0x0600087D RID: 2173 RVA: 0x000046BC File Offset: 0x000028BC
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ActualDespatchDateType ActualDespatchDate
		{
			get
			{
				return this.actualDespatchDateField;
			}
			set
			{
				this.actualDespatchDateField = value;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x000046C5 File Offset: 0x000028C5
		// (set) Token: 0x0600087F RID: 2175 RVA: 0x000046CD File Offset: 0x000028CD
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ActualDespatchTimeType ActualDespatchTime
		{
			get
			{
				return this.actualDespatchTimeField;
			}
			set
			{
				this.actualDespatchTimeField = value;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x000046D6 File Offset: 0x000028D6
		// (set) Token: 0x06000881 RID: 2177 RVA: 0x000046DE File Offset: 0x000028DE
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public InstructionsType Instructions
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

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x000046E7 File Offset: 0x000028E7
		// (set) Token: 0x06000883 RID: 2179 RVA: 0x000046EF File Offset: 0x000028EF
		public AddressType DespatchAddress
		{
			get
			{
				return this.despatchAddressField;
			}
			set
			{
				this.despatchAddressField = value;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x000046F8 File Offset: 0x000028F8
		// (set) Token: 0x06000885 RID: 2181 RVA: 0x00004700 File Offset: 0x00002900
		public PartyType DespatchParty
		{
			get
			{
				return this.despatchPartyField;
			}
			set
			{
				this.despatchPartyField = value;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x00004709 File Offset: 0x00002909
		// (set) Token: 0x06000887 RID: 2183 RVA: 0x00004711 File Offset: 0x00002911
		public ContactType Contact
		{
			get
			{
				return this.contactField;
			}
			set
			{
				this.contactField = value;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x0000471A File Offset: 0x0000291A
		// (set) Token: 0x06000889 RID: 2185 RVA: 0x00004722 File Offset: 0x00002922
		public PeriodType EstimatedDespatchPeriod
		{
			get
			{
				return this.estimatedDespatchPeriodField;
			}
			set
			{
				this.estimatedDespatchPeriodField = value;
			}
		}

		// Token: 0x04000271 RID: 625
		private IDType idField;

		// Token: 0x04000272 RID: 626
		private ActualDespatchDateType actualDespatchDateField;

		// Token: 0x04000273 RID: 627
		private ActualDespatchTimeType actualDespatchTimeField;

		// Token: 0x04000274 RID: 628
		private InstructionsType instructionsField;

		// Token: 0x04000275 RID: 629
		private AddressType despatchAddressField;

		// Token: 0x04000276 RID: 630
		private PartyType despatchPartyField;

		// Token: 0x04000277 RID: 631
		private ContactType contactField;

		// Token: 0x04000278 RID: 632
		private PeriodType estimatedDespatchPeriodField;
	}
}

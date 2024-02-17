using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000459 RID: 1113
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("EconomicOperatorShortList", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class EconomicOperatorShortListType
	{
		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x00008234 File Offset: 0x00006434
		// (set) Token: 0x06000FF5 RID: 4085 RVA: 0x0000823C File Offset: 0x0000643C
		[XmlElement("LimitationDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LimitationDescriptionType[] LimitationDescription
		{
			get
			{
				return this.limitationDescriptionField;
			}
			set
			{
				this.limitationDescriptionField = value;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x00008245 File Offset: 0x00006445
		// (set) Token: 0x06000FF7 RID: 4087 RVA: 0x0000824D File Offset: 0x0000644D
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ExpectedQuantityType ExpectedQuantity
		{
			get
			{
				return this.expectedQuantityField;
			}
			set
			{
				this.expectedQuantityField = value;
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x00008256 File Offset: 0x00006456
		// (set) Token: 0x06000FF9 RID: 4089 RVA: 0x0000825E File Offset: 0x0000645E
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MaximumQuantityType MaximumQuantity
		{
			get
			{
				return this.maximumQuantityField;
			}
			set
			{
				this.maximumQuantityField = value;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000FFA RID: 4090 RVA: 0x00008267 File Offset: 0x00006467
		// (set) Token: 0x06000FFB RID: 4091 RVA: 0x0000826F File Offset: 0x0000646F
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MinimumQuantityType MinimumQuantity
		{
			get
			{
				return this.minimumQuantityField;
			}
			set
			{
				this.minimumQuantityField = value;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000FFC RID: 4092 RVA: 0x00008278 File Offset: 0x00006478
		// (set) Token: 0x06000FFD RID: 4093 RVA: 0x00008280 File Offset: 0x00006480
		[XmlElement("PreSelectedParty")]
		public PartyType[] PreSelectedParty
		{
			get
			{
				return this.preSelectedPartyField;
			}
			set
			{
				this.preSelectedPartyField = value;
			}
		}

		// Token: 0x040005F2 RID: 1522
		private LimitationDescriptionType[] limitationDescriptionField;

		// Token: 0x040005F3 RID: 1523
		private ExpectedQuantityType expectedQuantityField;

		// Token: 0x040005F4 RID: 1524
		private MaximumQuantityType maximumQuantityField;

		// Token: 0x040005F5 RID: 1525
		private MinimumQuantityType minimumQuantityField;

		// Token: 0x040005F6 RID: 1526
		private PartyType[] preSelectedPartyField;
	}
}

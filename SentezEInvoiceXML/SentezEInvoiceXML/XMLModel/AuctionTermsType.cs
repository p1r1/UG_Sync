using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000418 RID: 1048
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("AuctionTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class AuctionTermsType
	{
		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x00005C27 File Offset: 0x00003E27
		// (set) Token: 0x06000B3A RID: 2874 RVA: 0x00005C2F File Offset: 0x00003E2F
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AuctionConstraintIndicatorType AuctionConstraintIndicator
		{
			get
			{
				return this.auctionConstraintIndicatorField;
			}
			set
			{
				this.auctionConstraintIndicatorField = value;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x00005C38 File Offset: 0x00003E38
		// (set) Token: 0x06000B3C RID: 2876 RVA: 0x00005C40 File Offset: 0x00003E40
		[XmlElement("JustificationDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public JustificationDescriptionType[] JustificationDescription
		{
			get
			{
				return this.justificationDescriptionField;
			}
			set
			{
				this.justificationDescriptionField = value;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x00005C49 File Offset: 0x00003E49
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x00005C51 File Offset: 0x00003E51
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

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x00005C5A File Offset: 0x00003E5A
		// (set) Token: 0x06000B40 RID: 2880 RVA: 0x00005C62 File Offset: 0x00003E62
		[XmlElement("ProcessDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ProcessDescriptionType[] ProcessDescription
		{
			get
			{
				return this.processDescriptionField;
			}
			set
			{
				this.processDescriptionField = value;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x00005C6B File Offset: 0x00003E6B
		// (set) Token: 0x06000B42 RID: 2882 RVA: 0x00005C73 File Offset: 0x00003E73
		[XmlElement("ConditionsDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ConditionsDescriptionType[] ConditionsDescription
		{
			get
			{
				return this.conditionsDescriptionField;
			}
			set
			{
				this.conditionsDescriptionField = value;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x00005C7C File Offset: 0x00003E7C
		// (set) Token: 0x06000B44 RID: 2884 RVA: 0x00005C84 File Offset: 0x00003E84
		[XmlElement("ElectronicDeviceDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ElectronicDeviceDescriptionType[] ElectronicDeviceDescription
		{
			get
			{
				return this.electronicDeviceDescriptionField;
			}
			set
			{
				this.electronicDeviceDescriptionField = value;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x00005C8D File Offset: 0x00003E8D
		// (set) Token: 0x06000B46 RID: 2886 RVA: 0x00005C95 File Offset: 0x00003E95
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AuctionURIType AuctionURI
		{
			get
			{
				return this.auctionURIField;
			}
			set
			{
				this.auctionURIField = value;
			}
		}

		// Token: 0x040003B5 RID: 949
		private AuctionConstraintIndicatorType auctionConstraintIndicatorField;

		// Token: 0x040003B6 RID: 950
		private JustificationDescriptionType[] justificationDescriptionField;

		// Token: 0x040003B7 RID: 951
		private DescriptionType[] descriptionField;

		// Token: 0x040003B8 RID: 952
		private ProcessDescriptionType[] processDescriptionField;

		// Token: 0x040003B9 RID: 953
		private ConditionsDescriptionType[] conditionsDescriptionField;

		// Token: 0x040003BA RID: 954
		private ElectronicDeviceDescriptionType[] electronicDeviceDescriptionField;

		// Token: 0x040003BB RID: 955
		private AuctionURIType auctionURIField;
	}
}

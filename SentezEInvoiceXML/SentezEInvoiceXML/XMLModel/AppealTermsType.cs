using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000416 RID: 1046
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("AppealTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class AppealTermsType
	{
		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x00005B9F File Offset: 0x00003D9F
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x00005BA7 File Offset: 0x00003DA7
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

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x00005BB0 File Offset: 0x00003DB0
		// (set) Token: 0x06000B2A RID: 2858 RVA: 0x00005BB8 File Offset: 0x00003DB8
		public PeriodType PresentationPeriod
		{
			get
			{
				return this.presentationPeriodField;
			}
			set
			{
				this.presentationPeriodField = value;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x00005BC1 File Offset: 0x00003DC1
		// (set) Token: 0x06000B2C RID: 2860 RVA: 0x00005BC9 File Offset: 0x00003DC9
		public PartyType AppealInformationParty
		{
			get
			{
				return this.appealInformationPartyField;
			}
			set
			{
				this.appealInformationPartyField = value;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x00005BD2 File Offset: 0x00003DD2
		// (set) Token: 0x06000B2E RID: 2862 RVA: 0x00005BDA File Offset: 0x00003DDA
		public PartyType AppealReceiverParty
		{
			get
			{
				return this.appealReceiverPartyField;
			}
			set
			{
				this.appealReceiverPartyField = value;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x00005BE3 File Offset: 0x00003DE3
		// (set) Token: 0x06000B30 RID: 2864 RVA: 0x00005BEB File Offset: 0x00003DEB
		public PartyType MediationParty
		{
			get
			{
				return this.mediationPartyField;
			}
			set
			{
				this.mediationPartyField = value;
			}
		}

		// Token: 0x040003AD RID: 941
		private DescriptionType[] descriptionField;

		// Token: 0x040003AE RID: 942
		private PeriodType presentationPeriodField;

		// Token: 0x040003AF RID: 943
		private PartyType appealInformationPartyField;

		// Token: 0x040003B0 RID: 944
		private PartyType appealReceiverPartyField;

		// Token: 0x040003B1 RID: 945
		private PartyType mediationPartyField;
	}
}

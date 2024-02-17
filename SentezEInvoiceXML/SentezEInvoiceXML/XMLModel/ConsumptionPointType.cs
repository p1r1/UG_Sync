using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200044D RID: 1101
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ConsumptionPoint", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ConsumptionPointType
	{
		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000F16 RID: 3862 RVA: 0x00007B3B File Offset: 0x00005D3B
		// (set) Token: 0x06000F17 RID: 3863 RVA: 0x00007B43 File Offset: 0x00005D43
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

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000F18 RID: 3864 RVA: 0x00007B4C File Offset: 0x00005D4C
		// (set) Token: 0x06000F19 RID: 3865 RVA: 0x00007B54 File Offset: 0x00005D54
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

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000F1A RID: 3866 RVA: 0x00007B5D File Offset: 0x00005D5D
		// (set) Token: 0x06000F1B RID: 3867 RVA: 0x00007B65 File Offset: 0x00005D65
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SubscriberIDType SubscriberID
		{
			get
			{
				return this.subscriberIDField;
			}
			set
			{
				this.subscriberIDField = value;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000F1C RID: 3868 RVA: 0x00007B6E File Offset: 0x00005D6E
		// (set) Token: 0x06000F1D RID: 3869 RVA: 0x00007B76 File Offset: 0x00005D76
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SubscriberTypeType SubscriberType
		{
			get
			{
				return this.subscriberTypeField;
			}
			set
			{
				this.subscriberTypeField = value;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000F1E RID: 3870 RVA: 0x00007B7F File Offset: 0x00005D7F
		// (set) Token: 0x06000F1F RID: 3871 RVA: 0x00007B87 File Offset: 0x00005D87
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SubscriberTypeCodeType SubscriberTypeCode
		{
			get
			{
				return this.subscriberTypeCodeField;
			}
			set
			{
				this.subscriberTypeCodeField = value;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x00007B90 File Offset: 0x00005D90
		// (set) Token: 0x06000F21 RID: 3873 RVA: 0x00007B98 File Offset: 0x00005D98
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

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x00007BA1 File Offset: 0x00005DA1
		// (set) Token: 0x06000F23 RID: 3875 RVA: 0x00007BA9 File Offset: 0x00005DA9
		public AddressType Address
		{
			get
			{
				return this.addressField;
			}
			set
			{
				this.addressField = value;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000F24 RID: 3876 RVA: 0x00007BB2 File Offset: 0x00005DB2
		// (set) Token: 0x06000F25 RID: 3877 RVA: 0x00007BBA File Offset: 0x00005DBA
		public WebSiteAccessType WebSiteAccess
		{
			get
			{
				return this.webSiteAccessField;
			}
			set
			{
				this.webSiteAccessField = value;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000F26 RID: 3878 RVA: 0x00007BC3 File Offset: 0x00005DC3
		// (set) Token: 0x06000F27 RID: 3879 RVA: 0x00007BCB File Offset: 0x00005DCB
		[XmlElement("UtilityMeter")]
		public MeterType[] UtilityMeter
		{
			get
			{
				return this.utilityMeterField;
			}
			set
			{
				this.utilityMeterField = value;
			}
		}

		// Token: 0x04000589 RID: 1417
		private IDType idField;

		// Token: 0x0400058A RID: 1418
		private DescriptionType[] descriptionField;

		// Token: 0x0400058B RID: 1419
		private SubscriberIDType subscriberIDField;

		// Token: 0x0400058C RID: 1420
		private SubscriberTypeType subscriberTypeField;

		// Token: 0x0400058D RID: 1421
		private SubscriberTypeCodeType subscriberTypeCodeField;

		// Token: 0x0400058E RID: 1422
		private TotalDeliveredQuantityType totalDeliveredQuantityField;

		// Token: 0x0400058F RID: 1423
		private AddressType addressField;

		// Token: 0x04000590 RID: 1424
		private WebSiteAccessType webSiteAccessField;

		// Token: 0x04000591 RID: 1425
		private MeterType[] utilityMeterField;
	}
}

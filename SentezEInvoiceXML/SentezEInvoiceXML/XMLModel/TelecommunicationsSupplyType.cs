using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000446 RID: 1094
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("TelecommunicationsSupply", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class TelecommunicationsSupplyType
	{
		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000E75 RID: 3701 RVA: 0x0000761E File Offset: 0x0000581E
		// (set) Token: 0x06000E76 RID: 3702 RVA: 0x00007626 File Offset: 0x00005826
		[XmlElement("TelecommunicationsSupplyType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TelecommunicationsSupplyTypeType TelecommunicationsSupplyType1
		{
			get
			{
				return this.telecommunicationsSupplyType1Field;
			}
			set
			{
				this.telecommunicationsSupplyType1Field = value;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000E77 RID: 3703 RVA: 0x0000762F File Offset: 0x0000582F
		// (set) Token: 0x06000E78 RID: 3704 RVA: 0x00007637 File Offset: 0x00005837
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TelecommunicationsSupplyTypeCodeType TelecommunicationsSupplyTypeCode
		{
			get
			{
				return this.telecommunicationsSupplyTypeCodeField;
			}
			set
			{
				this.telecommunicationsSupplyTypeCodeField = value;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000E79 RID: 3705 RVA: 0x00007640 File Offset: 0x00005840
		// (set) Token: 0x06000E7A RID: 3706 RVA: 0x00007648 File Offset: 0x00005848
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PrivacyCodeType PrivacyCode
		{
			get
			{
				return this.privacyCodeField;
			}
			set
			{
				this.privacyCodeField = value;
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000E7B RID: 3707 RVA: 0x00007651 File Offset: 0x00005851
		// (set) Token: 0x06000E7C RID: 3708 RVA: 0x00007659 File Offset: 0x00005859
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

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000E7D RID: 3709 RVA: 0x00007662 File Offset: 0x00005862
		// (set) Token: 0x06000E7E RID: 3710 RVA: 0x0000766A File Offset: 0x0000586A
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TotalAmountType TotalAmount
		{
			get
			{
				return this.totalAmountField;
			}
			set
			{
				this.totalAmountField = value;
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000E7F RID: 3711 RVA: 0x00007673 File Offset: 0x00005873
		// (set) Token: 0x06000E80 RID: 3712 RVA: 0x0000767B File Offset: 0x0000587B
		[XmlElement("TelecommunicationsSupplyLine")]
		public TelecommunicationsSupplyLineType[] TelecommunicationsSupplyLine
		{
			get
			{
				return this.telecommunicationsSupplyLineField;
			}
			set
			{
				this.telecommunicationsSupplyLineField = value;
			}
		}

		// Token: 0x0400053C RID: 1340
		private TelecommunicationsSupplyTypeType telecommunicationsSupplyType1Field;

		// Token: 0x0400053D RID: 1341
		private TelecommunicationsSupplyTypeCodeType telecommunicationsSupplyTypeCodeField;

		// Token: 0x0400053E RID: 1342
		private PrivacyCodeType privacyCodeField;

		// Token: 0x0400053F RID: 1343
		private DescriptionType[] descriptionField;

		// Token: 0x04000540 RID: 1344
		private TotalAmountType totalAmountField;

		// Token: 0x04000541 RID: 1345
		private TelecommunicationsSupplyLineType[] telecommunicationsSupplyLineField;
	}
}

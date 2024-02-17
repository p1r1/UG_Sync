using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200048C RID: 1164
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("SupplierConsumption", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class SupplierConsumptionType
	{
		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x0600131B RID: 4891 RVA: 0x00009B4E File Offset: 0x00007D4E
		// (set) Token: 0x0600131C RID: 4892 RVA: 0x00009B56 File Offset: 0x00007D56
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

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x0600131D RID: 4893 RVA: 0x00009B5F File Offset: 0x00007D5F
		// (set) Token: 0x0600131E RID: 4894 RVA: 0x00009B67 File Offset: 0x00007D67
		public PartyType UtilitySupplierParty
		{
			get
			{
				return this.utilitySupplierPartyField;
			}
			set
			{
				this.utilitySupplierPartyField = value;
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x0600131F RID: 4895 RVA: 0x00009B70 File Offset: 0x00007D70
		// (set) Token: 0x06001320 RID: 4896 RVA: 0x00009B78 File Offset: 0x00007D78
		public PartyType UtilityCustomerParty
		{
			get
			{
				return this.utilityCustomerPartyField;
			}
			set
			{
				this.utilityCustomerPartyField = value;
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06001321 RID: 4897 RVA: 0x00009B81 File Offset: 0x00007D81
		// (set) Token: 0x06001322 RID: 4898 RVA: 0x00009B89 File Offset: 0x00007D89
		public ConsumptionType Consumption
		{
			get
			{
				return this.consumptionField;
			}
			set
			{
				this.consumptionField = value;
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06001323 RID: 4899 RVA: 0x00009B92 File Offset: 0x00007D92
		// (set) Token: 0x06001324 RID: 4900 RVA: 0x00009B9A File Offset: 0x00007D9A
		public ContractType Contract
		{
			get
			{
				return this.contractField;
			}
			set
			{
				this.contractField = value;
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06001325 RID: 4901 RVA: 0x00009BA3 File Offset: 0x00007DA3
		// (set) Token: 0x06001326 RID: 4902 RVA: 0x00009BAB File Offset: 0x00007DAB
		[XmlElement("ConsumptionLine")]
		public ConsumptionLineType[] ConsumptionLine
		{
			get
			{
				return this.consumptionLineField;
			}
			set
			{
				this.consumptionLineField = value;
			}
		}

		// Token: 0x0400076C RID: 1900
		private DescriptionType[] descriptionField;

		// Token: 0x0400076D RID: 1901
		private PartyType utilitySupplierPartyField;

		// Token: 0x0400076E RID: 1902
		private PartyType utilityCustomerPartyField;

		// Token: 0x0400076F RID: 1903
		private ConsumptionType consumptionField;

		// Token: 0x04000770 RID: 1904
		private ContractType contractField;

		// Token: 0x04000771 RID: 1905
		private ConsumptionLineType[] consumptionLineField;
	}
}

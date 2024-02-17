using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003EE RID: 1006
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("ApplicableTaxCategory", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class TaxCategoryType
	{
		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x00004C15 File Offset: 0x00002E15
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x00004C1D File Offset: 0x00002E1D
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NameType1 Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x00004C26 File Offset: 0x00002E26
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x00004C2E File Offset: 0x00002E2E
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TaxExemptionReasonCodeType TaxExemptionReasonCode
		{
			get
			{
				return this.taxExemptionReasonCodeField;
			}
			set
			{
				this.taxExemptionReasonCodeField = value;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x00004C37 File Offset: 0x00002E37
		// (set) Token: 0x06000930 RID: 2352 RVA: 0x00004C3F File Offset: 0x00002E3F
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TaxExemptionReasonType TaxExemptionReason
		{
			get
			{
				return this.taxExemptionReasonField;
			}
			set
			{
				this.taxExemptionReasonField = value;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x00004C48 File Offset: 0x00002E48
		// (set) Token: 0x06000932 RID: 2354 RVA: 0x00004C50 File Offset: 0x00002E50
		public TaxSchemeType TaxScheme
		{
			get
			{
				return this.taxSchemeField;
			}
			set
			{
				this.taxSchemeField = value;
			}
		}

		// Token: 0x040002C3 RID: 707
		private NameType1 nameField;

		// Token: 0x040002C4 RID: 708
		private TaxExemptionReasonCodeType taxExemptionReasonCodeField;

		// Token: 0x040002C5 RID: 709
		private TaxExemptionReasonType taxExemptionReasonField;

		// Token: 0x040002C6 RID: 710
		private TaxSchemeType taxSchemeField;
	}
}

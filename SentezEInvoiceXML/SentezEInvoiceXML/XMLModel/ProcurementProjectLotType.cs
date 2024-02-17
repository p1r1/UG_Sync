using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200041A RID: 1050
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("InterestedProcurementProjectLot", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ProcurementProjectLotType
	{
		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x00005D59 File Offset: 0x00003F59
		// (set) Token: 0x06000B60 RID: 2912 RVA: 0x00005D61 File Offset: 0x00003F61
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

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000B61 RID: 2913 RVA: 0x00005D6A File Offset: 0x00003F6A
		// (set) Token: 0x06000B62 RID: 2914 RVA: 0x00005D72 File Offset: 0x00003F72
		public TenderingTermsType TenderingTerms
		{
			get
			{
				return this.tenderingTermsField;
			}
			set
			{
				this.tenderingTermsField = value;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x00005D7B File Offset: 0x00003F7B
		// (set) Token: 0x06000B64 RID: 2916 RVA: 0x00005D83 File Offset: 0x00003F83
		public ProcurementProjectType ProcurementProject
		{
			get
			{
				return this.procurementProjectField;
			}
			set
			{
				this.procurementProjectField = value;
			}
		}

		// Token: 0x040003C7 RID: 967
		private IDType idField;

		// Token: 0x040003C8 RID: 968
		private TenderingTermsType tenderingTermsField;

		// Token: 0x040003C9 RID: 969
		private ProcurementProjectType procurementProjectField;
	}
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000414 RID: 1044
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("DependentPriceReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class DependentPriceReferenceType
	{
		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x00005B4A File Offset: 0x00003D4A
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x00005B52 File Offset: 0x00003D52
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PercentType1 Percent
		{
			get
			{
				return this.percentField;
			}
			set
			{
				this.percentField = value;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x00005B5B File Offset: 0x00003D5B
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x00005B63 File Offset: 0x00003D63
		public AddressType LocationAddress
		{
			get
			{
				return this.locationAddressField;
			}
			set
			{
				this.locationAddressField = value;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x00005B6C File Offset: 0x00003D6C
		// (set) Token: 0x06000B20 RID: 2848 RVA: 0x00005B74 File Offset: 0x00003D74
		public LineReferenceType DependentLineReference
		{
			get
			{
				return this.dependentLineReferenceField;
			}
			set
			{
				this.dependentLineReferenceField = value;
			}
		}

		// Token: 0x040003A8 RID: 936
		private PercentType1 percentField;

		// Token: 0x040003A9 RID: 937
		private AddressType locationAddressField;

		// Token: 0x040003AA RID: 938
		private LineReferenceType dependentLineReferenceField;
	}
}

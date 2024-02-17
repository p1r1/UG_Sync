using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000389 RID: 905
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("AdditionalTemperature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class TemperatureType
	{
		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x00003AB0 File Offset: 0x00001CB0
		// (set) Token: 0x060006BD RID: 1725 RVA: 0x00003AB8 File Offset: 0x00001CB8
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AttributeIDType AttributeID
		{
			get
			{
				return this.attributeIDField;
			}
			set
			{
				this.attributeIDField = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x00003AC1 File Offset: 0x00001CC1
		// (set) Token: 0x060006BF RID: 1727 RVA: 0x00003AC9 File Offset: 0x00001CC9
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MeasureType2 Measure
		{
			get
			{
				return this.measureField;
			}
			set
			{
				this.measureField = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x00003AD2 File Offset: 0x00001CD2
		// (set) Token: 0x060006C1 RID: 1729 RVA: 0x00003ADA File Offset: 0x00001CDA
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

		// Token: 0x040001BE RID: 446
		private AttributeIDType attributeIDField;

		// Token: 0x040001BF RID: 447
		private MeasureType2 measureField;

		// Token: 0x040001C0 RID: 448
		private DescriptionType[] descriptionField;
	}
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020003D6 RID: 982
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("Dimension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class DimensionType
	{
		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x00004252 File Offset: 0x00002452
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x0000425A File Offset: 0x0000245A
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

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x00004263 File Offset: 0x00002463
		// (set) Token: 0x060007F0 RID: 2032 RVA: 0x0000426B File Offset: 0x0000246B
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

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x00004274 File Offset: 0x00002474
		// (set) Token: 0x060007F2 RID: 2034 RVA: 0x0000427C File Offset: 0x0000247C
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

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x00004285 File Offset: 0x00002485
		// (set) Token: 0x060007F4 RID: 2036 RVA: 0x0000428D File Offset: 0x0000248D
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MinimumMeasureType MinimumMeasure
		{
			get
			{
				return this.minimumMeasureField;
			}
			set
			{
				this.minimumMeasureField = value;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x00004296 File Offset: 0x00002496
		// (set) Token: 0x060007F6 RID: 2038 RVA: 0x0000429E File Offset: 0x0000249E
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MaximumMeasureType MaximumMeasure
		{
			get
			{
				return this.maximumMeasureField;
			}
			set
			{
				this.maximumMeasureField = value;
			}
		}

		// Token: 0x04000230 RID: 560
		private AttributeIDType attributeIDField;

		// Token: 0x04000231 RID: 561
		private MeasureType2 measureField;

		// Token: 0x04000232 RID: 562
		private DescriptionType[] descriptionField;

		// Token: 0x04000233 RID: 563
		private MinimumMeasureType minimumMeasureField;

		// Token: 0x04000234 RID: 564
		private MaximumMeasureType maximumMeasureField;
	}
}

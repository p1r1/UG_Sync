using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000451 RID: 1105
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("MeterProperty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class MeterPropertyType
	{
		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x00007D5B File Offset: 0x00005F5B
		// (set) Token: 0x06000F5B RID: 3931 RVA: 0x00007D63 File Offset: 0x00005F63
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

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x00007D6C File Offset: 0x00005F6C
		// (set) Token: 0x06000F5D RID: 3933 RVA: 0x00007D74 File Offset: 0x00005F74
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NameCodeType NameCode
		{
			get
			{
				return this.nameCodeField;
			}
			set
			{
				this.nameCodeField = value;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x00007D7D File Offset: 0x00005F7D
		// (set) Token: 0x06000F5F RID: 3935 RVA: 0x00007D85 File Offset: 0x00005F85
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ValueType Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x00007D8E File Offset: 0x00005F8E
		// (set) Token: 0x06000F61 RID: 3937 RVA: 0x00007D96 File Offset: 0x00005F96
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ValueQuantityType ValueQuantity
		{
			get
			{
				return this.valueQuantityField;
			}
			set
			{
				this.valueQuantityField = value;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000F62 RID: 3938 RVA: 0x00007D9F File Offset: 0x00005F9F
		// (set) Token: 0x06000F63 RID: 3939 RVA: 0x00007DA7 File Offset: 0x00005FA7
		[XmlElement("ValueQualifier", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ValueQualifierType[] ValueQualifier
		{
			get
			{
				return this.valueQualifierField;
			}
			set
			{
				this.valueQualifierField = value;
			}
		}

		// Token: 0x040005A9 RID: 1449
		private NameType1 nameField;

		// Token: 0x040005AA RID: 1450
		private NameCodeType nameCodeField;

		// Token: 0x040005AB RID: 1451
		private ValueType valueField;

		// Token: 0x040005AC RID: 1452
		private ValueQuantityType valueQuantityField;

		// Token: 0x040005AD RID: 1453
		private ValueQualifierType[] valueQualifierField;
	}
}

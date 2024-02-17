using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200043B RID: 1083
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("EndorserParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class EndorserPartyType
	{
		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000DDA RID: 3546 RVA: 0x00007156 File Offset: 0x00005356
		// (set) Token: 0x06000DDB RID: 3547 RVA: 0x0000715E File Offset: 0x0000535E
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public RoleCodeType RoleCode
		{
			get
			{
				return this.roleCodeField;
			}
			set
			{
				this.roleCodeField = value;
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x00007167 File Offset: 0x00005367
		// (set) Token: 0x06000DDD RID: 3549 RVA: 0x0000716F File Offset: 0x0000536F
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SequenceNumericType SequenceNumeric
		{
			get
			{
				return this.sequenceNumericField;
			}
			set
			{
				this.sequenceNumericField = value;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x00007178 File Offset: 0x00005378
		// (set) Token: 0x06000DDF RID: 3551 RVA: 0x00007180 File Offset: 0x00005380
		public PartyType Party
		{
			get
			{
				return this.partyField;
			}
			set
			{
				this.partyField = value;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x00007189 File Offset: 0x00005389
		// (set) Token: 0x06000DE1 RID: 3553 RVA: 0x00007191 File Offset: 0x00005391
		public ContactType SignatoryContact
		{
			get
			{
				return this.signatoryContactField;
			}
			set
			{
				this.signatoryContactField = value;
			}
		}

		// Token: 0x040004F4 RID: 1268
		private RoleCodeType roleCodeField;

		// Token: 0x040004F5 RID: 1269
		private SequenceNumericType sequenceNumericField;

		// Token: 0x040004F6 RID: 1270
		private PartyType partyField;

		// Token: 0x040004F7 RID: 1271
		private ContactType signatoryContactField;
	}
}

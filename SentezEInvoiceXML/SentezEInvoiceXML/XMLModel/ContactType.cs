using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200037B RID: 891
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("AccountingContact", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ContactType
	{
		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x000037E7 File Offset: 0x000019E7
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x000037EF File Offset: 0x000019EF
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TelephoneType Telephone
		{
			get
			{
				return this.telephoneField;
			}
			set
			{
				this.telephoneField = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x000037F8 File Offset: 0x000019F8
		// (set) Token: 0x0600065F RID: 1631 RVA: 0x00003800 File Offset: 0x00001A00
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TelefaxType Telefax
		{
			get
			{
				return this.telefaxField;
			}
			set
			{
				this.telefaxField = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x00003809 File Offset: 0x00001A09
		// (set) Token: 0x06000661 RID: 1633 RVA: 0x00003811 File Offset: 0x00001A11
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ElectronicMailType ElectronicMail
		{
			get
			{
				return this.electronicMailField;
			}
			set
			{
				this.electronicMailField = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x0000381A File Offset: 0x00001A1A
		// (set) Token: 0x06000663 RID: 1635 RVA: 0x00003822 File Offset: 0x00001A22
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NoteType Note
		{
			get
			{
				return this.noteField;
			}
			set
			{
				this.noteField = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x0000382B File Offset: 0x00001A2B
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x00003833 File Offset: 0x00001A33
		[XmlElement("OtherCommunication")]
		public CommunicationType[] OtherCommunication
		{
			get
			{
				return this.otherCommunicationField;
			}
			set
			{
				this.otherCommunicationField = value;
			}
		}

		// Token: 0x04000195 RID: 405
		private TelephoneType telephoneField;

		// Token: 0x04000196 RID: 406
		private TelefaxType telefaxField;

		// Token: 0x04000197 RID: 407
		private ElectronicMailType electronicMailField;

		// Token: 0x04000198 RID: 408
		private NoteType noteField;

		// Token: 0x04000199 RID: 409
		private CommunicationType[] otherCommunicationField;
	}
}

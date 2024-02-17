using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000402 RID: 1026
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[XmlRoot("BusinessClassificationScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
	[Serializable]
	public class ClassificationSchemeType
	{
		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x000052B9 File Offset: 0x000034B9
		// (set) Token: 0x06000A08 RID: 2568 RVA: 0x000052C1 File Offset: 0x000034C1
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

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x000052CA File Offset: 0x000034CA
		// (set) Token: 0x06000A0A RID: 2570 RVA: 0x000052D2 File Offset: 0x000034D2
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public UUIDType UUID
		{
			get
			{
				return this.uUIDField;
			}
			set
			{
				this.uUIDField = value;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x000052DB File Offset: 0x000034DB
		// (set) Token: 0x06000A0C RID: 2572 RVA: 0x000052E3 File Offset: 0x000034E3
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LastRevisionDateType LastRevisionDate
		{
			get
			{
				return this.lastRevisionDateField;
			}
			set
			{
				this.lastRevisionDateField = value;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x000052EC File Offset: 0x000034EC
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x000052F4 File Offset: 0x000034F4
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LastRevisionTimeType LastRevisionTime
		{
			get
			{
				return this.lastRevisionTimeField;
			}
			set
			{
				this.lastRevisionTimeField = value;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x000052FD File Offset: 0x000034FD
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x00005305 File Offset: 0x00003505
		[XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NoteType[] Note
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

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x0000530E File Offset: 0x0000350E
		// (set) Token: 0x06000A12 RID: 2578 RVA: 0x00005316 File Offset: 0x00003516
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

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x0000531F File Offset: 0x0000351F
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x00005327 File Offset: 0x00003527
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

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x00005330 File Offset: 0x00003530
		// (set) Token: 0x06000A16 RID: 2582 RVA: 0x00005338 File Offset: 0x00003538
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AgencyIDType AgencyID
		{
			get
			{
				return this.agencyIDField;
			}
			set
			{
				this.agencyIDField = value;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x00005341 File Offset: 0x00003541
		// (set) Token: 0x06000A18 RID: 2584 RVA: 0x00005349 File Offset: 0x00003549
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AgencyNameType AgencyName
		{
			get
			{
				return this.agencyNameField;
			}
			set
			{
				this.agencyNameField = value;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x00005352 File Offset: 0x00003552
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x0000535A File Offset: 0x0000355A
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public VersionIDType VersionID
		{
			get
			{
				return this.versionIDField;
			}
			set
			{
				this.versionIDField = value;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00005363 File Offset: 0x00003563
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x0000536B File Offset: 0x0000356B
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public URIType URI
		{
			get
			{
				return this.uRIField;
			}
			set
			{
				this.uRIField = value;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x00005374 File Offset: 0x00003574
		// (set) Token: 0x06000A1E RID: 2590 RVA: 0x0000537C File Offset: 0x0000357C
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SchemeURIType SchemeURI
		{
			get
			{
				return this.schemeURIField;
			}
			set
			{
				this.schemeURIField = value;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x00005385 File Offset: 0x00003585
		// (set) Token: 0x06000A20 RID: 2592 RVA: 0x0000538D File Offset: 0x0000358D
		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LanguageIDType LanguageID
		{
			get
			{
				return this.languageIDField;
			}
			set
			{
				this.languageIDField = value;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x00005396 File Offset: 0x00003596
		// (set) Token: 0x06000A22 RID: 2594 RVA: 0x0000539E File Offset: 0x0000359E
		[XmlElement("ClassificationCategory")]
		public ClassificationCategoryType[] ClassificationCategory
		{
			get
			{
				return this.classificationCategoryField;
			}
			set
			{
				this.classificationCategoryField = value;
			}
		}

		// Token: 0x04000327 RID: 807
		private IDType idField;

		// Token: 0x04000328 RID: 808
		private UUIDType uUIDField;

		// Token: 0x04000329 RID: 809
		private LastRevisionDateType lastRevisionDateField;

		// Token: 0x0400032A RID: 810
		private LastRevisionTimeType lastRevisionTimeField;

		// Token: 0x0400032B RID: 811
		private NoteType[] noteField;

		// Token: 0x0400032C RID: 812
		private NameType1 nameField;

		// Token: 0x0400032D RID: 813
		private DescriptionType[] descriptionField;

		// Token: 0x0400032E RID: 814
		private AgencyIDType agencyIDField;

		// Token: 0x0400032F RID: 815
		private AgencyNameType agencyNameField;

		// Token: 0x04000330 RID: 816
		private VersionIDType versionIDField;

		// Token: 0x04000331 RID: 817
		private URIType uRIField;

		// Token: 0x04000332 RID: 818
		private SchemeURIType schemeURIField;

		// Token: 0x04000333 RID: 819
		private LanguageIDType languageIDField;

		// Token: 0x04000334 RID: 820
		private ClassificationCategoryType[] classificationCategoryField;
	}
}

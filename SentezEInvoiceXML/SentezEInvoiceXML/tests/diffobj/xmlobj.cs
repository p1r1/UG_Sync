using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SentezEInvoiceXML.diffobj {

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2", IsNullable = false)]
    public partial class Invoicexxx {

        private UBLExtensions uBLExtensionsField;

        private decimal uBLVersionIDField;

        private string customizationIDField;

        private string profileIDField;

        private ID idField;

        private bool copyIndicatorField;

        private string uUIDField;

        private System.DateTime issueDateField;

        private System.DateTime issueTimeField;

        private string invoiceTypeCodeField;

        private string[] noteField;

        private string documentCurrencyCodeField;

        private byte lineCountNumericField;

        private DespatchDocumentReference despatchDocumentReferenceField;

        private AdditionalDocumentReference additionalDocumentReferenceField;

        private Signature signatureField;

        private AccountingSupplierParty accountingSupplierPartyField;

        private AccountingCustomerParty accountingCustomerPartyField;

        private PaymentMeans paymentMeansField;

        private PaymentTerms paymentTermsField;

        private TaxTotal taxTotalField;

        private LegalMonetaryTotal legalMonetaryTotalField;

        private InvoiceLine[] invoiceLineField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        public UBLExtensions UBLExtensions {
            get {
                return this.uBLExtensionsField;
            }
            set {
                this.uBLExtensionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public decimal UBLVersionID {
            get {
                return this.uBLVersionIDField;
            }
            set {
                this.uBLVersionIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string CustomizationID {
            get {
                return this.customizationIDField;
            }
            set {
                this.customizationIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string ProfileID {
            get {
                return this.profileIDField;
            }
            set {
                this.profileIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public bool CopyIndicator {
            get {
                return this.copyIndicatorField;
            }
            set {
                this.copyIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string UUID {
            get {
                return this.uUIDField;
            }
            set {
                this.uUIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", DataType = "date")]
        public System.DateTime IssueDate {
            get {
                return this.issueDateField;
            }
            set {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", DataType = "time")]
        public System.DateTime IssueTime {
            get {
                return this.issueTimeField;
            }
            set {
                this.issueTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string InvoiceTypeCode {
            get {
                return this.invoiceTypeCodeField;
            }
            set {
                this.invoiceTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string[] Note {
            get {
                return this.noteField;
            }
            set {
                this.noteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string DocumentCurrencyCode {
            get {
                return this.documentCurrencyCodeField;
            }
            set {
                this.documentCurrencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public byte LineCountNumeric {
            get {
                return this.lineCountNumericField;
            }
            set {
                this.lineCountNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DespatchDocumentReference DespatchDocumentReference {
            get {
                return this.despatchDocumentReferenceField;
            }
            set {
                this.despatchDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public AdditionalDocumentReference AdditionalDocumentReference {
            get {
                return this.additionalDocumentReferenceField;
            }
            set {
                this.additionalDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Signature Signature {
            get {
                return this.signatureField;
            }
            set {
                this.signatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public AccountingSupplierParty AccountingSupplierParty {
            get {
                return this.accountingSupplierPartyField;
            }
            set {
                this.accountingSupplierPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public AccountingCustomerParty AccountingCustomerParty {
            get {
                return this.accountingCustomerPartyField;
            }
            set {
                this.accountingCustomerPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PaymentMeans PaymentMeans {
            get {
                return this.paymentMeansField;
            }
            set {
                this.paymentMeansField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PaymentTerms PaymentTerms {
            get {
                return this.paymentTermsField;
            }
            set {
                this.paymentTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TaxTotal TaxTotal {
            get {
                return this.taxTotalField;
            }
            set {
                this.taxTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public LegalMonetaryTotal LegalMonetaryTotal {
            get {
                return this.legalMonetaryTotalField;
            }
            set {
                this.legalMonetaryTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InvoiceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public InvoiceLine[] InvoiceLine {
            get {
                return this.invoiceLineField;
            }
            set {
                this.invoiceLineField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", IsNullable = false)]
    public partial class UBLExtensions {

        private UBLExtensionsUBLExtension uBLExtensionField;

        /// <remarks/>
        public UBLExtensionsUBLExtension UBLExtension {
            get {
                return this.uBLExtensionField;
            }
            set {
                this.uBLExtensionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public partial class UBLExtensionsUBLExtension {

        private object extensionContentField;

        /// <remarks/>
        public object ExtensionContent {
            get {
                return this.extensionContentField;
            }
            set {
                this.extensionContentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
    public partial class ID {

        private string schemeIDField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string schemeID {
            get {
                return this.schemeIDField;
            }
            set {
                this.schemeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class DespatchDocumentReference {

        private ID idField;

        private System.DateTime issueDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", DataType = "date")]
        public System.DateTime IssueDate {
            get {
                return this.issueDateField;
            }
            set {
                this.issueDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class AdditionalDocumentReference {

        private ID idField;

        private System.DateTime issueDateField;

        private string documentTypeField;

        private AdditionalDocumentReferenceAttachment attachmentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", DataType = "date")]
        public System.DateTime IssueDate {
            get {
                return this.issueDateField;
            }
            set {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string DocumentType {
            get {
                return this.documentTypeField;
            }
            set {
                this.documentTypeField = value;
            }
        }

        /// <remarks/>
        public AdditionalDocumentReferenceAttachment Attachment {
            get {
                return this.attachmentField;
            }
            set {
                this.attachmentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AdditionalDocumentReferenceAttachment {

        private EmbeddedDocumentBinaryObject embeddedDocumentBinaryObjectField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EmbeddedDocumentBinaryObject EmbeddedDocumentBinaryObject {
            get {
                return this.embeddedDocumentBinaryObjectField;
            }
            set {
                this.embeddedDocumentBinaryObjectField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
    public partial class EmbeddedDocumentBinaryObject {

        private string mimeCodeField;

        private string encodingCodeField;

        private string characterSetCodeField;

        private string filenameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string mimeCode {
            get {
                return this.mimeCodeField;
            }
            set {
                this.mimeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string encodingCode {
            get {
                return this.encodingCodeField;
            }
            set {
                this.encodingCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string characterSetCode {
            get {
                return this.characterSetCodeField;
            }
            set {
                this.characterSetCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string filename {
            get {
                return this.filenameField;
            }
            set {
                this.filenameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class Signature {

        private ID idField;

        private SignatureSignatoryParty signatoryPartyField;

        private SignatureDigitalSignatureAttachment digitalSignatureAttachmentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        public SignatureSignatoryParty SignatoryParty {
            get {
                return this.signatoryPartyField;
            }
            set {
                this.signatoryPartyField = value;
            }
        }

        /// <remarks/>
        public SignatureDigitalSignatureAttachment DigitalSignatureAttachment {
            get {
                return this.digitalSignatureAttachmentField;
            }
            set {
                this.digitalSignatureAttachmentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class SignatureSignatoryParty {

        private SignatureSignatoryPartyPartyIdentification partyIdentificationField;

        private SignatureSignatoryPartyPostalAddress postalAddressField;

        /// <remarks/>
        public SignatureSignatoryPartyPartyIdentification PartyIdentification {
            get {
                return this.partyIdentificationField;
            }
            set {
                this.partyIdentificationField = value;
            }
        }

        /// <remarks/>
        public SignatureSignatoryPartyPostalAddress PostalAddress {
            get {
                return this.postalAddressField;
            }
            set {
                this.postalAddressField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class SignatureSignatoryPartyPartyIdentification {

        private ID idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class SignatureSignatoryPartyPostalAddress {

        private string streetNameField;

        private string buildingNameField;

        private string buildingNumberField;

        private string citySubdivisionNameField;

        private string cityNameField;

        private uint postalZoneField;

        private SignatureSignatoryPartyPostalAddressCountry countryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string StreetName {
            get {
                return this.streetNameField;
            }
            set {
                this.streetNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string BuildingName {
            get {
                return this.buildingNameField;
            }
            set {
                this.buildingNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string BuildingNumber {
            get {
                return this.buildingNumberField;
            }
            set {
                this.buildingNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string CitySubdivisionName {
            get {
                return this.citySubdivisionNameField;
            }
            set {
                this.citySubdivisionNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string CityName {
            get {
                return this.cityNameField;
            }
            set {
                this.cityNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public uint PostalZone {
            get {
                return this.postalZoneField;
            }
            set {
                this.postalZoneField = value;
            }
        }

        /// <remarks/>
        public SignatureSignatoryPartyPostalAddressCountry Country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class SignatureSignatoryPartyPostalAddressCountry {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class SignatureDigitalSignatureAttachment {

        private SignatureDigitalSignatureAttachmentExternalReference externalReferenceField;

        /// <remarks/>
        public SignatureDigitalSignatureAttachmentExternalReference ExternalReference {
            get {
                return this.externalReferenceField;
            }
            set {
                this.externalReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class SignatureDigitalSignatureAttachmentExternalReference {

        private string uRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string URI {
            get {
                return this.uRIField;
            }
            set {
                this.uRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class AccountingSupplierParty {

        private AccountingSupplierPartyParty partyField;

        /// <remarks/>
        public AccountingSupplierPartyParty Party {
            get {
                return this.partyField;
            }
            set {
                this.partyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AccountingSupplierPartyParty {

        private string websiteURIField;

        private AccountingSupplierPartyPartyPartyIdentification[] partyIdentificationField;

        private AccountingSupplierPartyPartyPartyName partyNameField;

        private AccountingSupplierPartyPartyPostalAddress postalAddressField;

        private AccountingSupplierPartyPartyPartyTaxScheme partyTaxSchemeField;

        private AccountingSupplierPartyPartyContact contactField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string WebsiteURI {
            get {
                return this.websiteURIField;
            }
            set {
                this.websiteURIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PartyIdentification")]
        public AccountingSupplierPartyPartyPartyIdentification[] PartyIdentification {
            get {
                return this.partyIdentificationField;
            }
            set {
                this.partyIdentificationField = value;
            }
        }

        /// <remarks/>
        public AccountingSupplierPartyPartyPartyName PartyName {
            get {
                return this.partyNameField;
            }
            set {
                this.partyNameField = value;
            }
        }

        /// <remarks/>
        public AccountingSupplierPartyPartyPostalAddress PostalAddress {
            get {
                return this.postalAddressField;
            }
            set {
                this.postalAddressField = value;
            }
        }

        /// <remarks/>
        public AccountingSupplierPartyPartyPartyTaxScheme PartyTaxScheme {
            get {
                return this.partyTaxSchemeField;
            }
            set {
                this.partyTaxSchemeField = value;
            }
        }

        /// <remarks/>
        public AccountingSupplierPartyPartyContact Contact {
            get {
                return this.contactField;
            }
            set {
                this.contactField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AccountingSupplierPartyPartyPartyIdentification {

        private ID idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AccountingSupplierPartyPartyPartyName {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AccountingSupplierPartyPartyPostalAddress {

        private string streetNameField;

        private string buildingNameField;

        private string buildingNumberField;

        private string citySubdivisionNameField;

        private string cityNameField;

        private uint postalZoneField;

        private AccountingSupplierPartyPartyPostalAddressCountry countryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string StreetName {
            get {
                return this.streetNameField;
            }
            set {
                this.streetNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string BuildingName {
            get {
                return this.buildingNameField;
            }
            set {
                this.buildingNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string BuildingNumber {
            get {
                return this.buildingNumberField;
            }
            set {
                this.buildingNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string CitySubdivisionName {
            get {
                return this.citySubdivisionNameField;
            }
            set {
                this.citySubdivisionNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string CityName {
            get {
                return this.cityNameField;
            }
            set {
                this.cityNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public uint PostalZone {
            get {
                return this.postalZoneField;
            }
            set {
                this.postalZoneField = value;
            }
        }

        /// <remarks/>
        public AccountingSupplierPartyPartyPostalAddressCountry Country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AccountingSupplierPartyPartyPostalAddressCountry {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AccountingSupplierPartyPartyPartyTaxScheme {

        private AccountingSupplierPartyPartyPartyTaxSchemeTaxScheme taxSchemeField;

        /// <remarks/>
        public AccountingSupplierPartyPartyPartyTaxSchemeTaxScheme TaxScheme {
            get {
                return this.taxSchemeField;
            }
            set {
                this.taxSchemeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AccountingSupplierPartyPartyPartyTaxSchemeTaxScheme {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AccountingSupplierPartyPartyContact {

        private ulong telephoneField;

        private object telefaxField;

        private string electronicMailField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ulong Telephone {
            get {
                return this.telephoneField;
            }
            set {
                this.telephoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public object Telefax {
            get {
                return this.telefaxField;
            }
            set {
                this.telefaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string ElectronicMail {
            get {
                return this.electronicMailField;
            }
            set {
                this.electronicMailField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class AccountingCustomerParty {

        private AccountingCustomerPartyParty partyField;

        /// <remarks/>
        public AccountingCustomerPartyParty Party {
            get {
                return this.partyField;
            }
            set {
                this.partyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AccountingCustomerPartyParty {

        private AccountingCustomerPartyPartyPartyIdentification partyIdentificationField;

        private AccountingCustomerPartyPartyPartyName partyNameField;

        private AccountingCustomerPartyPartyPostalAddress postalAddressField;

        private AccountingCustomerPartyPartyPartyTaxScheme partyTaxSchemeField;

        private AccountingCustomerPartyPartyContact contactField;

        private AccountingCustomerPartyPartyPerson personField;

        /// <remarks/>
        public AccountingCustomerPartyPartyPartyIdentification PartyIdentification {
            get {
                return this.partyIdentificationField;
            }
            set {
                this.partyIdentificationField = value;
            }
        }

        /// <remarks/>
        public AccountingCustomerPartyPartyPartyName PartyName {
            get {
                return this.partyNameField;
            }
            set {
                this.partyNameField = value;
            }
        }

        /// <remarks/>
        public AccountingCustomerPartyPartyPostalAddress PostalAddress {
            get {
                return this.postalAddressField;
            }
            set {
                this.postalAddressField = value;
            }
        }

        /// <remarks/>
        public AccountingCustomerPartyPartyPartyTaxScheme PartyTaxScheme {
            get {
                return this.partyTaxSchemeField;
            }
            set {
                this.partyTaxSchemeField = value;
            }
        }

        /// <remarks/>
        public AccountingCustomerPartyPartyContact Contact {
            get {
                return this.contactField;
            }
            set {
                this.contactField = value;
            }
        }

        /// <remarks/>
        public AccountingCustomerPartyPartyPerson Person {
            get {
                return this.personField;
            }
            set {
                this.personField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AccountingCustomerPartyPartyPartyIdentification {

        private ID idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AccountingCustomerPartyPartyPartyName {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AccountingCustomerPartyPartyPostalAddress {

        private string streetNameField;

        private string buildingNameField;

        private string citySubdivisionNameField;

        private string cityNameField;

        private AccountingCustomerPartyPartyPostalAddressCountry countryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string StreetName {
            get {
                return this.streetNameField;
            }
            set {
                this.streetNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string BuildingName {
            get {
                return this.buildingNameField;
            }
            set {
                this.buildingNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string CitySubdivisionName {
            get {
                return this.citySubdivisionNameField;
            }
            set {
                this.citySubdivisionNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string CityName {
            get {
                return this.cityNameField;
            }
            set {
                this.cityNameField = value;
            }
        }

        /// <remarks/>
        public AccountingCustomerPartyPartyPostalAddressCountry Country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AccountingCustomerPartyPartyPostalAddressCountry {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AccountingCustomerPartyPartyPartyTaxScheme {

        private AccountingCustomerPartyPartyPartyTaxSchemeTaxScheme taxSchemeField;

        /// <remarks/>
        public AccountingCustomerPartyPartyPartyTaxSchemeTaxScheme TaxScheme {
            get {
                return this.taxSchemeField;
            }
            set {
                this.taxSchemeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AccountingCustomerPartyPartyPartyTaxSchemeTaxScheme {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AccountingCustomerPartyPartyContact {

        private string electronicMailField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string ElectronicMail {
            get {
                return this.electronicMailField;
            }
            set {
                this.electronicMailField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AccountingCustomerPartyPartyPerson {

        private string firstNameField;

        private string familyNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string FirstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string FamilyName {
            get {
                return this.familyNameField;
            }
            set {
                this.familyNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class PaymentMeans {

        private byte paymentMeansCodeField;

        private System.DateTime paymentDueDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public byte PaymentMeansCode {
            get {
                return this.paymentMeansCodeField;
            }
            set {
                this.paymentMeansCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", DataType = "date")]
        public System.DateTime PaymentDueDate {
            get {
                return this.paymentDueDateField;
            }
            set {
                this.paymentDueDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class PaymentTerms {

        private string noteField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string Note {
            get {
                return this.noteField;
            }
            set {
                this.noteField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TaxTotal {

        private TaxAmount taxAmountField;

        private TaxTotalTaxSubtotal taxSubtotalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxAmount TaxAmount {
            get {
                return this.taxAmountField;
            }
            set {
                this.taxAmountField = value;
            }
        }

        /// <remarks/>
        public TaxTotalTaxSubtotal TaxSubtotal {
            get {
                return this.taxSubtotalField;
            }
            set {
                this.taxSubtotalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
    public partial class TaxAmount {

        private string currencyIDField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currencyID {
            get {
                return this.currencyIDField;
            }
            set {
                this.currencyIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TaxTotalTaxSubtotal {

        private TaxableAmount taxableAmountField;

        private TaxAmount taxAmountField;

        private byte calculationSequenceNumericField;

        private decimal percentField;

        private TaxTotalTaxSubtotalTaxCategory taxCategoryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxableAmount TaxableAmount {
            get {
                return this.taxableAmountField;
            }
            set {
                this.taxableAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxAmount TaxAmount {
            get {
                return this.taxAmountField;
            }
            set {
                this.taxAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public byte CalculationSequenceNumeric {
            get {
                return this.calculationSequenceNumericField;
            }
            set {
                this.calculationSequenceNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public decimal Percent {
            get {
                return this.percentField;
            }
            set {
                this.percentField = value;
            }
        }

        /// <remarks/>
        public TaxTotalTaxSubtotalTaxCategory TaxCategory {
            get {
                return this.taxCategoryField;
            }
            set {
                this.taxCategoryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
    public partial class TaxableAmount {

        private string currencyIDField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currencyID {
            get {
                return this.currencyIDField;
            }
            set {
                this.currencyIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TaxTotalTaxSubtotalTaxCategory {

        private TaxTotalTaxSubtotalTaxCategoryTaxScheme taxSchemeField;

        /// <remarks/>
        public TaxTotalTaxSubtotalTaxCategoryTaxScheme TaxScheme {
            get {
                return this.taxSchemeField;
            }
            set {
                this.taxSchemeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TaxTotalTaxSubtotalTaxCategoryTaxScheme {

        private string nameField;

        private byte taxTypeCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public byte TaxTypeCode {
            get {
                return this.taxTypeCodeField;
            }
            set {
                this.taxTypeCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class LegalMonetaryTotal {

        private LineExtensionAmount lineExtensionAmountField;

        private TaxExclusiveAmount taxExclusiveAmountField;

        private TaxInclusiveAmount taxInclusiveAmountField;

        private AllowanceTotalAmount allowanceTotalAmountField;

        private ChargeTotalAmount chargeTotalAmountField;

        private PayableAmount payableAmountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineExtensionAmount LineExtensionAmount {
            get {
                return this.lineExtensionAmountField;
            }
            set {
                this.lineExtensionAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxExclusiveAmount TaxExclusiveAmount {
            get {
                return this.taxExclusiveAmountField;
            }
            set {
                this.taxExclusiveAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxInclusiveAmount TaxInclusiveAmount {
            get {
                return this.taxInclusiveAmountField;
            }
            set {
                this.taxInclusiveAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AllowanceTotalAmount AllowanceTotalAmount {
            get {
                return this.allowanceTotalAmountField;
            }
            set {
                this.allowanceTotalAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ChargeTotalAmount ChargeTotalAmount {
            get {
                return this.chargeTotalAmountField;
            }
            set {
                this.chargeTotalAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PayableAmount PayableAmount {
            get {
                return this.payableAmountField;
            }
            set {
                this.payableAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
    public partial class LineExtensionAmount {

        private string currencyIDField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currencyID {
            get {
                return this.currencyIDField;
            }
            set {
                this.currencyIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
    public partial class TaxExclusiveAmount {

        private string currencyIDField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currencyID {
            get {
                return this.currencyIDField;
            }
            set {
                this.currencyIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
    public partial class TaxInclusiveAmount {

        private string currencyIDField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currencyID {
            get {
                return this.currencyIDField;
            }
            set {
                this.currencyIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
    public partial class AllowanceTotalAmount {

        private string currencyIDField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currencyID {
            get {
                return this.currencyIDField;
            }
            set {
                this.currencyIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
    public partial class ChargeTotalAmount {

        private string currencyIDField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currencyID {
            get {
                return this.currencyIDField;
            }
            set {
                this.currencyIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
    public partial class PayableAmount {

        private string currencyIDField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currencyID {
            get {
                return this.currencyIDField;
            }
            set {
                this.currencyIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class InvoiceLine {

        private ID idField;

        private string noteField;

        private InvoicedQuantity invoicedQuantityField;

        private LineExtensionAmount lineExtensionAmountField;

        private InvoiceLineAllowanceCharge allowanceChargeField;

        private InvoiceLineTaxTotal taxTotalField;

        private InvoiceLineItem itemField;

        private InvoiceLinePrice priceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string Note {
            get {
                return this.noteField;
            }
            set {
                this.noteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InvoicedQuantity InvoicedQuantity {
            get {
                return this.invoicedQuantityField;
            }
            set {
                this.invoicedQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineExtensionAmount LineExtensionAmount {
            get {
                return this.lineExtensionAmountField;
            }
            set {
                this.lineExtensionAmountField = value;
            }
        }

        /// <remarks/>
        public InvoiceLineAllowanceCharge AllowanceCharge {
            get {
                return this.allowanceChargeField;
            }
            set {
                this.allowanceChargeField = value;
            }
        }

        /// <remarks/>
        public InvoiceLineTaxTotal TaxTotal {
            get {
                return this.taxTotalField;
            }
            set {
                this.taxTotalField = value;
            }
        }

        /// <remarks/>
        public InvoiceLineItem Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public InvoiceLinePrice Price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
    public partial class InvoicedQuantity {

        private string unitCodeField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unitCode {
            get {
                return this.unitCodeField;
            }
            set {
                this.unitCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class InvoiceLineAllowanceCharge {

        private bool chargeIndicatorField;

        private string allowanceChargeReasonField;

        private decimal multiplierFactorNumericField;

        private Amount amountField;

        private BaseAmount baseAmountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public bool ChargeIndicator {
            get {
                return this.chargeIndicatorField;
            }
            set {
                this.chargeIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string AllowanceChargeReason {
            get {
                return this.allowanceChargeReasonField;
            }
            set {
                this.allowanceChargeReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public decimal MultiplierFactorNumeric {
            get {
                return this.multiplierFactorNumericField;
            }
            set {
                this.multiplierFactorNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Amount Amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BaseAmount BaseAmount {
            get {
                return this.baseAmountField;
            }
            set {
                this.baseAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
    public partial class Amount {

        private string currencyIDField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currencyID {
            get {
                return this.currencyIDField;
            }
            set {
                this.currencyIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
    public partial class BaseAmount {

        private string currencyIDField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currencyID {
            get {
                return this.currencyIDField;
            }
            set {
                this.currencyIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class InvoiceLineTaxTotal {

        private TaxAmount taxAmountField;

        private InvoiceLineTaxTotalTaxSubtotal taxSubtotalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxAmount TaxAmount {
            get {
                return this.taxAmountField;
            }
            set {
                this.taxAmountField = value;
            }
        }

        /// <remarks/>
        public InvoiceLineTaxTotalTaxSubtotal TaxSubtotal {
            get {
                return this.taxSubtotalField;
            }
            set {
                this.taxSubtotalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class InvoiceLineTaxTotalTaxSubtotal {

        private TaxableAmount taxableAmountField;

        private TaxAmount taxAmountField;

        private decimal percentField;

        private InvoiceLineTaxTotalTaxSubtotalTaxCategory taxCategoryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxableAmount TaxableAmount {
            get {
                return this.taxableAmountField;
            }
            set {
                this.taxableAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxAmount TaxAmount {
            get {
                return this.taxAmountField;
            }
            set {
                this.taxAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public decimal Percent {
            get {
                return this.percentField;
            }
            set {
                this.percentField = value;
            }
        }

        /// <remarks/>
        public InvoiceLineTaxTotalTaxSubtotalTaxCategory TaxCategory {
            get {
                return this.taxCategoryField;
            }
            set {
                this.taxCategoryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class InvoiceLineTaxTotalTaxSubtotalTaxCategory {

        private InvoiceLineTaxTotalTaxSubtotalTaxCategoryTaxScheme taxSchemeField;

        /// <remarks/>
        public InvoiceLineTaxTotalTaxSubtotalTaxCategoryTaxScheme TaxScheme {
            get {
                return this.taxSchemeField;
            }
            set {
                this.taxSchemeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class InvoiceLineTaxTotalTaxSubtotalTaxCategoryTaxScheme {

        private string nameField;

        private byte taxTypeCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public byte TaxTypeCode {
            get {
                return this.taxTypeCodeField;
            }
            set {
                this.taxTypeCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class InvoiceLineItem {

        private string nameField;

        private string modelNameField;

        private InvoiceLineItemManufacturersItemIdentification manufacturersItemIdentificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string ModelName {
            get {
                return this.modelNameField;
            }
            set {
                this.modelNameField = value;
            }
        }

        /// <remarks/>
        public InvoiceLineItemManufacturersItemIdentification ManufacturersItemIdentification {
            get {
                return this.manufacturersItemIdentificationField;
            }
            set {
                this.manufacturersItemIdentificationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class InvoiceLineItemManufacturersItemIdentification {

        private ID idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class InvoiceLinePrice {

        private PriceAmount priceAmountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PriceAmount PriceAmount {
            get {
                return this.priceAmountField;
            }
            set {
                this.priceAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
    public partial class PriceAmount {

        private string currencyIDField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currencyID {
            get {
                return this.currencyIDField;
            }
            set {
                this.currencyIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }


}


//namespace SentezEInvoiceXML.diffobj {

//    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2", IsNullable = false)]
//    public partial class Invoicexxx {
//        [XmlIgnore]
//        private UBLExtensions uBLExtensionsField;
//        [XmlIgnore]
//        private decimal uBLVersionIDField;
//        [XmlIgnore]
//        private string customizationIDField;
//        [XmlIgnore]
//        private string profileIDField;
//        [XmlIgnore]
//        private ID idField;
//        [XmlIgnore]
//        private bool copyIndicatorField;
//        [XmlIgnore]
//        private string uUIDField;
//        [XmlIgnore]
//        private System.DateTime issueDateField;
//        [XmlIgnore]
//        private System.DateTime issueTimeField;
//        [XmlIgnore]
//        private string invoiceTypeCodeField;
//        [XmlIgnore]
//        private string[] noteField;
//        [XmlIgnore]
//        private string documentCurrencyCodeField;
//        [XmlIgnore]
//        private byte lineCountNumericField;
//        [XmlIgnore]
//        private AdditionalDocumentReference additionalDocumentReferenceField;
//        [XmlIgnore]
//        private Signature signatureField;
//        [XmlIgnore]
//        private AccountingSupplierParty accountingSupplierPartyField;
//        [XmlIgnore]
//        private AccountingCustomerParty accountingCustomerPartyField;
//        [XmlIgnore]
//        private PaymentMeans paymentMeansField;
//        [XmlIgnore]
//        private PaymentTerms paymentTermsField;
//        [XmlIgnore]
//        private TaxTotal taxTotalField;
//        [XmlIgnore]
//        private LegalMonetaryTotal legalMonetaryTotalField;
//        [XmlIgnore]
//        private InvoiceLine[] invoiceLineField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
//        [XmlIgnore]
//        public UBLExtensions UBLExtensions {
//            get {
//                return this.uBLExtensionsField;
//            }
//            set {
//                this.uBLExtensionsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        [XmlIgnore]
//        public decimal UBLVersionID {
//            get {
//                return this.uBLVersionIDField;
//            }
//            set {
//                this.uBLVersionIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        [XmlIgnore]
//        public string CustomizationID {
//            get {
//                return this.customizationIDField;
//            }
//            set {
//                this.customizationIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        [XmlIgnore]
//        public string ProfileID {
//            get {
//                return this.profileIDField;
//            }
//            set {
//                this.profileIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        [XmlIgnore]
//        public ID ID {
//            get {
//                return this.idField;
//            }
//            set {
//                this.idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        [XmlIgnore]
//        public bool CopyIndicator {
//            get {
//                return this.copyIndicatorField;
//            }
//            set {
//                this.copyIndicatorField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        [XmlIgnore]
//        public string UUID {
//            get {
//                return this.uUIDField;
//            }
//            set {
//                this.uUIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", DataType = "date")]
//        [XmlIgnore]
//        public System.DateTime IssueDate {
//            get {
//                return this.issueDateField;
//            }
//            set {
//                this.issueDateField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", DataType = "time")]
//        [XmlIgnore]
//        public System.DateTime IssueTime {
//            get {
//                return this.issueTimeField;
//            }
//            set {
//                this.issueTimeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        [XmlIgnore]
//        public string InvoiceTypeCode {
//            get {
//                return this.invoiceTypeCodeField;
//            }
//            set {
//                this.invoiceTypeCodeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        [XmlIgnore]
//        public string[] Note {
//            get {
//                return this.noteField;
//            }
//            set {
//                this.noteField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        [XmlIgnore]
//        public string DocumentCurrencyCode {
//            get {
//                return this.documentCurrencyCodeField;
//            }
//            set {
//                this.documentCurrencyCodeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        [XmlIgnore]
//        public byte LineCountNumeric {
//            get {
//                return this.lineCountNumericField;
//            }
//            set {
//                this.lineCountNumericField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//        [XmlIgnore]
//        public AdditionalDocumentReference AdditionalDocumentReference {
//            get {
//                return this.additionalDocumentReferenceField;
//            }
//            set {
//                this.additionalDocumentReferenceField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//        [XmlIgnore]
//        public Signature Signature {
//            get {
//                return this.signatureField;
//            }
//            set {
//                this.signatureField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//        [XmlIgnore]
//        public AccountingSupplierParty AccountingSupplierParty {
//            get {
//                return this.accountingSupplierPartyField;
//            }
//            set {
//                this.accountingSupplierPartyField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//        [XmlIgnore]
//        public AccountingCustomerParty AccountingCustomerParty {
//            get {
//                return this.accountingCustomerPartyField;
//            }
//            set {
//                this.accountingCustomerPartyField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//        [XmlIgnore]
//        public PaymentMeans PaymentMeans {
//            get {
//                return this.paymentMeansField;
//            }
//            set {
//                this.paymentMeansField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//        [XmlIgnore]
//        public PaymentTerms PaymentTerms {
//            get {
//                return this.paymentTermsField;
//            }
//            set {
//                this.paymentTermsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//        [XmlIgnore]
//        public TaxTotal TaxTotal {
//            get {
//                return this.taxTotalField;
//            }
//            set {
//                this.taxTotalField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//        [XmlIgnore]
//        public LegalMonetaryTotal LegalMonetaryTotal {
//            get {
//                return this.legalMonetaryTotalField;
//            }
//            set {
//                this.legalMonetaryTotalField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("InvoiceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//        [XmlIgnore]
//        public InvoiceLine[] InvoiceLine {
//            get {
//                return this.invoiceLineField;
//            }
//            set {
//                this.invoiceLineField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", IsNullable = false)]
//    public partial class UBLExtensions {

//        private UBLExtensionsUBLExtension uBLExtensionField;
//        [XmlIgnore]
//        /// <remarks/>
//        public UBLExtensionsUBLExtension UBLExtension {
//            get {
//                return this.uBLExtensionField;
//            }
//            set {
//                this.uBLExtensionField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
//    public partial class UBLExtensionsUBLExtension {

//        private object extensionContentField;
//        [XmlIgnore]
//        /// <remarks/>
//        public object ExtensionContent {
//            get {
//                return this.extensionContentField;
//            }
//            set {
//                this.extensionContentField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
//    public partial class ID {

//        private string schemeIDField;

//        private string valueField;
//        [XmlIgnore]
//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string schemeID {
//            get {
//                return this.schemeIDField;
//            }
//            set {
//                this.schemeIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlTextAttribute()]
//        [XmlIgnore]
//        public string Value {
//            get {
//                return this.valueField;
//            }
//            set {
//                this.valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
//    public partial class AdditionalDocumentReference {

//        private ID idField;

//        private System.DateTime issueDateField;

//        private string documentTypeField;

//        private AdditionalDocumentReferenceAttachment attachmentField;
//        [XmlIgnore]
//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public ID ID {
//            get {
//                return this.idField;
//            }
//            set {
//                this.idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", DataType = "date")]
//        [XmlIgnore]
//        public System.DateTime IssueDate {
//            get {
//                return this.issueDateField;
//            }
//            set {
//                this.issueDateField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        [XmlIgnore]
//        public string DocumentType {
//            get {
//                return this.documentTypeField;
//            }
//            set {
//                this.documentTypeField = value;
//            }
//        }
//        [XmlIgnore]
//        /// <remarks/>
//        public AdditionalDocumentReferenceAttachment Attachment {
//            get {
//                return this.attachmentField;
//            }
//            set {
//                this.attachmentField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class AdditionalDocumentReferenceAttachment {

//        private EmbeddedDocumentBinaryObject embeddedDocumentBinaryObjectField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        [XmlIgnore]
//        public EmbeddedDocumentBinaryObject EmbeddedDocumentBinaryObject {
//            get {
//                return this.embeddedDocumentBinaryObjectField;
//            }
//            set {
//                this.embeddedDocumentBinaryObjectField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
//    public partial class EmbeddedDocumentBinaryObject {

//        private string mimeCodeField;

//        private string encodingCodeField;

//        private string characterSetCodeField;

//        private string filenameField;

//        private string valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        [XmlIgnore]
//        public string mimeCode {
//            get {
//                return this.mimeCodeField;
//            }
//            set {
//                this.mimeCodeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        [XmlIgnore]
//        public string encodingCode {
//            get {
//                return this.encodingCodeField;
//            }
//            set {
//                this.encodingCodeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        [XmlIgnore]
//        public string characterSetCode {
//            get {
//                return this.characterSetCodeField;
//            }
//            set {
//                this.characterSetCodeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        [XmlIgnore]
//        public string filename {
//            get {
//                return this.filenameField;
//            }
//            set {
//                this.filenameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlTextAttribute()]
//        [XmlIgnore]
//        public string Value {
//            get {
//                return this.valueField;
//            }
//            set {
//                this.valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
//    public partial class Signature {

//        private ID idField;

//        private SignatureSignatoryParty signatoryPartyField;

//        private SignatureDigitalSignatureAttachment digitalSignatureAttachmentField;
//        [XmlIgnore]
//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public ID ID {
//            get {
//                return this.idField;
//            }
//            set {
//                this.idField = value;
//            }
//        }
//        [XmlIgnore]

//        /// <remarks/>
//        public SignatureSignatoryParty SignatoryParty {
//            get {
//                return this.signatoryPartyField;
//            }
//            set {
//                this.signatoryPartyField = value;
//            }
//        }
//        [XmlIgnore]
//        /// <remarks/>
//        public SignatureDigitalSignatureAttachment DigitalSignatureAttachment {
//            get {
//                return this.digitalSignatureAttachmentField;
//            }
//            set {
//                this.digitalSignatureAttachmentField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class SignatureSignatoryParty {

//        private SignatureSignatoryPartyPartyIdentification partyIdentificationField;

//        private SignatureSignatoryPartyPostalAddress postalAddressField;
//        [XmlIgnore]
//        /// <remarks/>
//        public SignatureSignatoryPartyPartyIdentification PartyIdentification {
//            get {
//                return this.partyIdentificationField;
//            }
//            set {
//                this.partyIdentificationField = value;
//            }
//        }
//        [XmlIgnore]
//        /// <remarks/>
//        public SignatureSignatoryPartyPostalAddress PostalAddress {
//            get {
//                return this.postalAddressField;
//            }
//            set {
//                this.postalAddressField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class SignatureSignatoryPartyPartyIdentification {

//        private ID idField;
//        [XmlIgnore]
//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public ID ID {
//            get {
//                return this.idField;
//            }
//            set {
//                this.idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class SignatureSignatoryPartyPostalAddress {

//        private string streetNameField;

//        private string buildingNameField;

//        private string buildingNumberField;

//        private string citySubdivisionNameField;

//        private string cityNameField;

//        private uint postalZoneField;

//        private SignatureSignatoryPartyPostalAddressCountry countryField;

//        [XmlIgnore]
//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string StreetName {
//            get {
//                return this.streetNameField;
//            }
//            set {
//                this.streetNameField = value;
//            }
//        }
//        [XmlIgnore]
//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string BuildingName {
//            get {
//                return this.buildingNameField;
//            }
//            set {
//                this.buildingNameField = value;
//            }
//        }
//        [XmlIgnore]
//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string BuildingNumber {
//            get {
//                return this.buildingNumberField;
//            }
//            set {
//                this.buildingNumberField = value;
//            }
//        }
//        [XmlIgnore]
//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string CitySubdivisionName {
//            get {
//                return this.citySubdivisionNameField;
//            }
//            set {
//                this.citySubdivisionNameField = value;
//            }
//        }
//        [XmlIgnore]
//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string CityName {
//            get {
//                return this.cityNameField;
//            }
//            set {
//                this.cityNameField = value;
//            }
//        }
//        [XmlIgnore]
//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public uint PostalZone {
//            get {
//                return this.postalZoneField;
//            }
//            set {
//                this.postalZoneField = value;
//            }
//        }
//        [XmlIgnore]
//        /// <remarks/>
//        public SignatureSignatoryPartyPostalAddressCountry Country {
//            get {
//                return this.countryField;
//            }
//            set {
//                this.countryField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class SignatureSignatoryPartyPostalAddressCountry {

//        private string nameField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string Name {
//            get {
//                return this.nameField;
//            }
//            set {
//                this.nameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class SignatureDigitalSignatureAttachment {

//        private SignatureDigitalSignatureAttachmentExternalReference externalReferenceField;

//        /// <remarks/>
//        public SignatureDigitalSignatureAttachmentExternalReference ExternalReference {
//            get {
//                return this.externalReferenceField;
//            }
//            set {
//                this.externalReferenceField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class SignatureDigitalSignatureAttachmentExternalReference {

//        private string uRIField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string URI {
//            get {
//                return this.uRIField;
//            }
//            set {
//                this.uRIField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
//    public partial class AccountingSupplierParty {

//        private AccountingSupplierPartyParty partyField;

//        /// <remarks/>
//        public AccountingSupplierPartyParty Party {
//            get {
//                return this.partyField;
//            }
//            set {
//                this.partyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class AccountingSupplierPartyParty {

//        private string websiteURIField;

//        private AccountingSupplierPartyPartyPartyIdentification[] partyIdentificationField;

//        private AccountingSupplierPartyPartyPartyName partyNameField;

//        private AccountingSupplierPartyPartyPostalAddress postalAddressField;

//        private AccountingSupplierPartyPartyPartyTaxScheme partyTaxSchemeField;

//        private AccountingSupplierPartyPartyContact contactField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string WebsiteURI {
//            get {
//                return this.websiteURIField;
//            }
//            set {
//                this.websiteURIField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("PartyIdentification")]
//        public AccountingSupplierPartyPartyPartyIdentification[] PartyIdentification {
//            get {
//                return this.partyIdentificationField;
//            }
//            set {
//                this.partyIdentificationField = value;
//            }
//        }

//        /// <remarks/>
//        public AccountingSupplierPartyPartyPartyName PartyName {
//            get {
//                return this.partyNameField;
//            }
//            set {
//                this.partyNameField = value;
//            }
//        }

//        /// <remarks/>
//        public AccountingSupplierPartyPartyPostalAddress PostalAddress {
//            get {
//                return this.postalAddressField;
//            }
//            set {
//                this.postalAddressField = value;
//            }
//        }

//        /// <remarks/>
//        public AccountingSupplierPartyPartyPartyTaxScheme PartyTaxScheme {
//            get {
//                return this.partyTaxSchemeField;
//            }
//            set {
//                this.partyTaxSchemeField = value;
//            }
//        }

//        /// <remarks/>
//        public AccountingSupplierPartyPartyContact Contact {
//            get {
//                return this.contactField;
//            }
//            set {
//                this.contactField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class AccountingSupplierPartyPartyPartyIdentification {

//        private ID idField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public ID ID {
//            get {
//                return this.idField;
//            }
//            set {
//                this.idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class AccountingSupplierPartyPartyPartyName {

//        private string nameField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string Name {
//            get {
//                return this.nameField;
//            }
//            set {
//                this.nameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class AccountingSupplierPartyPartyPostalAddress {

//        private string streetNameField;

//        private string buildingNameField;

//        private string buildingNumberField;

//        private string citySubdivisionNameField;

//        private string cityNameField;

//        private uint postalZoneField;

//        private AccountingSupplierPartyPartyPostalAddressCountry countryField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string StreetName {
//            get {
//                return this.streetNameField;
//            }
//            set {
//                this.streetNameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string BuildingName {
//            get {
//                return this.buildingNameField;
//            }
//            set {
//                this.buildingNameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string BuildingNumber {
//            get {
//                return this.buildingNumberField;
//            }
//            set {
//                this.buildingNumberField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string CitySubdivisionName {
//            get {
//                return this.citySubdivisionNameField;
//            }
//            set {
//                this.citySubdivisionNameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string CityName {
//            get {
//                return this.cityNameField;
//            }
//            set {
//                this.cityNameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public uint PostalZone {
//            get {
//                return this.postalZoneField;
//            }
//            set {
//                this.postalZoneField = value;
//            }
//        }

//        /// <remarks/>
//        public AccountingSupplierPartyPartyPostalAddressCountry Country {
//            get {
//                return this.countryField;
//            }
//            set {
//                this.countryField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class AccountingSupplierPartyPartyPostalAddressCountry {

//        private string nameField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string Name {
//            get {
//                return this.nameField;
//            }
//            set {
//                this.nameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class AccountingSupplierPartyPartyPartyTaxScheme {

//        private AccountingSupplierPartyPartyPartyTaxSchemeTaxScheme taxSchemeField;

//        /// <remarks/>
//        public AccountingSupplierPartyPartyPartyTaxSchemeTaxScheme TaxScheme {
//            get {
//                return this.taxSchemeField;
//            }
//            set {
//                this.taxSchemeField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class AccountingSupplierPartyPartyPartyTaxSchemeTaxScheme {

//        private string nameField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string Name {
//            get {
//                return this.nameField;
//            }
//            set {
//                this.nameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class AccountingSupplierPartyPartyContact {

//        private ulong telephoneField;

//        private object telefaxField;

//        private string electronicMailField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public ulong Telephone {
//            get {
//                return this.telephoneField;
//            }
//            set {
//                this.telephoneField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public object Telefax {
//            get {
//                return this.telefaxField;
//            }
//            set {
//                this.telefaxField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string ElectronicMail {
//            get {
//                return this.electronicMailField;
//            }
//            set {
//                this.electronicMailField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
//    public partial class AccountingCustomerParty {

//        private AccountingCustomerPartyParty partyField;

//        /// <remarks/>
//        public AccountingCustomerPartyParty Party {
//            get {
//                return this.partyField;
//            }
//            set {
//                this.partyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class AccountingCustomerPartyParty {

//        private AccountingCustomerPartyPartyPartyIdentification partyIdentificationField;

//        private AccountingCustomerPartyPartyPartyName partyNameField;

//        private AccountingCustomerPartyPartyPostalAddress postalAddressField;

//        private AccountingCustomerPartyPartyPartyTaxScheme partyTaxSchemeField;

//        private AccountingCustomerPartyPartyContact contactField;

//        private AccountingCustomerPartyPartyPerson personField;

//        /// <remarks/>
//        public AccountingCustomerPartyPartyPartyIdentification PartyIdentification {
//            get {
//                return this.partyIdentificationField;
//            }
//            set {
//                this.partyIdentificationField = value;
//            }
//        }

//        /// <remarks/>
//        public AccountingCustomerPartyPartyPartyName PartyName {
//            get {
//                return this.partyNameField;
//            }
//            set {
//                this.partyNameField = value;
//            }
//        }

//        /// <remarks/>
//        public AccountingCustomerPartyPartyPostalAddress PostalAddress {
//            get {
//                return this.postalAddressField;
//            }
//            set {
//                this.postalAddressField = value;
//            }
//        }

//        /// <remarks/>
//        public AccountingCustomerPartyPartyPartyTaxScheme PartyTaxScheme {
//            get {
//                return this.partyTaxSchemeField;
//            }
//            set {
//                this.partyTaxSchemeField = value;
//            }
//        }

//        /// <remarks/>
//        public AccountingCustomerPartyPartyContact Contact {
//            get {
//                return this.contactField;
//            }
//            set {
//                this.contactField = value;
//            }
//        }

//        /// <remarks/>
//        public AccountingCustomerPartyPartyPerson Person {
//            get {
//                return this.personField;
//            }
//            set {
//                this.personField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class AccountingCustomerPartyPartyPartyIdentification {

//        private ID idField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public ID ID {
//            get {
//                return this.idField;
//            }
//            set {
//                this.idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class AccountingCustomerPartyPartyPartyName {

//        private string nameField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string Name {
//            get {
//                return this.nameField;
//            }
//            set {
//                this.nameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class AccountingCustomerPartyPartyPostalAddress {

//        private string streetNameField;

//        private string buildingNameField;

//        private string citySubdivisionNameField;

//        private string cityNameField;

//        private AccountingCustomerPartyPartyPostalAddressCountry countryField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string StreetName {
//            get {
//                return this.streetNameField;
//            }
//            set {
//                this.streetNameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string BuildingName {
//            get {
//                return this.buildingNameField;
//            }
//            set {
//                this.buildingNameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string CitySubdivisionName {
//            get {
//                return this.citySubdivisionNameField;
//            }
//            set {
//                this.citySubdivisionNameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string CityName {
//            get {
//                return this.cityNameField;
//            }
//            set {
//                this.cityNameField = value;
//            }
//        }

//        /// <remarks/>
//        public AccountingCustomerPartyPartyPostalAddressCountry Country {
//            get {
//                return this.countryField;
//            }
//            set {
//                this.countryField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class AccountingCustomerPartyPartyPostalAddressCountry {

//        private string nameField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string Name {
//            get {
//                return this.nameField;
//            }
//            set {
//                this.nameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class AccountingCustomerPartyPartyPartyTaxScheme {

//        private AccountingCustomerPartyPartyPartyTaxSchemeTaxScheme taxSchemeField;

//        /// <remarks/>
//        public AccountingCustomerPartyPartyPartyTaxSchemeTaxScheme TaxScheme {
//            get {
//                return this.taxSchemeField;
//            }
//            set {
//                this.taxSchemeField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class AccountingCustomerPartyPartyPartyTaxSchemeTaxScheme {

//        private string nameField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string Name {
//            get {
//                return this.nameField;
//            }
//            set {
//                this.nameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class AccountingCustomerPartyPartyContact {

//        private string electronicMailField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string ElectronicMail {
//            get {
//                return this.electronicMailField;
//            }
//            set {
//                this.electronicMailField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class AccountingCustomerPartyPartyPerson {

//        private string firstNameField;

//        private string familyNameField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string FirstName {
//            get {
//                return this.firstNameField;
//            }
//            set {
//                this.firstNameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string FamilyName {
//            get {
//                return this.familyNameField;
//            }
//            set {
//                this.familyNameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
//    public partial class PaymentMeans {

//        private byte paymentMeansCodeField;

//        private System.DateTime paymentDueDateField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public byte PaymentMeansCode {
//            get {
//                return this.paymentMeansCodeField;
//            }
//            set {
//                this.paymentMeansCodeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", DataType = "date")]
//        public System.DateTime PaymentDueDate {
//            get {
//                return this.paymentDueDateField;
//            }
//            set {
//                this.paymentDueDateField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
//    public partial class PaymentTerms {

//        private string noteField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string Note {
//            get {
//                return this.noteField;
//            }
//            set {
//                this.noteField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
//    public partial class TaxTotal {

//        private TaxAmount taxAmountField;

//        private TaxTotalTaxSubtotal taxSubtotalField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public TaxAmount TaxAmount {
//            get {
//                return this.taxAmountField;
//            }
//            set {
//                this.taxAmountField = value;
//            }
//        }

//        /// <remarks/>
//        public TaxTotalTaxSubtotal TaxSubtotal {
//            get {
//                return this.taxSubtotalField;
//            }
//            set {
//                this.taxSubtotalField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
//    public partial class TaxAmount {

//        private string currencyIDField;

//        private decimal valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string currencyID {
//            get {
//                return this.currencyIDField;
//            }
//            set {
//                this.currencyIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlTextAttribute()]
//        public decimal Value {
//            get {
//                return this.valueField;
//            }
//            set {
//                this.valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class TaxTotalTaxSubtotal {

//        private TaxableAmount taxableAmountField;

//        private TaxAmount taxAmountField;

//        private byte calculationSequenceNumericField;

//        private decimal percentField;

//        private TaxTotalTaxSubtotalTaxCategory taxCategoryField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public TaxableAmount TaxableAmount {
//            get {
//                return this.taxableAmountField;
//            }
//            set {
//                this.taxableAmountField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public TaxAmount TaxAmount {
//            get {
//                return this.taxAmountField;
//            }
//            set {
//                this.taxAmountField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public byte CalculationSequenceNumeric {
//            get {
//                return this.calculationSequenceNumericField;
//            }
//            set {
//                this.calculationSequenceNumericField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public decimal Percent {
//            get {
//                return this.percentField;
//            }
//            set {
//                this.percentField = value;
//            }
//        }

//        /// <remarks/>
//        public TaxTotalTaxSubtotalTaxCategory TaxCategory {
//            get {
//                return this.taxCategoryField;
//            }
//            set {
//                this.taxCategoryField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
//    public partial class TaxableAmount {

//        private string currencyIDField;

//        private decimal valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string currencyID {
//            get {
//                return this.currencyIDField;
//            }
//            set {
//                this.currencyIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlTextAttribute()]
//        public decimal Value {
//            get {
//                return this.valueField;
//            }
//            set {
//                this.valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class TaxTotalTaxSubtotalTaxCategory {

//        private TaxTotalTaxSubtotalTaxCategoryTaxScheme taxSchemeField;

//        /// <remarks/>
//        public TaxTotalTaxSubtotalTaxCategoryTaxScheme TaxScheme {
//            get {
//                return this.taxSchemeField;
//            }
//            set {
//                this.taxSchemeField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class TaxTotalTaxSubtotalTaxCategoryTaxScheme {

//        private string nameField;

//        private byte taxTypeCodeField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string Name {
//            get {
//                return this.nameField;
//            }
//            set {
//                this.nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public byte TaxTypeCode {
//            get {
//                return this.taxTypeCodeField;
//            }
//            set {
//                this.taxTypeCodeField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
//    public partial class LegalMonetaryTotal {

//        private LineExtensionAmount lineExtensionAmountField;

//        private TaxExclusiveAmount taxExclusiveAmountField;

//        private TaxInclusiveAmount taxInclusiveAmountField;

//        private AllowanceTotalAmount allowanceTotalAmountField;

//        private ChargeTotalAmount chargeTotalAmountField;

//        private PayableAmount payableAmountField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public LineExtensionAmount LineExtensionAmount {
//            get {
//                return this.lineExtensionAmountField;
//            }
//            set {
//                this.lineExtensionAmountField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public TaxExclusiveAmount TaxExclusiveAmount {
//            get {
//                return this.taxExclusiveAmountField;
//            }
//            set {
//                this.taxExclusiveAmountField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public TaxInclusiveAmount TaxInclusiveAmount {
//            get {
//                return this.taxInclusiveAmountField;
//            }
//            set {
//                this.taxInclusiveAmountField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public AllowanceTotalAmount AllowanceTotalAmount {
//            get {
//                return this.allowanceTotalAmountField;
//            }
//            set {
//                this.allowanceTotalAmountField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public ChargeTotalAmount ChargeTotalAmount {
//            get {
//                return this.chargeTotalAmountField;
//            }
//            set {
//                this.chargeTotalAmountField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public PayableAmount PayableAmount {
//            get {
//                return this.payableAmountField;
//            }
//            set {
//                this.payableAmountField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
//    public partial class LineExtensionAmount {

//        private string currencyIDField;

//        private decimal valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string currencyID {
//            get {
//                return this.currencyIDField;
//            }
//            set {
//                this.currencyIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlTextAttribute()]
//        public decimal Value {
//            get {
//                return this.valueField;
//            }
//            set {
//                this.valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
//    public partial class TaxExclusiveAmount {

//        private string currencyIDField;

//        private decimal valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string currencyID {
//            get {
//                return this.currencyIDField;
//            }
//            set {
//                this.currencyIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlTextAttribute()]
//        public decimal Value {
//            get {
//                return this.valueField;
//            }
//            set {
//                this.valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
//    public partial class TaxInclusiveAmount {

//        private string currencyIDField;

//        private decimal valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string currencyID {
//            get {
//                return this.currencyIDField;
//            }
//            set {
//                this.currencyIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlTextAttribute()]
//        public decimal Value {
//            get {
//                return this.valueField;
//            }
//            set {
//                this.valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
//    public partial class AllowanceTotalAmount {

//        private string currencyIDField;

//        private decimal valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string currencyID {
//            get {
//                return this.currencyIDField;
//            }
//            set {
//                this.currencyIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlTextAttribute()]
//        public decimal Value {
//            get {
//                return this.valueField;
//            }
//            set {
//                this.valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
//    public partial class ChargeTotalAmount {

//        private string currencyIDField;

//        private byte valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string currencyID {
//            get {
//                return this.currencyIDField;
//            }
//            set {
//                this.currencyIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlTextAttribute()]
//        public byte Value {
//            get {
//                return this.valueField;
//            }
//            set {
//                this.valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
//    public partial class PayableAmount {

//        private string currencyIDField;

//        private decimal valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string currencyID {
//            get {
//                return this.currencyIDField;
//            }
//            set {
//                this.currencyIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlTextAttribute()]
//        public decimal Value {
//            get {
//                return this.valueField;
//            }
//            set {
//                this.valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
//    public partial class InvoiceLine {

//        private ID idField;

//        private string noteField;

//        private InvoicedQuantity invoicedQuantityField;

//        private LineExtensionAmount lineExtensionAmountField;

//        private InvoiceLineAllowanceCharge[] allowanceChargeField;

//        private InvoiceLineTaxTotal taxTotalField;

//        private InvoiceLineItem itemField;

//        private InvoiceLinePrice priceField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public ID ID {
//            get {
//                return this.idField;
//            }
//            set {
//                this.idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string Note {
//            get {
//                return this.noteField;
//            }
//            set {
//                this.noteField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public InvoicedQuantity InvoicedQuantity {
//            get {
//                return this.invoicedQuantityField;
//            }
//            set {
//                this.invoicedQuantityField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public LineExtensionAmount LineExtensionAmount {
//            get {
//                return this.lineExtensionAmountField;
//            }
//            set {
//                this.lineExtensionAmountField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge")]
//        public InvoiceLineAllowanceCharge[] AllowanceCharge {
//            get {
//                return this.allowanceChargeField;
//            }
//            set {
//                this.allowanceChargeField = value;
//            }
//        }

//        /// <remarks/>
//        public InvoiceLineTaxTotal TaxTotal {
//            get {
//                return this.taxTotalField;
//            }
//            set {
//                this.taxTotalField = value;
//            }
//        }

//        /// <remarks/>
//        public InvoiceLineItem Item {
//            get {
//                return this.itemField;
//            }
//            set {
//                this.itemField = value;
//            }
//        }

//        /// <remarks/>
//        public InvoiceLinePrice Price {
//            get {
//                return this.priceField;
//            }
//            set {
//                this.priceField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
//    public partial class InvoicedQuantity {

//        private string unitCodeField;

//        private decimal valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string unitCode {
//            get {
//                return this.unitCodeField;
//            }
//            set {
//                this.unitCodeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlTextAttribute()]
//        public decimal Value {
//            get {
//                return this.valueField;
//            }
//            set {
//                this.valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class InvoiceLineAllowanceCharge {

//        private bool chargeIndicatorField;

//        private string allowanceChargeReasonField;

//        private decimal multiplierFactorNumericField;

//        private Amount amountField;

//        private BaseAmount baseAmountField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public bool ChargeIndicator {
//            get {
//                return this.chargeIndicatorField;
//            }
//            set {
//                this.chargeIndicatorField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string AllowanceChargeReason {
//            get {
//                return this.allowanceChargeReasonField;
//            }
//            set {
//                this.allowanceChargeReasonField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public decimal MultiplierFactorNumeric {
//            get {
//                return this.multiplierFactorNumericField;
//            }
//            set {
//                this.multiplierFactorNumericField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public Amount Amount {
//            get {
//                return this.amountField;
//            }
//            set {
//                this.amountField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public BaseAmount BaseAmount {
//            get {
//                return this.baseAmountField;
//            }
//            set {
//                this.baseAmountField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
//    public partial class Amount {

//        private string currencyIDField;

//        private decimal valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string currencyID {
//            get {
//                return this.currencyIDField;
//            }
//            set {
//                this.currencyIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlTextAttribute()]
//        public decimal Value {
//            get {
//                return this.valueField;
//            }
//            set {
//                this.valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
//    public partial class BaseAmount {

//        private string currencyIDField;

//        private decimal valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string currencyID {
//            get {
//                return this.currencyIDField;
//            }
//            set {
//                this.currencyIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlTextAttribute()]
//        public decimal Value {
//            get {
//                return this.valueField;
//            }
//            set {
//                this.valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class InvoiceLineTaxTotal {

//        private TaxAmount taxAmountField;

//        private InvoiceLineTaxTotalTaxSubtotal taxSubtotalField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public TaxAmount TaxAmount {
//            get {
//                return this.taxAmountField;
//            }
//            set {
//                this.taxAmountField = value;
//            }
//        }

//        /// <remarks/>
//        public InvoiceLineTaxTotalTaxSubtotal TaxSubtotal {
//            get {
//                return this.taxSubtotalField;
//            }
//            set {
//                this.taxSubtotalField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class InvoiceLineTaxTotalTaxSubtotal {

//        private TaxableAmount taxableAmountField;

//        private TaxAmount taxAmountField;

//        private decimal percentField;

//        private InvoiceLineTaxTotalTaxSubtotalTaxCategory taxCategoryField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public TaxableAmount TaxableAmount {
//            get {
//                return this.taxableAmountField;
//            }
//            set {
//                this.taxableAmountField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public TaxAmount TaxAmount {
//            get {
//                return this.taxAmountField;
//            }
//            set {
//                this.taxAmountField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public decimal Percent {
//            get {
//                return this.percentField;
//            }
//            set {
//                this.percentField = value;
//            }
//        }

//        /// <remarks/>
//        public InvoiceLineTaxTotalTaxSubtotalTaxCategory TaxCategory {
//            get {
//                return this.taxCategoryField;
//            }
//            set {
//                this.taxCategoryField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class InvoiceLineTaxTotalTaxSubtotalTaxCategory {

//        private InvoiceLineTaxTotalTaxSubtotalTaxCategoryTaxScheme taxSchemeField;

//        /// <remarks/>
//        public InvoiceLineTaxTotalTaxSubtotalTaxCategoryTaxScheme TaxScheme {
//            get {
//                return this.taxSchemeField;
//            }
//            set {
//                this.taxSchemeField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class InvoiceLineTaxTotalTaxSubtotalTaxCategoryTaxScheme {

//        private string nameField;

//        private byte taxTypeCodeField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string Name {
//            get {
//                return this.nameField;
//            }
//            set {
//                this.nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public byte TaxTypeCode {
//            get {
//                return this.taxTypeCodeField;
//            }
//            set {
//                this.taxTypeCodeField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class InvoiceLineItem {

//        private string nameField;

//        private ulong modelNameField;

//        private InvoiceLineItemManufacturersItemIdentification manufacturersItemIdentificationField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public string Name {
//            get {
//                return this.nameField;
//            }
//            set {
//                this.nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public ulong ModelName {
//            get {
//                return this.modelNameField;
//            }
//            set {
//                this.modelNameField = value;
//            }
//        }

//        /// <remarks/>
//        public InvoiceLineItemManufacturersItemIdentification ManufacturersItemIdentification {
//            get {
//                return this.manufacturersItemIdentificationField;
//            }
//            set {
//                this.manufacturersItemIdentificationField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class InvoiceLineItemManufacturersItemIdentification {

//        private ID idField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public ID ID {
//            get {
//                return this.idField;
//            }
//            set {
//                this.idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
//    public partial class InvoiceLinePrice {

//        private PriceAmount priceAmountField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//        public PriceAmount PriceAmount {
//            get {
//                return this.priceAmountField;
//            }
//            set {
//                this.priceAmountField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
//    public partial class PriceAmount {

//        private string currencyIDField;

//        private decimal valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string currencyID {
//            get {
//                return this.currencyIDField;
//            }
//            set {
//                this.currencyIDField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlTextAttribute()]
//        public decimal Value {
//            get {
//                return this.valueField;
//            }
//            set {
//                this.valueField = value;
//            }
//        }
//    }


//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentezEInvoiceXML {
    public class Erp_Company {
        public int RecId { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string TradeName { get; set; }
        public string Password { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public object Village { get; set; }
        public object Area { get; set; }
        public object Avenue { get; set; }
        public string Street { get; set; }
        public string DoorNo { get; set; }
        public object ApartmentNo { get; set; }
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public object StateId { get; set; }
        public string PostalCode { get; set; }
        public int CountryId { get; set; }
        public object TownId { get; set; }
        public object StreetId { get; set; }
        public string Phone { get; set; }
        public object Fax { get; set; }
        public string Internet { get; set; }
        public string EMail { get; set; }
        public int TaxOfficeId { get; set; }
        public string TaxNo { get; set; }
        public object IdNo { get; set; }
        public string CompanyType { get; set; }
        public object CompanyLogo { get; set; }
        public object CompanySigner { get; set; }
        public string Activity { get; set; }
        public int IsEInvoice { get; set; }
        public string EInvoiceAlias { get; set; }
        public int EInvoiceScenario { get; set; }
        public int IsEArchive { get; set; }
        public int IsELedger { get; set; }
        public int IsEExim { get; set; }
        public int InUse { get; set; }
        public object TypeCode { get; set; }
        public int TypeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string NaceCode { get; set; }
        public string MersisNo { get; set; }
        public string TradeRegistrationNo { get; set; }
        public object AcountantName { get; set; }
        public object AcountantBuildingNumber { get; set; }
        public object AcountantStreetId { get; set; }
        public object AcountantAddressStreet2 { get; set; }
        public int AcountantCityId { get; set; }
        public int AcountantCountryId { get; set; }
        public object AcountantZipOrPostalCode { get; set; }
        public object AcountantContactPhoneNumber { get; set; }
        public object AcountantEngagementTypeDescription { get; set; }
        public object AcountantContactFaxNumber { get; set; }
        public object AcountantEmailAddress { get; set; }
        public object Acountant2Name { get; set; }
        public object Acountant2BuildingNumber { get; set; }
        public object Acountant2StreetId { get; set; }
        public object Acountant2AddressStreet2 { get; set; }
        public object Acountant2CityId { get; set; }
        public object Acountant2CountryId { get; set; }
        public object Acountant2ZipOrPostalCode { get; set; }
        public object Acountant2ContactPhoneNumber { get; set; }
        public object Acountant2EngagementTypeDescription { get; set; }
        public object Acountant2ContactFaxNumber { get; set; }
        public object Acountant2EmailAddress { get; set; }
        public string PersonFirstName { get; set; }
        public string PersonFamilyName { get; set; }
        public object InsertedAt { get; set; }
        public object InsertedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public int IsDeleted { get; set; }
        public object DeletedAt { get; set; }
        public object DeletedBy { get; set; }
        public object IsEDespatch { get; set; }
        public object IsEProducerReceipt { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentezEInvoiceXML {
    public class Erp_Address {
        public int RecId { get; set; }
        public string AddressCode { get; set; }
        public int CurrentAccountId { get; set; }
        public object GuarantorId { get; set; }
        public object LeadId { get; set; }
        public object GuestId { get; set; }
        public int AddressType { get; set; }
        public object Explanation { get; set; }
        public string SpecialCode { get; set; }
        public object SellerId { get; set; }
        public object WorkplaceId { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public object Line3 { get; set; }
        public object Direction1 { get; set; }
        public object Direction2 { get; set; }
        public object Direction3 { get; set; }
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public object PostalCode { get; set; }
        public object StateId { get; set; }
        public int CountryId { get; set; }
        public object TownId { get; set; }
        public object StreetId { get; set; }
        public object GpsXCoordinate { get; set; }
        public object GpsYCoordinate { get; set; }
        public object Phone { get; set; }
        public object Fax { get; set; }
        public string EMail { get; set; }
        public object TimeZone { get; set; }
        public int IsDefault { get; set; }
        public object WarehouseId { get; set; }
        public object Boulevard { get; set; }
        public object Aveneu { get; set; }
        public object Street { get; set; }
        public object Neighborhood { get; set; }
        public object ExteriorDoor { get; set; }
        public object InteriorDoor { get; set; }
        public object Village { get; set; }
        public int InUse { get; set; }
        public DateTime InsertedAt { get; set; }
        public int InsertedBy { get; set; }
        public object UpdatedAt { get; set; }
        public object UpdatedBy { get; set; }
        public object IsDeleted { get; set; }
        public object DeletedAt { get; set; }
        public object DeletedBy { get; set; }
    }

}

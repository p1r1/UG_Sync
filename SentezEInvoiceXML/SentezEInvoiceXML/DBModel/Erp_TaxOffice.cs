using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentezEInvoiceXML {
    class Erp_TaxOffice {
        public int RecId { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public string Name { get; set; }
        public object Line1 { get; set; }
        public object Line2 { get; set; }
        public object DistrictId { get; set; }
        public object TownId { get; set; }
        public object StreetId { get; set; }
        public string PostalCode { get; set; }
        public object Phone { get; set; }
        public object Fax { get; set; }
        public object EMail { get; set; }
        public string CodeN { get; set; }
        public int InUse { get; set; }
        public object InsertedAt { get; set; }
        public object InsertedBy { get; set; }
        public object UpdatedAt { get; set; }
        public object UpdatedBy { get; set; }
        public object IsDeleted { get; set; }
        public object DeletedAt { get; set; }
        public object DeletedBy { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentezEInvoiceXML {
    public class Erp_City {
        public int RecId { get; set; }
        public int CountryId { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }
        public string CodeN { get; set; }
        public object LicensePlate { get; set; }
        public int InUse { get; set; }
        public object InsertedAt { get; set; }
        public object InsertedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public object IsDeleted { get; set; }
        public object DeletedAt { get; set; }
        public object DeletedBy { get; set; }
    }

}

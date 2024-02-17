using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentezEInvoiceXML {
    public class Erp_District {
        public int RecId { get; set; }
        public int CityId { get; set; }
        public object WorkplaceId { get; set; }
        public string DistrictCode { get; set; }
        public string DistrictName { get; set; }
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

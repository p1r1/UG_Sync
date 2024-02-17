using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentezEInvoiceXML {
    public class Erp_Paymentplan {
        public int RecId { get; set; }
        public int CompanyId { get; set; }
        public string PlanCode { get; set; }
        public string Explanation { get; set; }
        public object SpecialCode { get; set; }
        public object AccessCode { get; set; }
        public object LatePayment { get; set; }
        public object EarlyPayment { get; set; }
        public object PaymentDays { get; set; }
        public object StartDate { get; set; }
        public object EndDate { get; set; }
        public string UniversalCode { get; set; }
        public int InUse { get; set; }
        public DateTime InsertedAt { get; set; }
        public int InsertedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public object IsDeleted { get; set; }
        public object DeletedAt { get; set; }
        public object DeletedBy { get; set; }
    }

}

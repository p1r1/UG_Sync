using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentezEInvoiceXML {
    class Erp_UnitSetItem {
        public int RecId { get; set; }
        public int UnitSetId { get; set; }
        public string UnitCode { get; set; }
        public string UnitName { get; set; }
        public float UnitFactor { get; set; }
        public object UnitDivisor { get; set; }
        public object UnitWidth { get; set; }
        public object UnitWidthUnitId { get; set; }
        public object UnitLength { get; set; }
        public object UnitLengthUnitId { get; set; }
        public object UnitHeight { get; set; }
        public object UnitHeightUnitId { get; set; }
        public object UnitArea { get; set; }
        public object UnitAreaUnitId { get; set; }
        public object UnitVolume { get; set; }
        public object UnitVolumeUnitId { get; set; }
        public object UnitWeight { get; set; }
        public object UnitWeightUnitId { get; set; }
        public int IsMainUnit { get; set; }
        public string UniversalCode { get; set; }
        public DateTime InsertedAt { get; set; }
        public int InsertedBy { get; set; }
        public object IsDeleted { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public object DeletedAt { get; set; }
        public object DeletedBy { get; set; }
    }

}

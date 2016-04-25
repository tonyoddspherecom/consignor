using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "ShipmentDocument", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain")]
    public class ShipmentDocument
    {
        [DataMember()]
        public int Count { get; set; }
        
        [DataMember()]
        public DateTime? DatePrinted { get; set; }
        
        [DataMember()]
        public BinaryContent DocContent { get; set; }

        [DataMember()]
        public DocumentAccess DocumentAccess { get; set; }

        [DataMember()]
        public int? DocumentAccessId { get; set; }

        [DataMember()]
        public bool ManualPrint { get; set; }

        [DataMember()]
        public int PrintBox { get; set; }

        [DataMember()]
        public string PrinterPath { get; set; }

        [DataMember()]
        public int ShipmentId { get; set; }

    }
}

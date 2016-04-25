using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "LineUnit", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain")]
    public class LineUnit
    {
        [DataMember()]
        public int Count { get; set; }
        
        [DataMember()]
        public int KindId { get; set; }

        [DataMember()]
        public int LineId { get; set; }

        [DataMember()]
        public string Name { get; set; }

        [DataMember()]
        public int Vol { get; set; }

        [DataMember()]
        public int Weight { get; set; }

    }
}

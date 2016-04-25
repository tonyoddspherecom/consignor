using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ExportDomain")]
    public class StatusInfo
    {
        [DataMember(Order = 0)]
        public string Barcode { get; set; }
        [DataMember(Order = 1)]
        public bool IsClosed { get; set; }
        public bool IsClosedSpecified { get; set; }
        [DataMember(Order = 2)]
        public string ShipmentNumber { get; set; }
    }
}

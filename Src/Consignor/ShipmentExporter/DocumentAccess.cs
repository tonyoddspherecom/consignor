using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "DocumentAccess", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain")]
    public class DocumentAccess
    {
        [DataMember()]
        public DateTime? ExpirationDate { get; set; }
        
        [DataMember()]
        public string PIN { get; set; }
        
    }
}

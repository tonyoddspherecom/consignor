using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "Service", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ExportDomain")]
    public class Service
    {
        [DataMember(EmitDefaultValue = false)]
        public int ServiceId { get; set; }
        
        [DataMember(EmitDefaultValue = false)]
        public string ServiceName { get; set; }
        
    }
}

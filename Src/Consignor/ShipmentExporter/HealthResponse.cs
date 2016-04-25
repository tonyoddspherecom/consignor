using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    public class HealthResponse
    {
        [DataMember(Order = 0)] public bool HealthStatus { get; set; }
        public bool HealthStatusSpecified { get; set; }
        [DataMember(Order = 1)] public string Message { get; set; }
    }
}

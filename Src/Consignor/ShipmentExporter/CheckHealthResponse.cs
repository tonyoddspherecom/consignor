using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Namespace = "http://edisoftwebservices.com/")]
    public class CheckHealthResponse
    {
        [DataMember(Order = 0)] public HealthResponse CheckHealthResult { get; set; }

        public CheckHealthResponse()
        {
        }

        public CheckHealthResponse(HealthResponse CheckHealthResult)
        {
            this.CheckHealthResult = CheckHealthResult;
        }
    }
}

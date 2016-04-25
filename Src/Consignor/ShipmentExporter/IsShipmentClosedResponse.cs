using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Namespace = "http://edisoftwebservices.com/")]
    public class IsShipmentClosedResponse
    {
        [DataMember(Order = 0)] public StatusInfo[] IsShipmentClosedResult { get; set; }

        public IsShipmentClosedResponse()
        {
        }

        public IsShipmentClosedResponse(StatusInfo[] IsShipmentClosedResult)
        {
            this.IsShipmentClosedResult = IsShipmentClosedResult;
        }
    }
}

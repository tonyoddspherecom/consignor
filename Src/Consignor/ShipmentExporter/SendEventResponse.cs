using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Namespace = "http://edisoftwebservices.com/")]
    public class SendEventResponse
    {
        [DataMember(Order = 0)] public bool SendEventResult { get; set; }
        public SendEventResponse()
        {
        }
        public SendEventResponse(bool SendEventResult)
        {
            this.SendEventResult = SendEventResult;
        }
    }
}

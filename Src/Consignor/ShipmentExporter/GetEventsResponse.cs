using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [MessageContract(WrapperName = "GetEventsResponse", WrapperNamespace ="http://edisoftwebservices.com/")]
    public class GetEventsResponse
    {
        [MessageBodyMember(Order = 0, Namespace = "http://edisoftwebservices.com/")]
        public Event[] GetEventsResult;

        public GetEventsResponse()
        {
        }

        public GetEventsResponse(Event[] GetEventsResult)
        {
            this.GetEventsResult = GetEventsResult;
        }
    }
}

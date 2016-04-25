using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [MessageContract(WrapperName = "GetEvents", WrapperNamespace = "http://edisoftwebservices.com/")]
    public partial class GetEventsRequest
    {
        [MessageBodyMember(Order = 0)] public string userName { get; set; }
        [MessageBodyMember(Order = 1)] public string password { get; set; }
        [MessageBodyMember(Order = 2)] public DateTime eventDateTimeStart { get; set; }
        [MessageBodyMember(Order = 3)] public DateTime eventDateTimeEnd { get; set; }
        public GetEventsRequest()
        {
        }
        public GetEventsRequest(string userName, string password, System.DateTime eventDateTimeStart, System.DateTime eventDateTimeEnd)
        {
            this.userName = userName;
            this.password = password;
            this.eventDateTimeStart = eventDateTimeStart;
            this.eventDateTimeEnd = eventDateTimeEnd;
        }
    }
}

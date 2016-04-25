using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Namespace = "http://edisoftwebservices.com/")]
    public class SendEventRequest
    {
        [DataMember(Order = 0)] public string userName { get; set; }
        [DataMember(Order = 1)] public string password { get; set; }
        [DataMember(Order = 2)] public ImportEvent submitEvent { get; set; }

        public SendEventRequest()
        {
        }

        public SendEventRequest(string userName, string password, ImportEvent submitEvent)
        {
            this.userName = userName;
            this.password = password;
            this.submitEvent = submitEvent;
        }
    }
}

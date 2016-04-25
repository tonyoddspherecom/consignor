using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Namespace = "http://edisoftwebservices.com/")]
    public class IsShipmentClosedRequest
    {
        [DataMember(Order = 0)] public string userName { get; set; }
        [DataMember(Order = 1)] public string password { get; set; }
        [DataMember(Order = 2)] public string barcode { get; set; }

        public IsShipmentClosedRequest()
        {
        }

        public IsShipmentClosedRequest(string userName, string password, string barcode)
        {
            this.userName = userName;
            this.password = password;
            this.barcode = barcode;
        }
    }
}

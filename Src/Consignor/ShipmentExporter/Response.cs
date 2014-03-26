using System;
using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Namespace = "http://edisoftwebservices.com/")]
    public class Response
    {
        [DataMember(Order = 0)] public ShipmentDto[] Shipments { get;set; }
        [DataMember(Order = 1)] public ResponseStatus ResponseStatus  { get;set; }
    }
}

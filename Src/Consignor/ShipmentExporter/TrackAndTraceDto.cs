using System;
using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Namespace = "http://edisoftwebservices.com/")]
    public class TrackAndTraceDto : GenericEntityDto
    {
        [DataMember(Order = 0)] public string Name { get; set; }
        [DataMember(Order = 1)] public string PostalCode { get; set; }
        [DataMember(Order = 2)] public string EventCode { get; set; }
        [DataMember(Order = 3)] public DateTime EventDateTime { get; set; }
        [DataMember(Order = 4)] public string Location { get; set; }
        [DataMember(Order = 5)] public string Awb { get; set; }
        [DataMember(Order = 6)] public string OrderNumber { get; set; }
        [DataMember(Order = 7)] public bool IsShipment { get; set; }
    }
}
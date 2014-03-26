using System;
using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Namespace = "http://edisoftwebservices.com/")]
    public class ConsignorEventDto : GenericEntityDto
    {
        [DataMember(Order = 0)] public string Name { get; set; }
        [DataMember(Order = 1)] public string EventCode { get; set; }
        [DataMember(Order = 2)] public DateTime EventDateTime { get; set; }
        [DataMember(Order = 3)] public string Awb { get; set; }
        [DataMember(Order = 4)] public string OrderNumber { get; set; }
        [DataMember(Order = 5)] public bool IsShipment { get; set; }
    }
}
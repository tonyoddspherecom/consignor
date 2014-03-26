using System;
using System.Runtime.Serialization;
namespace Consignor.ShipAdvisor
{
    [DataContract(Namespace = "http://ws.consignorsupport.no/ShipAdvisor")]
    public class GetShipmentByOrderOutput
    {
        [DataMember(Order = 0)] public StatusCode ResponseStatus { get; set; }
        [DataMember(Order = 1)] public string[] ErrorMessages { get; set; }
        [DataMember(Order = 2)] public PortalShipment[] Shipments { get; set; }
    }
}

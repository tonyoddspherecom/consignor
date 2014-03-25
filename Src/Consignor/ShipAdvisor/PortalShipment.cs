using System;
using System.Runtime.Serialization;
namespace Consignor.ShipAdvisor
{
    [DataContract(Namespace = "http://ws.consignorsupport.no/ShipAdvisor")]
    public class PortalShipment
    {
        [DataMember(Order = 2)] PortalProduct Product { get; set; }
        [DataMember(Order = 0)] WebShopShipment Shipment { get; set; }
        [DataMember(Order = 1)] Sender WebShop { get; set; }
    }
}

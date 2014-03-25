using System;
using System.Runtime.Serialization;
namespace Consignor.ShipAdvisor
{
    [DataContract(Namespace = "http://ws.consignorsupport.no/ShipAdvisor")]
    public class PortalProduct
    {
        [DataMember(Order = 1)] public int? ConceptId { get; set; }
        [DataMember(Order = 5)] public string CurrencyCode { get; set; }
        [DataMember(Order = 2)] public int? CustomProductDBId { get; set; }
        [DataMember(Order = 6)] public DropPointData DropPoint { get; set; }
        [DataMember(Order = 4)] public double Price { get; set; }
        [DataMember(Order = 3)] public int[] ServiceIds { get; set; }
        [DataMember(Order = 0)] public long WebShopProductId { get; set; }
    }
}

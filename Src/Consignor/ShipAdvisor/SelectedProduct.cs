using System;
using System.Runtime.Serialization;
namespace Consignor.ShipAdvisor
{
    [DataContract(Namespace = "http://ws.consignorsupport.no/ShipAdvisor")]
    public class SelectedProduct
    {
        [DataMember(Order = 0)] public long WebShopProductId { get; set; }
        [DataMember(Order = 1)] public double Price { get; set; }
        [DataMember(Order = 2)] public string CurrencyCode { get; set; }
        [DataMember(Order = 3)] public DropPointData DropPoint { get; set; }
    }
}

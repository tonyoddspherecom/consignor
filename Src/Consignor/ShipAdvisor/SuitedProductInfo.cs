using System;
using System.Runtime.Serialization;
namespace Consignor.ShipAdvisor
{
    [DataContract(Namespace = "http://ws.consignorsupport.no/ShipAdvisor")]
    public class SuitedProductInfo
    {
        [DataMember(Order = 1)] public int? ConceptId { get; set; }
        [DataMember(Order = 0)] public string CurrencyCode { get; set; }
        [DataMember(Order = 2)] public int? CustomProductDBId { get; set; }
        [DataMember(Order = 5)] public string DeliveryTime { get; set; }
        [DataMember(Order = 11)] public string ErrorMessage { get; set; }
        [DataMember(Order = 6)] public string GoodsType { get; set; }
        [DataMember(Order = 9)] public string InfoFromCarrier { get; set; }
        [DataMember(Order = 8)] public double Price { get; set; }
        [DataMember(Order = 4)] public string ProductName { get; set; }
        [DataMember(Order = 7)] public string RecycleType { get; set; }
        [DataMember(Order = 3)] public int[] ServiceIds { get; set; }
        [DataMember(Order = 12)] public bool? SupportsPickDropPoint { get; set; }
        [DataMember(Order = 0)] public long WebShopProductId { get; set; }
    }
}

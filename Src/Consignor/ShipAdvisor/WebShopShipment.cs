using System;
using System.Runtime.Serialization;
namespace Consignor.ShipAdvisor
{
    [DataContract(Namespace = "http://ws.consignorsupport.no/ShipAdvisor")]
    public class WebShopShipment
    {
        [DataMember(Order = 2)] public long? ChODId { get; set; }
        [DataMember(Order = 4)] public double? CODAmount { get; set; }
        [DataMember(Order = 6)] public string CurrencyCode { get; set; }
        [DataMember(Order = 7)] public double? ExchangeRate { get; set; }
        [DataMember(Order = 3)] public double? InsuranceAmount { get; set; }
        [DataMember(Order = 5)] public WebShopLine[] Lines { get; set; }
        [DataMember(Order = 1)] public string OrderNumber { get; set; }
        [DataMember(Order = 9)] public DateTime? RequestDate { get; set; }
        [DataMember(Order = 11)] public ulong? ShipLoadmeterMM { get; set; }
        [DataMember(Order = 8)] public Receiver Shopper { get; set; }
        [DataMember(Order = 10)] public double? TotalOrderAmount { get; set; }
        [DataMember(Order = 0)] public int WebShopId { get; set; }
    }
}

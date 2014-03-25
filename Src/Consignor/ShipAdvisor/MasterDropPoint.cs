using System;
using System.Runtime.Serialization;
namespace Consignor.ShipAdvisor
{
    [DataContract(Namespace = "http://ws.consignorsupport.no/ShipAdvisor")]
    public class MasterDropPoint
    {
        [DataMember(Order = 3)] public string Address { get; set; }
        [DataMember(Order = 4)] public string Address2 { get; set; }
        [DataMember(Order = 5)] public string City { get; set; }
        [DataMember(Order = 7)] public string Country { get; set; }
        [DataMember(Order = 0)] public int Id { get; set; }
        [DataMember(Order = 8)] public decimal? MapRefX { get; set; }
        [DataMember(Order = 9)] public decimal? MapRefY { get; set; }
        [DataMember(Order = 14)] public MasterBusinessHour[] MasterBusinessHours { get; set; }
        [DataMember(Order = 16)] public MasterDropPointXRating[] MasterDropPointXRatings { get; set; }
        [DataMember(Order = 15)] public MDPXMPC[] MDPXMPCs { get; set; }
        [DataMember(Order = 2)] public string Name { get; set; }
        [DataMember(Order = 6)] public string PostCode { get; set; }
        [DataMember(Order = 1)] public string RoutingCode { get; set; }
        [DataMember(Order = 13)] public string SupportedProducts { get; set; }
        [DataMember(Order = 11)] public uint UntrustFlags { get; set; }
        [DataMember(Order = 10)] public DateTime? ValidTo { get; set; }
        [DataMember(Order = 12)] public int WebShopId { get; set; }
    }
}

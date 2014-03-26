using System;
using System.Runtime.Serialization;
namespace Consignor.ShipAdvisor
{
    [DataContract(Namespace = "http://ws.consignorsupport.no/ShipAdvisor")]
    public class RatingData
    {
        [DataMember(Order = 0)] public string Name { get; set; }
        [DataMember(Order = 1)] public int? Weight { get; set; }
        [DataMember(Order = 2)] public decimal? Rate { get; set; }
    }
}

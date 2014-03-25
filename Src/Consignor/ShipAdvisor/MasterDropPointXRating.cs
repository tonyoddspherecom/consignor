using System;
using System.Runtime.Serialization;
namespace Consignor.ShipAdvisor
{
    [DataContract(Namespace = "http://ws.consignorsupport.no/ShipAdvisor")]
    public class MasterDropPointXRating
    {
        [DataMember(Order = 0)] public int Id { get; set; }
        [DataMember(Order = 2)] public decimal? Rate { get; set; }
        [DataMember(Order = 3)] public Rating Rating { get; set; }
        [DataMember(Order = 1)] public int? Weight { get; set; }
    }
}

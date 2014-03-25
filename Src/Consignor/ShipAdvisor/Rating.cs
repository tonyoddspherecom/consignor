using System;
using System.Runtime.Serialization;
namespace Consignor.ShipAdvisor
{
    [DataContract(Namespace = "http://ws.consignorsupport.no/ShipAdvisor")]
    public class Rating
    {
        [DataMember(Order = 0)] public int Id { get; set; }
        [DataMember(Order = 3)] public bool InUse { get; set; }
        [DataMember(Order = 1)] public string Name { get; set; }
        [DataMember(Order = 2)] public int? Weight { get; set; }
    }
}

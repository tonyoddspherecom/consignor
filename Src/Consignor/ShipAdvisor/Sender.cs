using System;
using System.Runtime.Serialization;
namespace Consignor.ShipAdvisor
{
    [DataContract(Namespace = "http://ws.consignorsupport.no/ShipAdvisor")]
    public class Sender
    {
        [DataMember(Order = 1)] public int? ActorId { get; set; }
        [DataMember(Order = 5)] public string Address { get; set; }
        [DataMember(Order = 3)] public string CountryCode { get; set; }
        [DataMember(Order = 0)] public string InstallationId { get; set; }
        [DataMember(Order = 2)] public string Name { get; set; }
        [DataMember(Order = 4)] public string PostCode { get; set; }
    }
}

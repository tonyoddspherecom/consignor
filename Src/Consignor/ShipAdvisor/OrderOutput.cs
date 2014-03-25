using System;
using System.Runtime.Serialization;
namespace Consignor.ShipAdvisor
{
    [DataContract(Namespace = "http://ws.consignorsupport.no/ShipAdvisor")]
    public class OrderOutput
    {
        [DataMember(Order = 0)] public long? ChODId { get; set; }
        [DataMember(Order = 1)] public byte ErrorCode { get; set; }
        [DataMember(Order = 2)] public string ErrorMessage { get; set; }
    }
}

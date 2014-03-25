using System;
using System.Runtime.Serialization;
namespace Consignor.ShipAdvisor
{
    [DataContract(Namespace = "http://ws.consignorsupport.no/ShipAdvisor")]
    public class Receiver
    {
        [DataMember(Order = 7)] public string Address { get; set; }
        [DataMember(Order = 8)] public string Address2 { get; set; }
        [DataMember(Order = 9)] public string Attention { get; set; }
        [DataMember(Order = 2)] public string City { get; set; }
        [DataMember(Order = 14)] public string CODKID { get; set; }
        [DataMember(Order = 15)] public string CODReference { get; set; }
        [DataMember(Order = 5)] public string CountryCode { get; set; }
        [DataMember(Order = 3)] public string Email { get; set; }
        [DataMember(Order = 11)] public string MessageToCarrier { get; set; }
        [DataMember(Order = 12)] public string MessageToDriver { get; set; }
        [DataMember(Order = 13)] public string MessageToReceiver { get; set; }
        [DataMember(Order = 1)] public string Name { get; set; }
        [DataMember(Order = 4)] public string Phone { get; set; }
        [DataMember(Order = 6)] public string PostCode { get; set; }
        [DataMember(Order = 0)] public long? ReceiverId { get; set; }
        [DataMember(Order = 10)] public string ReceiverRef { get; set; }
    }
}

using System;
using System.Runtime.Serialization;
namespace Consignor.ShipAdvisor
{
    [DataContract(Namespace = "http://ws.consignorsupport.no/ShipAdvisor")]
    public class KeyValue
    {
        [DataMember(Order = 0)] public string Key { get; set; }
        [DataMember(Order = 1)] public string Value { get; set; }
        [DataMember(Order = 2)] public ValueType Type { get; set; }
    }
}

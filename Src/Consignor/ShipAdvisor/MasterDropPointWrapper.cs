using System;
using System.Runtime.Serialization;
namespace Consignor.ShipAdvisor
{
    [DataContract(Namespace = "http://ws.consignorsupport.no/ShipAdvisor")]
    public class MasterDropPointWrapper
    {
        [DataMember(Order = 2)] public string ErrorMessage { get; set; }
        [DataMember(Order = 0)] public MasterDropPoint[] MasterDropPointList { get; set; }
        [DataMember(Order = 1)] public int Zoom { get; set; }
    }
}

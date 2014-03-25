using System;
using System.Runtime.Serialization;
namespace Consignor.ShipAdvisor
{
    [DataContract(Namespace = "http://ws.consignorsupport.no/ShipAdvisor")]
    public class OpeningHours
    {
        [DataMember(Order = 2)] public string Close { get; set; }
        [DataMember(Order = 0)] public DayOfWeek Day { get; set; }
        [DataMember(Order = 1)] public string Open { get; set; }
    }
}

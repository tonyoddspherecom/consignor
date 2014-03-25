using System;
using System.Runtime.Serialization;
namespace Consignor.ShipAdvisor
{
    [DataContract(Namespace = "http://ws.consignorsupport.no/ShipAdvisor")]
    public class MasterBusinessHour
    {
        [DataMember(Order = 3)] public short? HoursStart { get; set; }
        [DataMember(Order = 4)] public short? HoursStop { get; set; }
        [DataMember(Order = 0)] public int Id { get; set; }
        [DataMember(Order = 1)] public byte? WeekDayStart { get; set; }
        [DataMember(Order = 2)] public byte? WeekDayStop { get; set; }
    }
}

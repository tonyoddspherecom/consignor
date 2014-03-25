using System.Runtime.Serialization;

namespace Consignor.ShipAdvisor
{
    [DataContract(Namespace = "http://ws.consignorsupport.no/ShipAdvisor")]
    public enum DayOfWeek
    {
        [EnumMember]Sunday,
        [EnumMember]Monday,
        [EnumMember]Tuesday,
        [EnumMember]Wednesday,
        [EnumMember]Thursday,
        [EnumMember]Friday,
        [EnumMember]Saturday,
    }
}

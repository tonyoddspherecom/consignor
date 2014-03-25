using System.Runtime.Serialization;

namespace Consignor.ShipAdvisor
{
    [DataContract(Namespace = "http://ws.consignorsupport.no/ShipAdvisor")]
    public enum StatusCode
    {
        [EnumMember]Success,
        [EnumMember]Failure,
    }
}

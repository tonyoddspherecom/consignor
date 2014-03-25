using System.Runtime.Serialization;

namespace Consignor.ShipAdvisor
{
    [DataContract(Namespace = "http://ws.consignorsupport.no/ShipAdvisor")]
    public enum ValueType
    {
        [EnumMember]String,
        [EnumMember]Integer,
        [EnumMember]Decimal,
        [EnumMember]Date,
        [EnumMember]Base64,
        [EnumMember]EplScript,
        [EnumMember]ZplScript,
        [EnumMember]Pdf,
    }
}

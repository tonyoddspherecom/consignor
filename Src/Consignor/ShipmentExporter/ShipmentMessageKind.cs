using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "ShipmentMessageKind", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain")]
    public enum ShipmentMessageKind : int
    {
        [EnumMember]Unknown = 0,
        [EnumMember]Driver = 1,
        [EnumMember]Carrier = 2,
        [EnumMember]Receiver = 3,
    }
}

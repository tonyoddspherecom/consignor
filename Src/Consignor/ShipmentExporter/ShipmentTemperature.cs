using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "ShipmentTemperature", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain")]
    public enum ShipmentTemperature : int
    {
        [EnumMember]Unknown = 0,
        [EnumMember]Normal = 1,
        [EnumMember]Heat = 2,
        [EnumMember]Cool = 3,
        [EnumMember]Freeze = 4,
    }
}

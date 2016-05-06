using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "CarriagePayer", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain")]
    public enum CarriagePayer : int
    {
        [EnumMember]Unknown = 0,
        [EnumMember]Sender = 1,
        [EnumMember]Receiver = 2,
        [EnumMember]Other = 3,
    }
}

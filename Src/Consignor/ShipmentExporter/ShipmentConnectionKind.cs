using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "ShipmentConnectionKind", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain")]
    public enum ShipmentConnectionKind : int
    {
        [EnumMember]Unknown = 0,
        [EnumMember]ChildIsComeback = 1,
        [EnumMember]ChildIsGroupMember = 2,
        [EnumMember]ChildIsCompletionSub = 3,
        [EnumMember]ChildIsBulksplitSub = 4,
    }
}

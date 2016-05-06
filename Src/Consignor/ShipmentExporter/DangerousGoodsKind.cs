using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "DangerousGoodsKind", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain")]
    public enum DangerousGoodsKind : int
    {
        [EnumMember]ADRRID = 0,
        [EnumMember]IMD = 1,
    }
}

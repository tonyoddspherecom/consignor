using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "DangerousGoodsPackingGroup", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain")]
    public enum DangerousGoodsPackingGroup : int
    {
        [EnumMember]None = 0,
        [EnumMember]I = 1,
        [EnumMember]II = 2,
        [EnumMember]III = 3,
    }
}

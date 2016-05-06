using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "IdentifierType", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.Events")]
    public enum IdentifierType : int
    {
        [EnumMember]Barcode = 1,
        [EnumMember]OrderNo = 2,
        [EnumMember]ReciverRefrence = 3,
    }
}

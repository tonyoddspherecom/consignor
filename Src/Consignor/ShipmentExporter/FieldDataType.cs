using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "FieldDataType", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain")]
    public enum FieldDataType : int
    {
        [EnumMember]efkString = 0,
        [EnumMember]efkCountry = 1,
        [EnumMember]efkCurrency = 2,
        [EnumMember]efkInt = 3,
        [EnumMember]efkFloat = 4,
        [EnumMember]efkDate = 5,
        [EnumMember]efkTime = 6,
        [EnumMember]efkDateTime = 7,
        [EnumMember]efkNone = 8,
    }
}

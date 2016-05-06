using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "SubEventTypes", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ExportDomain")]
    public enum SubEventTypes : int
    {
        [EnumMember]
        Simple = 0,
        [EnumMember]
        Text = 1,
        [EnumMember]
        Image = 2,
        [EnumMember]
        Date = 3,
        [EnumMember]
        Time = 4,
        [EnumMember]
        DateTime = 5,
        [EnumMember]
        Number = 6,
    }
}
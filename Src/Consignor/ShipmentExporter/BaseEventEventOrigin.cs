using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "BaseEvent.EventOrigin", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.Events.Interfaces")]
    public enum BaseEventEventOrigin : int
    {
        [EnumMember]Consignor = 1,
        [EnumMember]ReturnData = 2,
        [EnumMember]MobileScanApp = 3,
        [EnumMember]MobileHandheld = 4,
        [EnumMember]PortalStatus = 5,
        [EnumMember]ClientData = 6,
        [EnumMember]PortalEdit = 7,
    }
}
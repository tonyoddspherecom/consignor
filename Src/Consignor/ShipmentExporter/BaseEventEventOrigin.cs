using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "BaseEvent.EventOrigin", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.Events.Interfaces")]
    public enum BaseEventEventOrigin
    {
        [EnumMember]
        Consignor,
        [EnumMember]
        ReturnData,
        [EnumMember]
        MobileScanApp,
        [EnumMember]
        MobileHandheld,
        [EnumMember]
        PortalStatus,
        [EnumMember]
        ClientData,
        [EnumMember]
        PortalEdit,
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "BaseEvent.EventType", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.Events.Interfaces")]
    public enum BaseEventEventType
    {
        [EnumMember]
        Unspecified = 1,
        [EnumMember]
        TrackAndTrace = 2,
        [EnumMember]
        Measurement = 4,
        [EnumMember]
        Price = 8,
    }
}

using System;
using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [Flags]
    [DataContract(Name = "BaseEvent.EventType", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.Events.Interfaces")]
    public enum BaseEventEventType : int
    {
        [EnumMember]Unspecified = 0,
        [EnumMember]TrackAndTrace = 1,
        [EnumMember]Measurement = 2,
        [EnumMember]Price = 4,
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "SubEvent", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ExportDomain")]
    public class SubEvent
    {
        [DataMember(Order = 0)] public string Description { get; set; }
        [DataMember(Order = 1)] public ushort HasSpecialValue { get; set; }
        public bool HasSpecialValueSpecified { get; set; }
        [DataMember(Order = 2)] public SubEventTypes SubEventType { get; set; }
        public bool SubEventTypeSpecified { get; set; }
        [DataMember(Order = 3)] public SubEvent[] SubEvents { get; set; }
        [DataMember(Order = 4)] public string Value { get; set; }
    }
    [DataContract(Name = "SubEventTypes", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ExportDomain")]
    public enum SubEventTypes
    {
        [EnumMember]
        Simple,
        [EnumMember]
        Text,
        [EnumMember]
        Image,
        [EnumMember]
        Date,
        [EnumMember]
        Time,
        [EnumMember]
        DateTime,
        [EnumMember]
        Number,
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "RadarStatusType", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain")]
    public enum RadarStatusType
    {
        [EnumMember()]
        Open = 0,

        [EnumMember()]
        InProgress = 1,

        [EnumMember()]
        Closed = 2,

        [EnumMember()]
        PartiallyClosed = 3,
    }
}

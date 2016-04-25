using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "ShipmentMessageKind", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain")]
    public enum ShipmentMessageKind
    {
        [EnumMember()]
        Unknown = 0,

        [EnumMember()]
        Driver = 1,

        [EnumMember()]
        Carrier = 2,

        [EnumMember()]
        Receiver = 3,
    }
}

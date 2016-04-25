using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "ShipmentKind", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain")]
    public enum ShipmentKind
    {
        [EnumMember()]
        Unknown = 0,

        [EnumMember()]
        Normal = 1,

        [EnumMember()]
        Comeback = 2,

        [EnumMember()]
        Group = 3,

        [EnumMember()]
        Incomming = 1000,

        [EnumMember()]
        CHOD = 1001,

        [EnumMember()]
        ScanAppMatched = 1002,

        [EnumMember()]
        CustomCreated = 1010,
    }
}

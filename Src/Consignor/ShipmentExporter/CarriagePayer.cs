using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "CarriagePayer", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain")]
    public enum CarriagePayer
    {
        [EnumMember()]
        Unknown = 0,

        [EnumMember()]
        Sender = 1,

        [EnumMember()]
        Receiver = 2,

        [EnumMember()]
        Other = 3,
    }
}

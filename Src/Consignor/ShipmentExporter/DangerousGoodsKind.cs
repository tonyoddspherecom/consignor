using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "DangerousGoodsKind", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain")]
    public enum DangerousGoodsKind
    {
        [EnumMember()]
        ADRRID = 0,

        [EnumMember()]
        IMD = 1,
    }
}

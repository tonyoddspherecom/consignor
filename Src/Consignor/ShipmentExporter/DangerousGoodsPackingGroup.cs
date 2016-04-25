using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "DangerousGoodsPackingGroup", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain")]
    public enum DangerousGoodsPackingGroup
    {
        [EnumMember()]
        None = 0,

        [EnumMember()]
        I = 1,

        [EnumMember()]
        II = 2,

        [EnumMember()]
        III = 3,
    }
}

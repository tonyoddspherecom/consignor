using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "DangerousGoodsMarinePollutant", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain")]
    public enum DangerousGoodsMarinePollutant
    {
        [EnumMember()]
        Unknown = 0,

        [EnumMember()]
        None = 1,

        [EnumMember()]
        IMDG = 2,

        [EnumMember()]
        ADR = 3,
    }
}

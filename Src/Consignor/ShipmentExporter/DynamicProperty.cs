using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ExportDomain")]
    public class DynamicProperty
    {
        [DataMember(Order = 0)] public string Key { get; set; }
        [DataMember(Order = 1)] public string Value { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "ShipmentConnection", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ExportDomain")]
    public class ShipmentConnection
    {
        [DataMember(EmitDefaultValue = false)]
        public int ChildCsid { get; set; }
       
        [DataMember(EmitDefaultValue = false)]
        public ShipmentConnectionKind Kind { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "Reference", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ExportDomain")]
    public class Reference
    {
        [DataMember()]
        public int Kind { get; set; }
        
        [DataMember(EmitDefaultValue = false)]
        public string KindText { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Value { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "Message", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ExportDomain")]
    public class Message
    {
        [DataMember(EmitDefaultValue = false)]
        public ShipmentMessageKind Kind { get; set; }
        
        [DataMember(EmitDefaultValue = false)]
        public string Text { get; set; }
        
    }
}

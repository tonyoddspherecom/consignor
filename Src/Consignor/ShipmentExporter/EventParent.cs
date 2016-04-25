using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "EventParent" ,Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ExportDomain")]
    public class EventParent
    {
        [DataMember(EmitDefaultValue = false)] public string Barcode { get; set; }
        [DataMember] public long Esid { get; set; }
        public bool EsidSpecified { get; set; }
        [DataMember] public bool IsShipment { get; set; }
        public bool IsShipmentSpecified { get; set; }
        [DataMember(EmitDefaultValue = false)] public string OrderNumber { get; set; }
    }
}

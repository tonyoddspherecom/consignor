using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [System.Runtime.Serialization.DataContractAttribute(Name = "SubEvent", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ExportDomain")]
    public partial class SubEvent
    {
        [DataMember]
        public string Description { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public ushort HasSpecialValue { get; set; }

        [DataMember]
        public SubEventTypes SubEventType { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public SubEvent[] SubEvents { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Value { get; set; }
    }
}
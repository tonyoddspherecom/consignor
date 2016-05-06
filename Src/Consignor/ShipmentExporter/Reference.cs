using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "Reference", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ExportDomain")]
    public partial class Reference
    {
        [DataMember]
        public int Kind { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string KindText { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Value { get; set; }
    }
}

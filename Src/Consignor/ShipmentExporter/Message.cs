using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "Message", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ExportDomain")]
    public partial class Message
    {
        [DataMember(EmitDefaultValue = false)]
        public ShipmentMessageKind Kind { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Text { get; set; }
    }
}

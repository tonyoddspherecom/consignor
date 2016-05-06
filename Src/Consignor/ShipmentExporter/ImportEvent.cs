using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "ImportEvent", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ImportDomain")]
    public partial class ImportEvent
    {
        [DataMember]
        public byte[] AttachmentByte { get; set; }
        [DataMember]
        public AttachmentType? AttachmentType { get; set; }
        [DataMember(IsRequired = true)]
        public System.DateTime Date { get; set; }
        [DataMember(IsRequired = true)]
        public Identifier ParentIdentifier { get; set; }
        [DataMember(IsRequired = true)]
        public string StatusCode { get; set; }
        [DataMember]
        public bool StatusIsClosed { get; set; }
        [DataMember]
        public string StatusText { get; set; }
    }
}

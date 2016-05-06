using System;
using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "ShipmentCustomDocument", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain")]
    public partial class ShipmentCustomDocument : GenericEntity
    {

        [DataMember]
        public BinaryContent Content { get; set; }
        [DataMember]
        public string ContentType { get; set; }
        [DataMember]
        public DateTime? CreationDate { get; set; }
        [DataMember]
        public DocumentAccess DocumentAccess { get; set; }
        [DataMember]
        public int? DocumentAccessId { get; set; }
        [DataMember]
        public string DocumentName { get; set; }
        [DataMember]
        public string FileName { get; set; }
        [DataMember]
        public int ShipmentId { get; set; }
        [DataMember]
        public string UploadedByUser { get; set; }
    }
}

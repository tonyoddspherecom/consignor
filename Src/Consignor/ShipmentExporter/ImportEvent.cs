using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ImportDomain")]
    public class ImportEvent
    {
        [DataMember(Order = 0)] public byte[] AttachmentByte { get; set; }
        [DataMember(Order = 1)] public AttachmentType? AttachmentType { get; set; }
        public bool AttachmentTypeSpecified { get; set; }
        [DataMember(Order = 2)] public DateTime Date { get; set; }
        [DataMember(Order = 3)] public Identifier ParentIdentifier { get; set; }
        [DataMember(Order = 4)] public string StatusCode { get; set; }
        [DataMember(Order = 5)] public bool StatusIsClosed { get; set; }
        public bool StatusIsClosedSpecified { get; set; }
        [DataMember(Order = 6)] public string StatusText { get; set; }
    }
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ImportDomain")]
    public enum AttachmentType
    {
        Picture,
        Text,
    }
    
}

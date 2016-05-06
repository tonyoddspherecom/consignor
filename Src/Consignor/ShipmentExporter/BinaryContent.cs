using System;
using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "BinaryContent", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain")]
    public partial class BinaryContent
    {
        [DataMember]
        public Guid BinaryContentGUId { get; set; }
        [DataMember]
        public byte[] Content { get; set; }
    }
}

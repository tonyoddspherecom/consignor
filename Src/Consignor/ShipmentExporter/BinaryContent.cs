using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "BinaryContent", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain")]
    public class BinaryContent
    {
        [DataMember()]
        public Guid BinaryContentGUId { get; set; }
        

        [DataMember()]
        public byte[] Content { get; set; }
        
    }
}

using System;
using System.Linq;
using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "GenericEntity", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain")]
    [KnownType(typeof(ShipmentCustomDocument))]
    [KnownType(typeof(DocumentAccess))]
    [KnownType(typeof(ShipmentDocument))]
    [KnownType(typeof(LineUnit))]
    public partial class GenericEntity
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public byte[] TimeStamp { get; set; }
    }
}

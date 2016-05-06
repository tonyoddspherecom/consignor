using System;
using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "DocumentAccess", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain")]
    public partial class DocumentAccess : GenericEntity
    {
        [DataMember]
        public DateTime? ExpirationDate { get; set; }
        [DataMember]
        public string PIN { get; set; }
    }
}

using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "Identifier", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.Events")]
    public partial class Identifier
    {
        [DataMember]
        public IdentifierType IdentifierType { get; set; }
        [DataMember]
        public string IdentifierValue { get; set; }
    }
}

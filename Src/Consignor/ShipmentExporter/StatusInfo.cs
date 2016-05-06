using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "StatusInfo", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ExportDomain")]
    public partial class StatusInfo
    {
        [DataMember]
        public string Barcode { get; set; }
        [DataMember]
        public bool IsClosed { get; set; }
        [DataMember]
        public string ShipmentNumber { get; set; }
    }
}

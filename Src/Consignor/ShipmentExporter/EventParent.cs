using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "EventParent", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ExportDomain")]
    public partial class EventParent
    {
        [DataMember(EmitDefaultValue = false)]
        public string Barcode { get; set; }

        [DataMember]
        public long Esid { get; set; }

        [DataMember]
        public bool IsShipment { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string OrderNumber { get; set; }
    }
}
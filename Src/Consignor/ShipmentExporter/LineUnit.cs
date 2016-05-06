using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "LineUnit", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain")]
    public partial class LineUnit : GenericEntity
    {

        [DataMember]
        public int Count { get; set; }
        [DataMember]
        public int KindId { get; set; }
        [DataMember]
        public int LineId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Vol { get; set; }
        [DataMember]
        public int Weight { get; set; }
    }
}

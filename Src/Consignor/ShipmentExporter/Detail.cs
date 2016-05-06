using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "Detail", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ExportDomain")]
    public partial class Detail
    {
        [DataMember]
        public FieldDataType DataType { get; set; }
        [DataMember]
        public string DisplayName { get; set; }
        [DataMember]
        public string GroupDisplayName { get; set; }
        [DataMember]
        public string GroupName { get; set; }
        [DataMember]
        public int? Listing { get; set; }
        [DataMember]
        public int State { get; set; }
        [DataMember]
        public string Value { get; set; }
    }
}

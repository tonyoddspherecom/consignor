using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "DynamicProperty", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ExportDomain")]
    public partial class DynamicProperty
    {
        [DataMember(EmitDefaultValue = false)]
        public string Key { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Value { get; set; }
    }
}
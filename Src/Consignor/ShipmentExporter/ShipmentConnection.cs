using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "ShipmentConnection", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ExportDomain")]
    public partial class ShipmentConnection
    {
        [DataMember(EmitDefaultValue = false)]
        public int ChildCsid { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public ShipmentConnectionKind Kind { get; set; }
    }
}

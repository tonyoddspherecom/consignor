using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Namespace = "http://edisoftwebservices.com/")]
    public class ReferenceDto : GenericEntityDto
    {
        [DataMember(Order = 0)] public string Name { get; set; }
        [DataMember(Order = 1)] public string Value { get; set; }
    }
}
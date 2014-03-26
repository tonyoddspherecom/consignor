using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Namespace = "http://edisoftwebservices.com/")]
    public class AmountDto : GenericEntityDto
    {
        [DataMember(Order = 0)] public string Name { get; set; }
        [DataMember(Order = 1)] public double Value { get; set; }
        [DataMember(Order = 2)] public string Currency { get; set; }
    }
}
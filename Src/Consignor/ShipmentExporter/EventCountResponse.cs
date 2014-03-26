using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Namespace = "http://edisoftwebservices.com/")]
    public class EventCountResponse
    {
        [DataMember(Order = 0)] public int Count { get; set; }
        [DataMember(Order = 1)] public ResponseStatus ResponseStatus { get; set; }
    }
}
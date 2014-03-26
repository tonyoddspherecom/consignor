using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Namespace = "http://edisoftwebservices.com/")]
    public class ResponseStatus
    {
        [DataMember(Order = 0)] public string StatusCode { get; set; }
        [DataMember(Order = 1)] public string StatusDescription { get; set; }
    }
}
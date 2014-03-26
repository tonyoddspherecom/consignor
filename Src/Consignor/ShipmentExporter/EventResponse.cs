using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Namespace = "http://edisoftwebservices.com/")]
    public class EventResponse
    {
        //[XmlArrayItem(typeof(CarrierMeasurement))]
        //[XmlArrayItem(typeof(ConsignorEventDto))]
        //[XmlArrayItem(typeof(TrackAndTraceDto))]
        [DataMember(Order = 0)] public GenericEntityDto[] Events { get; set; }
        [DataMember(Order = 1)] public ResponseStatus ResponseStatus { get; set; }
    }
}
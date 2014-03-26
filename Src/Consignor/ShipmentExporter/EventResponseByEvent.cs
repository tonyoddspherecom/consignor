using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Namespace = "http://edisoftwebservices.com/")]
    public class EventResponseByEvent
    {
        //[XmlArrayItem(typeof(CarrierMeasurement))]
        //[XmlArrayItem(typeof(ConsignorEventDto))]
        //[XmlArrayItem(typeof(TrackAndTraceDto))]
        [DataMember(Order = 0)] public GenericEntityDto[] Events { get; set; }
        [DataMember(Order = 1)] public ResponseStatus ResponseStatus { get; set; }
        [DataMember(Order = 2)] public System.DateTime StartDate { get; set; }
        [DataMember(Order = 3)] public System.DateTime EndDate { get; set; }
        [DataMember(Order = 4)] public string[] EventCodes { get; set; }
        [DataMember(Order = 5)] public int[] ActorIds { get; set; }
    }
}
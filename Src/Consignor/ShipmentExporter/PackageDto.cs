using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Namespace = "http://edisoftwebservices.com/")]
    public class PackageDto : GenericEntityDto
    {
        [DataMember(Order = 0)] public CarrierMeasurement[] CarrierMeasurements { get; set; }
        [DataMember(Order = 1)] public TrackAndTraceDto[] TrackAndTraceList { get; set; }
        [DataMember(Order = 2)] public string PackageNumber { get; set; }
    }
}
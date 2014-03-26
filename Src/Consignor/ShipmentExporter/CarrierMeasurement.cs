using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Namespace = "http://edisoftwebservices.com/")]
    public class CarrierMeasurement : GenericEntityDto
    {
        [DataMember(Order = 0)] public double Volume { get; set; }
        [DataMember(Order = 1)] public double Price { get; set; }
        [DataMember(Order = 2)] public string PriceCurrency { get; set; }
        [DataMember(Order = 3)] public int WeightG { get; set; }
        [DataMember(Order = 4)] public string Awb { get; set; }
        [DataMember(Order = 5)] public string OrderNumber { get; set; }
        [DataMember(Order = 6)] public bool IsShipment { get; set; }
    }
}
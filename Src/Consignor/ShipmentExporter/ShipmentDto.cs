using System;
using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Namespace = "http://edisoftwebservices.com/")]
    public class ShipmentDto : GenericEntityDto
    {
        [DataMember(Order = 0)] public string ShipmentNumber { get; set; }
        [DataMember(Order = 1)] public string OrderNumber { get; set; }
        [DataMember(Order = 2)] public string CarrierName { get; set; }
        [DataMember(Order = 3)] public string ProductName { get; set; }
        [DataMember(Order = 4)] public DateTime TimeStamp { get; set; }
        [DataMember(Order = 5)] public DateTime? DateSubmitted { get; set; }
        [DataMember(Order = 6)] public int ShipmentClientId { get; set; }
        [DataMember(Order = 7)] public string User { get; set; }
        [DataMember(Order = 8)] public string LastStatus { get; set; }
        [DataMember(Order = 9)] public PackageDto[] Packages { get; set; }
        [DataMember(Order = 10)] public ReferenceDto[] ShipmentReferences { get; set; }
        [DataMember(Order = 11)] public AmountDto[] Amounts { get; set; }
        [DataMember(Order = 12)] public CarrierMeasurement[] CarrierMeasurements { get; set; }
        [DataMember(Order = 13)] public TrackAndTraceDto[] TrackAndTraceList { get; set; }
        [DataMember(Order = 14)] public SenderDto Sender { get; set; }
        [DataMember(Order = 15)] public ReceiverDto Receiver { get; set; }
        [DataMember(Order = 16)] public PickupDto Pickup { get; set; }
        [DataMember(Order = 17)] public PayerDto Payer { get; set; }
        [DataMember(Order = 18)] public BuyerDto Buyer { get; set; }
        [DataMember(Order = 19)] public TemporaryDto Temporary { get; set; }
        [DataMember(Order = 20)] public MessageDto Message { get; set; }
        [DataMember(Order = 21)] public ForwarderDto Forwarder { get; set; }
        [DataMember(Order = 22)] public ReturnToDto ReturnTo { get; set; }
        [DataMember(Order = 23)] public DropPointDto DropPoint { get; set; }
        [DataMember(Order = 24)] public DepotDto Depot { get; set; }
    }
}
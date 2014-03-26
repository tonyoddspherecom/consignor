using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Namespace = "http://edisoftwebservices.com/")]
    [KnownType(typeof(ConsignorEventDto))]
    [KnownType(typeof(DepotDto))]
    [KnownType(typeof(DropPointDto))]
    [KnownType(typeof(ReturnToDto))]
    [KnownType(typeof(ForwarderDto))]
    [KnownType(typeof(MessageDto))]
    [KnownType(typeof(TemporaryDto))]
    [KnownType(typeof(BuyerDto))]
    [KnownType(typeof(PayerDto))]
    [KnownType(typeof(PickupDto))]
    [KnownType(typeof(ReceiverDto))]
    [KnownType(typeof(SenderDto))]
    [KnownType(typeof(AmountDto))]
    [KnownType(typeof(ReferenceDto))]
    [KnownType(typeof(TrackAndTraceDto))]
    [KnownType(typeof(CarrierMeasurement))]
    [KnownType(typeof(PackageDto))]
    [KnownType(typeof(ShipmentDto))]
    public abstract class GenericEntityDto
    {
    }
}
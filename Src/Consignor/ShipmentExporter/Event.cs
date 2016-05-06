using System;
using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "Event", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ExportDomain")]
    public partial class Event
    {
        [DataMember(EmitDefaultValue = false)]
        public Guid BaseEventGuid { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string CarrierName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string CityName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Comments { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Country { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public System.DateTime Date { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string DeviceId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? DiscountAmount { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DynamicProperty[] DynamicList { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string EpiNumber { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string ExtraFieldValue { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string FileBase64 { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string FileUrl { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public double GpsLatitude { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public double GpsLongitude { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int? Height { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int? KindId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int? Length { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int? LoadMeter { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string LocationDesc { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int LocationId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string MobileEventCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string NameInSignature { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public BaseEventEventOrigin Origin { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public EventParent Parent { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? PriceBruto { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? PriceNetto { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime? ServerDate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string SignatureUrl { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string StatusCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string StatusState { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string StatusText { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public SubEvent SubEventList { get; set; }

        [DataMember]
        public BaseEventEventType Type { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int UserId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public long? Volume { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int? Weight { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int? Width { get; set; }
    }
}

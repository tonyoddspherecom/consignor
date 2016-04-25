using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "Event", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ExportDomain")]
    public class Event
    {
        [DataMember(Order = 0)] public string BaseEventGuid { get; set; }
        [DataMember(Order = 1)] public string CarrierName { get; set; }
        [DataMember(Order = 2)] public string CityName { get; set; }
        [DataMember(Order = 3)] public string Comments { get; set; }
        [DataMember(Order = 4)] public string Country { get; set; }
        [DataMember(Order = 5)] public DateTime Date { get; set; }
        public bool DateSpecified { get; set; }
        [DataMember(Order = 6)] public string DeviceId { get; set; }
        [DataMember(Order = 7)] public decimal? DiscountAmount { get; set; }
        public bool DiscountAmountSpecified { get; set; }
        [DataMember(Order = 8)] public DynamicProperty[] DynamicList { get; set; }
        [DataMember(Order = 9)] public string EpiNumber { get; set; }
        [DataMember(Order = 10)] public string ExtraFieldValue { get; set; }
        [DataMember(Order = 11)] public string FileBase64 { get; set; }
        [DataMember(Order = 12)] public string FileUrl { get; set; }
        [DataMember(Order = 13)] public double GpsLatitude { get; set; }
        public bool GpsLatitudeSpecified { get; set; }
        [DataMember(Order = 14)] public double GpsLongitude { get; set; }
        public bool GpsLongitudeSpecified { get; set; }
        [DataMember(Order = 15)] public int? Height { get; set; }
        public bool HeightSpecified { get; set; }
        [DataMember(Order = 16)] public int? KindId { get; set; }
        public bool KindIdSpecified { get; set; }
        [DataMember(Order = 17)] public int? Length { get; set; }
        public bool LengthSpecified { get; set; }
        [DataMember(Order = 18)] public int? LoadMeter { get; set; }
        public bool LoadMeterSpecified { get; set; }
        [DataMember(Order = 19)] public string LocationDesc { get; set; }
        [DataMember(Order = 20)] public int LocationId { get; set; }
        public bool LocationIdSpecified { get; set; }
        [DataMember(Order = 21)] public string MobileEventCode { get; set; }
        [DataMember(Order = 22)] public string NameInSignature { get; set; }
        [DataMember(Order = 23)] public BaseEventEventOrigin Origin { get; set; }
        public bool OriginSpecified { get; set; }
        [DataMember(Order = 24)] public EventParent Parent { get; set; }
        [DataMember(Order = 25)] public string PostalCode { get; set; }
        [DataMember(Order = 26)]public decimal? PriceBruto { get; set; }
        public bool PriceBrutoSpecified { get; set; }
        [DataMember(Order = 27)] public decimal? PriceNetto { get; set; }
        public bool PriceNettoSpecified { get; set; }
        [DataMember(Order = 28)] public DateTime? ServerDate { get; set; }
        [DataMember(Order = 29)] public string SignatureUrl { get; set; }
        [DataMember(Order = 30)] public string StatusCode { get; set; }
        [DataMember(Order = 31)] public string StatusState { get; set; }
        [DataMember(Order = 32)] public string StatusText { get; set; }
        [DataMember(Order = 33)] public SubEvent SubEventList { get; set; }
        [DataMember(Order = 34)] public BaseEventEventType Type { get; set; }
        public bool TypeSpecified { get; set; }
        [DataMember(Order = 35)] public int UserId { get; set; }
        public bool UserIdSpecified { get; set; }
        [DataMember(Order = 36)] public long? Volume { get; set; }
        public bool VolumeSpecified { get; set; }
        [DataMember(Order = 37)] public int? Weight { get; set; }
        public bool WeightSpecified { get; set; }
        [DataMember(Order = 38)]
        public int? Width { get; set; }
        public bool WidthSpecified { get; set; }
    }
}

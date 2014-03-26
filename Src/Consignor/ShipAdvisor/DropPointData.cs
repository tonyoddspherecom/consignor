using System;
using System.Runtime.Serialization;
namespace Consignor.ShipAdvisor
{
    [DataContract(Namespace = "http://ws.consignorsupport.no/ShipAdvisor")]
    public class DropPointData
    {
        [DataMember(Order = 0)] public string ChodProductCodes { get; set; }
        [DataMember(Order = 1)] public string OriginalId { get; set; }
        [DataMember(Order = 2)] public string ESId { get; set; }
        [DataMember(Order = 3)] public string RoutingCode { get; set; }
        [DataMember(Order = 4)] public string Depot { get; set; }
        [DataMember(Order = 5)] public string Name1 { get; set; }
        [DataMember(Order = 6)] public string Name2 { get; set; }
        [DataMember(Order = 7)] public string Address1 { get; set; }
        [DataMember(Order = 8)] public string Address2 { get; set; }
        [DataMember(Order = 9)] public string PostalCode { get; set; }
        [DataMember(Order = 10)] public string City { get; set; }
        [DataMember(Order = 11)] public string CountryCode { get; set; }
        [DataMember(Order = 12)] public string Contact { get; set; }
        [DataMember(Order = 13)] public string Phone { get; set; }
        [DataMember(Order = 14)] public string Fax { get; set; }
        [DataMember(Order = 15)] public string Email { get; set; }
        [DataMember(Order = 16)] public double MapRefX { get; set; }
        [DataMember(Order = 17)] public double MapRefY { get; set; }
        [DataMember(Order = 18)] public double Distance { get; set; }
        [DataMember(Order = 19)] public OpeningHours[] OpeningHoursList { get; set; }
        [DataMember(Order = 20)] public RatingData[] RatingDataList { get; set; }
        [DataMember(Order = 21)] public KeyValue[] KeyValueList { get; set; }
    }
}

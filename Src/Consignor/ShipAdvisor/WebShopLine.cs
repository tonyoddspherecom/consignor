using System;
using System.Runtime.Serialization;
namespace Consignor.ShipAdvisor
{
    [DataContract(Namespace = "http://ws.consignorsupport.no/ShipAdvisor")]
    public class WebShopLine
    {
        [DataMember(Order = 1)] public string Description { get; set; }
        [DataMember(Order = 9)] public string GoodsType { get; set; }
        [DataMember(Order = 12)] public ulong? LoadmeterMM { get; set; }
        [DataMember(Order = 7)] public bool? NullableDangerousGoods { get; set; }
        [DataMember(Order = 0)] public int NumberOfPackages { get; set; }
        [DataMember(Order = 3)] public long? PackageHeight { get; set; }
        [DataMember(Order = 4)] public long? PackageLength { get; set; }
        [DataMember(Order = 11)] public string PackagesContents { get; set; }
        [DataMember(Order = 6)] public long? PackageVolume { get; set; }
        [DataMember(Order = 2)] public long? PackageWeight { get; set; }
        [DataMember(Order = 5)] public long? PackageWidth { get; set; }
        [DataMember(Order = 10)] public string RecycleType { get; set; }
        [DataMember(Order = 8)] public string UNNumber { get; set; }
    }
}

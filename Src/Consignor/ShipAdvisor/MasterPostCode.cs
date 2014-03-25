using System;
using System.Runtime.Serialization;
namespace Consignor.ShipAdvisor
{
    [DataContract(Namespace = "http://ws.consignorsupport.no/ShipAdvisor")]
    public class MasterPostCode
    {
        [DataMember(Order = 1)] public string Code { get; set; }
        [DataMember(Order = 2)] public string Country { get; set; }
        [DataMember(Order = 0)] public int Id { get; set; }
        [DataMember(Order = 3)] public decimal? MapRefX { get; set; }
        [DataMember(Order = 4)] public decimal? MapRefY { get; set; }
        [DataMember(Order = 8)] public MDPXMPC[] MDPXMPCs { get; set; }
        [DataMember(Order = 5)] public int UntrustFlags { get; set; }
        [DataMember(Order = 6)] public DateTime? ValidTo { get; set; }
        [DataMember(Order = 7)] public int Zoom { get; set; }
    }
}

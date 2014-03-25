using System;
using System.Runtime.Serialization;
namespace Consignor.ShipAdvisor
{
    [DataContract(Namespace = "http://ws.consignorsupport.no/ShipAdvisor")]
    public class MDPXMPC
    {
        [DataMember(Order = 1)] public decimal? Distance { get; set; }
        [DataMember(Order = 0)] public int Id { get; set; }
        [DataMember(Order = 3)] public MasterDropPoint MasterDropPoint { get; set; }
        [DataMember(Order = 4)] public MasterPostCode MasterPostCode { get; set; }
        [DataMember(Order = 2)] public byte? Type { get; set; }
    }
}

using System;
using System.Runtime.Serialization;
namespace Consignor.ShipAdvisor
{
    [DataContract(Namespace = "http://ws.consignorsupport.no/ShipAdvisor")]
    public class ProductsWrapper
    {
        [DataMember(Order = 1)] public string ErrorMessage { get; set; }
        [DataMember(Order = 0)] public SuitedProductInfo[] ProductInfoList { get; set; }
    }
}

using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "AmountKind", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain")]
    public enum AmountKind : int
    {
        [EnumMember]Unknown = 0,
        [EnumMember]Price1 = 1,
        [EnumMember]Price2 = 2,
        [EnumMember]Price3 = 3,
        [EnumMember]InsuranceValue = 4,
        [EnumMember]CodAmount = 5,
        [EnumMember]CarrierSpecifiedPrice = 6,
        [EnumMember]CarrierSpecifiedCodAmount = 7,
        [EnumMember]InsuranceAmountPerPackage = 8,
        [EnumMember]FixedPrice = 9,
        [EnumMember]InvoiceAmount = 10,
        [EnumMember]CodAmountOriginal = 11,
        [EnumMember]ThirdPartyInsurance = 12,
    }
}

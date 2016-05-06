using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "DangerousGoods", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ExportDomain")]
    public partial class DangerousGoods
    {

        [DataMember(EmitDefaultValue = false)]
        public string ADRtankSpecialProvision { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ADRtankTankCode { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public DangerousGoodsClass Class { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Classification { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int Count { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Description { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string EMSNo { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ExceptedQuantities { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string FlashPoint { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int GoodsLineId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int GrossWeight { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string IdentificationNo { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public DangerousGoodsKind Kind { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int LQCount { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int LQGrossWeight { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Labels { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string LimitedQuantities { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public DangerousGoodsMarinePollutant MarinePollutant { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string MfagNo { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string MixedPackingProvision { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Name { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int NetWeight { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public DangerousGoodsPackingGroup PackingGroup { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string PackingInstructions { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string PackingTypeKey { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string PackingTypeName { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string PageNo { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string PortTankBulkContInstructions { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string PortTankBulkContSpecialProvisions { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string SecondaryClasses { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ShortName { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string SpecialPackingProvision { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string SpecialProvisions { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string SpecialProvisionsBulk { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string SpecialProvisionsHandling { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string SpecialProvisionsOperation { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string SpecialProvisionsPackages { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string StowingCategory { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string TransportCategory { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int UN { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Vehicle { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int Vol { get; set; }
    }
}

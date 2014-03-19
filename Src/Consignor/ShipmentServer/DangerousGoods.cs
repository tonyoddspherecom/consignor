using System.ComponentModel;

namespace Consignor.ShipmentServer
{
    public class DangerousGoods
    {
        [DefaultValue(DGKind.eDgkADRRID)]
        public DGKind Kind { get; set; }

        [DefaultValue(0)]
        public int UN { get; set; }

        [DefaultValue("")]
        public string Name { get; set; }

        [DefaultValue("")]
        public string ShortName { get; set; }

        [DefaultValue("")]
        public string Description { get; set; }

        public DGClass Class { get; set; }

        [DefaultValue("")]
        public string Classification { get; set; }

        [DefaultValue(DGPackingGroup.eDgPgNone)]
        public DGPackingGroup PackingGroup { get; set; }

        [DefaultValue("")]
        public string IdentificationNo { get; set; }

        [DefaultValue(0)]
        public int Count { get; set; }

        [DefaultValue(0)]
        public int GrossWeight { get; set; }

        [DefaultValue(0)]
        public int NetWeight { get; set; }

        [DefaultValue(0)]
        public int Vol { get; set; }

        [DefaultValue("")]
        public string EMSNo { get; set; }

        [DefaultValue("")]
        public string MfagNo { get; set; }

        [DefaultValue("")]
        public string FlashPoint { get; set; }

        [DefaultValue("")]
        public string StowingCategory { get; set; }

        [DefaultValue("")]
        public string PageNo { get; set; }

        [DefaultValue("")]
        public string Labels { get; set; }

        [DefaultValue("")]
        public string PackingTypeName { get; set; }

        [DefaultValue("")]
        public string PackingTypeKey { get; set; }

        [DefaultValue("")]
        public string SpecialProvisions { get; set; }

        [DefaultValue("")]
        public string LimitedQuantities { get; set; }

        [DefaultValue("")]
        public string ExceptedQuantities { get; set; }

        [DefaultValue("")]
        public string PackingInstructions { get; set; }

        [DefaultValue("")]
        public string SpecialPackingProvision { get; set; }

        [DefaultValue("")]
        public string MixedPackingProvision { get; set; }

        [DefaultValue("")]
        public string PortTankBulkContInstructions { get; set; }

        [DefaultValue("")]
        public string PortTankBulkContSpecialProvisions { get; set; }

        [DefaultValue("")]
        public string ADRtankTankCode { get; set; }

        [DefaultValue("")]
        public string ADRtankSpecialProvisions { get; set; }

        [DefaultValue("")]
        public string Vehicle { get; set; }

        [DefaultValue("")]
        public string TransportCategory { get; set; }

        [DefaultValue("")]
        public string SpecialProvisionsPackages { get; set; }

        [DefaultValue("")]
        public string SpecialProvisionsBulk { get; set; }

        [DefaultValue("")]
        public string SpecialProvisionsHandling { get; set; }

        [DefaultValue("")]
        public string SpecialProvisionsOperation { get; set; }

        [DefaultValue(0)]
        public int GoodsLineID { get; set; }

        public DGMarinePollutant MarinePollutant { get; set; }

        [DefaultValue("")]
        public string SecondaryClasses { get; set; }

        [DefaultValue("")]
        public string SubsidiaryRisk { get; set; }

        [DefaultValue(0)]
        public int LQCount { get; set; }

        [DefaultValue(0)]
        public int LQGrossWeight { get; set; }
    }
}
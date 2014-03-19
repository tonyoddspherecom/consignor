using System.Collections.Generic;
using System.ComponentModel;

namespace Consignor.ShipmentServer
{
    public class Line
    {
        [DefaultValue(0)]
        public int LineWeight { get; set; }

        [DefaultValue(0)]
        public int PkgWeight { get; set; }

        [DefaultValue(0)]
        public int DimensionalWeight { get; set; }

        [DefaultValue(0)]
        public int Height { get; set; }

        [DefaultValue(0)]
        public int Length { get; set; }

        [DefaultValue(0)]
        public int Width { get; set; }

        [DefaultValue(0)]
        public long LineVol { get; set; }

        [DefaultValue(0)]
        public long PkgVol { get; set; }

        [DefaultValue(0)]
        public int Loadmeter { get; set; }

        [DefaultValue(0)]
        public int GoodsTypeID { get; set; }

        [DefaultValue("")]
        public string GoodsTypeName { get; set; }

        [DefaultValue(0)]
        public int RecycleCount { get; set; }

        [DefaultValue(0)]
        public int RecycleTypeID { get; set; }

        [DefaultValue("")]
        public string RecycleTypeName { get; set; }

        [DefaultValue("")]
        public string GoodsTypeKey1 { get; set; }

        [DefaultValue("")]
        public string GoodsTypeKey2 { get; set; }

        public List<Reference> References { get; set; }

        public List<LineUnit> LineUnits { get; set; }

        public List<Package> Pkgs { get; set; }
    }
}
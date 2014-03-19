using System.ComponentModel;

namespace Consignor.ShipmentServer
{
    public class LineUnit
    {
        [DefaultValue("")]
        public string Name { get; set; }

        [DefaultValue(0)]
        public int KindID { get; set; }

        public double Count { get; set; }

        [DefaultValue(0)]
        public int Weight { get; set; }

        [DefaultValue(0)]
        public int Vol { get; set; }
    }
}
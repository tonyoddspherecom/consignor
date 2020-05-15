using System.ComponentModel;

namespace Consignor.ShipmentServer
{
    public class Label
    {
        [DefaultValue("")]
        public string Content { get; set; }

        [DefaultValue(0)]
        public int Type { get; set; }

        [DefaultValue(1)]
        public int Copies { get; set; }

        [DefaultValue(1)]
        public string PkgCSID { get; set; }

        [DefaultValue("")]
        public string PkgNo { get; set; }
    }
}
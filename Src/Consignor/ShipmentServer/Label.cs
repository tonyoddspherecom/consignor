using System.ComponentModel;

namespace Consignor.ShipmentServer
{
    public class Label
    {
        [DefaultValue("")]
        public string Content { get; set; }

        [DefaultValue(0)]
        public int Type { get; set; }
    }
}
using System.ComponentModel;

namespace Consignor.ShipmentServer
{
    public class CSEvent
    {
        [DefaultValue(ConsignorEventKind.eSskUnknown)]
        public ConsignorEventKind Kind { get; set; }

        [DefaultValue("")]
        public string Date { get; set; }

        [DefaultValue("")]
        public string User { get; set; }
    }
}
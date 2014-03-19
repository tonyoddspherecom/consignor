using System.ComponentModel;

namespace Consignor.ShipmentServer
{
    public class Message
    {
        public ShipmentMessageKind Kind { get; set; }

        [DefaultValue("")]
        public string Text { get; set; }
    }
}
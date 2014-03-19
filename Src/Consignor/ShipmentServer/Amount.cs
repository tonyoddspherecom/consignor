using System.ComponentModel;

namespace Consignor.ShipmentServer
{
    public class Amount
    {
        [DefaultValue(ShipmentAmountKind.eSamkUnknown)]
        public ShipmentAmountKind Kind { get; set; }

        [DefaultValue("")]
        public string CurrencyCode { get; set; }

        [DefaultValue(0)]
        public double Value { get; set; }
    }
}
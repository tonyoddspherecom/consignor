using System.ComponentModel;

namespace Consignor.ShipmentServer
{
    public class Reference
    {
        [DefaultValue(ReferenceKind.eSrkUnknown)]
        public ReferenceKind Kind { get; set; }

        [DefaultValue("")]
        public string Value { get; set; }
    }
}
using System.ComponentModel;

namespace Consignor.ShipmentServer
{
    public class ShpConnection
    {
        [DefaultValue(ShipmentConnectionKind.eSckUnknown)]
        public ShipmentConnectionKind Kind { get; set; }

        [DefaultValue(0)]
        public int ChildCSID { get; set; }
    }
}
using System.Collections.Generic;
using System.ComponentModel;

namespace Consignor.ShipmentServer
{
    public class Detail
    {
        public int KindID { get; set; }
        [DefaultValue("")]
        public string Value { get; set; }
    }
}
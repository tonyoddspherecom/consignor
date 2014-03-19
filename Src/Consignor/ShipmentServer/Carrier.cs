using System.Collections.Generic;

namespace Consignor.ShipmentServer
{
    public class Carrier
    {

        public int CarrierConceptID { get; set; }
        public string CarrierFullName { get; set; }
        public string CarrierShortName { get; set; }
        public string Icon { get; set; }
        public List<Subcarrier> Subcarriers { get; set; }
    }
}

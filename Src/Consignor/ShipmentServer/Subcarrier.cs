using System.Collections.Generic;

namespace Consignor.ShipmentServer
{
    public class Subcarrier
    {
        public int SubcarrierConceptID { get; set; }
        public string SubcarrierName { get; set; }
        public List<Stack> Stacks { get; set; }
        public List<Product> Products { get; set; }
    }
}

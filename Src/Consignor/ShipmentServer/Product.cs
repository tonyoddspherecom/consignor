using System.Collections.Generic;

namespace Consignor.ShipmentServer
{
    public class Product
    {
        public int ProdConceptID { get; set; }
        public int ProdCSID { get; set; }
        public string ProdName { get; set; }
        public List<Service> Services { get; set; }
    }
}

using System.Collections.Generic;

namespace Consignor.ShipmentServer
{
    public class DetailGroup
    {
        public long DetailGroupID { get; set; }
        public string Label { get; set; }
        public string Listing { get; set; }
        public List<DetailItem> Details { get; set; }
    }
}
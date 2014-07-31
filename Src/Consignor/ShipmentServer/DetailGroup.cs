using System.Collections.Generic;

namespace Consignor.ShipmentServer
{
    public class DetailGroup
    {
        public int GroupID { get; set; }
        public List<DetailRow> Rows { get; set; }
    }
}
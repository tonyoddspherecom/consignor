using System;
using System.Linq;

namespace Consignor
{
    public static class ConsignorService
    {
        public static IShipmentServer CreateShipmentServer(string url, int actorid, string key)
        {
            return new Consignor.Internal.ShipmentServer(url, actorid, key);
        }
    }
}

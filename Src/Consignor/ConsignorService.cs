using Consignor.ShipAdvisor;

namespace Consignor
{
    public static class ConsignorService
    {
        public static Consignor.ShipmentServer.IShipmentServer CreateShipmentServer(string url, int actorid, string key)
        {
            return new Consignor.Internal.ShipmentServer(url, actorid, key);
        }

        public static IShipAdvisor CreateShipAdvisor(string url, string username, string password)
        {
            return new Consignor.Internal.ShipAdvisor(url, username, password);
        }
    }
}
using Consignor.ShipmentServer;

namespace Consignor.Internal
{
    internal class ShipmentServerResponse<T> : ShipmentServerResponse, IShipmentServerResponse<T>
    {
        public ShipmentServerResponse() { }

        public ShipmentServerResponse(ShipmentServerResponse instance)
        {
            this.Info = instance.Info;
            this.Request = instance.Request;
            this.Response = instance.Response;
        }
        public T Result { get; set; }
    }

    internal class ShipmentServerResponse : IShipmentServerResponse
    {
        public IShipmentServerMessages Info { get; set; }

        public string Request { get; set; }

        public string Response { get; set; }
    }
}

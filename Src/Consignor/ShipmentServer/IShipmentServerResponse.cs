
namespace Consignor.ShipmentServer
{
    public interface IShipmentServerResponse<T> : IShipmentServerResponse
    {
        T Result { get; set; }
    }

    public interface IShipmentServerResponse
    {
        IShipmentServerMessages Info { get; set; }

        string Request { get; set; }

        string Response { get; set; }
    }
}

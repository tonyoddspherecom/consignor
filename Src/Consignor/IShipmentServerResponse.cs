using System;

namespace Consignor
{
    public interface IShipmentServerResponse
    {
        IShipmentServerMessages Info { get; set; }
        string Request { get; set; }
        string Response { get; set; }
    }

    public interface IShipmentServerResponse<T> : IShipmentServerResponse
    {
        T Result { get; set; }
    }
}

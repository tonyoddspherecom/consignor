
namespace Consignor.Internal
{
    internal class ConsignorResponse<T> : ConsignorResponse, IShipmentServerResponse<T>
    {
        public ConsignorResponse() { }

        public ConsignorResponse(ConsignorResponse instance)
        {
            this.Info = instance.Info;
            this.Request = instance.Request;
            this.Response = instance.Response;
        }
        public T Result { get; set; }
    }

    internal class ConsignorResponse : IShipmentServerResponse
    {
        public IShipmentServerMessages Info { get; set; }

        public string Request { get; set; }

        public string Response { get; set; }
    }
}

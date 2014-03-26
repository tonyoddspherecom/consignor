using System.Threading.Tasks;

namespace Consignor.ShipAdvisor
{
    public interface IShipAdvisor
    {
        Task<string> CancelChodOrderAsync(long ChODId);
        Task<string> CancelConfirmedOrderAsync(long ChODId);
        Task<string> ConfirmChodOrderAsync(long ChODId);
        Task<OrderOutput> CreateConfirmedOrderAsync(WebShopShipment Shipment, SelectedProduct Product);
        Task<string> ExportCustomDropPoints(int WebShopId);
        Task<string> ExportWebShopAsync(int WebShopId);
        Task<WebShopShipment> GetChodOrderAsync(long ChODId, OrderStatus status);
        Task<DropPointData> GetClosestDropPointAsync(int productConceptID, string installationID, string postCode, string country);
        Task<ProductsWrapper> GetFreightProductsAsync(long ChODId, int deliveryTypeOrder);
        Task<ProductsWrapper> GetFreightProductsForShipmentAsync(WebShopShipment Shipment, int deliveryTypeOrder);
        Task<ProductsWrapper> GetPricesAsync(WebShopShipment Shipment, long[] WebShopProductIds);
        Task<GetShipmentByOrderOutput> GetShipmentByOrderAsync(string orderNumber, string installationID, int actorID);
        Task<string> ImportCustomDropPoints(int WebShopId, string FileContent, bool DeleteExisting);
        Task<string> ImportWebShopAsync(string FileContent);
        Task<OrderInitializeOutput> OrderInitializeAsync(WebShopShipment Shipment, string ReturnUrl, string CancelUrl, string Hash);
        Task<DropPointData[]> SearchDPsForMoreProducts(int webShopId, string productConceptIds, string webshopProductIds, string installationID, string country, string address, string postCode, string city, int limit);
        Task<DropPointData[]> SearchForDropPointsAsync(int productConceptID, string installationID, string country, string address, string postCode, string city, int limit);
        Task<string> UpdateChodOrderAsync(long ChODId, WebShopShipment shipment, SelectedProduct selectedProduct, OrderStatus status);
    }
}

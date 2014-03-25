using Consignor.ShipAdvisor;
using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Consignor.Internal
{
    internal class ShipAdvisor : IShipAdvisor
    {
        private readonly ShipAdvisorClient client;
        private readonly MessageHeader authheader;

        public ShipAdvisor(string url, string username, string password)
        {
            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress(new Uri(url, UriKind.Absolute));
            client = new ShipAdvisorClient(binding, endpoint);
            authheader = MessageHeader.CreateHeader("ServiceAuthenticationHeader", "SoapAuthenticator", new ServiceAuthenticationHeader { Username = username, Password = password });
            //OperationContext.Current.OutgoingMessageHeaders.Add(header);
        }

        public Task<string> CancelChodOrderAsync(long ChODId)
        {
            return Task.Factory.FromAsync(client.BeginCancelChodOrder(ChODId, null, null), ar => client.EndCancelChodOrder(ar));
        }

        public Task<string> CancelConfirmedOrderAsync(long ChODId)
        {
            return Task.Factory.FromAsync(client.BeginCancelConfirmedOrder(ChODId, null, null), ar => client.EndCancelConfirmedOrder(ar));
        }

        public Task<string> ConfirmChodOrderAsync(long ChODId)
        {
            return Task.Factory.FromAsync(client.BeginConfirmChodOrder(ChODId, null, null), ar => client.EndConfirmChodOrder(ar));
        }

        public Task<OrderOutput> CreateConfirmedOrderAsync(WebShopShipment Shipment, SelectedProduct Product)
        {
            return Task.Factory.FromAsync(client.BeginCreateConfirmedOrder(Shipment, Product, null, null), ar => client.EndCreateConfirmedOrder(ar));
        }

        public Task<string> ExportWebShopAsync(int WebShopId)
        {
            return Task.Factory.FromAsync(client.BeginExportWebShop(WebShopId, null, null), ar => client.EndExportWebShop(ar));
        }

        public Task<MasterDropPointWrapper> GetChODAllDropPointsOnMapAsync(int webShopId, string productConceptIds, string webshopProductIds, string installationId, string postCode, string country, decimal mapWidth, decimal mapHeight)
        {
            return Task.Factory.FromAsync(client.BeginGetChODAllDropPointsOnMap(webShopId, productConceptIds, webshopProductIds, installationId, postCode, country, mapWidth, mapHeight, null, null), ar => client.EndGetChODAllDropPointsOnMap(ar));
        }

        public Task<MasterDropPointWrapper> GetChODAllDropPointsWithinBoundsAsync(int webShopId, string productConceptIds, string webshopProductIds, string installationId, decimal ne_lat, decimal ne_lng, decimal sw_lat, decimal sw_lng)
        {
            return Task.Factory.FromAsync(client.BeginGetChODAllDropPointsWithinBounds(webShopId, productConceptIds, webshopProductIds, installationId, ne_lat, ne_lng, sw_lat, sw_lng, null, null), ar => client.EndGetChODAllDropPointsWithinBounds(ar));
        }

        public Task<MasterDropPointWrapper> GetChODCarrierDropPointsOnMapAsync(string productConceptIds, string installationId, string postCode, string country, decimal mapWidth, decimal mapHeight)
        {
            return Task.Factory.FromAsync(client.BeginGetChODCarrierDropPointsOnMap(productConceptIds, installationId, postCode, country, mapWidth, mapHeight, null, null), ar => client.EndGetChODCarrierDropPointsOnMap(ar));
        }

        public Task<MasterDropPointWrapper> GetChODCarrierDropPointsWithinBoundsAsync(string productConceptIds, string installationId, decimal ne_lat, decimal ne_lng, decimal sw_lat, decimal sw_lng)
        {
            return Task.Factory.FromAsync(client.BeginGetChODCarrierDropPointsWithinBounds(productConceptIds, installationId, ne_lat, ne_lng, sw_lat, sw_lng, null, null), ar => client.EndGetChODCarrierDropPointsWithinBounds(ar));
        }

        public Task<WebShopShipment> GetChodOrderAsync(long ChODId, OrderStatus status)
        {
            return Task.Factory.FromAsync(client.BeginGetChodOrder(ChODId, status, null, null), ar => client.EndGetChodOrder(ar));
        }

        public Task<MasterDropPointWrapper> GetChODWebShopDropPointsOnMapAsync(int webShopId, string webshopProductIds, string installationId, string postCode, string country, decimal mapWidth, decimal mapHeight)
        {
            return Task.Factory.FromAsync(client.BeginGetChODWebShopDropPointsOnMap(webShopId, webshopProductIds, installationId, postCode, country, mapWidth, mapHeight, null, null), ar => client.EndGetChODWebShopDropPointsOnMap(ar));
        }

        public Task<MasterDropPointWrapper> GetChODWebShopDropPointsWithinBoundsAsync(int webShopId, string webshopProductIds, string installationId, decimal ne_lat, decimal ne_lng, decimal sw_lat, decimal sw_lng)
        {
            return Task.Factory.FromAsync(client.BeginGetChODWebShopDropPointsWithinBounds(webShopId, webshopProductIds, installationId, ne_lat, ne_lng, sw_lat, sw_lng, null, null), ar => client.EndGetChODWebShopDropPointsWithinBounds(ar));
        }

        public Task<DropPointData> GetClosestDropPointAsync(int productConceptID, string installationID, string postCode, string country)
        {
            return Task.Factory.FromAsync(client.BeginGetClosestDropPoint(productConceptID, installationID, postCode, country, null, null), ar => client.EndGetClosestDropPoint(ar));
        }

        public Task<ProductsWrapper> GetFreightProductsAsync(long ChODId, int deliveryTypeOrder)
        {
            return Task.Factory.FromAsync(client.BeginGetFreightProducts(ChODId, deliveryTypeOrder, null, null), ar => client.EndGetFreightProducts(ar));
        }

        public Task<ProductsWrapper> GetFreightProductsForShipmentAsync(WebShopShipment Shipment, int deliveryTypeOrder)
        {
            return Task.Factory.FromAsync(client.BeginGetFreightProductsForShipment(Shipment, deliveryTypeOrder, null, null), ar => client.EndGetFreightProductsForShipment(ar));
        }

        public Task<ProductsWrapper> GetPricesAsync(WebShopShipment Shipment, long[] WebShopProductIds)
        {
            return Task.Factory.FromAsync(client.BeginGetPrices(Shipment, WebShopProductIds, null, null), ar => client.EndGetPrices(ar));
        }

        public Task<GetShipmentByOrderOutput> GetShipmentByOrderAsync(string orderNumber, string installationID, int actorID)
        {
            return Task.Factory.FromAsync(client.BeginGetShipmentByOrder(orderNumber, installationID, actorID, null, null), ar => client.EndGetShipmentByOrder(ar));
        }

        public Task<string> ImportWebShopAsync(string FileContent)
        {
            return Task.Factory.FromAsync(client.BeginImportWebShop(FileContent, null, null), ar => client.EndImportWebShop(ar));
        }

        public Task<OrderInitializeOutput> OrderInitializeAsync(WebShopShipment Shipment, string ReturnUrl, string CancelUrl, string Hash)
        {
            return Task.Factory.FromAsync(client.BeginOrderInitialize(Shipment, ReturnUrl, CancelUrl, Hash, null, null), ar => client.EndOrderInitialize(ar));
        }

        public Task<DropPointData[]> SearchForDropPointsAsync(int productConceptID, string installationID, string country, string address, string postCode, string city, int limit)
        {
            using (OperationContextScope contextScope = new OperationContextScope(client.InnerChannel))
            {
                OperationContext.Current.OutgoingMessageHeaders.Add(authheader);
                return Task.Factory.FromAsync(client.BeginSearchForDropPoints(productConceptID, installationID, country, address, postCode, city, limit, null, null), ar => client.EndSearchForDropPoints(ar));
            }
        }

        public Task<string> UpdateChodOrderAsync(long ChODId, WebShopShipment shipment, SelectedProduct selectedProduct, OrderStatus status)
        {
            return Task.Factory.FromAsync(client.BeginUpdateChodOrder(ChODId, shipment, selectedProduct, status, null, null), ar => client.EndUpdateChodOrder(ar));
        }
    }
}

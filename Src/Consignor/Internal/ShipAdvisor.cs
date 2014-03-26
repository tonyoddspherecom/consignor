using Consignor.ShipAdvisor;
using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Consignor.Internal
{
    internal class ShipAdvisor : IShipAdvisor
    {
        private readonly ShipAdvisorAsync client;
        private readonly MessageHeader authheader;

        public ShipAdvisor(string url, string username, string password)
        {
            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress(new Uri(url, UriKind.Absolute));
            client = new ShipAdvisorAsync(binding, endpoint);
            authheader = MessageHeader.CreateHeader("ServiceAuthenticationHeader", "SoapAuthenticator", new ServiceAuthenticationHeader { Username = username, Password = password });
        }

        public Task<string> CancelChodOrderAsync(long ChODId)
        {
            using (new OperationContextScope(client.InnerChannel))
            {
                OperationContext.Current.OutgoingMessageHeaders.Add(authheader);
                return Task.Factory.FromAsync(client.BeginCancelChodOrder(ChODId, null, null), ar => client.EndCancelChodOrder(ar));
            }
        }

        public Task<string> CancelConfirmedOrderAsync(long ChODId)
        {
            using (new OperationContextScope(client.InnerChannel))
            {
                OperationContext.Current.OutgoingMessageHeaders.Add(authheader);
                return Task.Factory.FromAsync(client.BeginCancelConfirmedOrder(ChODId, null, null), ar => client.EndCancelConfirmedOrder(ar));
            }
        }

        public Task<string> ConfirmChodOrderAsync(long ChODId)
        {
            using (new OperationContextScope(client.InnerChannel))
            {
                OperationContext.Current.OutgoingMessageHeaders.Add(authheader);
                return Task.Factory.FromAsync(client.BeginConfirmChodOrder(ChODId, null, null), ar => client.EndConfirmChodOrder(ar));
            }
        }

        public Task<OrderOutput> CreateConfirmedOrderAsync(WebShopShipment Shipment, SelectedProduct Product)
        {
            using (new OperationContextScope(client.InnerChannel))
            {
                OperationContext.Current.OutgoingMessageHeaders.Add(authheader);
                return Task.Factory.FromAsync(client.BeginCreateConfirmedOrder(Shipment, Product, null, null), ar => client.EndCreateConfirmedOrder(ar));
            }
        }

        public Task<string> ExportCustomDropPoints(int WebShopId)
        {
            using (new OperationContextScope(client.InnerChannel))
            {
                OperationContext.Current.OutgoingMessageHeaders.Add(authheader);
                return Task.Factory.FromAsync(client.BeginExportCustomDropPoints(WebShopId, null, null), ar => client.EndExportCustomDropPoints(ar));
            }
        }

        public Task<string> ExportWebShopAsync(int WebShopId)
        {
            using (new OperationContextScope(client.InnerChannel))
            {
                OperationContext.Current.OutgoingMessageHeaders.Add(authheader);
                return Task.Factory.FromAsync(client.BeginExportWebShop(WebShopId, null, null), ar => client.EndExportWebShop(ar));
            }
        }

        public Task<WebShopShipment> GetChodOrderAsync(long ChODId, OrderStatus status)
        {
            using (new OperationContextScope(client.InnerChannel))
            {
                OperationContext.Current.OutgoingMessageHeaders.Add(authheader);
                return Task.Factory.FromAsync(client.BeginGetChodOrder(ChODId, status, null, null), ar => client.EndGetChodOrder(ar));
            }
        }

        public Task<DropPointData> GetClosestDropPointAsync(int productConceptID, string installationID, string postCode, string country)
        {
            using (new OperationContextScope(client.InnerChannel))
            {
                OperationContext.Current.OutgoingMessageHeaders.Add(authheader);
                return Task.Factory.FromAsync(client.BeginGetClosestDropPoint(productConceptID, installationID, postCode, country, null, null), ar => client.EndGetClosestDropPoint(ar));
            }
        }

        public Task<ProductsWrapper> GetFreightProductsAsync(long ChODId, int deliveryTypeOrder)
        {
            using (new OperationContextScope(client.InnerChannel))
            {
                OperationContext.Current.OutgoingMessageHeaders.Add(authheader);
                return Task.Factory.FromAsync(client.BeginGetFreightProducts(ChODId, deliveryTypeOrder, null, null), ar => client.EndGetFreightProducts(ar));
            }
        }

        public Task<ProductsWrapper> GetFreightProductsForShipmentAsync(WebShopShipment Shipment, int deliveryTypeOrder)
        {
            using (new OperationContextScope(client.InnerChannel))
            {
                OperationContext.Current.OutgoingMessageHeaders.Add(authheader);
                return Task.Factory.FromAsync(client.BeginGetFreightProductsForShipment(Shipment, deliveryTypeOrder, null, null), ar => client.EndGetFreightProductsForShipment(ar));
            }
        }

        public Task<ProductsWrapper> GetPricesAsync(WebShopShipment Shipment, long[] WebShopProductIds)
        {
            using (new OperationContextScope(client.InnerChannel))
            {
                OperationContext.Current.OutgoingMessageHeaders.Add(authheader);
                return Task.Factory.FromAsync(client.BeginGetPrices(Shipment, WebShopProductIds, null, null), ar => client.EndGetPrices(ar));
            }
        }

        public Task<GetShipmentByOrderOutput> GetShipmentByOrderAsync(string orderNumber, string installationID, int actorID)
        {
            using (new OperationContextScope(client.InnerChannel))
            {
                OperationContext.Current.OutgoingMessageHeaders.Add(authheader);
                return Task.Factory.FromAsync(client.BeginGetShipmentByOrder(orderNumber, installationID, actorID, null, null), ar => client.EndGetShipmentByOrder(ar));
            }
        }

        public Task<string> ImportCustomDropPoints(int WebShopId, string FileContent, bool DeleteExisting)
        {
            using (new OperationContextScope(client.InnerChannel))
            {
                OperationContext.Current.OutgoingMessageHeaders.Add(authheader);
                return Task.Factory.FromAsync(client.BeginImportCustomDropPoints(WebShopId, FileContent, DeleteExisting, null, null), ar => client.EndImportCustomDropPoints(ar));
            }
        }

        public Task<string> ImportWebShopAsync(string FileContent)
        {
            using (new OperationContextScope(client.InnerChannel))
            {
                OperationContext.Current.OutgoingMessageHeaders.Add(authheader);
                return Task.Factory.FromAsync(client.BeginImportWebShop(FileContent, null, null), ar => client.EndImportWebShop(ar));
            }
        }

        public Task<OrderInitializeOutput> OrderInitializeAsync(WebShopShipment Shipment, string ReturnUrl, string CancelUrl, string Hash)
        {
            using (new OperationContextScope(client.InnerChannel))
            {
                OperationContext.Current.OutgoingMessageHeaders.Add(authheader);
                return Task.Factory.FromAsync(client.BeginOrderInitialize(Shipment, ReturnUrl, CancelUrl, Hash, null, null), ar => client.EndOrderInitialize(ar));
            }
        }

        public Task<DropPointData[]> SearchDPsForMoreProducts(int webShopId, string productConceptIds, string webshopProductIds, string installationID, string country, string address, string postCode, string city, int limit)
        {
            using (new OperationContextScope(client.InnerChannel))
            {
                OperationContext.Current.OutgoingMessageHeaders.Add(authheader);
                return Task.Factory.FromAsync(client.BeginSearchDPsForMoreProducts(webShopId, productConceptIds, webshopProductIds, installationID, country, address, postCode, city, limit, null, null), ar => client.EndSearchDPsForMoreProducts(ar));
            }
        }

        public Task<DropPointData[]> SearchForDropPointsAsync(int productConceptID, string installationID, string country, string address, string postCode, string city, int limit)
        {
            using (new OperationContextScope(client.InnerChannel))
            {
                OperationContext.Current.OutgoingMessageHeaders.Add(authheader);
                return Task.Factory.FromAsync(client.BeginSearchForDropPoints(productConceptID, installationID, country, address, postCode, city, limit, null, null), ar => client.EndSearchForDropPoints(ar));
            }
        }

        public Task<string> UpdateChodOrderAsync(long ChODId, WebShopShipment shipment, SelectedProduct selectedProduct, OrderStatus status)
        {
            using (new OperationContextScope(client.InnerChannel))
            {
                OperationContext.Current.OutgoingMessageHeaders.Add(authheader);
                return Task.Factory.FromAsync(client.BeginUpdateChodOrder(ChODId, shipment, selectedProduct, status, null, null), ar => client.EndUpdateChodOrder(ar));
            }
        }
    }
}

using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using Consignor.ShipAdvisor;

namespace Consignor.Internal
{
    internal class ShipAdvisorAsync : ClientBase<IShipAdvisorAsync>, IShipAdvisorAsync
    {
        public ShipAdvisorAsync(Binding binding, EndpointAddress address) : base(binding, address) {}

        protected override IShipAdvisorAsync CreateChannel()
        {
            return new ShipAdvisorChannel(this);
        }

        public IAsyncResult BeginCancelChodOrder(long ChODId, AsyncCallback callback, object state)
        {
            return Channel.BeginCancelChodOrder(ChODId, callback, state);
        }

        public string EndCancelChodOrder(IAsyncResult result)
        {
            return Channel.EndCancelChodOrder(result);
        }

        public IAsyncResult BeginCancelConfirmedOrder(long ChODId, AsyncCallback callback, object state)
        {
            return Channel.BeginCancelConfirmedOrder(ChODId, callback, state);
        }

        public string EndCancelConfirmedOrder(IAsyncResult result)
        {
            return Channel.EndCancelConfirmedOrder(result);
        }

        public IAsyncResult BeginConfirmChodOrder(long ChODId, AsyncCallback callback, object state)
        {
            return Channel.BeginConfirmChodOrder(ChODId, callback, state);
        }

        public string EndConfirmChodOrder(IAsyncResult result)
        {
            return Channel.EndConfirmChodOrder(result);
        }

        public IAsyncResult BeginCreateConfirmedOrder(WebShopShipment Shipment, SelectedProduct Product, AsyncCallback callback, object state)
        {
            return Channel.BeginCreateConfirmedOrder(Shipment, Product, callback, state);
        }

        public OrderOutput EndCreateConfirmedOrder(IAsyncResult result)
        {
            return Channel.EndCreateConfirmedOrder(result);
        }

        public IAsyncResult BeginExportCustomDropPoints(int webShopId, AsyncCallback callback, object state)
        {
            return Channel.BeginExportCustomDropPoints(webShopId, callback, state);
        }

        public string EndExportCustomDropPoints(IAsyncResult result)
        {
            return Channel.EndExportCustomDropPoints(result);
        }

        public IAsyncResult BeginExportWebShop(int WebShopId, AsyncCallback callback, object state)
        {
            return Channel.BeginExportWebShop(WebShopId, callback, state);
        }

        public string EndExportWebShop(IAsyncResult result)
        {
            return Channel.EndExportWebShop(result);
        }

        public IAsyncResult BeginGetChodOrder(long ChODId, OrderStatus status, AsyncCallback callback, object state)
        {
            return Channel.BeginGetChodOrder(ChODId, status, callback, state);
        }

        public WebShopShipment EndGetChodOrder(IAsyncResult result)
        {
            return Channel.EndGetChodOrder(result);
        }

        public IAsyncResult BeginGetClosestDropPoint(int productConceptID, string installationID, string postCode, string country, AsyncCallback callback, object state)
        {
            return Channel.BeginGetClosestDropPoint(productConceptID, installationID, postCode, country, callback, state);
        }

        public DropPointData EndGetClosestDropPoint(IAsyncResult result)
        {
            return Channel.EndGetClosestDropPoint(result);
        }

        public IAsyncResult BeginGetFreightProducts(long ChODId, int deliveryTypeOrder, AsyncCallback callback, object state)
        {
            return Channel.BeginGetFreightProducts(ChODId, deliveryTypeOrder, callback, state);
        }

        public ProductsWrapper EndGetFreightProducts(IAsyncResult result)
        {
            return Channel.EndGetFreightProducts(result);
        }

        public IAsyncResult BeginGetFreightProductsForShipment(WebShopShipment Shipment, int deliveryTypeOrder, AsyncCallback callback, object state)
        {
            return Channel.BeginGetFreightProductsForShipment(Shipment, deliveryTypeOrder, callback, state);
        }

        public ProductsWrapper EndGetFreightProductsForShipment(IAsyncResult result)
        {
            return Channel.EndGetFreightProductsForShipment(result);
        }

        public IAsyncResult BeginGetPrices(WebShopShipment Shipment, long[] WebShopProductIds, AsyncCallback callback, object state)
        {
            return Channel.BeginGetPrices(Shipment, WebShopProductIds, callback, state);
        }

        public ProductsWrapper EndGetPrices(IAsyncResult result)
        {
            return Channel.EndGetPrices(result);
        }

        public IAsyncResult BeginGetShipmentByOrder(string orderNumber, string installationID, int actorID, AsyncCallback callback, object state)
        {
            return Channel.BeginGetShipmentByOrder(orderNumber, installationID, actorID, callback, state);
        }

        public GetShipmentByOrderOutput EndGetShipmentByOrder(IAsyncResult result)
        {
            return Channel.EndGetShipmentByOrder(result);
        }

        public IAsyncResult BeginImportCustomDropPoints(int webShopId, string fileContent, bool deleteExisting, AsyncCallback callback, object state)
        {
            return Channel.BeginImportCustomDropPoints(webShopId, fileContent, deleteExisting, callback, state);
        }

        public string EndImportCustomDropPoints(IAsyncResult result)
        {
            return Channel.EndImportCustomDropPoints(result);
        }

        public IAsyncResult BeginImportWebShop(string FileContent, AsyncCallback callback, object state)
        {
            return Channel.BeginImportWebShop(FileContent, callback, state);
        }

        public string EndImportWebShop(IAsyncResult result)
        {
            return Channel.EndImportWebShop(result);
        }

        public IAsyncResult BeginOrderInitialize(WebShopShipment Shipment, string ReturnUrl, string CancelUrl, string Hash, AsyncCallback callback, object state)
        {
            return Channel.BeginOrderInitialize(Shipment, ReturnUrl, CancelUrl, Hash, callback, state);
        }

        public OrderInitializeOutput EndOrderInitialize(IAsyncResult result)
        {
            return Channel.EndOrderInitialize(result);
        }

        public IAsyncResult BeginSearchDPsForMoreProducts(int webShopId, string productConceptIds, string webshopProductIds, string installationID, string country, string address, string postCode, string city, int limit, AsyncCallback callback, object state)
        {
            return Channel.BeginSearchDPsForMoreProducts(webShopId, productConceptIds, webshopProductIds, installationID, country, address, postCode, city, limit, callback, state);
        }

        public DropPointData[] EndSearchDPsForMoreProducts(IAsyncResult result)
        {
            return Channel.EndSearchDPsForMoreProducts(result);
        }

        public IAsyncResult BeginSearchForDropPoints(int productConceptID, string installationID, string country, string address, string postCode, string city, int limit, AsyncCallback callback, object state)
        {
            return Channel.BeginSearchForDropPoints(productConceptID, installationID, country, address, postCode, city, limit, callback, state);
        }

        public DropPointData[] EndSearchForDropPoints(IAsyncResult result)
        {
            return Channel.EndSearchForDropPoints(result);
        }

        public IAsyncResult BeginUpdateChodOrder(long ChODId, WebShopShipment shipment, SelectedProduct selectedProduct, OrderStatus status, AsyncCallback callback, object state)
        {
            return Channel.BeginUpdateChodOrder(ChODId, shipment, selectedProduct, status, callback, state);
        }

        public string EndUpdateChodOrder(IAsyncResult result)
        {
            return Channel.EndUpdateChodOrder(result);
        }

        protected class ShipAdvisorChannel : ChannelBase<IShipAdvisorAsync>, IShipAdvisorAsync
        {
            public ShipAdvisorChannel(ClientBase<IShipAdvisorAsync> client) : base(client) { }

            public IAsyncResult BeginCancelChodOrder(long ChODId, AsyncCallback callback, object state)
            {
                var _args = new object[] { ChODId };
                return base.BeginInvoke("CancelChodOrder", _args, callback, state);
            }

            public string EndCancelChodOrder(IAsyncResult result)
            {
                return ((string)(base.EndInvoke("CancelChodOrder", new object[0], result)));
            }

            public IAsyncResult BeginCancelConfirmedOrder(long ChODId, AsyncCallback callback, object state)
            {
                var _args = new object[] { ChODId };
                return base.BeginInvoke("CancelConfirmedOrder", _args, callback, state);
            }

            public string EndCancelConfirmedOrder(IAsyncResult result)
            {
                return ((string)(base.EndInvoke("CancelConfirmedOrder", new object[0], result)));
            }

            public IAsyncResult BeginConfirmChodOrder(long ChODId, AsyncCallback callback, object state)
            {
                var _args = new object[] { ChODId };
                return base.BeginInvoke("ConfirmChodOrder", _args, callback, state);
            }

            public string EndConfirmChodOrder(IAsyncResult result)
            {
                return ((string)(base.EndInvoke("ConfirmChodOrder", new object[0], result)));
            }

            public IAsyncResult BeginCreateConfirmedOrder(WebShopShipment Shipment, SelectedProduct Product, AsyncCallback callback, object state)
            {
                var _args = new object[] { Shipment, Product };
                return base.BeginInvoke("CreateConfirmedOrder", _args, callback, state);
            }

            public OrderOutput EndCreateConfirmedOrder(IAsyncResult result)
            {
                return ((OrderOutput)(base.EndInvoke("CreateConfirmedOrder", new object[0], result)));
            }

            public IAsyncResult BeginExportCustomDropPoints(int webShopId, AsyncCallback callback, object state)
            {
                var _args = new object[] { webShopId };
                return base.BeginInvoke("ExportCustomDropPoints", _args, callback, state);
            }

            public string EndExportCustomDropPoints(IAsyncResult result)
            {
                return ((string)(base.EndInvoke("ExportCustomDropPoints", new object[0], result)));
            }

            public IAsyncResult BeginExportWebShop(int WebShopId, AsyncCallback callback, object state)
            {
                var _args = new object[] { WebShopId };
                return base.BeginInvoke("ExportWebShop", _args, callback, state);
            }

            public string EndExportWebShop(IAsyncResult result)
            {
                return ((string)(base.EndInvoke("ExportWebShop", new object[0], result)));
            }

            public IAsyncResult BeginGetChodOrder(long ChODId, OrderStatus status, AsyncCallback callback, object state)
            {
                var _args = new object[] { ChODId, status };
                return base.BeginInvoke("GetChodOrder", _args, callback, state);
            }

            public WebShopShipment EndGetChodOrder(IAsyncResult result)
            {
                return ((WebShopShipment)(base.EndInvoke("GetChodOrder", new object[0], result)));
            }

            public IAsyncResult BeginGetClosestDropPoint(int productConceptID, string installationID, string postCode, string country, AsyncCallback callback, object state)
            {
                var _args = new object[] { productConceptID, installationID, postCode, country };
                return base.BeginInvoke("GetClosestDropPoint", _args, callback, state);
            }

            public DropPointData EndGetClosestDropPoint(IAsyncResult result)
            {
                return ((DropPointData)(base.EndInvoke("GetClosestDropPoint", new object[0], result)));
            }

            public IAsyncResult BeginGetFreightProducts(long ChODId, int deliveryTypeOrder, AsyncCallback callback, object state)
            {
                var _args = new object[] { ChODId, deliveryTypeOrder };
                return base.BeginInvoke("GetFreightProducts", _args, callback, state);
            }

            public ProductsWrapper EndGetFreightProducts(IAsyncResult result)
            {
                return ((ProductsWrapper)(base.EndInvoke("GetFreightProducts", new object[0], result)));
            }

            public IAsyncResult BeginGetFreightProductsForShipment(WebShopShipment Shipment, int deliveryTypeOrder, AsyncCallback callback, object state)
            {
                var _args = new object[] { Shipment, deliveryTypeOrder };
                return base.BeginInvoke("GetFreightProductsForShipment", _args, callback, state);
            }

            public ProductsWrapper EndGetFreightProductsForShipment(IAsyncResult result)
            {
                return ((ProductsWrapper)(base.EndInvoke("GetFreightProductsForShipment", new object[0], result)));
            }

            public IAsyncResult BeginGetPrices(WebShopShipment Shipment, long[] WebShopProductIds, AsyncCallback callback, object state)
            {
                var _args = new object[] { Shipment, WebShopProductIds };
                return base.BeginInvoke("GetPrices", _args, callback, state);
            }

            public ProductsWrapper EndGetPrices(IAsyncResult result)
            {
                return ((ProductsWrapper)(base.EndInvoke("GetPrices", new object[0], result)));
            }

            public IAsyncResult BeginGetShipmentByOrder(string orderNumber, string installationID, int actorID, AsyncCallback callback, object state)
            {
                var _args = new object[] { orderNumber, installationID, actorID };
                return base.BeginInvoke("GetShipmentByOrder", _args, callback, state);
            }

            public GetShipmentByOrderOutput EndGetShipmentByOrder(IAsyncResult result)
            {
                return ((GetShipmentByOrderOutput)(base.EndInvoke("GetShipmentByOrder", new object[0], result)));
            }

            public IAsyncResult BeginImportCustomDropPoints(int webShopId, string fileContent, bool deleteExisting, AsyncCallback callback, object state)
            {
                var _args = new object[] { webShopId, fileContent, deleteExisting };
                return base.BeginInvoke("ImportCustomDropPoints", _args, callback, state);
            }

            public string EndImportCustomDropPoints(IAsyncResult result)
            {
                return ((string)(base.EndInvoke("ImportCustomDropPoints", new object[0], result)));
            }

            public IAsyncResult BeginImportWebShop(string FileContent, AsyncCallback callback, object state)
            {
                var _args = new object[] { FileContent };
                return base.BeginInvoke("ImportWebShop", _args, callback, state);
            }

            public string EndImportWebShop(IAsyncResult result)
            {
                return ((string)(base.EndInvoke("ImportWebShop", new object[0], result)));
            }

            public IAsyncResult BeginOrderInitialize(WebShopShipment Shipment, string ReturnUrl, string CancelUrl, string Hash, AsyncCallback callback, object state)
            {
                var _args = new object[] { Shipment, ReturnUrl, CancelUrl, Hash };
                return base.BeginInvoke("OrderInitialize", _args, callback, state);
            }

            public OrderInitializeOutput EndOrderInitialize(IAsyncResult result)
            {
                return ((OrderInitializeOutput)(base.EndInvoke("OrderInitialize", new object[0], result)));
            }

            public IAsyncResult BeginSearchDPsForMoreProducts(int webShopId, string productConceptIds, string webshopProductIds, string installationID, string country, string address, string postCode, string city, int limit, AsyncCallback callback, object state)
            {
                var _args = new object[] { webShopId, productConceptIds, webshopProductIds, installationID, country, address, postCode, city, limit };
                return base.BeginInvoke("SearchDPsForMoreProducts", _args, callback, state);
            }

            public DropPointData[] EndSearchDPsForMoreProducts(IAsyncResult result)
            {
                return ((DropPointData[])(base.EndInvoke("SearchDPsForMoreProducts", new object[0], result)));
            }

            public IAsyncResult BeginSearchForDropPoints(int productConceptID, string installationID, string country, string address, string postCode, string city, int limit, AsyncCallback callback, object state)
            {
                var _args = new object[] { productConceptID, installationID, country, address, postCode, city, limit };
                return base.BeginInvoke("SearchForDropPoints", _args, callback, state);
            }

            public DropPointData[] EndSearchForDropPoints(IAsyncResult result)
            {
                return ((DropPointData[])(base.EndInvoke("SearchForDropPoints", new object[0], result)));
            }

            public IAsyncResult BeginUpdateChodOrder(long ChODId, WebShopShipment shipment, SelectedProduct selectedProduct, OrderStatus status, AsyncCallback callback, object state)
            {
                var _args = new object[] { ChODId, shipment, selectedProduct, status };
                return base.BeginInvoke("UpdateChodOrder", _args, callback, state);
            }

            public string EndUpdateChodOrder(IAsyncResult result)
            {
                return ((string)(base.EndInvoke("UpdateChodOrder", new object[0], result)));
            }
        }
    }
}
using System;
using System.ServiceModel.Channels;
using Consignor.ShipmentExporter;
using System.ServiceModel;
using System.Collections.Generic;

namespace Consignor.Internal
{
    internal class ShipmentExporterAsync : ClientBase<IShipmentExporterAsync>, IShipmentExporterAsync
    {
        public ShipmentExporterAsync(Binding binding, EndpointAddress address) : base(binding, address) { }

        protected override IShipmentExporterAsync CreateChannel()
        {
            return new ShipmentExporterChannel(this);
        }

        public IAsyncResult BeginGetShipmentsByShipmentNumber(string userName, string password, string installationValue, int[] actors, string shipmentNumber, DateTime? startDateTime, DateTime? endDateTime, AsyncCallback callback, object state)
        {
            return Channel.BeginGetShipmentsByShipmentNumber(userName, password, installationValue, actors, shipmentNumber, startDateTime, endDateTime, callback, state);
        }

        public Shipment[] EndGetShipmentsByShipmentNumber(IAsyncResult result)
        {
            var temp = Channel.EndGetShipmentsByShipmentNumber(result);
            return temp;
        }

        public IAsyncResult BeginGetEvents(string userName, string password, DateTime eventDateTimeStart, DateTime eventDateTimeEnd, AsyncCallback callback, object state)
        {
            return Channel.BeginGetEvents(userName, password, eventDateTimeStart, eventDateTimeEnd, callback, state);
        }

        public Event[] EndGetEvents(IAsyncResult result)
        {
            return Channel.EndGetEvents(result);
        }

        /*
        

        public IAsyncResult BeginGetShipmentsByOrderNumber(GetShipmentsByOrderNumberRequest request, AsyncCallback callback, object state)
        {
            return Channel.BeginGetShipmentsByOrderNumber(request, callback, state);
        }

        public GetShipmentsByOrderNumberResponse EndGetShipmentsByOrderNumber(IAsyncResult result)
        {
            return Channel.EndGetShipmentsByOrderNumber(result);
        }

        public IAsyncResult BeginGetShipmentsByPackageNumber(GetShipmentsByPackageNumberRequest request, AsyncCallback callback, object state)
        {
            return Channel.BeginGetShipmentsByPackageNumber(request, callback, state);
        }

        public GetShipmentsByPackageNumberResponse EndGetShipmentsByPackageNumber(IAsyncResult result)
        {
            return Channel.EndGetShipmentsByPackageNumber(result);
        }

        public IAsyncResult BeginGetShipmentsByDateRange(GetShipmentsByDateRangeRequest request, AsyncCallback callback, object state)
        {
            return Channel.BeginGetShipmentsByDateRange(request, callback, state);
        }

        public GetShipmentsByDateRangeResponse EndGetShipmentsByDateRange(IAsyncResult result)
        {
            return Channel.EndGetShipmentsByDateRange(result);
        }

        

        public IAsyncResult BeginGetCarrierEventsByEventCode(GetCarrierEventsByEventCodeRequest request, AsyncCallback callback, object state)
        {
            return Channel.BeginGetCarrierEventsByEventCode(request, callback, state);
        }

        public GetCarrierEventsByEventCodeResponse EndGetCarrierEventsByEventCode(IAsyncResult result)
        {
            return Channel.EndGetCarrierEventsByEventCode(result);
        }

        public IAsyncResult BeginGetShipmentStatus(GetShipmentStatusRequest request, AsyncCallback callback, object state)
        {
            return Channel.BeginGetShipmentStatus(request, callback, state);
        }

        public GetShipmentStatusResponse EndGetShipmentStatus(IAsyncResult result)
        {
            return Channel.EndGetShipmentStatus(result);
        }

        public IAsyncResult BeginSendEvent(SendEventRequest request, AsyncCallback callback, object state)
        {
            return Channel.BeginSendEvent(request, callback, state);
        }

        public SendEventResponse EndSendEvent(IAsyncResult result)
        {
            return Channel.EndSendEvent(result);
        }

        public IAsyncResult BeginIsShipmentClosed(IsShipmentClosedRequest request, AsyncCallback callback, object state)
        {
            return Channel.BeginIsShipmentClosed(request, callback, state);
        }

        public IsShipmentClosedResponse EndIsShipmentClosed(IAsyncResult result)
        {
            return Channel.EndIsShipmentClosed(result);
        }

        public IAsyncResult BeginCheckHealth(CheckHealthRequest request, AsyncCallback callback, object state)
        {
            return Channel.BeginCheckHealth(request, callback, state);
        }

        public CheckHealthResponse EndCheckHealth(IAsyncResult result)
        {
            return Channel.EndCheckHealth(result);
        }
        */
        protected class ShipmentExporterChannel : ChannelBase<IShipmentExporterAsync>, IShipmentExporterAsync
        {
            public ShipmentExporterChannel(ClientBase<IShipmentExporterAsync> client) : base(client) { }

            public IAsyncResult BeginGetEvents(string userName, string password, DateTime eventDateTimeStart, DateTime eventDateTimeEnd, AsyncCallback callback, object state)
            {
                var _args = new object[] { userName, password, eventDateTimeStart, eventDateTimeEnd };
                return base.BeginInvoke("GetEvents", _args, callback, state);
                
            }

            public Event[] EndGetEvents(IAsyncResult result)
            {
                return ((Event[])(base.EndInvoke("GetEvents", new object[0], result)));
            }

            public IAsyncResult BeginGetShipmentsByShipmentNumber(string userName, string password, string installationValue, int[] actors, string shipmentNumber, DateTime? startDateTime, DateTime? endDateTime, AsyncCallback callback, object state)
            {
                var _args = new object[] { userName, password, installationValue, actors, shipmentNumber };
                return base.BeginInvoke("GetShipmentsByShipmentNumber", _args, callback, state);
            }

            public Shipment[] EndGetShipmentsByShipmentNumber(IAsyncResult result)
            {
                var result2 = ((base.EndInvoke("GetShipmentsByShipmentNumber", new object[0], result)));
                return new List<Shipment>().ToArray();
            }
            /*
            public IAsyncResult BeginGetCarrierEventsByEventCode(GetCarrierEventsByEventCodeRequest request, AsyncCallback callback, object state)
            {
                var _args = new object[] { request.userName, request.password, request.eventDateTimeStart, request.eventDateTimeEnd, request.eventCodes, request.installationValue };
                return base.BeginInvoke("GetCarrierEventsByEventCode", _args, callback, state);
            }

            public GetCarrierEventsByEventCodeResponse EndGetCarrierEventsByEventCode(IAsyncResult result)
            {
                return ((GetCarrierEventsByEventCodeResponse)(base.EndInvoke("GetCarrierEventsByEventCode", new object[0], result)));
            }

            public IAsyncResult BeginGetShipmentsByDateRange(GetShipmentsByDateRangeRequest request, AsyncCallback callback, object state)
            {
                var _args = new object[] { request.userName, request.password, request.installationValue, request.actors, request.startDateTime, request.endDateTime, request.pageIndex };
                return base.BeginInvoke("GetShipmentsByDateRange", _args, callback, state);
            }

            public GetShipmentsByDateRangeResponse EndGetShipmentsByDateRange(IAsyncResult result)
            {
                return ((GetShipmentsByDateRangeResponse)(base.EndInvoke("GetShipmentsByDateRange", new object[0], result)));
            }

            public IAsyncResult BeginGetShipmentsByOrderNumber(GetShipmentsByOrderNumberRequest request, AsyncCallback callback, object state)
            {
                var _args = new object[] { request.userName, request.password, request.installationValue, request.actors, request.referenceNumber };
                return base.BeginInvoke("GetShipmentsByOrderNumber", _args, callback, state);
            }

            public GetShipmentsByOrderNumberResponse EndGetShipmentsByOrderNumber(IAsyncResult result)
            {
                return ((GetShipmentsByOrderNumberResponse)(base.EndInvoke("GetShipmentsByOrderNumber", new object[0], result)));
            }

            public IAsyncResult BeginGetShipmentsByPackageNumber(GetShipmentsByPackageNumberRequest request, AsyncCallback callback, object state)
            {
                var _args = new object[] { request.userName, request.password, request.installationValue, request.actors, request.packageNumber, };
                return base.BeginInvoke("GetShipmentsByPackageNumber", _args, callback, state);
            }

            public GetShipmentsByPackageNumberResponse EndGetShipmentsByPackageNumber(IAsyncResult result)
            {
                return ((GetShipmentsByPackageNumberResponse)(base.EndInvoke("GetShipmentsByPackageNumber", new object[0], result)));
            }

            public IAsyncResult BeginGetShipmentsByShipmentNumber(GetShipmentsByShipmentNumberRequest request, AsyncCallback callback, object state)
            {
                var _args = new object[] { request.userName, request.password, request.installationValue, request.actors, request.shipmentNumber };
                return base.BeginInvoke("GetShipmentsByShipmentNumber", _args, callback, state);
            }

            public GetShipmentsByShipmentNumberResponse EndGetShipmentsByShipmentNumber(IAsyncResult result)
            {
                return ((GetShipmentsByShipmentNumberResponse)(base.EndInvoke("GetShipmentsByShipmentNumber", new object[0], result)));
            }

            public IAsyncResult BeginGetShipmentStatus(GetShipmentStatusRequest request, AsyncCallback callback, object state)
            {
                var _args = new object[] { request.userName, request.password, request.shipmentNumber };
                return base.BeginInvoke("GetShipmentStatus", _args, callback, state);
            }

            public GetShipmentStatusResponse EndGetShipmentStatus(IAsyncResult result)
            {
                return ((GetShipmentStatusResponse)(base.EndInvoke("GetShipmentStatus", new object[0], result)));
            }

            public IAsyncResult BeginSendEvent(SendEventRequest request, AsyncCallback callback, object state)
            {
                var _args = new object[] { request.userName, request.password, request.submitEvent };
                return base.BeginInvoke("SendEvent", _args, callback, state);
            }

            public SendEventResponse EndSendEvent(IAsyncResult result)
            {
                return ((SendEventResponse)(base.EndInvoke("GetShipmentStatus", new object[0], result)));
            }

            public IAsyncResult BeginIsShipmentClosed(IsShipmentClosedRequest request, AsyncCallback callback, object state)
            {
                var _args = new object[] { request.userName, request.password, request.barcode };
                return base.BeginInvoke("IsShipmentClosed", _args, callback, state);
            }

            public IsShipmentClosedResponse EndIsShipmentClosed(IAsyncResult result)
            {
                return ((IsShipmentClosedResponse)(base.EndInvoke("IsShipmentClosed", new object[0], result)));
            }

            public IAsyncResult BeginCheckHealth(CheckHealthRequest request, AsyncCallback callback, object state)
            {
                var _args = new object[] { };
                return base.BeginInvoke("CheckHealth", _args, callback, state);
            }

            public CheckHealthResponse EndCheckHealth(IAsyncResult result)
            {
                return ((CheckHealthResponse)(base.EndInvoke("CheckHealth", new object[0], result)));
            }*/
        }
    }
}

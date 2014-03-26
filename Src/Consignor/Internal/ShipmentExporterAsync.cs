using System;
using System.ServiceModel.Channels;
using Consignor.ShipmentExporter;
using System.ServiceModel;

namespace Consignor.Internal
{
    internal class ShipmentExporterAsync : ClientBase<IShipmentExporterAsync>, IShipmentExporterAsync
    {
        public ShipmentExporterAsync(Binding binding, EndpointAddress address) : base(binding, address) { }

        protected override IShipmentExporterAsync CreateChannel()
        {
            return new ShipmentExporterChannel(this);
        }

        public IAsyncResult BeginGetEvents(string userName, string password, DateTime eventDateTimeStart, DateTime eventDateTimeEnd, AsyncCallback callback, object state)
        {
            return Channel.BeginGetEvents(userName, password, eventDateTimeStart, eventDateTimeEnd, callback, state);
        }

        public EventResponse EndGetEvents(IAsyncResult result)
        {
            return Channel.EndGetEvents(result);
        }

        public IAsyncResult BeginGetEventsByEventCode(string userName, string password, DateTime eventDateTimeStart, DateTime eventDateTimeEnd, string[] eventCode, int[] actorId, AsyncCallback callback, object state)
        {
            return Channel.BeginGetEventsByEventCode(userName, password, eventDateTimeStart, eventDateTimeEnd, eventCode, actorId, callback, state);
        }

        public EventResponseByEvent EndGetEventsByEventCode(IAsyncResult result)
        {
            return Channel.EndGetEventsByEventCode(result);
        }

        public IAsyncResult BeginGetShipmentByDateRange(string userName, string password, string installationValue, int[] actors, DateTime startDate, DateTime endDate, int pageIndex, AsyncCallback callback, object state)
        {
            return Channel.BeginGetShipmentByDateRange(userName, password, installationValue, actors, startDate, endDate, pageIndex, callback, state);
        }

        public Response EndGetShipmentByDateRange(IAsyncResult result)
        {
            return Channel.EndGetShipmentByDateRange(result);
        }

        public IAsyncResult BeginGetShipmentByOrderNumber(string userName, string password, string installationValue, int[] actors, string referenceNumber, AsyncCallback callback, object state)
        {
            return Channel.BeginGetShipmentByOrderNumber(userName, password, installationValue, actors, referenceNumber, callback, state);
        }

        public Response EndGetShipmentByOrderNumber(IAsyncResult result)
        {
            return Channel.EndGetShipmentByOrderNumber(result);
        }

        public IAsyncResult BeginGetShipmentByPackageNumber(string userName, string password, string installationValue, int[] actors, string packageNumber, AsyncCallback callback, object state)
        {
            return Channel.BeginGetShipmentByPackageNumber(userName, password, installationValue, actors, packageNumber, callback, state);
        }

        public Response EndGetShipmentByPackageNumber(IAsyncResult result)
        {
            return Channel.EndGetShipmentByPackageNumber(result);
        }

        public IAsyncResult BeginGetShipmentByShipmentNumber(string userName, string password, string installationValue, int[] actors, string shipmentNumber, AsyncCallback callback, object state)
        {
            return Channel.BeginGetShipmentByShipmentNumber(userName, password, installationValue, actors, shipmentNumber, callback, state);
        }

        public Response EndGetShipmentByShipmentNumber(IAsyncResult result)
        {
            return Channel.EndGetShipmentByShipmentNumber(result);
        }

        public IAsyncResult BeginGetShipmentsByOrderNumber(string userName, string password, string installationValue, int[] actors, string referenceNumber, AsyncCallback callback, object state)
        {
            return Channel.BeginGetShipmentsByOrderNumber(userName, password, installationValue, actors, referenceNumber, callback, state);
        }

        public Response EndGetShipmentsByOrderNumber(IAsyncResult result)
        {
            return Channel.EndGetShipmentsByOrderNumber(result);
        }

        public IAsyncResult BeginGetShipmentStatus(string userName, string password, string number, AsyncCallback callback, object state)
        {
            return Channel.BeginGetShipmentStatus(userName, password, number, callback, state);
        }

        public EventResponse EndGetShipmentStatus(IAsyncResult result)
        {
            return Channel.EndGetShipmentStatus(result);
        }

        public IAsyncResult BeginVerifyCount(string userName, string password, DateTime eventDateTimeStart, DateTime eventDateTimeEnd, string[] eventCode, int[] actorId, AsyncCallback callback, object state)
        {
            return Channel.BeginVerifyCount(userName, password, eventDateTimeStart, eventDateTimeEnd, eventCode, actorId, callback, state);
        }

        public EventCountResponse EndVerifyCount(IAsyncResult result)
        {
            return Channel.EndVerifyCount(result);
        }

        protected class ShipmentExporterChannel : ChannelBase<IShipmentExporterAsync>, IShipmentExporterAsync
        {
            public ShipmentExporterChannel(ClientBase<IShipmentExporterAsync> client) : base(client) { }

            public IAsyncResult BeginGetEvents(string userName, string password, DateTime eventDateTimeStart, DateTime eventDateTimeEnd, AsyncCallback callback, object state)
            {
                var _args = new object[] { userName, password, eventDateTimeStart, eventDateTimeEnd };
                return base.BeginInvoke("GetEvents", _args, callback, state);
            }

            public EventResponse EndGetEvents(IAsyncResult result)
            {
                return ((EventResponse)(base.EndInvoke("GetEvents", new object[0], result)));
            }

            public IAsyncResult BeginGetEventsByEventCode(string userName, string password, DateTime eventDateTimeStart, DateTime eventDateTimeEnd, string[] eventCode, int[] actorId, AsyncCallback callback, object state)
            {
                var _args = new object[] { userName, password, eventDateTimeStart, eventDateTimeEnd, eventCode, actorId};
                return base.BeginInvoke("GetEventsByEventCode", _args, callback, state);
            }

            public EventResponseByEvent EndGetEventsByEventCode(IAsyncResult result)
            {
                return ((EventResponseByEvent)(base.EndInvoke("GetEventsByEventCode", new object[0], result)));
            }

            public IAsyncResult BeginGetShipmentByDateRange(string userName, string password, string installationValue, int[] actors, DateTime startDate, DateTime endDate, int pageIndex, AsyncCallback callback, object state)
            {
                var _args = new object[] { userName, password, installationValue, actors, startDate, endDate, pageIndex };
                return base.BeginInvoke("GetShipmentByDateRange", _args, callback, state);
            }

            public Response EndGetShipmentByDateRange(IAsyncResult result)
            {
                return ((Response)(base.EndInvoke("GetShipmentByDateRange", new object[0], result)));
            }

            public IAsyncResult BeginGetShipmentByOrderNumber(string userName, string password, string installationValue, int[] actors, string referenceNumber, AsyncCallback callback, object state)
            {
                var _args = new object[] { userName, password, installationValue, actors, referenceNumber };
                return base.BeginInvoke("GetShipmentByOrderNumber", _args, callback, state);
            }

            public Response EndGetShipmentByOrderNumber(IAsyncResult result)
            {
                return ((Response)(base.EndInvoke("GetShipmentByOrderNumber", new object[0], result)));
            }

            public IAsyncResult BeginGetShipmentByPackageNumber(string userName, string password, string installationValue, int[] actors, string packageNumber, AsyncCallback callback, object state)
            {
                var _args = new object[] { userName, password, installationValue, actors, packageNumber, };
                return base.BeginInvoke("GetShipmentByPackageNumber", _args, callback, state);
            }

            public Response EndGetShipmentByPackageNumber(IAsyncResult result)
            {
                return ((Response)(base.EndInvoke("GetShipmentByPackageNumber", new object[0], result)));
            }

            public IAsyncResult BeginGetShipmentByShipmentNumber(string userName, string password, string installationValue, int[] actors, string shipmentNumber, AsyncCallback callback, object state)
            {
                var _args = new object[] { userName, password, installationValue, actors, shipmentNumber};
                return base.BeginInvoke("GetShipmentByShipmentNumber", _args, callback, state);
            }

            public Response EndGetShipmentByShipmentNumber(IAsyncResult result)
            {
                return ((Response)(base.EndInvoke("GetShipmentByShipmentNumber", new object[0], result)));
            }

            public IAsyncResult BeginGetShipmentsByOrderNumber(string userName, string password, string installationValue, int[] actors, string referenceNumber, AsyncCallback callback, object state)
            {
                var _args = new object[] { userName, password, installationValue, actors, referenceNumber };
                return base.BeginInvoke("GetShipmentsByOrderNumber", _args, callback, state);
            }

            public Response EndGetShipmentsByOrderNumber(IAsyncResult result)
            {
                return ((Response)(base.EndInvoke("GetShipmentsByOrderNumber", new object[0], result)));
            }

            public IAsyncResult BeginGetShipmentStatus(string userName, string password, string number, AsyncCallback callback, object state)
            {
                var _args = new object[] { userName, password, number };
                return base.BeginInvoke("GetShipmentStatus", _args, callback, state);
            }

            public EventResponse EndGetShipmentStatus(IAsyncResult result)
            {
                return ((EventResponse)(base.EndInvoke("GetShipmentStatus", new object[0], result)));
            }

            public IAsyncResult BeginVerifyCount(string userName, string password, DateTime eventDateTimeStart, DateTime eventDateTimeEnd, string[] eventCode, int[] actorId, AsyncCallback callback, object state)
            {
                var _args = new object[] { userName, password, eventDateTimeStart, eventDateTimeEnd, eventCode, actorId};
                return base.BeginInvoke("VerifyCount", _args, callback, state);
            }

            public EventCountResponse EndVerifyCount(IAsyncResult result)
            {
                return ((EventCountResponse)(base.EndInvoke("VerifyCount", new object[0], result)));
            }
        }
    }
}

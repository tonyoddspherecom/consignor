using System;
using System.ServiceModel.Channels;
using Consignor.ShipmentExporter;
using System.ServiceModel;

namespace Consignor.Internal
{
    internal partial class ShipmentExporterAsync : ClientBase<IShipmentExporterAsync>, IShipmentExporterAsync
    {
        public ShipmentExporterAsync(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress) { }


        protected override IShipmentExporterAsync CreateChannel()
        {
            return new ShipmentExporterChannel(this);
        }


        public IAsyncResult BeginGetShipmentStatus(string userName, string password, string shipmentNumber, DateTime? startDateTime, DateTime? endDateTime, AsyncCallback callback, object asyncState)
        {
            return Channel.BeginGetShipmentStatus(userName, password, shipmentNumber, startDateTime, endDateTime, callback, asyncState);
        }

        public Event[] EndGetShipmentStatus(IAsyncResult result)
        {
            return Channel.EndGetShipmentStatus(result);
        }

        public IAsyncResult BeginGetShipmentsByShipmentNumber(string userName, string password, string installationValue, int[] actors, string shipmentNumber, DateTime? startDateTime, DateTime? endDateTime, AsyncCallback callback, object asyncState)
        {
            return Channel.BeginGetShipmentsByShipmentNumber(userName, password, installationValue, actors, shipmentNumber, startDateTime, endDateTime, callback, asyncState);
        }

        public Shipment[] EndGetShipmentsByShipmentNumber(IAsyncResult result)
        {
            return Channel.EndGetShipmentsByShipmentNumber(result);
        }

        public IAsyncResult BeginGetShipmentsByOrderNumber(string userName, string password, string installationValue, int[] actors, string referenceNumber, DateTime? startDateTime, DateTime? endDateTime, AsyncCallback callback, object asyncState)
        {
            return Channel.BeginGetShipmentsByOrderNumber(userName, password, installationValue, actors, referenceNumber, startDateTime, endDateTime, callback, asyncState);
        }

        public Shipment[] EndGetShipmentsByOrderNumber(IAsyncResult result)
        {
            return Channel.EndGetShipmentsByOrderNumber(result);
        }

        public IAsyncResult BeginGetShipmentsByPackageNumber(string userName, string password, string installationValue, int[] actors, string packageNumber, DateTime? startDateTime, DateTime? endDateTime, AsyncCallback callback, object asyncState)
        {
            return Channel.BeginGetShipmentsByPackageNumber(userName, password, installationValue, actors, packageNumber, startDateTime, endDateTime, callback, asyncState);
        }

        public Shipment[] EndGetShipmentsByPackageNumber(IAsyncResult result)
        {
            return Channel.EndGetShipmentsByPackageNumber(result);
        }

        public IAsyncResult BeginGetShipmentsByDateRange(string userName, string password, string installationValue, int[] actors, DateTime startDateTime, DateTime endDateTime, int pageIndex, AsyncCallback callback, object asyncState)
        {
            return Channel.BeginGetShipmentsByDateRange(userName, password, installationValue, actors, startDateTime, endDateTime, pageIndex, callback, asyncState);
        }

        public Shipment[] EndGetShipmentsByDateRange(IAsyncResult result)
        {
            return Channel.EndGetShipmentsByDateRange(result);
        }

        public IAsyncResult BeginGetEvents(string userName, string password, DateTime eventDateTimeStart, DateTime eventDateTimeEnd, AsyncCallback callback, object asyncState)
        {
            return Channel.BeginGetEvents(userName, password, eventDateTimeStart, eventDateTimeEnd, callback, asyncState);
        }

        public Event[] EndGetEvents(IAsyncResult result)
        {
            return Channel.EndGetEvents(result);
        }

        public IAsyncResult BeginGetCarrierEventsByEventCode(string userName, string password, DateTime eventDateTimeStart, DateTime eventDateTimeEnd, string[] eventCodes, string installationValue, int[] actors, AsyncCallback callback, object asyncState)
        {
            return Channel.BeginGetCarrierEventsByEventCode(userName, password, eventDateTimeStart, eventDateTimeEnd, eventCodes, installationValue, actors, callback, asyncState);
        }

        public Event[] EndGetCarrierEventsByEventCode(IAsyncResult result)
        {
            return Channel.EndGetCarrierEventsByEventCode(result);
        }

        public IAsyncResult BeginSendEvent(string userName, string password, ImportEvent submitEvent, AsyncCallback callback, object asyncState)
        {
            return Channel.BeginSendEvent(userName, password, submitEvent, callback, asyncState);
        }

        public bool EndSendEvent(IAsyncResult result)
        {
            return Channel.EndSendEvent(result);
        }

        public IAsyncResult BeginIsShipmentClosed(string userName, string password, string barcode, AsyncCallback callback, object asyncState)
        {
            return Channel.BeginIsShipmentClosed(userName, password, barcode, callback, asyncState);
        }

        public StatusInfo[] EndIsShipmentClosed(IAsyncResult result)
        {
            return Channel.EndIsShipmentClosed(result);
        }

        public IAsyncResult BeginCheckHealth(AsyncCallback callback, object asyncState)
        {
            return Channel.BeginCheckHealth(callback, asyncState);
        }

        public HealthResponse EndCheckHealth(IAsyncResult result)
        {
            return Channel.EndCheckHealth(result);
        }

        protected class ShipmentExporterChannel : ChannelBase<IShipmentExporterAsync>, IShipmentExporterAsync
        {
            public ShipmentExporterChannel(ClientBase<IShipmentExporterAsync> client) : base(client) { }

            public IAsyncResult BeginCheckHealth(AsyncCallback callback, object asyncState)
            {
                var _args = new object[] { };
                return base.BeginInvoke("CheckHealth", _args, callback, asyncState);
            }

            public IAsyncResult BeginGetCarrierEventsByEventCode(string userName, string password, DateTime eventDateTimeStart, DateTime eventDateTimeEnd, string[] eventCodes, string installationValue, int[] actors, AsyncCallback callback, object asyncState)
            {
                var _args = new object[] { userName, password, eventDateTimeStart, eventDateTimeEnd, eventCodes, installationValue, actors };
                return base.BeginInvoke("GetCarrierEventsByEventCode", _args, callback, asyncState);
            }

            public IAsyncResult BeginGetEvents(string userName, string password, DateTime eventDateTimeStart, DateTime eventDateTimeEnd, AsyncCallback callback, object asyncState)
            {
                var _args = new object[] { userName, password, eventDateTimeStart, eventDateTimeEnd};
                return base.BeginInvoke("GetEvents", _args, callback, asyncState);
            }

            public IAsyncResult BeginGetShipmentsByDateRange(string userName, string password, string installationValue, int[] actors, DateTime startDateTime, DateTime endDateTime, int pageIndex, AsyncCallback callback, object asyncState)
            {
                var _args = new object[] { userName, password, installationValue, actors, startDateTime, endDateTime, pageIndex };
                return base.BeginInvoke("GetShipmentsByDateRange", _args, callback, asyncState);
            }

            public IAsyncResult BeginGetShipmentsByOrderNumber(string userName, string password, string installationValue, int[] actors, string referenceNumber, DateTime? startDateTime, DateTime? endDateTime, AsyncCallback callback, object asyncState)
            {
                var _args = new object[] { userName, password, installationValue, actors, referenceNumber, startDateTime, endDateTime };
                return base.BeginInvoke("GetShipmentsByOrderNumber", _args, callback, asyncState);
            }

            public IAsyncResult BeginGetShipmentsByPackageNumber(string userName, string password, string installationValue, int[] actors, string packageNumber, DateTime? startDateTime, DateTime? endDateTime, AsyncCallback callback, object asyncState)
            {
                var _args = new object[] { userName, password, installationValue, actors, packageNumber, startDateTime, endDateTime };
                return base.BeginInvoke("GetShipmentsByPackageNumber", _args, callback, asyncState);
            }

            public IAsyncResult BeginGetShipmentsByShipmentNumber(string userName, string password, string installationValue, int[] actors, string shipmentNumber, DateTime? startDateTime, DateTime? endDateTime, AsyncCallback callback, object asyncState)
            {
                var _args = new object[] { userName, password, installationValue, actors, shipmentNumber, startDateTime, endDateTime };
                return base.BeginInvoke("GetShipmentsByShipmentNumber", _args, callback, asyncState);
            }

            public IAsyncResult BeginGetShipmentStatus(string userName, string password, string shipmentNumber, DateTime? startDateTime, DateTime? endDateTime, AsyncCallback callback, object asyncState)
            {
                var _args = new object[] { userName, password, shipmentNumber, startDateTime, endDateTime };
                return base.BeginInvoke("GetShipmentStatus", _args, callback, asyncState);
            }

            public IAsyncResult BeginIsShipmentClosed(string userName, string password, string barcode, AsyncCallback callback, object asyncState)
            {
                var _args = new object[] { userName, password, barcode };
                return base.BeginInvoke("IsShipmentClosed", _args, callback, asyncState);
            }

            public IAsyncResult BeginSendEvent(string userName, string password, ImportEvent submitEvent, AsyncCallback callback, object asyncState)
            {
                var _args = new object[] { userName, password, submitEvent };
                return base.BeginInvoke("SendEvent", _args, callback, asyncState);
            }

            public HealthResponse EndCheckHealth(IAsyncResult result)
            {
                return (HealthResponse)(base.EndInvoke("CheckHealth", new object[0], result));
            }

            public Event[] EndGetCarrierEventsByEventCode(IAsyncResult result)
            {
                return (Event[])(base.EndInvoke("GetCarrierEventsByEventCode", new object[0], result));
            }

            public Event[] EndGetEvents(IAsyncResult result)
            {
                return (Event[])(base.EndInvoke("GetEvents", new object[0], result));
            }

            public Shipment[] EndGetShipmentsByDateRange(IAsyncResult result)
            {
                return (Shipment[])(base.EndInvoke("GetShipmentsByDateRange", new object[0], result));
            }

            public Shipment[] EndGetShipmentsByOrderNumber(IAsyncResult result)
            {
                return (Shipment[])(base.EndInvoke("GetShipmentsByOrderNumber", new object[0], result));
            }

            public Shipment[] EndGetShipmentsByPackageNumber(IAsyncResult result)
            {
                return (Shipment[])(base.EndInvoke("GetShipmentsByPackageNumber", new object[0], result));
            }

            public Shipment[] EndGetShipmentsByShipmentNumber(IAsyncResult result)
            {
                return (Shipment[])(base.EndInvoke("GetShipmentsByShipmentNumber", new object[0], result));
            }

            public Event[] EndGetShipmentStatus(IAsyncResult result)
            {
                return (Event[])(base.EndInvoke("GetShipmentStatus", new object[0], result));
            }

            public StatusInfo[] EndIsShipmentClosed(IAsyncResult result)
            {
                return (StatusInfo[])(base.EndInvoke("IsShipmentClosed", new object[0], result));
            }

            public bool EndSendEvent(IAsyncResult result)
            {
                return (bool)(base.EndInvoke("SendEvent", new object[0], result));
            }
        }
    }
}

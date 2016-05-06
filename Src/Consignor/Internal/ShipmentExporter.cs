using System;
using System.Threading.Tasks;
using Consignor.ShipmentExporter;
using System.ServiceModel;

namespace Consignor.Internal
{
    internal class ShipmentExporter : IShipmentExporter
    {
        private readonly ShipmentExporterAsync client;
        private readonly string username;
        private readonly string password;

        public ShipmentExporter(string url, string username, string password)
        {
            this.username = username;
            this.password = password;
            var binding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);
            var endpoint = new EndpointAddress(new Uri(url, UriKind.Absolute));
            client = new ShipmentExporterAsync(binding, endpoint);
        }

        public Task<Event[]> GetShipmentStatus(string shipmentNumber, DateTime? startDateTime = null, DateTime? endDateTime = null)
        {
            return Task.Factory.FromAsync(client.BeginGetShipmentStatus(username, password, shipmentNumber, startDateTime, endDateTime, null, null), 
                ar => client.EndGetShipmentStatus(ar));
        }

        public Task<Shipment[]> GetShipmentsByShipmentNumber(string installationValue, int[] actors, string shipmentNumber, DateTime? startDateTime = null, DateTime? endDateTime = null)
        {
            return Task.Factory.FromAsync(client.BeginGetShipmentsByShipmentNumber(username, password, installationValue, actors, shipmentNumber, startDateTime, endDateTime, null, null),
                ar => client.EndGetShipmentsByShipmentNumber(ar));
        }

        public Task<Shipment[]> GetShipmentsByOrderNumber(string installationValue, int[] actors, string referenceNumber, DateTime? startDateTime = null, DateTime? endDateTime = null)
        {
            return Task.Factory.FromAsync(client.BeginGetShipmentsByOrderNumber(username, password, installationValue, actors, referenceNumber, startDateTime, endDateTime, null, null),
                ar => client.EndGetShipmentsByOrderNumber(ar));
        }

        public Task<Shipment[]> GetShipmentsByPackageNumber(string installationValue, int[] actors, string packageNumber, DateTime? startDateTime = default(DateTime?), DateTime? endDateTime = default(DateTime?))
        {
            return Task.Factory.FromAsync(client.BeginGetShipmentsByPackageNumber(username, password, installationValue, actors, packageNumber, startDateTime, endDateTime, null, null),
                ar => client.EndGetShipmentsByPackageNumber(ar));
        }

        public Task<Shipment[]> GetShipmentsByDateRange(string installationValue, int[] actors, DateTime startDateTime, DateTime endDateTime, int pageIndex)
        {
            return Task.Factory.FromAsync(client.BeginGetShipmentsByDateRange(username, password, installationValue, actors, startDateTime, endDateTime, pageIndex, null, null),
                ar => client.EndGetShipmentsByDateRange(ar));
        }

        public Task<Event[]> GetEvents(DateTime eventDateTimeStart, DateTime eventDateTimeEnd)
        {
            return Task.Factory.FromAsync(client.BeginGetEvents(username, password, eventDateTimeStart, eventDateTimeEnd, null, null),
                ar => client.EndGetEvents(ar));
        }

        public Task<Event[]> GetCarrierEventsByEventCode(DateTime eventDateTimeStart, DateTime eventDateTimeEnd, string[] eventCodes, string installationValue, int[] actors)
        {
            return Task.Factory.FromAsync(client.BeginGetCarrierEventsByEventCode(username, password, eventDateTimeStart, eventDateTimeEnd, eventCodes, installationValue, actors, null, null),
                ar => client.EndGetCarrierEventsByEventCode(ar));
        }

        public Task<bool> SendEvent(ImportEvent submitEvent)
        {
            return Task.Factory.FromAsync(client.BeginSendEvent(username, password, submitEvent, null, null),
                ar => client.EndSendEvent(ar));
        }

        public Task<StatusInfo[]> IsShipmentClosed(string barcode)
        {
            return Task.Factory.FromAsync(client.BeginIsShipmentClosed(username, password, barcode, null, null),
                ar => client.EndIsShipmentClosed(ar));
        }

        public Task<HealthResponse> CheckHealth()
        {
            return Task.Factory.FromAsync(client.BeginCheckHealth(null, null),
                ar => client.EndCheckHealth(ar));
        }
    }
}

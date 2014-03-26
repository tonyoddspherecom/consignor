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
            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress(new Uri(url, UriKind.Absolute));
            client = new ShipmentExporterAsync(binding, endpoint);
        }

        public Task<Response> GetShipmentByShipmentNumberAsync(string installationValue, int[] actors, string shipmentNumber)
        {
            return Task.Factory.FromAsync(client.BeginGetShipmentByShipmentNumber(username, password, installationValue, actors, shipmentNumber, null, null), ar => client.EndGetShipmentByShipmentNumber(ar));
        }

        public Task<Response> GetShipmentByOrderNumberAsync(string installationValue, int[] actors, string referenceNumber)
        {
            return Task.Factory.FromAsync(client.BeginGetShipmentByOrderNumber(username, password, installationValue, actors, referenceNumber, null, null), ar => client.EndGetShipmentByOrderNumber(ar));
        }

        public Task<Response> GetShipmentsByOrderNumberAsync(string installationValue, int[] actors, string referenceNumber)
        {
            return Task.Factory.FromAsync(client.BeginGetShipmentsByOrderNumber(username, password, installationValue, actors, referenceNumber, null, null), ar => client.EndGetShipmentsByOrderNumber(ar));
        }

        public Task<Response> GetShipmentByPackageNumberAsync(string installationValue, int[] actors, string packageNumber)
        {
            return Task.Factory.FromAsync(client.BeginGetShipmentByPackageNumber(username, password, installationValue, actors, packageNumber, null, null), ar => client.EndGetShipmentByPackageNumber(ar));
        }

        public Task<Response> GetShipmentByDateRangeAsync(string installationValue, int[] actors, DateTime startDate, DateTime endDate, int pageIndex)
        {
            return Task.Factory.FromAsync(client.BeginGetShipmentByDateRange(username, password, installationValue, actors, startDate, endDate, pageIndex, null, null), ar => client.EndGetShipmentByDateRange(ar));
        }

        public Task<EventResponse> GetEventsAsync(DateTime eventDateTimeStart, DateTime eventDateTimeEnd)
        {
            return Task.Factory.FromAsync(client.BeginGetEvents(username, password, eventDateTimeStart, eventDateTimeEnd, null, null), ar => client.EndGetEvents(ar));
        }

        public Task<EventResponseByEvent> GetEventsByEventCodeAsync(DateTime eventDateTimeStart, DateTime eventDateTimeEnd, string[] eventCode, int[] actorId)
        {
            return Task.Factory.FromAsync(client.BeginGetEventsByEventCode(username, password, eventDateTimeStart, eventDateTimeEnd, eventCode, actorId, null, null), ar => client.EndGetEventsByEventCode(ar));
        }

        public Task<EventCountResponse> VerifyCountAsync(DateTime eventDateTimeStart, DateTime eventDateTimeEnd, string[] eventCode, int[] actorId)
        {
            return Task.Factory.FromAsync(client.BeginVerifyCount(username, password, eventDateTimeStart, eventDateTimeEnd, eventCode, actorId, null, null), ar => client.EndVerifyCount(ar));
        }

        public Task<EventResponse> GetShipmentStatusAsync(string number)
        {
            return Task.Factory.FromAsync(client.BeginGetShipmentStatus(username, password, number, null, null), ar => client.EndGetShipmentStatus(ar));
        }
    }
}

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
        public Task<Event[]> GetEventsAsync(DateTime eventDateTimeStart, DateTime eventDateTimeEnd)
        {
            return Task<Event[]>.Factory.FromAsync(client.BeginGetEvents(username, password, eventDateTimeStart, eventDateTimeEnd, null, null), ar => client.EndGetEvents(ar));
        }

        public Task<Shipment[]> GetShipmentsByShipmentNumberAsync(string installationValue, int[] actors, string shipmentNumber, DateTime? startDateTime, DateTime? endDateTime)
        {
            return Task<Shipment[]>.Factory.FromAsync(client.BeginGetShipmentsByShipmentNumber(username,password, installationValue,actors,shipmentNumber,startDateTime,endDateTime, null, null), ar => client.EndGetShipmentsByShipmentNumber(ar));
        }
        /*
        

        public Task<GetShipmentsByOrderNumberResponse> GetShipmentsByOrderNumberAsync(GetShipmentsByOrderNumberRequest request)
        {
            return Task<GetShipmentsByOrderNumberResponse>.Factory.FromAsync(client.BeginGetShipmentsByOrderNumber(request, null, null), ar => client.EndGetShipmentsByOrderNumber(ar));
        }

        public Task<GetShipmentsByPackageNumberResponse> GetShipmentsByPackageNumberAsync(GetShipmentsByPackageNumberRequest request)
        {
            return Task<GetShipmentsByPackageNumberResponse>.Factory.FromAsync(client.BeginGetShipmentsByPackageNumber(request, null, null), ar => client.EndGetShipmentsByPackageNumber(ar));
        }

        public Task<GetShipmentsByDateRangeResponse> GetShipmentsByDateRangeAsync(GetShipmentsByDateRangeRequest request)
        {
            return Task<GetShipmentsByDateRangeResponse>.Factory.FromAsync(client.BeginGetShipmentsByDateRange(request, null, null), ar => client.EndGetShipmentsByDateRange(ar));
        }

        

        public Task<GetCarrierEventsByEventCodeResponse> GetCarrierEventsByEventCodeAsync(GetCarrierEventsByEventCodeRequest request)
        {
            return Task<GetCarrierEventsByEventCodeResponse>.Factory.FromAsync(client.BeginGetCarrierEventsByEventCode(request, null, null), ar => client.EndGetCarrierEventsByEventCode(ar));
        }


        public Task<GetShipmentStatusResponse> GetShipmentStatusAsync(GetShipmentStatusRequest request)
        {
            return Task<GetShipmentStatusResponse>.Factory.FromAsync(client.BeginGetShipmentStatus(request, null, null), ar => client.EndGetShipmentStatus(ar));
        }

        public Task<SendEventResponse> SendEventAsync(SendEventRequest request)
        {
            return Task<SendEventResponse>.Factory.FromAsync(client.BeginSendEvent(request, null, null), ar => client.EndSendEvent(ar));
        }

        public Task<IsShipmentClosedResponse> IsShipmentClosedAsync(IsShipmentClosedRequest request)
        {
            return Task<IsShipmentClosedResponse>.Factory.FromAsync(client.BeginIsShipmentClosed(request, null, null), ar => client.EndIsShipmentClosed(ar));
        }

        public Task<CheckHealthResponse> CheckHealthAsync(CheckHealthRequest request)
        {
            return Task<CheckHealthResponse>.Factory.FromAsync(client.BeginCheckHealth(request, null, null), ar => client.EndCheckHealth(ar));
        }
        */
    }
}

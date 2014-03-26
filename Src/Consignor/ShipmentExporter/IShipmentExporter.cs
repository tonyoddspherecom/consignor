using System;
using System.Threading.Tasks;
namespace Consignor.ShipmentExporter
{ 
    public interface IShipmentExporter
    {
        Task<Response> GetShipmentByShipmentNumberAsync(string installationValue, int[] actors, string shipmentNumber);
        Task<Response> GetShipmentByOrderNumberAsync(string installationValue, int[] actors, string referenceNumber);
        Task<Response> GetShipmentsByOrderNumberAsync(string installationValue, int[] actors, string referenceNumber);
        Task<Response> GetShipmentByPackageNumberAsync(string installationValue, int[] actors, string packageNumber);
        Task<Response> GetShipmentByDateRangeAsync(string installationValue, int[] actors, DateTime startDate, DateTime endDate, int pageIndex);
        Task<EventResponse> GetEventsAsync(DateTime eventDateTimeStart, DateTime eventDateTimeEnd);
        Task<EventResponseByEvent> GetEventsByEventCodeAsync(DateTime eventDateTimeStart, DateTime eventDateTimeEnd, string[] eventCode, int[] actorId);
        Task<EventCountResponse> VerifyCountAsync(DateTime eventDateTimeStart, DateTime eventDateTimeEnd, string[] eventCode, int[] actorId);
        Task<EventResponse> GetShipmentStatusAsync(string number);
    }
}
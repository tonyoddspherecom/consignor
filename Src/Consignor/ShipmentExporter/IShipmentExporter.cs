using System;
using System.Threading.Tasks;
namespace Consignor.ShipmentExporter
{
    public interface IShipmentExporter
    {
        Task<Shipment[]> GetShipmentsByShipmentNumber(string installationValue, int[] actors, string shipmentNumber, DateTime? startDateTime = null, DateTime? endDateTime = null);
        Task<Shipment[]> GetShipmentsByOrderNumber(string installationValue, int[] actors, string referenceNumber, DateTime? startDateTime = null, DateTime? endDateTime = null);
        Task<Shipment[]> GetShipmentsByPackageNumber(string installationValue, int[] actors, string packageNumber, DateTime? startDateTime = null, DateTime? endDateTime = null);
        Task<Shipment[]> GetShipmentsByDateRange(string installationValue, int[] actors, DateTime startDateTime, DateTime endDateTime, int pageIndex);
        Task<Event[]> GetEvents(DateTime eventDateTimeStart, DateTime eventDateTimeEnd);
        Task<Event[]> GetCarrierEventsByEventCode(DateTime eventDateTimeStart, DateTime eventDateTimeEnd, string[] eventCodes, string installationValue, int[] actors);
        Task<Event[]> GetShipmentStatus(string shipmentNumber, DateTime? startDateTime = null, DateTime? endDateTime = null);
        Task<bool> SendEvent(ImportEvent submitEvent);
        Task<StatusInfo[]> IsShipmentClosed(string barcode);
        Task<HealthResponse> CheckHealth();
    }
}
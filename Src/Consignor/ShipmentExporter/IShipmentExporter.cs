using System;
using System.Threading.Tasks;

namespace Consignor.ShipmentExporter
{ 
    public interface IShipmentExporter
    {
        Task<Event[]> GetEventsAsync(DateTime eventDateTimeStart, DateTime eventDateTimeEnd);

        Task<Shipment[]> GetShipmentsByShipmentNumberAsync(string installationValue, int[] actors, string shipmentNumber, DateTime? startDateTime, DateTime? endDateTime);
        //Task<Shipment[]> GetShipmentsByOrderNumberAsync(string installationValue, int[] actors, string referenceNumber, DateTime? startDateTime, DateTime? endDateTime);
        /*
        
        Task<Shipment[]> GetShipmentsByPackageNumberAsync(string installationValue, int[] actors, string packageNumber, DateTime? startDateTime, DateTime? endDateTime);
        Task<Shipment[]> GetShipmentsByDateRangeAsync(string installationValue, int[] actors, DateTime? startDateTime, DateTime? endDateTime);
        
        Task<Event[]> GetCarrierEventsByEventCodeAsync(System.DateTime eventDateTimeStart, System.DateTime eventDateTimeEnd, string[] eventCodes, string installationValue, int[] actors);
        Task<Event[]> GetShipmentStatusAsync(string shipmentNumber, DateTime? startDateTime, DateTime? endDateTime);
        Task<bool> SendEventAsync(ImportEvent submitEvent);
        Task<StatusInfo[]> IsShipmentClosedAsync(string barcode);
        Task<HealthResponse> CheckHealthAsync();
        */
    }
}

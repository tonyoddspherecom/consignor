using Consignor.ShipmentExporter;
using System;
using System.ServiceModel;
namespace Consignor.Internal
{
    [ServiceContract(Namespace = "http://edisoftwebservices.com/")]
    internal interface IShipmentExporterAsync
    {
        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/IPortalData/GetShipmentsByShipmentNumber", ReplyAction = "http://edisoftwebservices.com/IPortalData/GetShipmentsByShipmentNumberResponse")]
        IAsyncResult BeginGetShipmentsByShipmentNumber(string userName, string password, string installationValue, int[] actors, string shipmentNumber, DateTime? startDateTime, DateTime? endDateTime, AsyncCallback callback, object asyncState);
        Shipment[] EndGetShipmentsByShipmentNumber(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/IPortalData/GetShipmentsByOrderNumber", ReplyAction = "http://edisoftwebservices.com/IPortalData/GetShipmentsByOrderNumberResponse")]
        IAsyncResult BeginGetShipmentsByOrderNumber(string userName, string password, string installationValue, int[] actors, string referenceNumber, DateTime? startDateTime, DateTime? endDateTime, AsyncCallback callback, object asyncState);
        Shipment[] EndGetShipmentsByOrderNumber(IAsyncResult result);
        
        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/IPortalData/GetShipmentsByPackageNumber", ReplyAction = "http://edisoftwebservices.com/IPortalData/GetShipmentsByPackageNumberResponse")]
        IAsyncResult BeginGetShipmentsByPackageNumber(string userName, string password, string installationValue, int[] actors, string packageNumber, DateTime? startDateTime, DateTime? endDateTime, AsyncCallback callback, object asyncState);
        Shipment[] EndGetShipmentsByPackageNumber(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/IPortalData/GetShipmentsByDateRange", ReplyAction = "http://edisoftwebservices.com/IPortalData/GetShipmentsByDateRangeResponse")]
        IAsyncResult BeginGetShipmentsByDateRange(string userName, string password, string installationValue, int[] actors, DateTime startDateTime, DateTime endDateTime, int pageIndex, AsyncCallback callback, object asyncState);
        Shipment[] EndGetShipmentsByDateRange(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/IPortalData/GetEvents", ReplyAction = "http://edisoftwebservices.com/IPortalData/GetEventsResponse")]
        IAsyncResult BeginGetEvents(string userName, string password, DateTime eventDateTimeStart, DateTime eventDateTimeEnd, AsyncCallback callback, object asyncState);
        Event[] EndGetEvents(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/IPortalData/GetCarrierEventsByEventCode", ReplyAction = "http://edisoftwebservices.com/IPortalData/GetCarrierEventsByEventCodeResponse")]
        IAsyncResult BeginGetCarrierEventsByEventCode(string userName, string password, DateTime eventDateTimeStart, DateTime eventDateTimeEnd, string[] eventCodes, string installationValue, int[] actors, AsyncCallback callback, object asyncState);
        Event[] EndGetCarrierEventsByEventCode(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/IPortalData/GetShipmentStatus", ReplyAction = "http://edisoftwebservices.com/IPortalData/GetShipmentStatusResponse")]
        IAsyncResult BeginGetShipmentStatus(string userName, string password, string shipmentNumber, DateTime? startDateTime, DateTime? endDateTime, AsyncCallback callback, object asyncState);
        Event[] EndGetShipmentStatus(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/IPortalData/SendEvent", ReplyAction = "http://edisoftwebservices.com/IPortalData/SendEventResponse")]
        IAsyncResult BeginSendEvent(string userName, string password, ImportEvent submitEvent, AsyncCallback callback, object asyncState);
        bool EndSendEvent(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/IPortalData/IsShipmentClosed", ReplyAction = "http://edisoftwebservices.com/IPortalData/IsShipmentClosedResponse")]
        IAsyncResult BeginIsShipmentClosed(string userName, string password, string barcode, AsyncCallback callback, object asyncState);
        StatusInfo[] EndIsShipmentClosed(IAsyncResult result);
        
        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/IPortalData/CheckHealth", ReplyAction = "http://edisoftwebservices.com/IPortalData/CheckHealthResponse")]
        IAsyncResult BeginCheckHealth(AsyncCallback callback, object asyncState);
        HealthResponse EndCheckHealth(IAsyncResult result);
    }
}



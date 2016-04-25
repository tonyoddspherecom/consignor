using Consignor.ShipmentExporter;
using System;
using System.ServiceModel;
namespace Consignor.Internal
{
    [ServiceContractAttribute(Namespace="http://edisoftwebservices.com/")]
    [XmlSerializerFormat]
    internal interface IShipmentExporterAsync
    {
        /*
        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/IPortalData/GetCarrierEventsByEventCode")]
        //[ServiceKnownType(typeof(GenericEntityDto))]
        IAsyncResult BeginGetCarrierEventsByEventCode(GetCarrierEventsByEventCodeRequest request, AsyncCallback callback, object state);
        GetCarrierEventsByEventCodeResponse EndGetCarrierEventsByEventCode(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/IPortalData/GetShipmentStatus")]
        //[ServiceKnownType(typeof(GenericEntityDto))]
        IAsyncResult BeginGetShipmentStatus(GetShipmentStatusRequest request, AsyncCallback callback, object state);
        GetShipmentStatusResponse EndGetShipmentStatus(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/IPortalData/SendEvent")]
        //[ServiceKnownType(typeof(GenericEntityDto))]
        IAsyncResult BeginSendEvent(SendEventRequest request, AsyncCallback callback, object state);
        SendEventResponse EndSendEvent(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/IPortalData/IsShipmentClosed")]
        //[ServiceKnownType(typeof(GenericEntityDto))]
        IAsyncResult BeginIsShipmentClosed(IsShipmentClosedRequest request, AsyncCallback callback, object state);
        IsShipmentClosedResponse EndIsShipmentClosed(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/IPortalData/CheckHealth")]
        //[ServiceKnownType(typeof(GenericEntityDto))]
        IAsyncResult BeginCheckHealth(CheckHealthRequest request, AsyncCallback callback, object state);
        CheckHealthResponse EndCheckHealth(IAsyncResult result);

        

        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/IPortalData/GetShipmentsByOrderNumber")]
        //[ServiceKnownType(typeof(GenericEntityDto))]
        IAsyncResult BeginGetShipmentsByOrderNumber(GetShipmentsByOrderNumberRequest request, AsyncCallback callback, object state);
        GetShipmentsByOrderNumberResponse EndGetShipmentsByOrderNumber(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/IPortalData/GetShipmentsByPackageNumber")]
        //[ServiceKnownType(typeof(GenericEntityDto))]
        IAsyncResult BeginGetShipmentsByPackageNumber(GetShipmentsByPackageNumberRequest request, AsyncCallback callback, object state);
        GetShipmentsByPackageNumberResponse EndGetShipmentsByPackageNumber(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/IPortalData/GetShipmentsByDateRange")]
        //[ServiceKnownType(typeof(GenericEntityDto))]
        IAsyncResult BeginGetShipmentsByDateRange(GetShipmentsByDateRangeRequest request, AsyncCallback callback, object state);
        GetShipmentsByDateRangeResponse EndGetShipmentsByDateRange(IAsyncResult result);
        */
        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/IPortalData/GetEvents", ReplyAction = "http://edisoftwebservices.com/IPortalData/GetEventsResponse")]
        IAsyncResult BeginGetEvents(string userName, string password, DateTime eventDateTimeStart, DateTime eventDateTimeEnd, AsyncCallback callback, object state);
        Event[] EndGetEvents(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/IPortalData/GetShipmentsByShipmentNumber", ReplyAction = "http://edisoftwebservices.com/IPortalData/GetShipmentsByShipmentNumberResponse")]
        //[ServiceKnownType(typeof(GenericEntityDto))]
        IAsyncResult BeginGetShipmentsByShipmentNumber(string userName, string password, string installationValue, int[] actors, string shipmentNumber, DateTime? startDateTime, DateTime? endDateTime, AsyncCallback callback, object state);
        Shipment[] EndGetShipmentsByShipmentNumber(IAsyncResult result);



    }
}

using Consignor.ShipmentExporter;
using System;
using System.ServiceModel;
namespace Consignor.Internal
{
    [ServiceContractAttribute(Namespace="http://edisoftwebservices.com/")]
    [XmlSerializerFormat]
    internal interface IShipmentExporterAsync
    {
        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/GetEvents")]
        [ServiceKnownType(typeof(GenericEntityDto))]
        IAsyncResult BeginGetEvents(string userName, string password, DateTime eventDateTimeStart, DateTime eventDateTimeEnd, AsyncCallback callback, object state);
        EventResponse EndGetEvents(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/GetEventsByEventCode")]
        [ServiceKnownType(typeof(GenericEntityDto))]
        IAsyncResult BeginGetEventsByEventCode(string userName, string password, DateTime eventDateTimeStart, DateTime eventDateTimeEnd, string[] eventCode, int[] actorId, AsyncCallback callback, object state);
        EventResponseByEvent EndGetEventsByEventCode(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/GetShipmentByDateRange")]
        [ServiceKnownType(typeof(GenericEntityDto))]
        IAsyncResult BeginGetShipmentByDateRange(string userName, string password, string installationValue, int[] actors, DateTime startDate, DateTime endDate, int pageIndex, AsyncCallback callback, object state);
        Response EndGetShipmentByDateRange(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/GetShipmentByOrderNumber")]
        [ServiceKnownType(typeof(GenericEntityDto))]
        IAsyncResult BeginGetShipmentByOrderNumber(string userName, string password, string installationValue, int[] actors, string referenceNumber, AsyncCallback callback, object state);
        Response EndGetShipmentByOrderNumber(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/GetShipmentByPackageNumber")]
        [ServiceKnownType(typeof(GenericEntityDto))]
        IAsyncResult BeginGetShipmentByPackageNumber(string userName, string password, string installationValue, int[] actors, string packageNumber, AsyncCallback callback, object state);
        Response EndGetShipmentByPackageNumber(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/GetShipmentByShipmentNumber")]
        [ServiceKnownType(typeof(GenericEntityDto))]
        IAsyncResult BeginGetShipmentByShipmentNumber(string userName, string password, string installationValue, int[] actors, string shipmentNumber, AsyncCallback callback, object state);
        Response EndGetShipmentByShipmentNumber(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/GetShipmentsByOrderNumber")]
        [ServiceKnownType(typeof(GenericEntityDto))]
        IAsyncResult BeginGetShipmentsByOrderNumber(string userName, string password, string installationValue, int[] actors, string referenceNumber, AsyncCallback callback, object state);
        Response EndGetShipmentsByOrderNumber(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/GetShipmentStatus")]
        [ServiceKnownType(typeof(GenericEntityDto))]
        IAsyncResult BeginGetShipmentStatus(string userName, string password, string number, AsyncCallback callback, object state);
        EventResponse EndGetShipmentStatus(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://edisoftwebservices.com/VerifyCount")]
        [ServiceKnownType(typeof(GenericEntityDto))]
        IAsyncResult BeginVerifyCount(string userName, string password, DateTime eventDateTimeStart, DateTime eventDateTimeEnd, string[] eventCode, int[] actorId, AsyncCallback callback, object state);
        EventCountResponse EndVerifyCount(IAsyncResult result);
    }
}

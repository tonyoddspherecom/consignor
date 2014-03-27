using System.Collections.Generic;
using System.Threading.Tasks;

namespace Consignor.ShipmentServer
{
    public interface IShipmentServer
    {
        Task<Consignor.ShipmentServer.IShipmentServerResponse<CarrierCollection>> GetProductsAsync();

        Task<Consignor.ShipmentServer.IShipmentServerResponse<CarrierCollection>> GetStacksAsync();

        Task<Consignor.ShipmentServer.IShipmentServerResponse<int?>> GetInboxCountAsync();

        Task<Consignor.ShipmentServer.IShipmentServerResponse<int?>> CreateStackAsync(int subcarrierConceptID, string stackName);

        Task<Consignor.ShipmentServer.IShipmentServerResponse> DeleteContactAsync(int contactCSID);

        Task<Consignor.ShipmentServer.IShipmentServerResponse> DeleteContactListAsync(int contactListCSID);

        Task<Consignor.ShipmentServer.IShipmentServerResponse> DeleteShipmentAsync(int shpCSID);

        Task<Consignor.ShipmentServer.IShipmentServerResponse<int?>> GetBatchCountAsync();

        Task<Consignor.ShipmentServer.IShipmentServerResponse<Batch>> GetBatchDetailsAsync(int batchCSID);

        Task<Consignor.ShipmentServer.IShipmentServerResponse<BatchCollection>> GetBatchListAsync(int startIndex = 0, int count = 90, string sortField = "BatchCSID", int sortDirection = 0);

        Task<Consignor.ShipmentServer.IShipmentServerResponse<byte[]>> GetBatchReportAsync(int batchReportCSID);

        Task<Consignor.ShipmentServer.IShipmentServerResponse<ShipmentCollection>> GetBatchShipmentsAsync(int batchCSID);

        Task<Consignor.ShipmentServer.IShipmentServerResponse<int?>> GetContactCountAsync(int contactListCSID);

        Task<Consignor.ShipmentServer.IShipmentServerResponse<ContactListCollection>> GetContactListsAsync();

        Task<Consignor.ShipmentServer.IShipmentServerResponse<ContactList>> GetContactListDetailsAsync(int contactListCSID);

        Task<Consignor.ShipmentServer.IShipmentServerResponse<ContactCollection>> GetContactsAsync(int contactListCSID, int startIndex = 0, int count = 90, string sortField = "ContactNo", int sortDirection = 0);

        Task<Consignor.ShipmentServer.IShipmentServerResponse<ContactCollection>> GetContactProfileAsync(int contactNo, int addressCSID);

        Task<Consignor.ShipmentServer.IShipmentServerResponse<Shipment>> GetDefaultShipmentAsync(int prodConceptID);

        Task<Consignor.ShipmentServer.IShipmentServerResponse<DocumentCollection>> GetDocumentListAsync(int ShpCSID);

        Task<Consignor.ShipmentServer.IShipmentServerResponse<int?>> GetDocumentCountAsync(int ShpCSID);

        Task<Consignor.ShipmentServer.IShipmentServerResponse<DocumentCollection>> GetDocumentAsync(int ShpCSID);

        Task<Consignor.ShipmentServer.IShipmentServerResponse<ShipmentCollection>> GetInboxShipmentsAsync(int startIndex = 0, int count = 90, string sortField = "ShpCSID", int sortDirection = 0);

        Task<Consignor.ShipmentServer.IShipmentServerResponse<InsurancePrice>> GetInsurancePrice(decimal amount, string currencyCode, string senderCountryCode, string receiverCountryCode);

        Task<Consignor.ShipmentServer.IShipmentServerResponse<Address>> GetSenderAddressAsync(int actorCSID);

        Task<Consignor.ShipmentServer.IShipmentServerResponse<dynamic>> GetSettingsAsync(int carrierConceptID, int subcarrierConceptID, int prodConceptID);

        Task<Consignor.ShipmentServer.IShipmentServerResponse<Shipment>> GetShipmentAsync(int shpCSID);

        Task<Consignor.ShipmentServer.IShipmentServerResponse<ShipmentCollection>> GetShipmentsAsync(int orderNo);

        Task<Consignor.ShipmentServer.IShipmentServerResponse> GetShipmentAlternativesAsync(Shipment shipment);

        Task<Consignor.ShipmentServer.IShipmentServerResponse<UpdatePrice>> GetShipmentPriceAsync(Shipment shipment);

        Task<Consignor.ShipmentServer.IShipmentServerResponse<ShipmentCollection>> GetStackShipmentsAsync(int stackCSID);

        Task<Consignor.ShipmentServer.IShipmentServerResponse> MoveContactsAsync(int contactListCSID, List<int> contactCSID);

        Task<Consignor.ShipmentServer.IShipmentServerResponse<LabelCollection>> ReprintLabelsAsync(int shpCSID, LabelKind kind);

        Task<Consignor.ShipmentServer.IShipmentServerResponse> RestoreBatchAsync(int batchCSID);

        Task<Consignor.ShipmentServer.IShipmentServerResponse<int?>> SaveContactAsync(Contact contact);

        Task<Consignor.ShipmentServer.IShipmentServerResponse<int?>> SaveContactListAsync(ContactList contactList);

        Task<Consignor.ShipmentServer.IShipmentServerResponse> SaveSettingsAsync(int carrierConceptID, int subcarrierConceptID, int prodConceptID, dynamic settings);

        Task<Consignor.ShipmentServer.IShipmentServerResponse<Shipment>> SaveShipmentAsync(Shipment shipment);

        Task<Consignor.ShipmentServer.IShipmentServerResponse<Shipment>> SubmitShipmentAsync(Shipment shipment, LabelKind label = LabelKind.None, bool calculatePrice = false);

        Task<Consignor.ShipmentServer.IShipmentServerResponse> TransmitStackAsync(int stackCSID);

        Task<Consignor.ShipmentServer.IShipmentServerResponse> ValidateShipmentAsync(Shipment shipment);
    }
}
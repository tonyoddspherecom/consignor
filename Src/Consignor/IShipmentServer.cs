using Consignor.ShipmentServer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Consignor
{
    public interface IShipmentServer
    {
        Task<Consignor.IShipmentServerResponse<CarrierCollection>> GetProductsAsync();

        Task<Consignor.IShipmentServerResponse<CarrierCollection>> GetStacksAsync();

        Task<Consignor.IShipmentServerResponse<int?>> GetInboxCountAsync();

        Task<Consignor.IShipmentServerResponse<int?>> CreateStackAsync(int subcarrierConceptID, string stackName);

        Task<Consignor.IShipmentServerResponse> DeleteContactAsync(int contactCSID);

        Task<Consignor.IShipmentServerResponse> DeleteContactListAsync(int contactListCSID);

        Task<Consignor.IShipmentServerResponse> DeleteShipmentAsync(int shpCSID);

        Task<Consignor.IShipmentServerResponse<int?>> GetBatchCountAsync();

        Task<Consignor.IShipmentServerResponse<Batch>> GetBatchDetailsAsync(int batchCSID);

        Task<Consignor.IShipmentServerResponse<BatchCollection>> GetBatchListAsync(int startIndex = 0, int count = 90, string sortField = "BatchCSID", int sortDirection = 0);

        Task<Consignor.IShipmentServerResponse<byte[]>> GetBatchReportAsync(int batchReportCSID);

        Task<Consignor.IShipmentServerResponse<ShipmentCollection>> GetBatchShipmentsAsync(int batchCSID);

        Task<Consignor.IShipmentServerResponse<int?>> GetContactCountAsync(int contactListCSID);

        Task<Consignor.IShipmentServerResponse<ContactListCollection>> GetContactListsAsync();

        Task<Consignor.IShipmentServerResponse<ContactList>> GetContactListDetailsAsync(int contactListCSID);

        Task<Consignor.IShipmentServerResponse<ContactCollection>> GetContactsAsync(int contactListCSID, int startIndex = 0, int count = 90, string sortField = "ContactNo", int sortDirection = 0);

        Task<Consignor.IShipmentServerResponse<ContactCollection>> GetContactProfileAsync(int contactNo, int addressCSID);

        Task<Consignor.IShipmentServerResponse<Shipment>> GetDefaultShipmentAsync(int prodConceptID);

        Task<Consignor.IShipmentServerResponse<DocumentCollection>> GetDocumentListAsync(int ShpCSID);

        Task<Consignor.IShipmentServerResponse<int?>> GetDocumentCountAsync(int ShpCSID);

        Task<Consignor.IShipmentServerResponse<DocumentCollection>> GetDocumentAsync(int ShpCSID);

        Task<Consignor.IShipmentServerResponse<ShipmentCollection>> GetInboxShipmentsAsync(int startIndex = 0, int count = 90, string sortField = "ShpCSID", int sortDirection = 0);

        Task<Consignor.IShipmentServerResponse<InsurancePrice>> GetInsurancePrice(decimal amount, string currencyCode, string senderCountryCode, string receiverCountryCode);

        Task<Consignor.IShipmentServerResponse<Address>> GetSenderAddressAsync(int actorCSID);

        Task<Consignor.IShipmentServerResponse<dynamic>> GetSettingsAsync(int carrierConceptID, int subcarrierConceptID, int prodConceptID);

        Task<Consignor.IShipmentServerResponse<Shipment>> GetShipmentAsync(int shpCSID);

        Task<Consignor.IShipmentServerResponse<ShipmentCollection>> GetShipmentsAsync(int orderNo);

        Task<Consignor.IShipmentServerResponse> GetShipmentAlternativesAsync(Shipment shipment);

        Task<Consignor.IShipmentServerResponse<UpdatePrice>> GetShipmentPriceAsync(Shipment shipment);

        Task<Consignor.IShipmentServerResponse<ShipmentCollection>> GetStackShipmentsAsync(int stackCSID);

        Task<Consignor.IShipmentServerResponse> MoveContactsAsync(int contactListCSID, List<int> contactCSID);

        Task<Consignor.IShipmentServerResponse<LabelCollection>> ReprintLabelsAsync(int shpCSID, LabelKind kind);

        Task<Consignor.IShipmentServerResponse> RestoreBatchAsync(int batchCSID);

        Task<Consignor.IShipmentServerResponse<int?>> SaveContactAsync(Contact contact);

        Task<Consignor.IShipmentServerResponse<int?>> SaveContactListAsync(ContactList contactList);

        Task<Consignor.IShipmentServerResponse> SaveSettingsAsync(int carrierConceptID, int subcarrierConceptID, int prodConceptID, dynamic settings);

        Task<Consignor.IShipmentServerResponse<Shipment>> SaveShipmentAsync(Shipment shipment);

        Task<Consignor.IShipmentServerResponse<Shipment>> SubmitShipmentAsync(Shipment shipment, LabelKind label = LabelKind.None, bool calculatePrice = false);

        Task<Consignor.IShipmentServerResponse> TransmitStackAsync(int stackCSID);

        Task<Consignor.IShipmentServerResponse> ValidateShipmentAsync(Shipment shipment);
    }
}
using Consignor.ShipmentServer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Consignor.Internal
{
    internal class ShipmentServer : IShipmentServer
    {
        private string Url { get; set; }

        private string Key { get; set; }

        private int ActorID { get; set; }

        public ShipmentServer(string url, int actorid, string key)
        {
            Url = url;
            Key = key;
            ActorID = actorid;
        }

        private async Task<IShipmentServerResponse> Request(string command, string data = "", string options = "", string context = "")
        {
            var client = new HttpClient();
            var values = new List<KeyValuePair<string, string>>		
            {
                new KeyValuePair<string, string>("options", options),
                new KeyValuePair<string, string>("data", data),
                new KeyValuePair<string, string>("actor", ActorID.ToString()),
                new KeyValuePair<string, string>("key", Key),
                new KeyValuePair<string, string>("command", command),
                new KeyValuePair<string, string>("context", context)
            };
            var content = new FormUrlEncodedContent(values);
            var serverresponse = await client.PostAsync(Url, content);
            var response = await serverresponse.Content.ReadAsStringAsync();
            var result = new ShipmentServerResponse
            {
                Request = new
                {
                    options = options.ToObject(),
                    data = data.ToObject(),
                    actor = ActorID,
                    key = Key,
                    command = command,
                    context = context.ToObject()
                , }.ToJson(),
                Response = response.ToObject().ToJson(),
                Info = response.ToObject<ShipmentServerMessages>(),
            };
            return result;
        }

        private async Task<IShipmentServerResponse<byte[]>> RequestBinary(string command, string data = "", string options = "", string context = "")
        {
            var client = new HttpClient();
            var values = new List<KeyValuePair<string, string>>		
            {
                new KeyValuePair<string, string>("options", options),
                new KeyValuePair<string, string>("data", data),
                new KeyValuePair<string, string>("actor", ActorID.ToString()),
                new KeyValuePair<string, string>("key", Key),
                new KeyValuePair<string, string>("command", command),
                new KeyValuePair<string, string>("context", context)
            };
            var content = new FormUrlEncodedContent(values);
            var serverresponse = await client.PostAsync(Url, content);
            var bytes = serverresponse.IsSuccessStatusCode ? await serverresponse.Content.ReadAsByteArrayAsync() : null;
            var info = serverresponse.IsSuccessStatusCode ? string.Empty : await serverresponse.Content.ReadAsStringAsync();

            var result = new ShipmentServerResponse<byte[]>
            {
                Request = new
                {
                    options = options.ToObject(),
                    data = data.ToObject(),
                    actor = ActorID,
                    key = Key,
                    command = command,
                    context = context.ToObject()
                , }.ToJson(),
                Response = serverresponse.Content.Headers.ToJson(),
                Info = info.ToObject<ShipmentServerMessages>(),
                Result = bytes,
            };

            return result;
        }

        private async Task<IShipmentServerResponse<T>> Request<T>(string command, string data = "", string options = "", string context = "")
        {
            var response = await Request(command, data, options, context);
            var result = new ShipmentServerResponse<T>(response as ShipmentServerResponse);
            if (!string.IsNullOrWhiteSpace(result.Response) && result.Info.ErrorMessages == null && result.Info.Messages == null)
            {
                try
                {
                    result.Result = result.Response.ToObject<T>();
                }
                catch (Exception)
                {
                }
            }
            return result;
        }

        private async Task<IShipmentServerResponse<TResult>> RequestAnonymous<T, TResult>(T template, Func<T, TResult> selector, string command, string data = "", string options = "", string context = "")
        {
            var response = await Request(command, data, options, context);
            var result = new ShipmentServerResponse<TResult>(response as ShipmentServerResponse);
            if (!string.IsNullOrWhiteSpace(result.Response) && result.Info.ErrorMessages == null && result.Info.Messages == null)
            {
                try
                {
                    T obj = JsonConvert.DeserializeAnonymousType(result.Response, template);
                    result.Result = selector(obj);
                }
                catch (Exception)
                {
                }
            }
            return result;
        }

        public Task<IShipmentServerResponse<CarrierCollection>> GetProductsAsync()
        {
            return Request<CarrierCollection>("GetProducts");
        }

        public Task<IShipmentServerResponse<CarrierCollection>> GetStacksAsync()
        {
            return Request<CarrierCollection>("GetStacks");
        }

        public Task<IShipmentServerResponse<int?>> GetInboxCountAsync()
        {
            return RequestAnonymous(new { Count = (int?)null }, o => o.Count, "GetInboxCount");
        }

        public Task<IShipmentServerResponse<int?>> CreateStackAsync(int subcarrierConceptID, string stackName)
        {
            var data = (new { SubcarrierConceptID = subcarrierConceptID, StackName = stackName }).ToJson();
            return RequestAnonymous(new { StackCSID = (int?)null }, o => o.StackCSID, "CreateStack", data);
        }

        public Task<IShipmentServerResponse> DeleteContactAsync(int contactCSID)
        {
            var data = (new { ContactCSID = contactCSID }).ToJson();
            return Request("DeleteContact", data);
        }

        public Task<IShipmentServerResponse> DeleteContactListAsync(int contactListCSID)
        {
            var data = (new { ContactListCSID = contactListCSID }).ToJson();
            return Request("DeleteContactList", data);
        }

        public Task<IShipmentServerResponse> DeleteShipmentAsync(int shpCSID)
        {
            var data = (new { ShpCSID = shpCSID }).ToJson();
            return Request("DeleteShipment", data); 
        }

        public Task<IShipmentServerResponse<int?>> GetBatchCountAsync()
        {
            return RequestAnonymous(new { Count = (int?)null }, o => o.Count, "GetBatchCount");
        }

        public Task<IShipmentServerResponse<Batch>> GetBatchDetailsAsync(int batchCSID)
        {
            var data = (new { BatchCSID = batchCSID }).ToJson();
            return Request<Batch>("GetBatchDetails", data);
        }

        public Task<IShipmentServerResponse<BatchCollection>> GetBatchListAsync(int startIndex = 0, int count = 90, string sortField = "BatchCSID", int sortDirection = 0)
        {
            var data = new { StartIndex = startIndex, Count = count, SortField = sortField, SortDirection = sortDirection }.ToJson(false);
            return Request<BatchCollection>("GetBatchList", data);
        }

        public Task<IShipmentServerResponse<byte[]>> GetBatchReportAsync(int batchReportCSID)
        {
            var data = new { BatchReportCSID = batchReportCSID }.ToJson();
            return RequestBinary("GetBatchReport", data);
        }

        public Task<IShipmentServerResponse<ShipmentCollection>> GetBatchShipmentsAsync(int batchCSID)
        { 
            var data = new { BatchCSID = batchCSID }.ToJson();
            return Request<ShipmentCollection>("GetBatchShipments", data);
        }

        public Task<IShipmentServerResponse<int?>> GetContactCountAsync(int contactListCSID)
        {
            var data = new { ContactListCSID = contactListCSID }.ToJson();
            return RequestAnonymous(new { Count = (int?)null }, o => o.Count, "GetContactCount", data);
        }

        public Task<IShipmentServerResponse<ContactListCollection>> GetContactListsAsync()
        {
            return Request<ContactListCollection>("GetContactLists");
        }

        public Task<IShipmentServerResponse<ContactList>> GetContactListDetailsAsync(int contactListCSID)
        {
            var data = new { ContactListCSID = contactListCSID }.ToJson();
            return Request<ContactList>("GetContactListDetails", data);
        }

        public Task<IShipmentServerResponse<ContactCollection>> GetContactsAsync(int contactListCSID, int startIndex = 0, int count = 90, string sortField = "ContactNo", int sortDirection = 0)
        {
            var data = new { ContactListCSID = contactListCSID, StartIndex = startIndex, Count = count, SortField = sortField, SortDirection = sortDirection }.ToJson(false);
            return Request<ContactCollection>("GetContacts", data);
        }

        public Task<IShipmentServerResponse<ContactCollection>> GetContactProfileAsync(int contactNo, int addressCSID)
        {
            var data = new { ContactNo = contactNo, AddressCSID = addressCSID }.ToJson();
            return Request<ContactCollection>("GetContactProfile", data);
        }

        public Task<IShipmentServerResponse<Shipment>> GetDefaultShipmentAsync(int prodConceptID)
        {
            var data = new { ProdConceptID = prodConceptID }.ToJson();
            return Request<Shipment>("GetDefaultShipment", data);
        }

        public Task<IShipmentServerResponse<DocumentCollection>> GetDocumentListAsync(int ShpCSID)
        {
            var data = new { ShpCSID = ShpCSID }.ToJson();
            return Request<DocumentCollection>("GetDocumentList", data);
        }

        public Task<IShipmentServerResponse<int?>> GetDocumentCountAsync(int ShpCSID)
        {
            var data = new { ShpCSID = ShpCSID }.ToJson();
            return RequestAnonymous(new { count = (int?)null }, o => o.count, "GetDocumentCount", data);
        }

        public Task<IShipmentServerResponse<DocumentCollection>> GetDocumentAsync(int ShpCSID)
        {
            var data = new { ShpCSID = ShpCSID }.ToJson();
            return Request<DocumentCollection>("GetDocument", data);
        }

        public Task<IShipmentServerResponse<ShipmentCollection>> GetInboxShipmentsAsync(int startIndex = 0, int count = 90, string sortField = "ShpCSID", int sortDirection = 0)
        {
            var data = new { StartIndex = startIndex, Count = count, SortField = sortField, SortDirection = sortDirection }.ToJson(false);
            return Request<ShipmentCollection>("GetInboxShipments", data);
        }

        public Task<IShipmentServerResponse<InsurancePrice>> GetInsurancePrice(decimal amount, string currencyCode, string senderCountryCode, string receiverCountryCode)
        {
            var data = new { Amount = amount, CurrencyCode = currencyCode, SenderCountryCode = senderCountryCode, ReceiverCountryCode = receiverCountryCode }.ToJson();
            return Request<InsurancePrice>("GetInsurancePrice", data);
        }

        public Task<IShipmentServerResponse<Address>> GetSenderAddressAsync(int actorCSID)
        {
            var data = new { ActorCSID = actorCSID }.ToJson();
            return Request<Address>("GetSenderAddress", data);
        }

        public Task<IShipmentServerResponse<dynamic>> GetSettingsAsync(int carrierConceptID, int subcarrierConceptID, int prodConceptID)
        {
            var context = new { CarrierConceptID = carrierConceptID, SubcarrierConceptID = subcarrierConceptID, ProdConceptID = prodConceptID }.ToJson();
            return Request<dynamic>("GetSettings", "", "", context);
        }

        public Task<IShipmentServerResponse<Shipment>> GetShipmentAsync(int shpCSID)
        {
            var data = new { ShpCSID = shpCSID }.ToJson();
            return Request<Shipment>("GetShipment", data);
        }

        public Task<IShipmentServerResponse<ShipmentCollection>> GetShipmentsAsync(int orderNo)
        {
            var data = new { OrderNo = orderNo }.ToJson();
            return Request<ShipmentCollection>("GetShipment", data);
        }

        public Task<IShipmentServerResponse> GetShipmentAlternativesAsync(Shipment shipment)
        {
            return Request("GetShipmentAlternatives", shipment.ToJson());
        }

        public Task<IShipmentServerResponse<UpdatePrice>> GetShipmentPriceAsync(Shipment shipment)
        {
            return Request<UpdatePrice>("GetShipmentPrice", shipment.ToJson(), new { }.ToJson());
        }

        public Task<IShipmentServerResponse<ShipmentCollection>> GetStackShipmentsAsync(int stackCSID)
        {
            var data = new { StackCSID = stackCSID }.ToJson();
            return Request<ShipmentCollection>("GetStackShipments", data);
        }

        public Task<IShipmentServerResponse> MoveContactsAsync(int contactListCSID, List<int> contactCSID)
        {
            var data = new { ContactListCSID = contactListCSID, ContactCSID = contactCSID }.ToJson();
            return Request("MoveContacts", data);
        }

        public Task<IShipmentServerResponse<LabelCollection>> ReprintLabelsAsync(int shpCSID, LabelKind kind)
        {
            var data = new { ShpCSID = shpCSID }.ToJson();
            var options = new { Labels = Enum.GetName(typeof(LabelKind), kind) }.ToJson();
            return Request<LabelCollection>("ReprintLabels", data, options);
        }

        public Task<IShipmentServerResponse> RestoreBatchAsync(int batchCSID)
        {
            var data = new { BatchCSID = batchCSID }.ToJson();
            return Request("RestoreBatch", data);
        }

        public Task<IShipmentServerResponse<int?>> SaveContactAsync(Contact contact)
        {
            return RequestAnonymous(new { ContactCSID = (int?)null }, o => o.ContactCSID, "SaveContact", contact.ToJson());
        }

        public Task<IShipmentServerResponse<int?>> SaveContactListAsync(ContactList contactList)
        {
            return RequestAnonymous(new { ContactListCSID = (int?)null }, o => o.ContactListCSID, "SaveContactList", contactList.ToJson(false));
        }

        public Task<IShipmentServerResponse> SaveSettingsAsync(int carrierConceptID, int subcarrierConceptID, int prodConceptID, dynamic settings)
        {
            var context = new { CarrierConceptID = carrierConceptID, SubcarrierConceptID = subcarrierConceptID, ProdConceptID = prodConceptID }.ToJson();
            return Request("SaveSettings", (settings as object).ToJson(), "", context);
        }

        public Task<IShipmentServerResponse<Shipment>> SaveShipmentAsync(Shipment shipment)
        {
            return Request<Shipment>("SaveShipment", shipment.ToJson());
        }

        public Task<IShipmentServerResponse<Shipment>> SubmitShipmentAsync(Shipment shipment, LabelKind label = LabelKind.None, bool calculatePrice = false)
        {
            var options = new { Labels = label == LabelKind.None ? null : Enum.GetName(typeof(LabelKind), label), PriceCalculation = calculatePrice ? 1 : 0 }.ToJson();
            return Request<Shipment>("SubmitShipment", shipment.ToJson(), options);
        }

        public Task<IShipmentServerResponse> TransmitStackAsync(int stackCSID)
        {
            var data = new { StackCSID = stackCSID }.ToJson();
            return Request("TransmitStack", data);
        }

        public Task<IShipmentServerResponse> ValidateShipmentAsync(Shipment shipment)
        {
            return Request("ValidateShipment", shipment.ToJson(), new { }.ToJson());
        }
	}
}

using System;
using System.Collections.Generic;

namespace Consignor.ShipmentServer
{
    public class Shipment
    {
        public int ShpCSID { get; set; }
        public string ProdName { get; set; }
        public string InstallationID { get; set; }
        public ShipmentKind Kind { get; set; }
        public string ShpNo { get; set; }
        public string OrderNo { get; set; }
        public DateTime? PickUpDt { get; set; }
        public DateTime? LabelPrintDt { get; set; }
        public DateTime? TransmitDt { get; set; }
        public DateTime? ImportDt { get; set; }
        public DateTime? ExpireDt { get; set; }
        public DateTime? SubmitDt { get; set; }
        public int DimensionalWeight { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int ActorCSID { get; set; }
        public int StackCSID { get; set; }
        public int BatchCSID { get; set; }
        public string BatchDate { get; set; }
        public int ComebackParentCSID { get; set; }
        public int GroupParentCSID { get; set; }
        public int BulksplitMainCSID { get; set; }
        public ShipmentTemperature Temperature { get; set; }
        public CarriagePayer CarriagePayer { get; set; }
        public int CarrierConceptID { get; set; }
        public int SubcarrierConceptID { get; set; }
        public int Loadmeter { get; set; }
        public int ProdConceptID { get; set; }
        public string Barcode1 { get; set; }
        public string Barcode2 { get; set; }
        public string OriginPostcode { get; set; }
        public string OriginTerminal { get; set; }
        public string PickupTerminal { get; set; }
        public string AgentNo { get; set; }
        public string PayerAccountAtCarrier { get; set; }
        public string SenderAccountAtCarrier { get; set; }
        public string SenderAccountAtBank { get; set; }
        public int InsuranceGroup { get; set; }
        public int ReturnPackaging { get; set; }
        public int LabelsCount { get; set; }
        public int FreightBillsCount { get; set; }
        public List<int> Services { get; set; }
        public List<DetailGroup> DetailGroups { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Amount> Amounts { get; set; }
        public List<Line> Lines { get; set; }
        public List<Reference> References { get; set; }
        public List<Message> Messages { get; set; }
        public List<DangerousGoods> DangerousGoods { get; set; }
        public List<CSEvent> CSEvents { get; set; }
        public List<ShpConnection> ShpConnections { get; set; }
        public List<Label> Labels { get; set; }
    }
}

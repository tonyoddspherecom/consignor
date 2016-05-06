using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "Shipment", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ExportDomain")]
    public partial class Shipment
    {
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ActorCsid { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ActorName { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Address[] Addresses { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Amount[] Amounts { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Barcode1 { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Barcode2 { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int BatchCsid { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public CarriagePayer CarriagePayer { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int CarrierId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string CarrierName { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Detail[] Details { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int DimensionalWeight { get; set; }
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Esid { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Event[] Events { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> ExpireDate { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int FreightBillsCount { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int Height { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> ImportDate { get; set; }
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InstallationId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string InstallationName { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int InsuranceGroup { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool IsConceptCarrier { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool IsConceptProduct { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> LabelPrintDate { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int LabelsCount { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string LatestStatusText { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int Length { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Line[] Lines { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public decimal LinesSummedWeights { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int Loadmeter { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int LocationId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string LocationName { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Message[] Messages { get; set; }
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Number { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int NumberOfPackages { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string OrderNumber { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string OriginPostcode { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string OriginTerminal { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string PackageUid { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string PayerAccountAtCarrier { get; set; }
        [DataMember]
        public string PhysicalInstallationId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> PickupDate { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string PickupTerminal { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int ProductId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool ProductIsReturn { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ProductName { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Reference[] References { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int ReturnPackaging { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string SearchKey { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string SenderAccountAtBank { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string SenderAccountAtCarrier { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Service[] Services { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public ShipmentConnection[] ShipmentConnections { get; set; }
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ShipmentCsid { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public ShipmentCustomDocument[] ShipmentCustomDocuments { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public ShipmentDocument[] ShipmentDocuments { get; set; }
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ShipmentKind ShipmentKind { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public RadarStatusType ShipmentStatus { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public ShipmentTemperature ShipmentTemperature { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int StackCsid { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int SubcarrierId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string SubcarrierName { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public System.DateTime SubmitDate { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> TransmitDate { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool UsedInstallationIsVirtual { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public decimal VolumeCM { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int Width { get; set; }
    }
}

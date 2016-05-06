using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "HealthResponse", Namespace = "http://schemas.datacontract.org/2004/07/EDISoft.Portal.Endpoints.Services.PortalDataWS")]
    public partial class HealthResponse
    {
        [DataMember]
        public bool HealthStatus { get; set; }
        [DataMember]
        public string Message { get; set; }
    }
}

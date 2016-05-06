using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "AttachmentType", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ImportDomain")]
    public enum AttachmentType : int
    {
        [EnumMember]Picture = 1,
        [EnumMember]Text = 2,
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.Events")]
    public class Identifier
    {
        [DataMember(Order = 0)] public IdentifierType IdentifierType { get; set; }
        public bool IdentifierTypeSpecified { get; set; }
        [DataMember(Order = 0)] public string IdentifierValue { get; set; }
    }
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.Events")]
    public enum IdentifierType
    {
        Barcode,
        OrderNo,
        ReciverRefrence,
    }
}

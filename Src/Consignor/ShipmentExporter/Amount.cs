using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "Amount", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ExportDomain")]
    public class Amount
    {
        [DataMember(EmitDefaultValue = false)]
        public int CurrencyClientId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public AmountKind Kind { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal Value { get; set; }
    }
}

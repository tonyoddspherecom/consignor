using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "Address", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ExportDomain")]
    public class Address
    {
        [DataMember(EmitDefaultValue = false)]
        public string Attention { get; set; }
        
        [DataMember(EmitDefaultValue = false)]
        public string City { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int CountryClientId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string CountryName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string CustNo { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string ERPRef { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Email { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Fax { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public AddressKind Kind { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Mobile { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Name1 { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Name2 { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string OpeningHours { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string POBox { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string POCity { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string POPostCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Phone { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string PostCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string ReceiverRef { get; set; }
        
        [DataMember(EmitDefaultValue = false)]
        public string Street1 { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Street2 { get; set; }
        
    }
}

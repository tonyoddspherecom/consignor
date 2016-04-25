using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    public class GenericEntity
    {
        [DataMember(Order = 0)]public int Id { get; set; }
        public bool IdSpecified { get; set; }
        [DataMember(Order = 0)] public byte[] TimeStamp { get; set; }
    }
}

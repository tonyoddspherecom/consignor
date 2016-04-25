using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "AddressKind", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain")]
    public enum AddressKind
    {
        [EnumMember()]
        Unknown = 0,

        [EnumMember()]
        Receiver = 1,

        [EnumMember()]
        Sender = 2,

        [EnumMember()]
        PickUp = 3,

        [EnumMember()]
        Payer = 4,

        [EnumMember()]
        Buyer = 5,

        [EnumMember()]
        Temporary = 6,

        [EnumMember()]
        Message = 7,

        [EnumMember()]
        Forwarder = 8,

        [EnumMember()]
        ReturnTo = 9,

        [EnumMember()]
        DropPoint = 10,

        [EnumMember()]
        Depot = 11,

        [EnumMember()]
        Comeback = 12,

        [EnumMember()]
        Broker = 13,

        [EnumMember()]
        Delivery = 14,
    }
}

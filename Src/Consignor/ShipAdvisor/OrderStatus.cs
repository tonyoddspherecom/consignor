using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipAdvisor
{
    [DataContract(Namespace = "http://ws.consignorsupport.no/ShipAdvisor")]
    public enum OrderStatus
    {
        [EnumMember]Any,
        [EnumMember]Initialized,
        [EnumMember]ConfirmedByUser,
        [EnumMember]CanceledByUser,
        [EnumMember]ConfirmedByWebShop,
        [EnumMember]CanceledByWebShop,
        [EnumMember]SentToPortal,
        [EnumMember]RollbackedFromPortal,
        [EnumMember]All,
    }
}

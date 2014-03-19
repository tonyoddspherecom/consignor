using System;
using System.Collections.Generic;
using System.Linq;

namespace Consignor.ShipmentServer
{
    public class ContactList
    {
        public int ContactListCSID { get; set; }
        public string ContactListName { get; set; }
        public int? DefaultContactList { get; set; }
        public List<ContactListKind> ContactListKinds { get; set; }
    }
}

using System.Collections.Generic;
using Consignor.ShipmentServer;

namespace Consignor.Internal
{
    internal class ShipmentServerMessages : IShipmentServerMessages
    {
        public List<string> ErrorMessages { get; set; }
        public List<string> WarningMessages { get; set; }
        public List<string> Messages { get; set; }
        public string Message { get; set; }
    }
}
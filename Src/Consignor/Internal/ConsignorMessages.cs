using System.Collections.Generic;

namespace Consignor.Internal
{
    internal class ConsignorMessages : Consignor.IShipmentServerMessages
    {
        public List<string> ErrorMessages { get; set; }
        public List<string> WarningMessages { get; set; }
        public List<string> Messages { get; set; }
        public string Message { get; set; }
    }
}
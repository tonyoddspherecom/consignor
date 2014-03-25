using System;
using System.Collections.Generic;

namespace Consignor.ShipmentServer
{
    public interface IShipmentServerMessages
    {
        List<string> ErrorMessages { get; set; }
        string Message { get; set; }
        List<string> Messages { get; set; }
        List<string> WarningMessages { get; set; }
    }
}

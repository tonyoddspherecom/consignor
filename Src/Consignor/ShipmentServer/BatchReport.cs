using System;

namespace Consignor.ShipmentServer
{
    public class BatchReport
    { 
        public int BatchReportCSID { get; set; }

        public string BatchReportName { get; set; }

        public DateTime CreationDate { get; set; }

        public string Description { get; set; }

        public bool IsEdiFile { get; set; }
    }
}
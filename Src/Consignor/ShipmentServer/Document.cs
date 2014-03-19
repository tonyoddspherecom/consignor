using System;

namespace Consignor.ShipmentServer
{
    public class Document
    { 
        public int DocumentCSID { get; set; }
        public string DocumentName { get; set; }
        public byte[] Content { get; set; }
        public DateTime? PrintedDt { get; set; }
        public string DocumentType { get; set; }
    }
}
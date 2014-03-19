using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Consignor.ShipmentServer
{
    public class Batch
    {
        public int BatchCSID { get; set; }
        public string ActorName { get; set; }
        public string CarrierFullName { get; set; }
        public string SubcarrierName { get; set; }
        public string StackName { get; set; }
        public DateTime TransmitDt { get; set; }
        public DateTime SentDt { get; set; }
        [DefaultValue(0)]
        public int CarrierConceptID { get; set; }
        [DefaultValue(0)]
        public int SubcarrierConceptID { get; set; }
        [DefaultValue(0)]
        public int CarrierCSID { get; set; }
        [DefaultValue(0)]
        public int SubcarrierCSID { get; set; }
        public List<BatchReport> Files { get; set; }

    }
}

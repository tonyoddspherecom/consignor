using System.Collections.Generic;
using System.ComponentModel;

namespace Consignor.ShipmentServer
{
    public class Package
    {
        [DefaultValue(0)]
        public int ItemNo { get; set; }

        [DefaultValue("")]
        public string PkgNo { get; set; }

        [DefaultValue("")]
        public string Barcode1 { get; set; }

        [DefaultValue("")]
        public string Barcode2 { get; set; }

        public List<Reference> References { get; set; }

        public List<CSEvent> ConsignorEvents { get; set; }
    }
}
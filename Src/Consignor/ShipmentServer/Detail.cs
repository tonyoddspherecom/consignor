using System.ComponentModel;

namespace Consignor.ShipmentServer
{
    public class Detail
    {
        [DefaultValue(0)]
        public int KindID { get; set; }

        [DefaultValue(0)]
        public int RowNo { get; set; }

        [DefaultValue(0)]
        public int GroupID { get; set; }

        [DefaultValue("")]
        public string Value { get; set; }

        public FieldDataType DataType { get; set; }
    }
}
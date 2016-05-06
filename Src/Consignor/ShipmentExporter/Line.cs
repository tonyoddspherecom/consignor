using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "Line", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ExportDomain")]
    public partial class Line
    {
        [DataMember(EmitDefaultValue = false)]
        public DangerousGoods[] DangerousGoods { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int DimensionalWeight { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int GoodsTypeId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string GoodsTypeKey1 { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string GoodsTypeKey2 { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string GoodsTypeName { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int Height { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int Length { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int LineNumberOfPackages { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public LineUnit[] LineUnits { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public long LineVolume { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int LineWeight { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int Loadmeter { get; set; }
        [DataMember]
        public int Number { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public long PackageVolume { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int PackageWeight { get; set; }
        [DataMember]
        public Package[] Packages { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int RecycleCount { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string RecycleTypeCode { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int RecycleTypeId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string RecycleTypeName { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Reference[] References { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int Width { get; set; }
    }
}

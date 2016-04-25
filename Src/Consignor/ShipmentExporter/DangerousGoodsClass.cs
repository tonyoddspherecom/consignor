using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "DangerousGoodsClass", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain")]
    public enum DangerousGoodsClass
    {
        [EnumMember()]
        Unknown = 0,

        [EnumMember()]
        Class1 = 1,

        [EnumMember()]
        Class2 = 2,

        [EnumMember()]
        Class2_1 = 3,

        [EnumMember()]
        Class3 = 4,

        [EnumMember()]
        Class4 = 5,

        [EnumMember()]
        Class4_1 = 6,

        [EnumMember()]
        Class4_2 = 7,

        [EnumMember()]
        Class4_3 = 8,

        [EnumMember()]
        Class5_1 = 9,

        [EnumMember()]
        Class5_2 = 10,

        [EnumMember()]
        Class6_1 = 11,

        [EnumMember()]
        Class6_2 = 12,

        [EnumMember()]
        Class7 = 13,

        [EnumMember()]
        Class8 = 14,

        [EnumMember()]
        Class9 = 15,

        [EnumMember()]
        Class1_1A = 16,

        [EnumMember()]
        Class1_1B = 17,

        [EnumMember()]
        Class1_1C = 18,

        [EnumMember()]
        Class1_1E = 19,

        [EnumMember()]
        Class1_1F = 20,

        [EnumMember()]
        Class1_1G = 21,

        [EnumMember()]
        Class1_1J = 22,

        [EnumMember()]
        Class1_1L = 23,

        [EnumMember()]
        Class1_2B = 24,

        [EnumMember()]
        Class1_2C = 25,

        [EnumMember()]
        Class1_2D = 26,

        [EnumMember()]
        Class1_2F = 27,

        [EnumMember()]
        Class1_2G = 28,

        [EnumMember()]
        Class1_2H = 29,

        [EnumMember()]
        Class1_2J = 30,

        [EnumMember()]
        Class1_2K = 31,

        [EnumMember()]
        Class1_2L = 32,

        [EnumMember()]
        Class1_3C = 33,

        [EnumMember()]
        Class1_3G = 34,

        [EnumMember()]
        Class1_3H = 35,

        [EnumMember()]
        Class1_3J = 36,

        [EnumMember()]
        Class1_3K = 37,

        [EnumMember()]
        Class1_3L = 38,

        [EnumMember()]
        Class1_4B = 39,

        [EnumMember()]
        Class1_4C = 40,

        [EnumMember()]
        Class1_4D = 41,

        [EnumMember()]
        Class1_4E = 42,

        [EnumMember()]
        Class1_4F = 43,

        [EnumMember()]
        Class1_4G = 44,

        [EnumMember()]
        Class1_4S = 45,

        [EnumMember()]
        Class1_5D = 46,

        [EnumMember()]
        Class1_6N = 47,

        [EnumMember()]
        Class2_2 = 48,

        [EnumMember()]
        Class2_3 = 49,
    }
}

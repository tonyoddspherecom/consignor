namespace Consignor.ShipmentServer
{
    public enum FieldDataType
    {
        efkString = 0,           // string
        efkCountry = 1,       // country public enum Country
        efkCurrency = 2,       // currency public enum Currency
        efkInt = 3,            // int
        efkFloat = 4,          // real
        efkDate = 5,           // date
        efkTime = 6,           // time
        efkDateTime = 7,       // date with time
        efkNone = 8           // no type - special fields with no value  { like button fields in PV}
    }
}
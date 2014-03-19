namespace Consignor.ShipmentServer
{
    public class InsurancePrice
    { 
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
        public int Status { get; set; }
        public string StatusKind { get; set; }
    }
}
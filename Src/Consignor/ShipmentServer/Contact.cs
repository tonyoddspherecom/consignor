namespace Consignor.ShipmentServer
{
    public class Contact
    {
        public int AddressCSID { get; set; }
        public int ContactCSID { get; set; }
        public int ContactListCSID { get; set; }
        public int ContactNo { get; set; }
        public string CustomerListName { get; set; }

        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string City { get; set; }
        public string POBox { get; set; }
        public string POPostCode { get; set; }
        public string POCity { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Attention { get; set; }
        public string OpeningHours { get; set; }
    }
}
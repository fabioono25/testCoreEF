namespace TestCoreEF.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public bool Active { get; set; }

        public int  ContactId { get; set; }
        public Contact Contact { get; set; }
       
    }
}
namespace OData.Domain.AggregatesModel.CustomerAggregate
{
    public class Address
    {
        public string Street { get; set; }
        public int PostalCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        protected Address() { }

        public Address(string street, int postalCode, string state, string city, string country)
        {
            Street = street;
            PostalCode = postalCode;
            State = state;
            City = city;
            Country = country;
        }
    }
}

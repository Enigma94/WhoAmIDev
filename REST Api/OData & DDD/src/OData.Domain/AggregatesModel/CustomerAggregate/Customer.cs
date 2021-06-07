using OData.Domain.Seedwork;

namespace OData.Domain.AggregatesModel.CustomerAggregate
{
    public class Customer : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Address Address { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        protected Customer() { }
        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}

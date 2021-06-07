using System;
using OData.Domain.Seedwork;

namespace OData.Domain.AggregatesModel.CustomerAggregate
{
    public class PaymentMethod : Entity
    {
        public DateTime ExpirationDate { get; set; }
        public CardType Type { get; set; }
        public string CardHolderName { get; set; }
        public int CardNumber { get; set; }
        public int SecurityNumber { get; set; }

        protected PaymentMethod() { }

        public PaymentMethod(DateTime expirationDate, CardType type, string cardHolderName, int cardNumber, int securityNumber)
        {
            ExpirationDate = expirationDate;
            Type = type;
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            SecurityNumber = securityNumber;
        }
    }
}

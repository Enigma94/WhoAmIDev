using System;
using System.Collections.Generic;
using OData.Domain.Seedwork;

namespace OData.Domain.AggregatesModel.OrderAggregate
{
    public class Order : Entity
    {
        public DateTime OrderDate { get; private set; }
        public decimal PrincipalAmount { get; private set; }
        public List<Ticket> Tickets { get; private set; }
        public OrderStatus Status { get; set; }

        public Order(DateTime orderDate, decimal principalAmount, OrderStatus orderStatus)
        {
            OrderDate = orderDate;
            PrincipalAmount = principalAmount;
            Status = orderStatus;

            Tickets = new List<Ticket>();
        }

        public void AddTicket(DateTime departureDate, DateTime arrivalDate, FlightType flightType,
            FlightClass flightClass, string departure, string destination)
            => Tickets.Add(new Ticket(departureDate, arrivalDate, flightType, flightClass, departure, destination));

        public void UpdateOrderStatus(OrderStatus status) => Status = status;
    }
}

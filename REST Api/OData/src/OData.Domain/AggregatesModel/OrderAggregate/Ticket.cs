using System;
using OData.Domain.Seedwork;

namespace OData.Domain.AggregatesModel.OrderAggregate
{
    public class Ticket : Entity
    {
        public DateTime DepartureDate { get; private set; }
        public DateTime ArrivalDate { get; private set; }
        public FlightType FlightType { get; private set; }
        public FlightClass FlightClass { get; private set; }
        public string Departure { get; private set; }
        public string Destination { get; private set; }

        protected Ticket() { }

        public Ticket(DateTime departureDate, DateTime arrivalDate, FlightType flightType, FlightClass flightClass, string departure, string destination)
        {
            DepartureDate = departureDate;
            ArrivalDate = arrivalDate;
            FlightType = flightType;
            FlightClass = flightClass;
            Departure = departure;
            Destination = destination;
        }
    }
}

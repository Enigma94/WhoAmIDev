using Microsoft.EntityFrameworkCore;
using OData.Domain.AggregatesModel.CustomerAggregate;
using OData.Domain.AggregatesModel.OrderAggregate;

namespace OData.Infrastructure
{
    public class BookingContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }

        public BookingContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}

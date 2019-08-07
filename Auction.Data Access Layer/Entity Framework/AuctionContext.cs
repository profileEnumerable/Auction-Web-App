using Auction.Data_Access_Layer.Entities;
using System;
using System.Data.Entity;

namespace Auction.Data_Access_Layer.Entity_Framework
{
    public class AuctionContext : DbContext
    {
        public DbSet<Lot> Lots { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Bid> Bids { get; set; }

        static AuctionContext()
        {
            Database.SetInitializer(new AuctionDbInitializer());
        }

        public AuctionContext(string connectionString)
            : base(connectionString)
        { }
    }

    public class AuctionDbInitializer : DropCreateDatabaseIfModelChanges<AuctionContext>
    {
        protected override void Seed(AuctionContext context)
        {

            var customers = new Customer[]
            {
                new Customer(){ Name="Yuri" },
                new Customer(){ Name="Vlad" },
            };

            var lots = new Lot[]
            {
                new Lot()
                {
                    Name = "Commander Watch",
                    StartPrice = 10,
                    CurrentPrice = 10,
                    DateAdded = DateTime.Now,
                    Owner = customers[0]
                },
                new Lot()
                {
                    Name = "Picture \"Sailboat\"",
                    StartPrice = 120,
                    CurrentPrice = 120,
                    DateAdded = DateTime.Now,
                    Owner = customers[1]
                }
            };

            context.Customers.AddRange(customers);
            context.Lots.AddRange(lots);

            context.SaveChanges();
        }
    }
}

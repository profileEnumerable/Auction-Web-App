using Auction.Data_Access_Layer.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Auction.Data_Access_Layer.Entity_Framework
{
    public class AuctionContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Lot> Lots { get; set; }

        public DbSet<Bid> Bids { get; set; }

        static AuctionContext()
        {
            Database.SetInitializer(new AuctionDbInitializer());
        }

        public AuctionContext(string connectionString)
            : base(connectionString)
        {
        }
    }

    public class AuctionDbInitializer : DropCreateDatabaseAlways<AuctionContext>
    {
        protected override void Seed(AuctionContext context)
        {
            var yuri = new ApplicationUser() { Name = "Yuri" };
            var vlad = new ApplicationUser() { Name = "Vlad" };
            var jon = new ApplicationUser() { Name = "Jon" };

            var lots = new List<Lot>();

            for (int i = 0; i < 100; i++)
            {
                var lot = new Lot()
                {
                    Name = "Commander Watch",
                    StartPrice = 10,
                    CurrentPrice = 10,
                    DateAdded = DateTime.Now,
                    //Owner = yuri
                };

                lots.Add(lot);
            }

            yuri.LotsForSale.Add(lots[0]);
            vlad.LotsForSale.Add(lots[1]);

            ApplicationUser[] applicationUsers = { yuri, vlad, jon };

            foreach (ApplicationUser applicationUser in applicationUsers)
            {
                context.Users.Add(applicationUser);
            }

            context.Lots.AddRange(lots);

            context.SaveChanges();
        }
    }
}

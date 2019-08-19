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

        public AuctionContext()
            : base("AuctionDB")
        {
        }
    }

    public class AuctionDbInitializer : DropCreateDatabaseIfModelChanges<AuctionContext>
    {
        protected override void Seed(AuctionContext context)
        {
            var yuri = new ApplicationUser() { UserName = "Yuri" };
            var vlad = new ApplicationUser() { UserName = "Vlad" };
            var jon = new ApplicationUser() { UserName = "Jon" };

            var lots = new List<Lot>();

            for (int i = 0; i < 500; i++)
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

            context.Lots.Add(new Lot()
            {
                Name = "Unique coin",
                StartPrice = 10,
                CurrentPrice = 10,
                DateAdded = DateTime.Now
            });

            context.SaveChanges();
        }
    }
}

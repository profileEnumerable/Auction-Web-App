using Auction.Data_Access_Layer.Entities;
using Auction.Data_Access_Layer.Entity_Framework;
using Auction.Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Auction.Data_Access_Layer.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AuctionContext _context;

        public UserRepository(AuctionContext context)
        {
            _context = context;
        }

        public void RegisterUser(ApplicationUser user)
        {
            _context.Users.Add(user);
        }
    }
}
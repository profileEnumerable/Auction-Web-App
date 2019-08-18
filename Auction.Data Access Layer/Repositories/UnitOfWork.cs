using Auction.Data_Access_Layer.Entities;
using Auction.Data_Access_Layer.Entity_Framework;
using Auction.Data_Access_Layer.Identity_Managers;
using Auction.Data_Access_Layer.Interfaces;
using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace Auction.Data_Access_Layer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AuctionContext _context;
        private ApplicationUserManager _userManager;
        private LotRepository _lotRepository;

        public UnitOfWork(string connectionString)
        {
            _context = new AuctionContext(connectionString);

            //use this line for debug propose and check in console SQL requests
            //_context.Database.Log = Console.WriteLine;
        }

        public ApplicationUserManager Users
        {
            get
            {
                if (_userManager == null)
                {
                    _userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(_context));
                }

                return _userManager;
            }
        }

        public IRepository<Lot> Lots
        {
            get
            {
                if (_lotRepository == null)
                {
                    _lotRepository = new LotRepository(_context);
                }

                return _lotRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool _disposed = false;

        public void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

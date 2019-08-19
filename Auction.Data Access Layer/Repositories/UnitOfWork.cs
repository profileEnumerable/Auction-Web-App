using Auction.Data_Access_Layer.Entities;
using Auction.Data_Access_Layer.Entity_Framework;
using Auction.Data_Access_Layer.Interfaces;
using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace Auction.Data_Access_Layer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AuctionContext _context;
        private UserRepository _userRepository;
        private LotRepository _lotRepository;

        public UnitOfWork()
        {
            _context = new AuctionContext();

            //use this line for debug propose and check in console SQL requests
            //_context.Database.Log = Console.WriteLine;
        }

        public IUserRepository Users
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(_context);
                }

                return _userRepository;
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

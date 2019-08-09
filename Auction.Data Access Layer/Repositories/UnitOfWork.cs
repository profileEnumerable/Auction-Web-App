using Auction.Data_Access_Layer.Entities;
using Auction.Data_Access_Layer.Entity_Framework;
using Auction.Data_Access_Layer.Interfaces;
using System;

namespace Auction.Data_Access_Layer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AuctionContext _context;
        private CustomerRepository _customerRepository;
        private LotRepository _lotRepository;

        public UnitOfWork(string connectionString)
        {
            _context = new AuctionContext(connectionString);


            _context.Configuration.LazyLoadingEnabled = true;

            //use this line for debug propose and check in console SQL requests
            //_context.Database.Log = Console.WriteLine;
        }

        public IRepository<Customer> Customers
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(_context);
                }

                return _customerRepository;
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

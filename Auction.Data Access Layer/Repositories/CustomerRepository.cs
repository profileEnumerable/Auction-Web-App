using Auction.Data_Access_Layer.Entities;
using Auction.Data_Access_Layer.Entity_Framework;
using Auction.Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Auction.Data_Access_Layer.Repositories
{
    public class CustomerRepository : IRepository<Customer>
    {
        private readonly AuctionContext _context;

        public CustomerRepository(AuctionContext context)
        {
            _context = context;
        }
        public IEnumerable<Customer> Find(Func<Customer, bool> predicate)
        {
            return _context.Customers.Where(predicate);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers;
        }

        public Customer Get(int id)
        {
            return _context.Customers.Find(id);
        }

        public void Create(Customer item)
        {
            _context.Customers.Add(item);
        }

        public void Update(Customer item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Customer customer = _context.Customers.Find(id);

            if (customer != null)
            {
                _context.Customers.Remove(customer);
            }
        }
    }
}
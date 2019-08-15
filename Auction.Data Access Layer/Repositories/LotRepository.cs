using Auction.Data_Access_Layer.Entities;
using Auction.Data_Access_Layer.Entity_Framework;
using Auction.Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Auction.Data_Access_Layer.Repositories
{
    public class LotRepository : IRepository<Lot>
    {
        private readonly AuctionContext _context;

        public LotRepository(AuctionContext auctionContext)
        {
            _context = auctionContext;
        }
        public IEnumerable<Lot> Find(Func<Lot, bool> predicate)
        {
            return _context.Lots.Where(predicate).ToList();
        }

        public IEnumerable<Lot> GetAll()
        {
            return _context.Lots;
        }

        public Lot Get(int id)
        {
            return _context.Lots.Find(id);
        }

        public void Create(Lot item)
        {
            _context.Lots.Add(item);
        }

        public void Update(Lot item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Lot lot = _context.Lots.Find(id);

            if (lot != null)
            {
                _context.Lots.Remove(lot);
            }
        }

    }
}

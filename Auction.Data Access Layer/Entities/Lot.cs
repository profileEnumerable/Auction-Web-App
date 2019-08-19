using System;
using System.Collections.Generic;

namespace Auction.Data_Access_Layer.Entities
{
    public class Lot
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal StartPrice { get; set; }

        /// <summary>
        /// Specify the maximum price that reflect last bid
        /// </summary>

        public decimal CurrentPrice { get; set; }

        //TODO: define how to specify the photo/s in Lot
        //public string[] PhotoPaths { get; set; }

        public string Description { get; set; }

        //public virtual Customer Owner { get; set; }

        //public virtual Customer BidLeader { get; set; }

        public DateTime DateAdded { get; set; }

        public virtual ICollection<Bid> Bids { get; set; }

        public Lot()
        {
            Bids = new List<Bid>();
        }
    }
}

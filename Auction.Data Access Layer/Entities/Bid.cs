using System;
using System.ComponentModel.DataAnnotations;

namespace Auction.Data_Access_Layer.Entities
{
    public class Bid
    {
        public int Id { get; set; }

        
        public Customer Participant { get; set; }

        
        public DateTime DateOfBid { get; set; }

        
        public decimal Rate { get; set; }
    }
}

﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Auction.Data_Access_Layer.Entities
{
    public class Bid
    {
        public int Id { get; set; }

        [Required]
        public Customer Participant { get; set; }

        [Required]
        public DateTime DateOfBid { get; set; }

        [Required]
        public decimal Rate { get; set; }
    }
}

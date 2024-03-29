﻿using Auction.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Auction.Business_Logic_Layer.DTO
{
    public class LotDto
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public decimal StartPrice { get; set; }

        /// <summary>
        /// Specify the maximum price that reflect last bid
        /// </summary>
        [Required]
        public decimal CurrentPrice { get; set; }

        //TODO: define how to specify the photo/s in Lot
        //public string[] PhotoPaths { get; set; }

        public string Description { get; set; }

        [Required]
        public virtual ApplicationUser Owner { get; set; }

        public virtual ApplicationUser BidLeader { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        public virtual ICollection<Bid> Bids { get; set; }

        public LotDto()
        {
            Bids = new List<Bid>();
        }
    }
}

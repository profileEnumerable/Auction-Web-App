using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Auction.Data_Access_Layer.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Lot> LotsForSale { get; set; }

        public ICollection<Lot> LotsForBuy { get; set; }
    }
}

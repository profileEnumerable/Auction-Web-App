using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Auction.Data_Access_Layer.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Lot> LotsForSale { get; set; }

        public virtual ICollection<Lot> LotsForBuy { get; set; }

        public Customer()
        {
            LotsForSale = new List<Lot>();
            LotsForBuy = new List<Lot>();
        }
    }
}

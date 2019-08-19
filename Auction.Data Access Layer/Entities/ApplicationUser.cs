using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace Auction.Data_Access_Layer.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public virtual ICollection<Lot> LotsForSale { get; set; }

        public virtual ICollection<Lot> LotsForBuy { get; set; }

        public ApplicationUser()
        {
            LotsForSale = new List<Lot>();
            LotsForBuy = new List<Lot>();
        }
    }
}

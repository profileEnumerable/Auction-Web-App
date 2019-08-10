using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Auction.Business_Logic_Layer.DTO
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<LotDto> LotsForSale { get; set; }

        public ICollection<LotDto> LotsForBuy { get; set; }

        public CustomerDto()
        {
            LotsForSale = new List<LotDto>();
            LotsForBuy = new List<LotDto>();
        }
    }
}

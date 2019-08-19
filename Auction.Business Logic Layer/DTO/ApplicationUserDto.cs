using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Auction.Business_Logic_Layer.DTO
{
    public class ApplicationUserDto
    {
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        public ICollection<LotDto> LotsForSale { get; set; }

        public ICollection<LotDto> LotsForBuy { get; set; }

        public ApplicationUserDto()
        {
            LotsForSale = new List<LotDto>();
            LotsForBuy = new List<LotDto>();
        }
    }
}

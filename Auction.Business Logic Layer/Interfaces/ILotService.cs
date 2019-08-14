using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auction.Business_Logic_Layer.DTO;

namespace Auction.Business_Logic_Layer.Interfaces
{
    public interface ILotService
    {
        IEnumerable<LotDto> GetLotsByPageNumber(int pageNum);
    }
}

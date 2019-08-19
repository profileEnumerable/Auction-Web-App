using Auction.Business_Logic_Layer.DTO;
using Auction.Business_Logic_Layer.Interfaces;
using Auction.Data_Access_Layer.Entities;
using Auction.Data_Access_Layer.Interfaces;
using Auction.Data_Access_Layer.Repositories;
using AutoMapper;
using System.Collections.Generic;

namespace Auction.Business_Logic_Layer.Services
{
    public class LotService : ILotService
    {
        private IUnitOfWork Database { get; }

        public LotService(IUnitOfWork database)
        {
            Database = database;
        }

        public IEnumerable<LotDto> GetLotsByPageNumber(int pageNum)
        {
            const int selectionLength = 9;//how many lots we can get for the requested page
            int startId = selectionLength * (pageNum - 1);
            int endId = startId + selectionLength;//set the and id of selection

            IEnumerable<Lot> lots = Database.Lots.Find(l => l.Id > startId && l.Id <= endId);

            IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<Lot, LotDto>()).CreateMapper();

            return mapper.Map<IEnumerable<Lot>, IEnumerable<LotDto>>(lots);
        }
    }
}

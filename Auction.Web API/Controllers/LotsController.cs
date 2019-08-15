using Auction.Business_Logic_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Auction.Business_Logic_Layer.DTO;

namespace Auction.Web_API.Controllers
{
    public class LotsController : ApiController
    {
        private readonly ILotService _lotService;

        public LotsController(ILotService lotService)
        {
            _lotService = lotService;
        }

        [HttpGet]
        public IHttpActionResult GetLotsSelection(int pageNumber)
        {
            IEnumerable<LotDto> lotsByPageNumber = _lotService.GetLotsByPageNumber(pageNumber);

            if (!lotsByPageNumber.Any())
            {
                return NotFound();
            }

            return Ok(lotsByPageNumber);
        }
    }
}

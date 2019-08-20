using Auction.Business_Logic_Layer.DTO;
using Auction.Data_Access_Layer.Entities;
using Auction.Data_Access_Layer.Entity_Framework;
using Auction.Web_API.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Http;

namespace Auction.Web_API.Controllers
{
    public class AccountController : ApiController
    {
        [Route("api/user/register")]
        [HttpPost]
        [AllowAnonymous]
        public IdentityResult Register(AccountModel model)
        {
            var store = new UserStore<ApplicationUser>(new AuctionContext()); //TODO: replace with DTO
            var manager = new UserManager<ApplicationUser>(store);

            var user = new ApplicationUser() { UserName = model.UserName, Email = model.Email };

            IdentityResult identityResult = manager.Create(user, model.Password);

            return identityResult;
        }

        [HttpGet]
        [Route("api/GetUserClaims")]
        public AccountModel GetUserClaims()
        {
            var userIdentity = (ClaimsIdentity)User.Identity;
            
            var accountModel = new AccountModel
            {
                UserName = userIdentity.FindFirst("Username").Value,
                Email = userIdentity.FindFirst("Email").Value,
                LoggedOn = userIdentity.FindFirst("LoggedOn").Value,
            };

            return accountModel;
        }
    }
}
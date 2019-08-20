using Auction.Data_Access_Layer.Entities;
using Auction.Data_Access_Layer.Entity_Framework;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace Auction.Web_API.Providers
{
    public class ApplicationOAuthProvider : OAuthAuthorizationServerProvider
    {
        //prevent the authenticate client device  
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {

            var store = new UserStore<ApplicationUser>(new AuctionContext()); //TODO: replace with DTO
            var manager = new UserManager<ApplicationUser>(store);

            ApplicationUser user = await manager.FindAsync(context.UserName, context.Password);

            if (user != null)
            {
                var claimsIdentity = new ClaimsIdentity(context.Options.AuthenticationType);

                claimsIdentity.AddClaim(new Claim("Username",user.UserName));
                claimsIdentity.AddClaim(new Claim("Email",user.Email));
                claimsIdentity.AddClaim(new Claim("LoggedOn",DateTime.Now.ToString(CultureInfo.CurrentCulture)));

                context.Validated(claimsIdentity);
            }
        }
    }
}
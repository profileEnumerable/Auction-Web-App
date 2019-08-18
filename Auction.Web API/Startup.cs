using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using Auction.Data_Access_Layer.Entity_Framework;

[assembly: OwinStartup(typeof(Auction.Web_API.Startup))]

namespace Auction.Web_API
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
         //app.CreatePerOwinContext(AuctionContext)   
        }
    }
}
 
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auction.Web_API.Models
{
    public class AccountModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string LoggedOn { get; set; }
    }
}
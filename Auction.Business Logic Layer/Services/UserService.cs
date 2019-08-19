using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auction.Data_Access_Layer.Entities;
using Auction.Data_Access_Layer.Entity_Framework;
using Auction.Data_Access_Layer.Interfaces;
using Auction.Data_Access_Layer.Repositories;

namespace Auction.Business_Logic_Layer.Services
{
    public class UserService
    {
        private IUnitOfWork _database;

        public UserService(IUnitOfWork database)
        {
            this._database = database;
        }

        public IEnumerable<ApplicationUser> GetAll()
        {
            return _database.Users.GetAll();
        }
    }
}

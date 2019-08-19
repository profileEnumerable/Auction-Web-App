using System.Collections.Generic;
using Auction.Data_Access_Layer.Entities;

namespace Auction.Data_Access_Layer.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<ApplicationUser> GetAll();
    }
}
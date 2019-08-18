using Auction.Data_Access_Layer.Entities;

namespace Auction.Data_Access_Layer.Interfaces
{
    public interface IUserRepository
    {
        void RegisterUser(ApplicationUser user);
    }
}
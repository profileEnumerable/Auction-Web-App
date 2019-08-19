using Auction.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Data_Access_Layer.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Lot> Lots { get; }
        IUserRepository Users { get; }
        void Save();
    }
}

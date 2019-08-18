using Auction.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auction.Data_Access_Layer.Identity_Managers;

namespace Auction.Data_Access_Layer.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Lot> Lots { get;  }
        ApplicationUserManager Users { get;  }
        void Save();
    }
}

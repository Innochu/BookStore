using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookParadise.Persistence.Repository.Interface
{
    public interface IUnitOfWork
    {
        IOrderRepository OrderRepo { get; }
        IAuthenticationRepository AuthRepo { get; }
        IBookRepository BookRepo { get; }
        Task SaveChangesAsync();
    }
}

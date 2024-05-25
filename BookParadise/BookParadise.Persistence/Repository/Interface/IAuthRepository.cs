using BookParadise.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookParadise.Persistence.Repository.Interface
{
    public interface IAuthRepository
    {
        Task<bool> AddUser(User user, string password);
        Task<User> GetUserByEmail(string email);
    }
}

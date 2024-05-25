using BookParadise.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookParadise.Persistence.Repository.Interface
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllBooksAsync();
        Task<Book> GetBookByIdAsync(string id);
        Task UpdateStockAsync(string bookId, int quantity);
    }
}

using BookParadise.Domain.Models;
using BookParadise.Persistence.DBContextFolder;
using BookParadise.Persistence.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace BookParadise.Persistence.Repository.ConcreteClass
{
    public class BookRepository : IBookRepository
    {
        private readonly BookParadiseDb _dbContext;
        public BookRepository(BookParadiseDb dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _dbContext.Books.ToListAsync();
        }

        public async Task<Book> GetBookByIdAsync(string id)
        {
            return await _dbContext.Books.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task UpdateStockAsync(string bookId, int quantity)
        {
            var book = await _dbContext.Books.FirstOrDefaultAsync(b => b.Id == bookId);
            if (book != null)
            {
                book.StockQuantity = quantity;
                await _dbContext.SaveChangesAsync();
            }
        }
    }


}

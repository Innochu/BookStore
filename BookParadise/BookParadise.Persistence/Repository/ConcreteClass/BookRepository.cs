using BookParadise.Domain.Models;
using BookParadise.Persistence.DBContextFolder;
using BookParadise.Persistence.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace BookParadise.Persistence.Repository.ConcreteClass
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        private readonly BookParadiseDb _dbContext;
        public BookRepository(BookParadiseDb dbContext) : base(dbContext) { }
     
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
            var book = await _dbContext.Books.FindAsync(bookId);

            if (book == null)
            {
                throw new Exception($"Book with ID '{bookId}' not found");
            }   

            
            await _dbContext.SaveChangesAsync();

        }


    }
}


    

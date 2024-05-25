using BookParadise.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookParadise.Persistence.DBContextFolder
{
    public class BookParadiseDb : IdentityDbContext<IdentityUser>
    {
        public BookParadiseDb(DbContextOptions<BookParadiseDb> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }

    }
}

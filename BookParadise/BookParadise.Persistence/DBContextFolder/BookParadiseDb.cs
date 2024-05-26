using BookParadise.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookParadise.Persistence.DBContextFolder
{
    public class BookParadiseDb : IdentityDbContext<User>
    {
        public BookParadiseDb(DbContextOptions<BookParadiseDb> options) : base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }
       public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure primary key for IdentityUserLogin
            modelBuilder.Entity<IdentityUserLogin<string>>().HasKey(p => new { p.LoginProvider, p.ProviderKey });

            // Seed initial data for User entity
            modelBuilder.Entity<Book>().HasData(
                 new Book
                 {
                     Title = "The Name of the Wind",
                     Description = "In a world shrouded in mystery, a young orphan named Kvothe enters a prestigious academy for magic users. There, he learns the mystical arts, confronts deadly enemies, and unravels an ancient secret.",
                     Content = "Content",
                     Author = "Patrick Rothfuss",
                     ISBN = "978-0765364560",
                     Publisher = "DAW Books",
                     PublishedDate = new DateTime(2007, 06, 26),
                     TotalPageCount = 624,
                     StockQuantity = 100
                 },
                      new Book
                      {
                          Title = "Mistborn: The Final Empire",
                          Description = "Ash falls from the sky in the empire of Luthadel, where a ruthless Lord Ruler has brooded for a thousand years. Vin, a young woman living a life of hardship, discovers her hidden power and joins a rebellion to overthrow the empire.",
                          Content = "Content",
                          Author = "Brandon Sanderson",
                          ISBN = "978-0765360946",
                          Publisher = "Tor Books",
                          PublishedDate = new DateTime(2006, 04, 18),
                          TotalPageCount = 672,
                          StockQuantity = 80
                      },

                      new Book
                      {
                          Title = "Project Hail Mary",
                          Description = "Ryland Grace wakes up disoriented on a spaceship with no memory of his past. As he pieces together his fragmented memories, he discovers he is on a one-way mission to a distant star system carrying a desperate hope for humanity.",
                          Content = "Content",
                          Author = "Andy Weir",
                          ISBN = "978-0593338491",
                          Publisher = "Ballantine Books",
                          PublishedDate = new DateTime(2021, 05, 04),
                          TotalPageCount = 464,
                          StockQuantity = 50
                      },
                      new Book
                      {
                          Title = "A Fire Upon the Deep",
                          Description = "In a universe divided by a vast barrier of faster-than-light travel, humanity finds itself on the losing side of a war with a technologically superior alien race. A young starship captain stumbles upon a hidden cache of ancient technology that could turn the tide.",
                          Content = "Content",
                          Author = "Vernor Vinge",
                          ISBN = "978-0345380977",
                          Publisher = "Baen Books",
                          PublishedDate = new DateTime(1992, 08, 01),
                          TotalPageCount = 624,
                          StockQuantity = 70
                      },

                      new Book
                      {
                          Title = "Murder on the Orient Express",
                          Description = "A luxurious train journey across Europe is disrupted by a murder.  Hercule Poirot, a renowned detective, must use his keen intellect to identify the killer among a group of suspicious passengers.",
                          Content = "Content",
                          Author = "Agatha Christie",
                          ISBN = "978-0061122731",
                          Publisher = "HarperCollins",
                          PublishedDate = new DateTime(1934, 01, 01),
                          TotalPageCount = 320,
                          StockQuantity = 90
                      },

                      new Book
                      {
                          Title = "The Martian",
                          Description = "After a mission gone wrong, astronaut Mark Watney finds himself stranded alone on Mars with limited supplies. He must utilize his ingenuity and determination to survive in the harsh environment while NASA tries to bring him home.",
                          Content = "Content",
                          Author = "Andy Weir",
                          ISBN = "978-0553418026",
                          Publisher = "Crown Publishing Group",
                          PublishedDate = new DateTime(2014, 02, 11),
                          TotalPageCount = 384,
                          StockQuantity = 60
                      },
new Book
{
    Title = "Dune",
    Description = "Set in a distant future where the universe is ruled by noble families, Dune tells the epic story of Paul Atreides, whose family accepts control of the desert planet Arrakis, the only source of the valuable spice melange.",
    Content = "Content",
    Author = "Frank Herbert",
    ISBN = "978-0441013593",
    Publisher = "Ace Books",
    PublishedDate = new DateTime(1965, 08, 01),
    TotalPageCount = 896,
    StockQuantity = 75
},
new Book
{
    Title = "The Hitchhiker's Guide to the Galaxy",
    Description = "Seconds before Earth is demolished to make way for a galactic freeway, Arthur Dent is plucked off the planet by his friend Ford Prefect, a researcher for the revised edition of The Hitchhiker's Guide to the Galaxy.",
    Content = "Content",
    Author = "Douglas Adams",
    ISBN = "978-0345391803",
    Publisher = "Del Rey Books",
    PublishedDate = new DateTime(1979, 10, 12),
    TotalPageCount = 216,
    StockQuantity = 85
},
new Book
{
    Title = "Ender's Game",
    Description = "In a future where Earth is under attack by an insectoid alien race, young Andrew 'Ender' Wiggin is recruited to join the elite Battle School, where he must undergo rigorous training to lead humanity's fight for survival.",
    Content = "Content",
    Author = "Orson Scott Card",
    ISBN = "978-0812550702",
    Publisher = "Tor Books",
    PublishedDate = new DateTime(1985, 01, 15),
    TotalPageCount = 324,
    StockQuantity = 70
},
new Book
{
    Title = "The Lord of the Rings",
    Description = "J.R.R. Tolkien's epic high-fantasy novel that chronicles the quest to destroy the One Ring and defeat the Dark Lord Sauron. A timeless tale of courage, friendship, and the struggle between good and evil.",
    Content = "Content",
    Author = "J.R.R. Tolkien",
    ISBN = "978-0618640157",
    Publisher = "Houghton Mifflin Harcourt",
    PublishedDate = new DateTime(1954, 07, 29),
    TotalPageCount = 1216,
    StockQuantity = 65
},
new Book
{
    Title = "The Handmaid's Tale",
    Description = "In a dystopian future, a woman is forced to live as a concubine under a fundamentalist theocratic dictatorship. The novel explores themes of subjugation, resistance, and the resilience of the human spirit.",
    Content = "Content",
    Author = "Margaret Atwood",
    ISBN = "978-0385490818",
    Publisher = "Anchor Books",
    PublishedDate = new DateTime(1985, 03, 16),
    TotalPageCount = 311,
    StockQuantity = 80
},
new Book
{
    Title = "The Giver",
    Description = "Jonas lives in a seemingly utopian society where all memories of the past are held by a single person called the Receiver. When Jonas is selected as the next Receiver, he uncovers the dark truth behind his community's perfect facade.",
    Content = "Content",
    Author = "Lois Lowry",
    ISBN = "978-0544336261",
    Publisher = "Houghton Mifflin Harcourt",
    PublishedDate = new DateTime(1993, 04, 26),
    TotalPageCount = 179,
    StockQuantity = 90
},
new Book
{
    Title = "The Picture of Dorian Gray",
    Description = "Dorian Gray, a young and handsome man, becomes obsessed with his own beauty and makes a fateful wish to remain youthful forever. As he indulges in a life of pleasure and sin, his portrait begins to age and reflect his corrupted soul.",
    Content = "Content",
    Author = "Oscar Wilde",
    ISBN = "978-0486278070",
    Publisher = "Dover Publications",
    PublishedDate = new DateTime(1890, 07, 01),
    TotalPageCount = 256,
    StockQuantity = 55
},
new Book
{
    Title = "The Unbearable Lightness of Being",
    Description = "Set in Prague during the 1968 Soviet invasion, the novel explores the lives of two couples and their complex relationships, intertwined with philosophical musings on love, life, and the human condition.",
    Content = "Content",
    Author = "Milan Kundera",
    ISBN = "978-0060932139",
    Publisher = "Harper Perennial",
    PublishedDate = new DateTime(1984, 04, 01),
    TotalPageCount = 320,
    StockQuantity = 45
},
new Book
{
    Title = "The Kite Runner",
    Description = "Khaled Hosseini's powerful novel about the bond between two boys in Afghanistan and the path of redemption. A gripping tale of friendship, betrayal, and the power of atonement.",
    Content = "Content",
    Author = "Khaled Hosseini",
    ISBN = "978-1594480003",
    Publisher = "Riverhead Books",
    PublishedDate = new DateTime(2003, 05, 29),
    TotalPageCount = 368,
    StockQuantity = 65
},
new Book
{
    Title = "The Shining",
    Description = "Jack Torrance, his wife, and their young son become the winter caretakers of the isolated Overlook Hotel. However, they soon discover the hotel's haunted past and Jack's own demons threaten to destroy them all.",
    Content = "Content",
    Author = "Stephen King",
    ISBN = "978-0385121675",
    Publisher = "Doubleday",
    PublishedDate = new DateTime(1977, 01, 28),
    TotalPageCount = 447,
    StockQuantity = 70
},
new Book
{
    Title = "The Count of Monte Cristo",
    Description = "After being wrongfully imprisoned for years, Edmond Dantès escapes and reinvents himself as the wealthy Count of Monte Cristo, determined to seek revenge against those who conspired against him.",
    Content = "Content",
    Author = "Alexandre Dumas",
    ISBN = "978-0140449264",
    Publisher = "Penguin Classics",
    PublishedDate = new DateTime(1844, 08, 18),
    TotalPageCount = 1312,
    StockQuantity = 60
},
new Book
{
    Title = "The Brothers Karamazov",
    Description = "Fyodor Dostoevsky's final novel explores the moral dilemmas and spiritual conflicts within a dysfunctional family, delving into themes of faith, reason, and the human psyche.",
    Content = "Content",
    Author = "Fyodor Dostoevsky",
    ISBN = "978-0140444421",
    Publisher = "Penguin Classics",
    PublishedDate = new DateTime(1880, 01, 01),
    TotalPageCount = 824,
    StockQuantity = 55
}
            );
        }
    }
}
    
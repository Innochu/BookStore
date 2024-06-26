﻿// <auto-generated />
using System;
using BookParadise.Persistence.DBContextFolder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookParadise.Persistence.Migrations
{
    [DbContext(typeof(BookParadiseDb))]
    [Migration("20240526024711_seed2")]
    partial class seed2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookParadise.Domain.Models.Book", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalPageCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = "360e7512-7e69-48e1-aea5-76a1bc5cc51a",
                            Author = "Patrick Rothfuss",
                            Content = "Content",
                            CreatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9252),
                            Description = "In a world shrouded in mystery, a young orphan named Kvothe enters a prestigious academy for magic users. There, he learns the mystical arts, confronts deadly enemies, and unravels an ancient secret.",
                            ISBN = "978-0765364560",
                            PublishedDate = new DateTime(2007, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "DAW Books",
                            StockQuantity = 100,
                            Title = "The Name of the Wind",
                            TotalPageCount = 624,
                            UpdatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9253)
                        },
                        new
                        {
                            Id = "1a066441-d7dc-4922-9894-33db677b869a",
                            Author = "Brandon Sanderson",
                            Content = "Content",
                            CreatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9271),
                            Description = "Ash falls from the sky in the empire of Luthadel, where a ruthless Lord Ruler has brooded for a thousand years. Vin, a young woman living a life of hardship, discovers her hidden power and joins a rebellion to overthrow the empire.",
                            ISBN = "978-0765360946",
                            PublishedDate = new DateTime(2006, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Tor Books",
                            StockQuantity = 80,
                            Title = "Mistborn: The Final Empire",
                            TotalPageCount = 672,
                            UpdatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9272)
                        },
                        new
                        {
                            Id = "05889be0-d9c9-41a7-b3e4-dcbc40d8005a",
                            Author = "Andy Weir",
                            Content = "Content",
                            CreatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9281),
                            Description = "Ryland Grace wakes up disoriented on a spaceship with no memory of his past. As he pieces together his fragmented memories, he discovers he is on a one-way mission to a distant star system carrying a desperate hope for humanity.",
                            ISBN = "978-0593338491",
                            PublishedDate = new DateTime(2021, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Ballantine Books",
                            StockQuantity = 50,
                            Title = "Project Hail Mary",
                            TotalPageCount = 464,
                            UpdatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9281)
                        },
                        new
                        {
                            Id = "398a19a5-76fa-4138-9e78-7b5e1f9d11e1",
                            Author = "Vernor Vinge",
                            Content = "Content",
                            CreatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9289),
                            Description = "In a universe divided by a vast barrier of faster-than-light travel, humanity finds itself on the losing side of a war with a technologically superior alien race. A young starship captain stumbles upon a hidden cache of ancient technology that could turn the tide.",
                            ISBN = "978-0345380977",
                            PublishedDate = new DateTime(1992, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Baen Books",
                            StockQuantity = 70,
                            Title = "A Fire Upon the Deep",
                            TotalPageCount = 624,
                            UpdatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9289)
                        },
                        new
                        {
                            Id = "7358bdc1-208c-4e47-8ca0-ecc9268d4b8f",
                            Author = "Agatha Christie",
                            Content = "Content",
                            CreatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9298),
                            Description = "A luxurious train journey across Europe is disrupted by a murder.  Hercule Poirot, a renowned detective, must use his keen intellect to identify the killer among a group of suspicious passengers.",
                            ISBN = "978-0061122731",
                            PublishedDate = new DateTime(1934, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "HarperCollins",
                            StockQuantity = 90,
                            Title = "Murder on the Orient Express",
                            TotalPageCount = 320,
                            UpdatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9299)
                        },
                        new
                        {
                            Id = "55a32825-d644-4862-9ad9-9c6920d354d4",
                            Author = "Andy Weir",
                            Content = "Content",
                            CreatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9306),
                            Description = "After a mission gone wrong, astronaut Mark Watney finds himself stranded alone on Mars with limited supplies. He must utilize his ingenuity and determination to survive in the harsh environment while NASA tries to bring him home.",
                            ISBN = "978-0553418026",
                            PublishedDate = new DateTime(2014, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Crown Publishing Group",
                            StockQuantity = 60,
                            Title = "The Martian",
                            TotalPageCount = 384,
                            UpdatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9307)
                        },
                        new
                        {
                            Id = "3d814777-f073-46ae-a6ed-e8389641a527",
                            Author = "Frank Herbert",
                            Content = "Content",
                            CreatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9314),
                            Description = "Set in a distant future where the universe is ruled by noble families, Dune tells the epic story of Paul Atreides, whose family accepts control of the desert planet Arrakis, the only source of the valuable spice melange.",
                            ISBN = "978-0441013593",
                            PublishedDate = new DateTime(1965, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Ace Books",
                            StockQuantity = 75,
                            Title = "Dune",
                            TotalPageCount = 896,
                            UpdatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9315)
                        },
                        new
                        {
                            Id = "5a812deb-d49c-473d-b18d-31961b344520",
                            Author = "Douglas Adams",
                            Content = "Content",
                            CreatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9322),
                            Description = "Seconds before Earth is demolished to make way for a galactic freeway, Arthur Dent is plucked off the planet by his friend Ford Prefect, a researcher for the revised edition of The Hitchhiker's Guide to the Galaxy.",
                            ISBN = "978-0345391803",
                            PublishedDate = new DateTime(1979, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Del Rey Books",
                            StockQuantity = 85,
                            Title = "The Hitchhiker's Guide to the Galaxy",
                            TotalPageCount = 216,
                            UpdatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9323)
                        },
                        new
                        {
                            Id = "516a33b5-efc0-4144-bb7c-5766e53db0a6",
                            Author = "Orson Scott Card",
                            Content = "Content",
                            CreatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9336),
                            Description = "In a future where Earth is under attack by an insectoid alien race, young Andrew 'Ender' Wiggin is recruited to join the elite Battle School, where he must undergo rigorous training to lead humanity's fight for survival.",
                            ISBN = "978-0812550702",
                            PublishedDate = new DateTime(1985, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Tor Books",
                            StockQuantity = 70,
                            Title = "Ender's Game",
                            TotalPageCount = 324,
                            UpdatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9337)
                        },
                        new
                        {
                            Id = "4f8a40c5-60a5-4553-97e3-aff9fef4bf20",
                            Author = "J.R.R. Tolkien",
                            Content = "Content",
                            CreatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9345),
                            Description = "J.R.R. Tolkien's epic high-fantasy novel that chronicles the quest to destroy the One Ring and defeat the Dark Lord Sauron. A timeless tale of courage, friendship, and the struggle between good and evil.",
                            ISBN = "978-0618640157",
                            PublishedDate = new DateTime(1954, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Houghton Mifflin Harcourt",
                            StockQuantity = 65,
                            Title = "The Lord of the Rings",
                            TotalPageCount = 1216,
                            UpdatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9345)
                        },
                        new
                        {
                            Id = "4712985a-a451-41d1-8a95-fc3b615a638f",
                            Author = "Margaret Atwood",
                            Content = "Content",
                            CreatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9355),
                            Description = "In a dystopian future, a woman is forced to live as a concubine under a fundamentalist theocratic dictatorship. The novel explores themes of subjugation, resistance, and the resilience of the human spirit.",
                            ISBN = "978-0385490818",
                            PublishedDate = new DateTime(1985, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Anchor Books",
                            StockQuantity = 80,
                            Title = "The Handmaid's Tale",
                            TotalPageCount = 311,
                            UpdatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9355)
                        },
                        new
                        {
                            Id = "28c28e1e-87bd-4334-a5a0-4626e126e8b0",
                            Author = "Lois Lowry",
                            Content = "Content",
                            CreatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9363),
                            Description = "Jonas lives in a seemingly utopian society where all memories of the past are held by a single person called the Receiver. When Jonas is selected as the next Receiver, he uncovers the dark truth behind his community's perfect facade.",
                            ISBN = "978-0544336261",
                            PublishedDate = new DateTime(1993, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Houghton Mifflin Harcourt",
                            StockQuantity = 90,
                            Title = "The Giver",
                            TotalPageCount = 179,
                            UpdatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9363)
                        },
                        new
                        {
                            Id = "28d39f97-30f5-4374-8923-bbffc676dc32",
                            Author = "Oscar Wilde",
                            Content = "Content",
                            CreatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9370),
                            Description = "Dorian Gray, a young and handsome man, becomes obsessed with his own beauty and makes a fateful wish to remain youthful forever. As he indulges in a life of pleasure and sin, his portrait begins to age and reflect his corrupted soul.",
                            ISBN = "978-0486278070",
                            PublishedDate = new DateTime(1890, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Dover Publications",
                            StockQuantity = 55,
                            Title = "The Picture of Dorian Gray",
                            TotalPageCount = 256,
                            UpdatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9371)
                        },
                        new
                        {
                            Id = "9763a1e3-559b-4eac-90c8-a2e5d85445ae",
                            Author = "Milan Kundera",
                            Content = "Content",
                            CreatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9379),
                            Description = "Set in Prague during the 1968 Soviet invasion, the novel explores the lives of two couples and their complex relationships, intertwined with philosophical musings on love, life, and the human condition.",
                            ISBN = "978-0060932139",
                            PublishedDate = new DateTime(1984, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Harper Perennial",
                            StockQuantity = 45,
                            Title = "The Unbearable Lightness of Being",
                            TotalPageCount = 320,
                            UpdatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9379)
                        },
                        new
                        {
                            Id = "08a224ba-baae-46b9-b01f-fe602b84b780",
                            Author = "Khaled Hosseini",
                            Content = "Content",
                            CreatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9387),
                            Description = "Khaled Hosseini's powerful novel about the bond between two boys in Afghanistan and the path of redemption. A gripping tale of friendship, betrayal, and the power of atonement.",
                            ISBN = "978-1594480003",
                            PublishedDate = new DateTime(2003, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Riverhead Books",
                            StockQuantity = 65,
                            Title = "The Kite Runner",
                            TotalPageCount = 368,
                            UpdatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9388)
                        },
                        new
                        {
                            Id = "afd47d8a-04fd-4bfb-a01d-e5b5b610d466",
                            Author = "Stephen King",
                            Content = "Content",
                            CreatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9396),
                            Description = "Jack Torrance, his wife, and their young son become the winter caretakers of the isolated Overlook Hotel. However, they soon discover the hotel's haunted past and Jack's own demons threaten to destroy them all.",
                            ISBN = "978-0385121675",
                            PublishedDate = new DateTime(1977, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Doubleday",
                            StockQuantity = 70,
                            Title = "The Shining",
                            TotalPageCount = 447,
                            UpdatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9397)
                        },
                        new
                        {
                            Id = "e4e5f78e-52d8-4a36-9e3b-fac929714dd0",
                            Author = "Alexandre Dumas",
                            Content = "Content",
                            CreatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9409),
                            Description = "After being wrongfully imprisoned for years, Edmond Dantès escapes and reinvents himself as the wealthy Count of Monte Cristo, determined to seek revenge against those who conspired against him.",
                            ISBN = "978-0140449264",
                            PublishedDate = new DateTime(1844, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Penguin Classics",
                            StockQuantity = 60,
                            Title = "The Count of Monte Cristo",
                            TotalPageCount = 1312,
                            UpdatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9410)
                        },
                        new
                        {
                            Id = "ae7fa62e-2602-4df6-a7ec-02fe74266ff7",
                            Author = "Fyodor Dostoevsky",
                            Content = "Content",
                            CreatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9418),
                            Description = "Fyodor Dostoevsky's final novel explores the moral dilemmas and spiritual conflicts within a dysfunctional family, delving into themes of faith, reason, and the human psyche.",
                            ISBN = "978-0140444421",
                            PublishedDate = new DateTime(1880, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Penguin Classics",
                            StockQuantity = 55,
                            Title = "The Brothers Karamazov",
                            TotalPageCount = 824,
                            UpdatedAt = new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9419)
                        });
                });

            modelBuilder.Entity("BookParadise.Domain.Models.Cart", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BookId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("BookParadise.Domain.Models.Order", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BookId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BookParadise.Domain.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BookParadise.Domain.Models.Cart", b =>
                {
                    b.HasOne("BookParadise.Domain.Models.Book", "Book")
                        .WithMany("Carts")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookParadise.Domain.Models.User", "User")
                        .WithOne("Cart")
                        .HasForeignKey("BookParadise.Domain.Models.Cart", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BookParadise.Domain.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BookParadise.Domain.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookParadise.Domain.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BookParadise.Domain.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookParadise.Domain.Models.Book", b =>
                {
                    b.Navigation("Carts");
                });

            modelBuilder.Entity("BookParadise.Domain.Models.User", b =>
                {
                    b.Navigation("Cart")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

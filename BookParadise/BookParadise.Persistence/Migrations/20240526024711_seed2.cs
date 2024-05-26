using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookParadise.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class seed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Content", "CreatedAt", "Description", "ISBN", "PublishedDate", "Publisher", "StockQuantity", "Title", "TotalPageCount", "UpdatedAt" },
                values: new object[,]
                {
                    { "05889be0-d9c9-41a7-b3e4-dcbc40d8005a", "Andy Weir", "Content", new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9281), "Ryland Grace wakes up disoriented on a spaceship with no memory of his past. As he pieces together his fragmented memories, he discovers he is on a one-way mission to a distant star system carrying a desperate hope for humanity.", "978-0593338491", new DateTime(2021, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ballantine Books", 50, "Project Hail Mary", 464, new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9281) },
                    { "08a224ba-baae-46b9-b01f-fe602b84b780", "Khaled Hosseini", "Content", new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9387), "Khaled Hosseini's powerful novel about the bond between two boys in Afghanistan and the path of redemption. A gripping tale of friendship, betrayal, and the power of atonement.", "978-1594480003", new DateTime(2003, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Riverhead Books", 65, "The Kite Runner", 368, new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9388) },
                    { "1a066441-d7dc-4922-9894-33db677b869a", "Brandon Sanderson", "Content", new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9271), "Ash falls from the sky in the empire of Luthadel, where a ruthless Lord Ruler has brooded for a thousand years. Vin, a young woman living a life of hardship, discovers her hidden power and joins a rebellion to overthrow the empire.", "978-0765360946", new DateTime(2006, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tor Books", 80, "Mistborn: The Final Empire", 672, new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9272) },
                    { "28c28e1e-87bd-4334-a5a0-4626e126e8b0", "Lois Lowry", "Content", new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9363), "Jonas lives in a seemingly utopian society where all memories of the past are held by a single person called the Receiver. When Jonas is selected as the next Receiver, he uncovers the dark truth behind his community's perfect facade.", "978-0544336261", new DateTime(1993, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Houghton Mifflin Harcourt", 90, "The Giver", 179, new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9363) },
                    { "28d39f97-30f5-4374-8923-bbffc676dc32", "Oscar Wilde", "Content", new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9370), "Dorian Gray, a young and handsome man, becomes obsessed with his own beauty and makes a fateful wish to remain youthful forever. As he indulges in a life of pleasure and sin, his portrait begins to age and reflect his corrupted soul.", "978-0486278070", new DateTime(1890, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dover Publications", 55, "The Picture of Dorian Gray", 256, new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9371) },
                    { "360e7512-7e69-48e1-aea5-76a1bc5cc51a", "Patrick Rothfuss", "Content", new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9252), "In a world shrouded in mystery, a young orphan named Kvothe enters a prestigious academy for magic users. There, he learns the mystical arts, confronts deadly enemies, and unravels an ancient secret.", "978-0765364560", new DateTime(2007, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "DAW Books", 100, "The Name of the Wind", 624, new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9253) },
                    { "398a19a5-76fa-4138-9e78-7b5e1f9d11e1", "Vernor Vinge", "Content", new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9289), "In a universe divided by a vast barrier of faster-than-light travel, humanity finds itself on the losing side of a war with a technologically superior alien race. A young starship captain stumbles upon a hidden cache of ancient technology that could turn the tide.", "978-0345380977", new DateTime(1992, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baen Books", 70, "A Fire Upon the Deep", 624, new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9289) },
                    { "3d814777-f073-46ae-a6ed-e8389641a527", "Frank Herbert", "Content", new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9314), "Set in a distant future where the universe is ruled by noble families, Dune tells the epic story of Paul Atreides, whose family accepts control of the desert planet Arrakis, the only source of the valuable spice melange.", "978-0441013593", new DateTime(1965, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ace Books", 75, "Dune", 896, new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9315) },
                    { "4712985a-a451-41d1-8a95-fc3b615a638f", "Margaret Atwood", "Content", new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9355), "In a dystopian future, a woman is forced to live as a concubine under a fundamentalist theocratic dictatorship. The novel explores themes of subjugation, resistance, and the resilience of the human spirit.", "978-0385490818", new DateTime(1985, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anchor Books", 80, "The Handmaid's Tale", 311, new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9355) },
                    { "4f8a40c5-60a5-4553-97e3-aff9fef4bf20", "J.R.R. Tolkien", "Content", new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9345), "J.R.R. Tolkien's epic high-fantasy novel that chronicles the quest to destroy the One Ring and defeat the Dark Lord Sauron. A timeless tale of courage, friendship, and the struggle between good and evil.", "978-0618640157", new DateTime(1954, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Houghton Mifflin Harcourt", 65, "The Lord of the Rings", 1216, new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9345) },
                    { "516a33b5-efc0-4144-bb7c-5766e53db0a6", "Orson Scott Card", "Content", new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9336), "In a future where Earth is under attack by an insectoid alien race, young Andrew 'Ender' Wiggin is recruited to join the elite Battle School, where he must undergo rigorous training to lead humanity's fight for survival.", "978-0812550702", new DateTime(1985, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tor Books", 70, "Ender's Game", 324, new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9337) },
                    { "55a32825-d644-4862-9ad9-9c6920d354d4", "Andy Weir", "Content", new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9306), "After a mission gone wrong, astronaut Mark Watney finds himself stranded alone on Mars with limited supplies. He must utilize his ingenuity and determination to survive in the harsh environment while NASA tries to bring him home.", "978-0553418026", new DateTime(2014, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crown Publishing Group", 60, "The Martian", 384, new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9307) },
                    { "5a812deb-d49c-473d-b18d-31961b344520", "Douglas Adams", "Content", new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9322), "Seconds before Earth is demolished to make way for a galactic freeway, Arthur Dent is plucked off the planet by his friend Ford Prefect, a researcher for the revised edition of The Hitchhiker's Guide to the Galaxy.", "978-0345391803", new DateTime(1979, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Del Rey Books", 85, "The Hitchhiker's Guide to the Galaxy", 216, new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9323) },
                    { "7358bdc1-208c-4e47-8ca0-ecc9268d4b8f", "Agatha Christie", "Content", new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9298), "A luxurious train journey across Europe is disrupted by a murder.  Hercule Poirot, a renowned detective, must use his keen intellect to identify the killer among a group of suspicious passengers.", "978-0061122731", new DateTime(1934, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HarperCollins", 90, "Murder on the Orient Express", 320, new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9299) },
                    { "9763a1e3-559b-4eac-90c8-a2e5d85445ae", "Milan Kundera", "Content", new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9379), "Set in Prague during the 1968 Soviet invasion, the novel explores the lives of two couples and their complex relationships, intertwined with philosophical musings on love, life, and the human condition.", "978-0060932139", new DateTime(1984, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harper Perennial", 45, "The Unbearable Lightness of Being", 320, new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9379) },
                    { "ae7fa62e-2602-4df6-a7ec-02fe74266ff7", "Fyodor Dostoevsky", "Content", new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9418), "Fyodor Dostoevsky's final novel explores the moral dilemmas and spiritual conflicts within a dysfunctional family, delving into themes of faith, reason, and the human psyche.", "978-0140444421", new DateTime(1880, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Penguin Classics", 55, "The Brothers Karamazov", 824, new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9419) },
                    { "afd47d8a-04fd-4bfb-a01d-e5b5b610d466", "Stephen King", "Content", new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9396), "Jack Torrance, his wife, and their young son become the winter caretakers of the isolated Overlook Hotel. However, they soon discover the hotel's haunted past and Jack's own demons threaten to destroy them all.", "978-0385121675", new DateTime(1977, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doubleday", 70, "The Shining", 447, new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9397) },
                    { "e4e5f78e-52d8-4a36-9e3b-fac929714dd0", "Alexandre Dumas", "Content", new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9409), "After being wrongfully imprisoned for years, Edmond Dantès escapes and reinvents himself as the wealthy Count of Monte Cristo, determined to seek revenge against those who conspired against him.", "978-0140449264", new DateTime(1844, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Penguin Classics", 60, "The Count of Monte Cristo", 1312, new DateTime(2024, 5, 26, 2, 47, 10, 887, DateTimeKind.Utc).AddTicks(9410) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "05889be0-d9c9-41a7-b3e4-dcbc40d8005a");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "08a224ba-baae-46b9-b01f-fe602b84b780");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "1a066441-d7dc-4922-9894-33db677b869a");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "28c28e1e-87bd-4334-a5a0-4626e126e8b0");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "28d39f97-30f5-4374-8923-bbffc676dc32");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "360e7512-7e69-48e1-aea5-76a1bc5cc51a");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "398a19a5-76fa-4138-9e78-7b5e1f9d11e1");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "3d814777-f073-46ae-a6ed-e8389641a527");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "4712985a-a451-41d1-8a95-fc3b615a638f");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "4f8a40c5-60a5-4553-97e3-aff9fef4bf20");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "516a33b5-efc0-4144-bb7c-5766e53db0a6");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "55a32825-d644-4862-9ad9-9c6920d354d4");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "5a812deb-d49c-473d-b18d-31961b344520");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "7358bdc1-208c-4e47-8ca0-ecc9268d4b8f");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9763a1e3-559b-4eac-90c8-a2e5d85445ae");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ae7fa62e-2602-4df6-a7ec-02fe74266ff7");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "afd47d8a-04fd-4bfb-a01d-e5b5b610d466");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "e4e5f78e-52d8-4a36-9e3b-fac929714dd0");
        }
    }
}

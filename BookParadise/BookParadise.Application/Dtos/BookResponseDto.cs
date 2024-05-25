using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookParadise.Application.Dtos
{
    public class BookResponseDto
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Publisher { get; set; }
        public DateTime PublishedDate { get; set; } = DateTime.UtcNow;
        public int TotalPageCount { get; set; }
        public int StockQuantity { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}

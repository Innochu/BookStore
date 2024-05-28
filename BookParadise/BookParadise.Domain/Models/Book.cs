using BookParadise.Domain.SharedEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookParadise.Domain.Models
{
    public class Book : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public string Publisher { get; set; }   = string.Empty; 
        public DateTime PublishedDate { get; set; } = DateTime.UtcNow;
        public int TotalPageCount { get; set; }
        public int StockQuantity { get; set; }
        public ICollection<Cart> Carts { get; set; } = new List<Cart>();        
    }
}

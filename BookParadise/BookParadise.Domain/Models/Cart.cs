using BookParadise.Domain.SharedEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookParadise.Domain.Models
{
    public class Cart : BaseEntity
    {
        public int Quantity { get; set; }
        [ForeignKey("Book")]
        public string BookId { get; set; } = Guid.NewGuid().ToString();
        public Book Book { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; } = Guid.NewGuid().ToString();
        public User User { get; set; } 
    }
}

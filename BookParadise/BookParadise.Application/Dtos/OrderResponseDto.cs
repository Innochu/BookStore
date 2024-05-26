using BookParadise.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookParadise.Application.Dtos
{
    public class OrderResponseDto
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public int Quantity { get; set; }
        [ForeignKey("BookId")]
        public string BookId { get; set; } = string.Empty;

        [ForeignKey("UserId")]
        public string UserId { get; set; } = string.Empty;
        public OrderStatus OrderStatus { get; set; }
    }
}

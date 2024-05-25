using BookParadise.Domain.Models;

namespace BookParadise.Persistence.Repository.Interface
{
    public interface IOrderRepository
    {
        Task<Order> PlaceOrderAsync(Order order);
        Task<Order> GetOrderByIdAsync(string orderId);
    }
}

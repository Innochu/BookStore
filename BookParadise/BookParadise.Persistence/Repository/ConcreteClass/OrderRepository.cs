using BookParadise.Domain.Models;
using BookParadise.Persistence.DBContextFolder;
using BookParadise.Persistence.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace BookParadise.Persistence.Repository.ConcreteClass
{
    public class OrderRepository : IOrderRepository
    {
        private readonly BookParadiseDb _dbContext;

        public OrderRepository(BookParadiseDb dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Order> PlaceOrderAsync(Order order)
        {
            _dbContext.Orders.Add(order);
            await _dbContext.SaveChangesAsync();
            return order;
        }

        public async Task<Order> GetOrderByIdAsync(string orderId)
        {
            return await _dbContext.Orders.FirstOrDefaultAsync(o => o.Id == orderId);
        }
    }
}

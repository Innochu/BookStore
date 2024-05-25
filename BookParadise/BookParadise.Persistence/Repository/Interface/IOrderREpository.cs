using BookParadise.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookParadise.Persistence.Repository.Interface
{
    public interface IOrderRepository
    {
        Task<Order> PlaceOrderAsync(Order order);
        //Task<Order> GetOrderByIdAsync(string orderId);
    }
}

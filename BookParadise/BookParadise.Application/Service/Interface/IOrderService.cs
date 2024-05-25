using BookParadise.Application.Dtos;
using HeightsBookHub.Domain.Entities.SharedEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookParadise.Application.Service.Interface
{
    public interface IOrderService
    {
        Task<ApiResponse<OrderResponseDto>> PlaceOrderAsync(OrderRequestDTO orderDTO);
        Task<ApiResponse<OrderResponseDto>> GetOrderByIdAsync(string orderId);
    }
}

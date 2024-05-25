using BookParadise.Application.Dtos;
using HeightsBookHub.Domain.Entities.SharedEntities;

namespace BookParadise.Application.Service.Interface
{
    public interface IOrderService
    {
        Task<ApiResponse<OrderResponseDto>> PlaceOrderAsync(OrderRequestDTO orderDTO);
        Task<ApiResponse<OrderResponseDto>> GetOrderByIdAsync(string orderId);
    }
}

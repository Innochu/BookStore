using BookParadise.Application.Dtos;
using BookParadise.Application.Service.Interface;
using BookParadise.Domain.Models;
using BookParadise.Persistence.Repository.Interface;
using HeightsBookHub.Domain.Entities.SharedEntities;

namespace BookParadise.Application.Service.ConcreteClass
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRabbitMQService _rabbitMQService;
        private readonly IIInventorymgt _iInventorymgt;

        public OrderService(IUnitOfWork unitOfWork, IRabbitMQService rabbitMQService, IIInventorymgt iInventorymgt)
        {
            _unitOfWork = unitOfWork;
            _rabbitMQService = rabbitMQService;
            _iInventorymgt = iInventorymgt;
        }
        public async Task<ApiResponse<OrderResponseDto>> PlaceOrderAsync(OrderRequestDTO orderDTO)
        {
            try
            {
                var order = new Order
                {
                    UserId = orderDTO.UserId,
                    BookId = orderDTO.BookId,
                    Quantity = orderDTO.Quantity,
                    OrderStatus = orderDTO.OrderStatus, 
                };

                var placedOrder = await _unitOfWork.OrderRepo.PlaceOrderAsync(order);
               
                var placedOrderDTO = new OrderResponseDto
                {
                    Id = placedOrder.Id,
                    UserId = placedOrder.UserId, 
                    BookId = placedOrder.BookId,
                    Quantity = placedOrder.Quantity,
                    OrderStatus = placedOrder.OrderStatus,
                };
                _rabbitMQService.SendMessage("orders", $"OrderProcessed: {placedOrder.Id}");
                  _rabbitMQService.ReceiveMessage("orders",messageHandler);
               await _iInventorymgt.UpdateInventoryLevelAsync(placedOrder.Id);

                return ApiResponse<OrderResponseDto>.Success(placedOrderDTO, "Order placed successfully", 200);
            }
            catch (Exception ex)
            {
                return ApiResponse<OrderResponseDto>.Failed(false, ex.Message, 500, new List<string> { ex.StackTrace });
            }
        }
        private void messageHandler(string message)
        {
            Console.WriteLine($"Received message: {message}");

        }
        public async Task<ApiResponse<OrderResponseDto>> GetOrderByIdAsync(string orderId)
        {
            try
            {
                var order = await _unitOfWork.OrderRepo.GetOrderByIdAsync(orderId);

                if (order == null)
                    return ApiResponse<OrderResponseDto>.Failed(false, "Order not found", 404, new List<string> { "Order not found" });

                var orderDTO = new OrderResponseDto
                {
                    Id = order.Id,
                    UserId = order.UserId,
                    BookId = order.BookId,
                    Quantity = order.Quantity,
                    OrderStatus = order.OrderStatus,
                };

                return ApiResponse<OrderResponseDto>.Success(orderDTO, "Order retrieved successfully", 200);
            }
            catch (Exception ex)
            {
                return ApiResponse<OrderResponseDto>.Failed(false, ex.Message, 500, new List<string> { ex.StackTrace });
            }
        }
    }
}

using BookParadise.Application.Dtos;
using BookParadise.Application.Service.Interface;
using BookParadise.Domain.Models;
using BookParadise.Persistence.Repository.Interface;
using HeightsBookHub.Domain.Entities.SharedEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookParadise.Application.Service.ConcreteClass
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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
              //  _rabbitMQService.SendMessage("InventoryQueue", $"OrderProcessed: {placedOrder.Id}");

                return ApiResponse<OrderResponseDto>.Success(placedOrderDTO, "Order placed successfully", 200);
            }
            catch (Exception ex)
            {
                return ApiResponse<OrderResponseDto>.Failed(false, ex.Message, 500, new List<string> { ex.StackTrace });
            }
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

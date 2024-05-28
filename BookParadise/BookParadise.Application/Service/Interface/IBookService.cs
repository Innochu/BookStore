using BookParadise.Application.Dtos;
using BookParadise.Common;
using HeightsBookHub.Domain.Entities.SharedEntities;

namespace BookParadise.Application.Service.Interface
{
    public interface IBookService
    {
        Task<ApiResponse<IEnumerable<BookResponseDto>>> GetAllBooksAsync();
        Task<ApiResponse<BookResponseDto>> GetBookByIdAsync(string bookId);
        Task<ApiResponse<string>> UpdateBookStockAsync(string bookId, int newStockQuantity);
    }
}

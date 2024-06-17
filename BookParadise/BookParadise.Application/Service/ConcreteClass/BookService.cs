using BookParadise.Application.Dtos;
using BookParadise.Application.Service.Interface;
using BookParadise.Common;
using BookParadise.Domain.Models;
using BookParadise.Persistence.Repository.Interface;
using HeightsBookHub.Domain.Entities.SharedEntities;

namespace BookParadise.Application.Service.ConcreteClass
{
    public class BookService : IBookService
    {
            
        private readonly IUnitOfWork _unitOfWork;

        public BookService(IUnitOfWork unitOfWork)
            {
              
            _unitOfWork = unitOfWork;
        }

        public async Task<ApiResponse<PageResult<IEnumerable<BookResponseDto>>>> GetAllBooksAsync(int page, int perPage)
        {
            try
            {
                var allBooks = await _unitOfWork.BookRepo.GetAllBooksAsync();
                var pagedBooks = await Pagination<Book>.GetPager(allBooks, perPage, page, b => b.Title);


                var bookDtoList = allBooks.Select(book => new BookResponseDto
                {
                    Id = book.Id,
                    Title = book.Title,
                    Description = book.Description,
                    Content = book.Content, // Consider security implications of including full content
                    Author = book.Author,
                    ISBN = book.ISBN,
                    Publisher = book.Publisher,
                    PublishedDate = book.PublishedDate,
                    TotalPageCount = book.TotalPageCount,
                    StockQuantity = book.StockQuantity,
                    CreatedAt = book.CreatedAt,
                    UpdatedAt = book.UpdatedAt
                }).ToList();

                var pagedBookDto = new PageResult<IEnumerable<BookResponseDto>>
                {
                    Data = bookDtoList,
                    TotalPageCount = pagedBooks.TotalPageCount,
                    CurrentPage = pagedBooks.CurrentPage,
                    PerPage = pagedBooks.PerPage,
                    TotalCount = pagedBooks.TotalCount
                };

                return ApiResponse<PageResult<IEnumerable<BookResponseDto>>>.Success(pagedBookDto, "Books retrieved successfully", 200);
            }
            catch (Exception ex)
            {
                return ApiResponse<PageResult<IEnumerable<BookResponseDto>>>.Failed(false, ex.Message, 500, new List<string> { ex.StackTrace });
            }
        }


        public async Task<ApiResponse<BookResponseDto>> GetBookByIdAsync(string bookId)
            {
                try
                {
                    var book = await _unitOfWork.BookRepo.GetBookByIdAsync(bookId);

                    if (book == null)
                        return ApiResponse<BookResponseDto>.Failed(false, "Book not found", 404, new List<string> { "Book not found" });

                    var bookDto = new BookResponseDto
                    {
                        Id = book.Id,
                        Title = book.Title,
                        Description = book.Description,
                        Content = book.Content,
                        Author = book.Author,
                        ISBN = book.ISBN,
                        Publisher = book.Publisher,
                        PublishedDate = book.PublishedDate,
                        TotalPageCount = book.TotalPageCount,
                        StockQuantity = book.StockQuantity,
                        CreatedAt = book.CreatedAt,
                        UpdatedAt = book.UpdatedAt
                    };

                    return ApiResponse<BookResponseDto>.Success(bookDto, "Book retrieved successfully", 200);
                }
                catch (Exception ex)
                {
                    return ApiResponse<BookResponseDto>.Failed(false, ex.Message, 500, new List<string> { ex.StackTrace });
                }
            }

            public async Task<ApiResponse<string>> UpdateBookStockAsync(string bookId, int newStockQuantity)
            {
                try
                {
                    await _unitOfWork.BookRepo.UpdateStockAsync(bookId, newStockQuantity);
                    return ApiResponse<string>.Success("Stock quantity updated successfully", "Stock quantity updated successfully", 200);
                }
                catch (Exception ex)
                {
                    return ApiResponse<string>.Failed(false, ex.Message, 500, new List<string> { ex.StackTrace });
                }
            }
        }
    }


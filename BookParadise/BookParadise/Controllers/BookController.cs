using BookParadise.Application.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BookParadise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllBooks()
        {
            var result = await _bookService.GetAllBooksAsync();
            return Ok(result);
        }


        [HttpGet("{bookId}")]
        public async Task<ActionResult> GetBookById(string bookId)
        {
            var result = await _bookService.GetBookByIdAsync(bookId);
            return Ok(result);
        }

        [HttpPut("{bookId}/updateStock")]
        public async Task<ActionResult> UpdateBookStock(string bookId, [FromBody] int newStockQuantity)
        {
            var result = await _bookService.UpdateBookStockAsync(bookId, newStockQuantity);
            return Ok(result);
        }
    }
}

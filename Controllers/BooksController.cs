using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_books.Data.Services;
using my_books.Data.ViewModels;

namespace my_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksService _booksService;
        public BooksController(BooksService booksService)
        {
            _booksService = booksService;
        }

        [HttpPost("add-book")]
        public IActionResult AddBook([FromBody]BookVM book)
        {
            _booksService.AddBook(book);
            return Ok();
        }

        [HttpGet("get-all-books")]
        public IActionResult getAllBooks()
        {
            var books = _booksService.getAllBooks();
            return Ok(books);
        }

        [HttpGet("get-book-by-id/{id}")]
        public IActionResult getBookById(int id)
        {
            var singleBook = _booksService.GetBookById(id);
            return Ok(singleBook);
        }

        [HttpPut("update-book-by-id/{id}")]
        public IActionResult UpdateBookById(int id, [FromBody]BookVM book)
        {
            var updatedBook = _booksService.updateBookById(id, book);
            return Ok(updatedBook); 
        }
        [HttpDelete("delete-book-id/{id}")]
        public IActionResult deleteBookById(int id)
        {
            _booksService.deleteBookById(id);
            return Ok();
        }
    }
}

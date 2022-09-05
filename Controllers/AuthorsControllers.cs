using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_books.Data.Services;
using my_books.Data.ViewModels;

namespace my_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsControllers : ControllerBase
    {
        private AuthorsService _authorsService;
        public AuthorsControllers(AuthorsService authorsService)
        {
            _authorsService = authorsService;
        }
        [HttpPost("add-author")]
        public IActionResult addAuthor([FromBody] AuthorMV author)
        {
            _authorsService.AddAuthor(author);
            return Ok();
        }
    }
}

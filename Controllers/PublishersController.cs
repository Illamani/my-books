using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_books.Data.Services;
using my_books.Data.ViewModels;

namespace my_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private PublishersService _publishersService;
        public PublishersController(PublishersService publishersService)
        {
            _publishersService = publishersService; 
        }
        [HttpPost("add-publisher")]
        public IActionResult addBook([FromBody] PublisherVM publisher)
        {
            _publishersService.addPublisher(publisher);
            return Ok();
        }
    }
}

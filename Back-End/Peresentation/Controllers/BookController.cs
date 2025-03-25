using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;



namespace Peresentation.Controllers
{
    [Route("api/{controller}")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpGet("FindBook/{bookId}")]
        public IActionResult FindBook(int bookId)
        {
            
        }

    }
}
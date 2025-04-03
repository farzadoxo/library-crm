using Application.DTOs.Book;
using Application.Interfaces.Service;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Iana;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;



namespace Peresentation.Controllers
{
    [Route("api/{controller}")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _service;
        public BookController(IBookService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("getall/{take}/{skip}")]
        public IActionResult GetAllBook(int take,int skip)
        {
            var books = _service.GetBooks(take,skip);
            return Ok(books);
        }

        [HttpGet]
        [Route("find/{id}")]
        public IActionResult FindBook(int id)
        {
            var result = _service.FindBook(id);
            return Ok(result);
        }

        [HttpGet]
        [Route("findbyauther/{id}")]
        public IActionResult FindBookByAuther(int id)
        {
            var result = _service.FindBooksByAuther(id);
            return Ok(result);
        }

        [HttpGet]
        [Route("findbytopic/{id}")]
        public IActionResult FindBookByTopic(int id)
        {
            var result = _service.FindBooksByTopic(id);
            return Ok(result);
        }

        [HttpGet]
        [Route("findbypublisher/{id}")]
        public IActionResult FindBookByPublisher(int id)
        {
            var result = _service.FindBooksByPublisher(id);
            return Ok(result);
        }


        [HttpPost]
        [Route("addbook")]
        public IActionResult AddBook(AddBookDTO dto)
        {
            var result = _service.AddBook(dto);
            return Ok(result);
        }

        [HttpDelete]
        [Route("deletebook/{id}")]
        public IActionResult DeleteBook(int id)
        {
            var result = _service.DeleteBook(id);
            return BadRequest(result);
        }


        [HttpPut]
        [Route("updatebook/{id}")]
        public IActionResult UpdateBook(int id , UpdateBookDTO dto)
        {
            var result = _service.UpdateBook(id , dto);
            return Ok(result);
        }

        [HttpPut]
        [Route("deactivatebook/{id}")]
        public IActionResult DeactivateBook(int id)
        {
            var result = _service.DeactiveBook(id);
            return Ok(result);
        }

        [HttpPut]
        [Route("activatebook/{id}")]
        public IActionResult ActivateBook(int id)
        {
            var result = _service.ActiveBook(id);
            return Ok(result);
        }
        
    }
}   
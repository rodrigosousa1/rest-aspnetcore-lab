using Microsoft.AspNetCore.Mvc;
using RestAspNetCoreLab.Model;
using RestAspNetCoreLab.Services;

namespace RestAspNetCoreLab.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_bookService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var book = _bookService.FindById(id);
            if (book == null) return NotFound();
            return Ok(book);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Book book)
        {
            if (book == null) return BadRequest();
            return new ObjectResult(_bookService.Create(book));
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody]Book book)
        {
            if (book == null) return BadRequest();
            var updatedBook = _bookService.Update(book);
            if (updatedBook == null) return BadRequest();
            return new ObjectResult(updatedBook);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _bookService.Delete(id);
            return NoContent();
        }

    }
}


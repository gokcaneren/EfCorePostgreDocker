using EfCorePostgreDocker.API.DataAccess.Repositories.Abstract;
using EfCorePostgreDocker.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EfCorePostgreDocker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        [Route("GetBooks")]
        public IActionResult GetAll()
        {
            List<Book> books = _bookRepository.GetAll();

            return Ok(books);
        }

        [HttpGet]
        [Route("GetBook")]
        public IActionResult Get(int id)
        {
            Book? book = _bookRepository.Get(id);

            if (book == null) return NotFound();

            return Ok(book);
        }

        [HttpPut]
        [Route("UpdateBook")]
        public IActionResult Update(Book book)
        {
            _bookRepository.Update(book);
            return Ok();
        }

        [HttpPost]
        [Route("AddBook")]
        public IActionResult Save(Book book)
        {
            Book newBook = _bookRepository.Add(book);
            return Ok(newBook);
        }

        [HttpDelete]
        [Route("RemoveBook")]
        public IActionResult Remove(int id)
        {
            _bookRepository.Delete(id);
            return Ok();
        }


    }
}

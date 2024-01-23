using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReposatryPatternWithUOW.Core;
using ReposatryPatternWithUOW.Core.Models;

namespace ReposatryPatternWithUOW.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IUnitOfWork _unitofwork;

        public BooksController(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        [HttpGet]
        public IActionResult GetById()
        {
            return Ok(_unitofwork.Books.GetById(1));
        }
        [HttpGet("GetByName")]
        public IActionResult GetByName()
        {
            return Ok(_unitofwork.Books.Find(p => p.Title == "book2", new[] { "Author" }));
        }
        [HttpGet("GetAllWithAuthors")]
        public IActionResult GetAll()
        {
            return Ok(_unitofwork.Books.FindAll(p => p.Title.Contains("book"), new[] { "Author" }));
        }
        [HttpGet("GetOrder")]
        public IActionResult GetOrder()
        {
            return Ok(_unitofwork.Books.FindAll(p => p.Title.Contains("book"), null, null, b => b.Title));
        }
        [HttpPost("AddOne")]
        public IActionResult AddOne()
        {
            var book = _unitofwork.Books.Add(new Book { Title = "Book8", AuthorId = 4 });
            _unitofwork.Complete();
                
            return Ok(book);
        }
      
    }
}

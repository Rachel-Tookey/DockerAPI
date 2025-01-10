using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DockerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
       
        [HttpGet]
        public IActionResult GetBooks()
        {
            var json = System.IO.File.ReadAllText("./Controllers/books.json");
            var books = JsonSerializer.Deserialize<List<Book>>(json);
            return Ok(books); 
        }
        [HttpGet("{id}")]
        public IActionResult GetBooks(int id)
        {
            var json = System.IO.File.ReadAllText("./Controllers/books.json");
            var books = JsonSerializer.Deserialize<List<Book>>(json);
            var book1 = books.Find(x => x.Id == id);
            return Ok(book1);
        }
    }
}

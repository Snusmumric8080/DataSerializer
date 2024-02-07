using Microsoft.AspNetCore.Mvc;

namespace DataSerializer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentService _bookService;
        public DocumentController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BookReadDto>> GetBooks()
        {
            var result = _bookService.GetBooks();
            return Ok(result);
        }

        [HttpPost]
        public ActionResult<BookReadDto> CreateBook(BookCreateDto bookCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdBook = _bookService.CreateBook(bookCreateDto);
            return CreatedAtAction(nameof(GetBookByGuid), new { guid = createdBook.Guid }, createdBook);
        }

        [HttpGet("{id}")]
        public ActionResult<BookReadDto> GetBookById(int id)
        {
            var result = _bookService.GetBookById(id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet("get/{guid}")]
        public ActionResult<BookReadDto> GetBookByGuid(Guid guid)
        {
            var result = _bookService.GetBookByGuid(guid);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPut("update/{guid}")]
        public IActionResult UpdateBook(Guid guid, BookUpdateDto updatedBook)
        {
            _bookService.UpdateBook(guid, updatedBook);
            return NoContent();
        }

        [HttpDelete("del/{guid}")]
        public IActionResult DeleteBook(Guid guid)
        {
            _bookService.DeleteBook(guid);
            return NoContent();
        }
    }
}

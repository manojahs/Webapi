using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Webapi.Model;
using Webapi.Repository;

namespace Webapi.Controllers
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

        [HttpGet("")]
        public async Task<IActionResult> GetAllResult()
        
        {
            var v = await _bookRepository.GetAllBooksAsync();
            return Ok(v);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllResult([FromRoute]int id)

        {
            var v = await _bookRepository.GetSingleBooksAsync(id);
            if(v==null)
            {
                return NotFound();
            }    
            return Ok(v);
        } 
        
        [HttpPost("")]
        public async Task<IActionResult> AddAllResult([FromBody]BookModel bookModel)

        {
            var s = await _bookRepository.GetAddBooksAsync(bookModel);

            return CreatedAtAction(nameof(GetAllResult),new { s=s,Controller="book"},s);
        } 

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAllResult([FromRoute]int id ,[FromBody]BookModel bookModel)

        {
            await _bookRepository.AddBooksAsync(id,bookModel);
            return Ok();
        } 
        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateSingleResult([FromRoute]int id ,[FromBody] JsonPatchDocument bookModel)

        {
            await _bookRepository.PatchBooksAsync(id,bookModel);
            return Ok();
        }  
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleResult([FromRoute]int id )

        {
            await _bookRepository.DeleteBooksAsync(id);
            return Ok();
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using REST_API.Dtos;
using System.Diagnostics;

namespace REST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private readonly ApplicationDbContext _appDbContext;
        public BookController(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        
        [HttpGet(Name = "GetBooks")]
        [Authorize]
        public async Task<IActionResult> Get(int page = 1 , int pageSize = 10)
        {

            var stopWatch = new Stopwatch();
            stopWatch.Start();

            var listBooks = await _appDbContext.Books
                .AsNoTracking() // for performance optimization / disables the tracking of changes for read only query
                .OrderBy(b=> b.Id)
                .Skip((page - 1) * pageSize) // pagination concept
                .Take(pageSize)
                .Select(b=> new {b.Id ,  b.Name, b.Description , b.Price , b.AuthorName})
                .ToListAsync();


            stopWatch.Stop();
            Console.WriteLine($"Tracking query took {stopWatch.ElapsedMilliseconds} ms");

            return Ok(listBooks);
        }


        [HttpPost(Name = "AddBook")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Add([FromBody] AddBookReq obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }


            var NewBook = new Book
            {
                Description = obj.Description,
                AuthorName = obj.AuthorName,
                Price = obj.Price,
                Name = obj.Name,

            };

            await _appDbContext.AddAsync(NewBook);
            await _appDbContext.SaveChangesAsync();

            return Ok(NewBook);
        }



        [HttpDelete("{Id}" , Name = "DeleteBook")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int Id)
        {
          

            var BookToBeRemoved = await _appDbContext.Books.FindAsync(Id);

            if (BookToBeRemoved == null)
            {
                return NotFound();
            }

             _appDbContext.Books.Remove(BookToBeRemoved);
              await _appDbContext.SaveChangesAsync();

            return Ok(BookToBeRemoved);
        }


        [HttpPatch("{id}" , Name = "UpdateBook")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(int id , [FromBody] AddBookReq obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var UpdateBookobj = await _appDbContext.Books.FindAsync(id);

            if(UpdateBookobj == null)
            {
                return NotFound();
            }

            UpdateBookobj.AuthorName = obj.AuthorName;
            UpdateBookobj.Description = obj.Description;
            UpdateBookobj.Name = obj.Name;
            UpdateBookobj.Price = obj.Price;


            await _appDbContext.SaveChangesAsync();


            return Ok(UpdateBookobj);
        }


    }
}

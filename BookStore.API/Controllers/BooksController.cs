using AutoMapper;
using BookStore.API.Contracts;
using BookStore.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBooksService _booksService;
        private readonly IMapper _mapper;

        public BooksController(IBooksService booksService, IMapper mapper)
        {
            _booksService = booksService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var books = await _booksService.Get();

            var response = _mapper.Map<Domain.Book[], GetBookResponse[]>(books);

            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _booksService.Delete(id);

            if (response == 0)
            {
                return BadRequest();
            }

            return Ok(response);
        }
    }
}
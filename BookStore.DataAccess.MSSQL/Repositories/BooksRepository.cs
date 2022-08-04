using AutoMapper;
using BookStore.DataAccess.MSSQL.Entites;
using BookStore.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DataAccess.MSSQL.Repositories
{
    public class BooksRepository : IBooksRepository
    {
        private readonly BookStoreDbContext _context;

        private readonly IMapper _mapper;

        public BooksRepository(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Domain.Book[]> Get()
        {
            var booksEntity = await _context.Books
                .AsNoTracking()
                .ToArrayAsync();

            var books = _mapper.Map<Book[], Domain.Book[]>(booksEntity);
            return books;
        }

        public async Task<int> Delete(int id)
        {
            var bookToDelete = await _context.Books
                .AsNoTracking()
                .FirstOrDefaultAsync(b => b.Id == id);

            if (bookToDelete == null)
            {
                return 0;
            }

            _context.Books.Remove(bookToDelete);
            await _context.SaveChangesAsync();

            return bookToDelete.Id;
        }
    }
}

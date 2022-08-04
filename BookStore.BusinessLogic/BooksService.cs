using BookStore.Domain;
using BookStore.Domain.Interfaces;

namespace BookStore.BusinessLogic
{
    public class BooksService : IBooksService
    {
        private readonly IBooksRepository _booksRepository;

        public BooksService(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }

        public async Task<Book[]> Get()
        {
            return await _booksRepository.Get();
        }

        public async Task<int> Delete(int id)
        {
            return await _booksRepository.Delete(id);
        }
    }
}
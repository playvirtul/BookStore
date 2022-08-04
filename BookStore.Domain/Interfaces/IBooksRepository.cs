using BookStore.Domain;

namespace BookStore.Domain.Interfaces
{
    public interface IBooksRepository
    {
        Task<Book[]> Get();

        Task<int> Delete(int id);
    }
}
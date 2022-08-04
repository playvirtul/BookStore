using BookStore.Domain;

namespace BookStore.Domain.Interfaces
{
    public interface IBooksService
    {
        Task<Book[]> Get();

        Task<int> Delete(int id);
    }
}
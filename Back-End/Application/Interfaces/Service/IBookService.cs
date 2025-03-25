using Application.Common;
using Domain.Entities;

namespace Application.Interfaces.Service
{
    public interface IBookService
    {
        Task<List<Book>> GetBooks(int take, int skip);
        Task<BookOprationResult> FindBook(int bookId);

    }
}
using Application.Common;
using Application.DTOs.Book;
using Domain.Entities;

namespace Application.Interfaces.Service
{
    public interface IBookService
    {
        Task<List<Book>> GetBooks(int take, int skip);
        Task<BookOprationResult> FindBook(int bookId);
        Task<IQueryable> FindBooksByAuther(int autherId);
        Task<IQueryable> FindBooksByTopic(int topicId);
        Task<IQueryable> FindBooksByPublisher(int publisherId);
        Task<BookOprationResult> AddBook(AddBookDTO dto);
        Task<BookOprationResult> UpdateBook(int bookId, UpdateBookDTO dto);
        Task<BookOprationResult> DeleteBook(int bookId);
        Task<BookOprationResult> DeactiveBook(int bookId);
        Task<BookOprationResult> ActiveBook(int bookId);

    }
}
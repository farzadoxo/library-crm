using Application.DTOs.Book;
using Domain.Entities;

namespace Application.Interfaces.Repository
{
    public interface IBookRepository
    {
        // Find Book
        Book FindBook(int bookId);
        IQueryable FindBooksByAuther(int autherId);
        IQueryable FindBooksByTopic(int topicId);
        IQueryable FindBooksByPublisher(int publisherId);

        // CRUD Book
        Book Add(AddBookDTO dto);
        void Delete(int bookId);
        void Update(int bookID,UpdateBookDTO dto);

        // Oprator
        void DeactiveBook(int bookId);
        

    }
}
using Application.DTOs.Book;
using Domain.Entities;

namespace Application.Interfaces.Repository
{
    public interface IBookRepository
    {
        // Find Book
        Book FindBook(int bookId);

        // CRUD Book
        Book Add(AddBookDTO dto);
        void Delete(int bookId);
        Book Update(int bookID,UpdateBookDTO dto);

        // Oprator
        void DeactiveBook(int bookId);
        

    }
}
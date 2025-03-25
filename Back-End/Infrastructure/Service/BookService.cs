using Application.Common;
using Application.Interfaces.Repository;
using Application.Interfaces.Service;
using Domain.Entities;

namespace Infrastructure.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repo;
        public BookService(IBookRepository repo)
        {
            _repo = repo;
        }
        public async Task<BookOprationResult> FindBook(int bookId)
        {
            var book = _repo.FindBook(bookId);
            if(book != null)
            {
                return BookOprationResult.Success(message:"Book reached successfully !",request:book);
            }
            else
            {
                return BookOprationResult.Failure("somthing went wrong");
            }
        }


        public async Task<List<Book>> GetBooks(int take , int skip)
        {
            var books = _repo.GetBooks(skip:skip,take:take);
            return books;
        }
    }
}
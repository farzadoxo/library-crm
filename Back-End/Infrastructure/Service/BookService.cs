using Application.Common;
using Application.DTOs.Book;
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
        public async Task<IQueryable> FindBooksByAuther(int autherId)
        {
            var books = _repo.FindBooksByAuther(autherId);
            return books;
        }
        public async Task<IQueryable> FindBooksByTopic(int topicId)
        {
            var books = _repo.FindBooksByTopic(topicId);
            return books;
        }
        public async Task<IQueryable> FindBooksByPublisher(int publisherId)
        {
            var books = _repo.FindBooksByPublisher(publisherId);
            return books;
        }
        public async Task<BookOprationResult> AddBook(AddBookDTO dto)
        {
            var book = _repo.Add(dto);
            if(book != null)
            {
                return BookOprationResult.Success(message:"Book added successfully !",request:book);
            }
            else
            {
                return BookOprationResult.Failure("somthing went wrong");
            }
        }
        public async Task<BookOprationResult> DeleteBook(int bookId)
        {
            var book = _repo.FindBook(bookId);
            if(book != null)
            {
                _repo.Delete(bookId);
                return BookOprationResult.Success(message:"Book deleted successfully !",request:book);
            }
            else
            {
                return BookOprationResult.Failure("somthing went wrong");
            }
        }

        public async Task<BookOprationResult> DeactiveBook(int bookId)
        {
            var book = _repo.FindBook(bookId);
            if(book != null)
            {
                _repo.DeactiveBook(bookId);
                return BookOprationResult.Success(message:"Book deactivated successfully !",request:book);
            }
            else
            {
                return BookOprationResult.Failure("somthing went wrong");
            }
        }

        public async Task<BookOprationResult> ActiveBook(int bookId)
        {
            var book = _repo.FindBook(bookId);
            if(book != null)
            {
                _repo.ActiveBook(bookId);
                return BookOprationResult.Success(message:"Book activated successfully !",request:book);
            }
            else
            {
                return BookOprationResult.Failure("somthing went wrong");
            }
        }

        public async Task<BookOprationResult> UpdateBook(int bookId , UpdateBookDTO dto)
        {
            _repo.Update(bookId,dto);

            var book = _repo.FindBook(bookId);
            return BookOprationResult.Success(message:"Book updated succesfully !", request:book);
        }


    }
}
using Application.DTOs.Book;
using Application.Interfaces.Repository;
using Domain.Entities;
using Infrastructure.Data.Contexts;
using DataEntities = Infrastructure.Data.Entities;

namespace Infrastructure.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryContext _db;
        public BookRepository(LibraryContext db)
        {
            _db = db;
        }


        public Book FindBook(int bookId)
        {
            var book = _db.Books.Find(bookId);
            if(book != null)
            {
                Book result = new Book
                {
                    Id = book.Id,
                    Title = book.Title,
                    AutherId = book.AutherId,
                    PublishDate = book.PublishDate,
                    PublisherId = book.PublisherId,
                    Price = book.Price,
                    Edition = book.Edition,
                    TopicId = book.TopicId,
                    IsActive = book.IsActive
                };


                return result;
            }
            else
            {
                return null;
            }
        }


        public Book Add(AddBookDTO dto)
        {
            DataEntities.Book book = new DataEntities.Book
            {
                Title = dto.Title,
                AutherId = dto.AutherId,
                PublishDate = dto.PublishDate,
                PublisherId = dto.PublisherId,
                Price = dto.Price,
                Edition = dto.Edition,
                TopicId = dto.TopicId
            };

            _db.Books.Add(book);
            _db.SaveChanges();

            var result = _db.Books.Select(x => new Book{
                Title = dto.Title,
                AutherId = dto.AutherId,
                PublishDate = dto.PublishDate,
                PublisherId = dto.PublisherId,
                Price = dto.Price,
                Edition = dto.Edition,
                TopicId = dto.TopicId
            }).OrderByDescending(x => x.Id).FirstOrDefault();

            return result;
            
        }


        public void Delete(int bookId)
        {
            var book = _db.Books.Find(bookId);
            _db.Books.Remove(book);
            _db.SaveChanges();
        }


        public void DeactiveBook(int bookId)
        {
            var book = _db.Books.Find(bookId);
            if(book != null)
            {
                book.IsActive = false;
                _db.SaveChanges();
            }
        }

    }
}
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

        public IQueryable FindBooksByAuther(int autherId)
        {
            var books = _db.Books.Select(x => x.AutherId == autherId);
            return books;
        }


        public IQueryable FindBooksByTopic(int topicId)
        {
            var books = _db.Books.Select(x => x.TopicId == topicId);
            return books;
        }



        public IQueryable FindBooksByPublisher(int publisherId)
        {
            var books = _db.Books.Select(x => x.PublisherId == publisherId);
            return books;
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
            if(book != null)
            {
                _db.Books.Remove(book);
                _db.SaveChanges();
            }
            else
            {
                return;
            }
            
        }


        public void DeactiveBook(int bookId)
        {
            var book = _db.Books.Find(bookId);
            if(book != null)
            {
                book.IsActive = false;
                _db.SaveChanges();
            }
            else
            {
                return;
            }
        }


        public void Update(int bookId,UpdateBookDTO dto)
        {
            var book = _db.Books.Find(bookId);
            if(book !=  null)
            {
                if(dto.Title != null && book.Title != dto.Title)
                    book.Title = dto.Title;
                else if(dto.AutherId != null && book.AutherId != dto.AutherId)
                    book.AutherId = dto.AutherId;
                else if(dto.PublishDate != null && book.PublishDate != dto.PublishDate)
                    book.PublishDate = dto.PublishDate;
                else if(dto.PublisherId != null && book.PublisherId != dto.PublisherId)
                    book.PublisherId = dto.PublisherId;
                else if(dto.Price != null && book.Price != dto.Price)
                    book.Price = dto.Price;
                else if(dto.Edition != null && book.Edition != dto.Edition)
                    book.Edition = dto.Edition;
                else if(dto.TopicId != null && book.TopicId != dto.TopicId)
                    book.TopicId = dto.TopicId;
                
                _db.SaveChanges();
                
            }
            else
            {
                return;
            }
        }

    }
}
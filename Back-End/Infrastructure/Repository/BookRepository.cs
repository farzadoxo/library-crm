using Application.Interfaces.Repository;
using Domain.Entities;
using Infrastructure.Data.Contexts;

namespace Infrastructure.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryContext _db;
        public BookRepository(LibraryContext db)
        {
            _db = db;
        }


    }
}
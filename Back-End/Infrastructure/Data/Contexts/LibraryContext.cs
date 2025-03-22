using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure.Data.Contexts
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Auther> Authers { get; set; }
        public DbSet<BookTopic> BookTopics { get; set; }
        public DbSet<Lend> Lends { get; set; }
        public DbSet<Librarian> Librarians { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Publisher> Publishers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }


    }
}
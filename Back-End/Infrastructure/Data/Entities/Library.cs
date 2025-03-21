namespace Infrastructure.Data.Entities
{
    public class Library
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Book>? Books { get; set; }
        public List<Member>? Members { get; set; }
        public List<Librarian>? Employees { get; set; }
    }
}
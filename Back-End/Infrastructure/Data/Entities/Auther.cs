namespace Domain.Entities
{
    public class Auther
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public List<Book>? Books { get; set; }
    }
}
namespace Infrastructure.Data.Entities
{
    public class Member
    {
        public int Id { get; set; }
        string? FullName { get; set; }
        DateTime BirthDate { get; set; }
        public List<Library>? Libraries { get; set; }
    }
}
namespace Domain.Entities
{
    public class Lend
    {
        public int Id { get; set; }
        public List<Book>? Books { get; set; }
        public int OwnerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }

    }
}

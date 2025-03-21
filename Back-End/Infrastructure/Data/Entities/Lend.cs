namespace Infrastructure.Data.Entities
{
    public class Lend
    {
        public int Id { get; set; }
        public List<Book>? Books { get; set; }
        public Member? Owner { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }

    }
}

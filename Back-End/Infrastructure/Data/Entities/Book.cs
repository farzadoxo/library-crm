namespace Infrastructure.Data.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int AutherId { get; set; }
        public DateTime PublishDate { get; set; }
        public int PublisherId { get; set; }
        public decimal Price { get; set; }
        public double Edition { get; set; }
        public int TopicId { get; set; }
        public bool IsActive { get; set; }
    }
}
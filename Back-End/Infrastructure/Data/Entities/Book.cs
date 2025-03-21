namespace Infrastructure.Data.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public List<Auther>? Authers { get; set; }
        public DateTime PublishDate { get; set; }
        public Publisher? Publisher { get; set; }
        public decimal Price { get; set; }
        public double Edition { get; set; }
        public int Tiraj { get; set; }
        public BookTopic? Topic { get; set; }
    }
}
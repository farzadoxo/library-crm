namespace Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Auther>? Authers { get; set; }
        public DateTime PublishDate { get; set; }
        public Publisher? Publishers { get; set; }
        public decimal Price { get; set; }
        public double Version { get; set; }
        public int Tiraj { get; set; }
    }
}
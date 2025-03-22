using Domain.Entities;

namespace Application.DTOs.Book
{

    public class UpdateBookDTO
    {
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
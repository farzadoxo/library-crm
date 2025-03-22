using Domain.Entities;

namespace Application.DTOs.Book
{
    public class AddBookDTO
    {
        public string? Title { get; set; }
        public int AutherId { get; set; }
        public DateTime PublishDate { get; set; }
        public int PublisherId { get; set; }
        public decimal Price { get; set; }
        public double Edition { get; set; }
        public int TopicId { get; set; }
    }
}
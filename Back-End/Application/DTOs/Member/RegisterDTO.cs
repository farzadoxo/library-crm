using Domain.Entities;

namespace Application.DTOs.Member
{
    public class RegisterDTO
    {
        public string? FullName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
using Domain.Entities;

namespace Application.DTOs.Member
{
    public class ReqgisterDTO
    {
        string? FullName { get; set; }
        DateTime BirthDate { get; set; }
        public List<Library>? Libraries { get; set; }
    }
}
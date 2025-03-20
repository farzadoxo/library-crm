namespace Domain.Entities
{
    public class Account
    {
        public int Id { get; set; }

        string? FullName { get; set; }
        string? Role { get; set; }
        DateTime BirthDate { get; set; }
    }
}
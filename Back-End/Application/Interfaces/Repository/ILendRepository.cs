namespace Application.Interfaces.Repository
{
    public interface ILendRepository
    {
        void AddLend(LendDTO dto);
        void AddBookLend(BookLendDTO dto);
        void DeactiveLend(int LendId);
    }
}
namespace Application.Interfaces
{
    public interface IMemberService
    {
        Member FindMember(int memberId);
        Member Register(RegisterDTO dto);
        void Delete(int memberId);
        void Update(int memberId,UpdateMemberDTO dto);
    }
}
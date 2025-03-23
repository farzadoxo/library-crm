using Domain.Entities;
using Application.DTOs.Member;

namespace Application.Interfaces.Repository
{
    public interface IMemberRepository
    {
        Member FindMember(int memberId);
        Member Register(RegisterDTO dto);
        void Delete(int memberId);
        void Update(int memberId,UpdateMemberDTO dto);
    }
}
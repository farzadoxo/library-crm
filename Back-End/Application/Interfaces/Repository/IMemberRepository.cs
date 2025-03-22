using Domain.Entities;
using Application.DTOs.Member;

namespace Application.Interfaces.Repository
{
    public interface IMemberRepository
    {
        Member FindMember(int memberId);
        Member Register(ReqgisterDTO dto);
        void Delete(int memberId);
        Member Update(int memberId,UpdateMemberDTO dto);
    }
}
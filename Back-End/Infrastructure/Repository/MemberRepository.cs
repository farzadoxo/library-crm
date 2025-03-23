using Application.Interfaces.Repository;
using Domain.Entities;
using Infrastructure.Data.Contexts;
using Application.DTOs.Member;
using DataEntities = Infrastructure.Data.Entities;
namespace Infrastructure.Repository
{
    public class MemberRepository : IMemberRepository
    {
        private readonly LibraryContext _db;
        public MemberRepository(LibraryContext db)
        {
            _db = db;
        }


        public Member FindMember(int memberId)
        {
            var member = _db.Members.Find(memberId);
            if(member != null)
            {
                Member result = new Member
                {
                    Id = member.Id,
                    FullName = member.FullName,
                    BirthDate = member.BirthDate
                };

                return result;
            }
            else
            {
                return null;
            }
        }



        public Member Register(RegisterDTO dto)
        {
            DataEntities.Member member = new DataEntities.Member
            {
                FullName = dto.FullName,
                BirthDate = dto.BirthDate
            };

            _db.Members.Add(member);

            var result = _db.Members.Select(x => new Member{
                Id = x.Id,
                FullName = x.FullName,
                BirthDate = x.BirthDate
            }).OrderByDescending(x => x.Id).FirstOrDefault();

            return result;
        }


        public void Delete(int memberId)
        {
            var member = _db.Members.Find(memberId);
            if(member != null)
            {
                _db.Members.Remove(member);
                _db.SaveChanges();
            }
            else
            {
                return;
            }
        }

        

        public void Update(int memberId, UpdateMemberDTO dto)
        {
            var member = _db.Members.Find(memberId);
            if(member != null)
            {
                if(dto.FullName != null)
                {
                    member.FullName = dto.FullName;
                }
                else if(dto.BirthDate != null)
                {
                    member.BirthDate = dto.BirthDate;
                }

                _db.SaveChanges();
            }
            else
            {
                return;
            }
        }
    }
}
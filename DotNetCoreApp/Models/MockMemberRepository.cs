using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreApp.Models
{
    public class MockMemberRepository : IMemberRepository
    {
        private List<Member> _memberList;

        public MockMemberRepository()
        {
            _memberList = new List<Member>()
            {
                new Member() { Id = 1, Name = "Eric", Alias = "Truth", Role = "Dancing Man", Description = "The founder and most valuable member from our brotherhood" },
                new Member() { Id = 2, Name = "Sara", Alias = "Solomon", Role = "Bouncing Ball", Description = "Keep in mind that your life is only an illusion" },
                new Member() { Id = 3, Name = "Alice", Alias = "Wonderland", Role = "Bouncing Ball", Description = "Keep in mind that your life is only an illusion" },
                new Member() { Id = 4, Name = "John", Alias = "Father", Role = "Bouncing Ball", Description = "Keep in mind that your life is only an illusion" },
                new Member() { Id = 5, Name = "Stefano", Alias = "Pignolo", Role = "Bouncing Ball", Description = "Keep in mind that your life is only an illusion" },
                new Member() { Id = 6, Name = "Sisoko", Alias = "Pole", Role = "Bouncing Ball", Description = "Keep in mind that your life is only an illusion" },
                new Member() { Id = 7, Name = "Mary", Alias = "Mother", Role = "Bouncing Ball", Description = "Keep in mind that your life is only an illusion" },
                new Member() { Id = 8, Name = "Nargiz", Alias = "Zakirova", Role = "Bouncing Ball", Description = "Keep in mind that your life is only an illusion" },
                new Member() { Id = 9, Name = "Praful", Alias = "Varanasi", Role = "Bouncing Ball", Description = "Keep in mind that your life is only an illusion" },
        };
        }

        public IEnumerable<Member> GetAllMembers()
        {
            return _memberList;
        }

        public Member GetMemberById(int Id)
        {
            return _memberList.FirstOrDefault(m => m.Id == Id);
        }
    }
}

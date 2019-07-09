using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreApp.Models
{
    public interface IMemberRepository
    {
        Member GetMemberById(int Id);
        IEnumerable<Member> GetAllMembers(); 
    }
}

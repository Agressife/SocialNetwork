using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork
{
    class SocialNetwork:ISocialNetwork
    {
        public IMember AddMember(string firstName,string lastName,string city,string country)
        {
            return null;
        }
        public IMember FindMemberById(int id)
        {
            return null;
        }
        public IEnumerable<IMember> FindMember(string search)
        {
            return null;
        }
        public int MemberCount { get { return 0; } }
    }
}

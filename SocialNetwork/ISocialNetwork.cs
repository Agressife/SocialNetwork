using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork
{
    interface ISocialNetwork
    {
        public IMember AddMember(string name1, string name2, string city, string country);
        public IMember FindMemberById(int id);
        public List<IMember> FindMember(string search);
        public int MemberCount { get { return 0; } }
    }
}

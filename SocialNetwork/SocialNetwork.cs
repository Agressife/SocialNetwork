using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork
{
    class SocialNetwork:ISocialNetwork
    {
        List<IMember> list;
        public IMember AddMember(string firstName,string lastName,string city,string country)
        {
            Member member = new Member();
            member.Id = list.Count+1;
            member.Profile.FirstName = firstName;
            member.Profile.LastName = lastName;
            member.Profile.City = city;
            member.Profile.Country = country;
            member.Profile.MemberId = member.Id;
            list.Add(member);
            return member;
        }
        public IMember FindMemberById(int id)
        {
            foreach(var member in list)
            {
                if (member.Id == id) return member;

            }
            return null;
        }
        public List<IMember> FindMember(string search)
        {
            List<IMember> finded = new List<IMember>();
            foreach(var member in list)
            {
                if (member.Profile.City == search || member.Profile.Country == search || member.Profile.FirstName == search || member.Profile.LastName == search) finded.Add(member);
            }
            return finded;
        }
        public int MemberCount { get { return list.Count; } }
    }
}

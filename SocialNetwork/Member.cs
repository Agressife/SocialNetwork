using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork
{
    class Member:IMember
    {
        public int Id { get; }
        public IMemberProfile Profile { get; }
        public IEnumerable<IMember> Friends { get { return null; } }
        public IEnumerable<IMember> Pending { get { return null; } }
        public IEnumerable<IPost> Posts { get { return null; } }
        public void AddFriendRequest(IMember from)
        {            
        }
        public void ConfirmFriend(IMember member)
        {

        }
        public void RemoveFriendRequest(IMember member)
        {

        }
        public void RemoveFriend(IMember friend)
        {

        }
        public IEnumerable<IMember> GetFriends(int level = 1,IList<int> fliter=null)
        {
            return null;
        }
        public IPost AddPost(string message)
        {
            return null;
        }
        public void RemovePost(int id)
        {

        }
        public IEnumerable<IPost> GetFeed()
        {
            return null;
        }
    }
}

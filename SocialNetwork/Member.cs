using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork
{
    class Member:IMember
    {
        public int Id { get; set; }
        public IMemberProfile Profile { get; }
        public List<IMember> Friends { get; }
        public List<IMember> Pending { get; }
        public List<IPost> Posts { get; }
        public void AddFriendRequest(IMember from)
        {
            this.Pending.Add(from);
        }
        public void ConfirmFriend(IMember member)
        {
            this.Pending.Remove(member);
            this.Friends.Add(member);
        }
        public void RemoveFriendRequest(IMember member)
        {
            this.Pending.Remove(member);
        }
        public void RemoveFriend(IMember friend)
        {
            this.Friends.Remove(friend);
        }
        public IEnumerable<IMember> GetFriends(int level = 1,IList<int> fliter=null)
        {
            return this.Friends;
        }
        public IPost AddPost(string message)
        {
            Post p = new Post();
            p.Message = message;
            p.Member = this;
            p.Likes = 0;
            p.Id = Posts.Count + 1;
            p.Date = DateTime.Now;
            return p;
        }
        public void RemovePost(int id)
        {
            Posts.RemoveAt(id);
        }
        public IEnumerable<IPost> GetFeed()
        {
            return this.Posts;
        }
    }
}

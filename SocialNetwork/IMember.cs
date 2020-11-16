using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork
{
    interface IMember
    {
        public int Id { get; }//Id of member.Must be unique
        public IMemberProfile Profile { get; }//Member's profile
        public IEnumerable<IMember> Friends { get { return null; } }// List of friends
        public IEnumerable<IMember> Pending { get { return null; } }// List of friend requests
        public IEnumerable<IPost> Posts { get { return null; } }//Member's posts
        public void AddFriendRequest(IMember from);//add a friend request from "From"
        public void ConfirmFriend(IMember member);//confirms a pending request
        public void RemoveFriendRequest(IMember member);//remove a pending request
        public void RemoveFriend(IMember member);//remove a friend
        public IEnumerable<IMember> GetFriends(int level = 1, IList<int> filter = null);//returns a list of friends (1,2,3... level of friends)
        public IPost AddPost(string message);// add a new post to feed
        public void RemovePost(int id);//remove a post
        public IEnumerable<IPost> GetFeed();//returns feed


    }
}

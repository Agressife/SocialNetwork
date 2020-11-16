using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork
{
    interface IPost
    {
        public int Id { get; set; }
        public IMember Member { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public int Likes { get; set; }
    }
}

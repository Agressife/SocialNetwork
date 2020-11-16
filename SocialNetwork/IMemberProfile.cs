using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork
{
    interface IMemberProfile
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;}
        public string City { get; set; }
        public string Country { get; set; }
    }
}

using BookLibrarySystem.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookLibrarySystem.Models
{
    internal class Member
    {
        public Member()
        {
            
        }
        public Member(string name)
        {
            UserName = name;
        }
        public string UserName { get; set; }

        public void SetUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("The username Is Requirment");
            else
                UserName = username;
        }
    }
}

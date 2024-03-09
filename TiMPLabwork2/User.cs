using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiMPLabwork2
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<MenuItem> MenuItems { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            MenuItems = new List<MenuItem>();
        }
    }
}

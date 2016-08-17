using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Model
{
    public class User
    {
        private string Username;
        private string Password;

        public string getUsername() { return Username; }
        public string getPassword() { return Password; }

        public void setUsername(string a) { Username = a; }
        public void setPassword(string a) { Password = a; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Model;

namespace Lab1.Repository
{
    public class User_Repo
    {
        public List<User> list = new List<User>();

        public User_Repo()
        {

        }

        public void add(User user)
        {
            list.Add(user);
        }

        public int check_user(string username, string password)
        {
            int a = 0;
            foreach (User u in list)
            {
                if (u.getUsername() == username)
                    a += 2;
                if (u.getPassword() == password)
                    a++;
            }
            return a;
        }
    }
}

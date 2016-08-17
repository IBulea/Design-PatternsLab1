using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Model;

namespace Lab1.Repository
{
    public class Install_Repo : IRepository<Install_Method>
    {
        public List<Install_Method> List = new List<Install_Method>();

        public Install_Repo()
        {

        }
    
        public int total ()
        {
            int sum = 0;
            foreach (Install_Method i in List)
                sum += i.getPrice();
            return sum;
        }

        public void remove(Install_Method i)
        {
            List.Remove(i);
        }

        public List<Install_Method> getList()
        {
            return List;
        }

        public string ToString()
        {
            string output= "";
            foreach (Install_Method i in List)
                output += i + "\n";
            return output;
        }

        public void add(Install_Method i)
        {
            List.Add(i);
        }
    }
}

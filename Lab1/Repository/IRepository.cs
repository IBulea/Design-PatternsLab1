using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Model;

namespace Lab1.Repository
{
    public interface IRepository<T>
    {
    
            List<T> getList();

            int total();

            string ToString();

            void add(T product);

            void remove(T p);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Model
{
    public interface Item
    {
        int getPrice();
        string getName();
        void setPrice(int a);
        void setName(string a);
        string ToString();
    }
}

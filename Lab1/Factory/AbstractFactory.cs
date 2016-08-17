using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Model;
using Lab1.Repository;

namespace Lab1.Factory
{
    public abstract class AbstractFactory
    {
        public abstract Item getItem(int price, string name,Install_Method optionalInst = null, params string[] values);
    }
}

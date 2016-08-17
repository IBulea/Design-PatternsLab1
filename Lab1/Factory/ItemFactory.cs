using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Model;
namespace Lab1.Factory
{
    class ItemFactory : AbstractFactory
    {
        public override Item getItem(int price, string name, Install_Method optionalInst = null, params string[] values)
        {
            if (optionalInst != null && values.Length == 2)
                return new Product(price, name, optionalInst, values[0], values[1]);
            else if (optionalInst == null && values.Length == 2)
                return new Install_Method(price, name, values[0], values[1]);
            else
                return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Model
{
    public class Product : Item
    {
        private int Price;
        private string Name ;
        private string Color;
        private string Unit;
        private Install_Method Method;

        public int getPrice() { return Price; }
        public string getName() { return Name; }
        public string getColor() { return Color; }
        public string getUnit() { return Unit; }
        public Install_Method getMethod() { return Method; }

        public void setPrice(int a) { Price = a; }
        public void setName(string a) { Name = a; }
        public void setColor(string a) { Color = a; }
        public void setUnit(string a) { Unit = a; }
        public void setUnit(Install_Method a) { Method = a; }

        public Product ( int price,string name, Install_Method method, string color, string unit)
        {
            Name = name;
            Color = color;
            Unit = unit;
            Price = price;
            Method = method;
        }

        public Product() { }

        public string ToString()
        {
            return Name + " " + Color + " " + Unit + " " + Price.ToString();
        }
    }
}

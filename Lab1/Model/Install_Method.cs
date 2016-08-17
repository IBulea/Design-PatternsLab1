using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Model
{
    public class Install_Method : Item
    {
        private int Price;
        private string Name;
        private string Items;
        private string Description;

        public int getPrice() { return Price; }
        public string getName() { return Name; }
        public string getItems() { return Items; }
        public string getDescription() { return Description; }

        public void setPrice(int a) { Price=a; } 
        public void setName(string a) { Name=a; }
        public void setItems(string a) { Items=a; }
        public void setDescription(string a) { Description=a; }

        public Install_Method( int price,string name, string description, string items)
        {
            Name = name;
            Price = price;
            Description = description;
            Items = items;
        }


        public string ToString()
        {
            return Name + " " + Description + " " + Items.ToString() + " " + Price.ToString();
        }
    }
}

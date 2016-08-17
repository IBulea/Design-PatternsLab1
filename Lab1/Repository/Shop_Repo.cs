using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Model;

namespace Lab1.Repository
{
    public class Shop_Repo : IRepository<Product>
    {
        public List<Product> List = new List<Product>();

        public Shop_Repo()
        {

        }
        public List<Product> getList()
        {
            return List;
        }

        public int total()
        {
            int sum = 0;
            foreach (Product p in List)
                sum += p.getPrice() + p.getMethod().getPrice();
            return sum;
        }

        public void remove(Product p)
        {
            List.Remove(p);
        }

        public string ToString()
        {
            string output = "";
            foreach (Product p in List)
                output += p.ToString() + p.getMethod().getItems().ToString() + " " + (p.getPrice() + p.getMethod().getPrice()).ToString() + "\n";
            return output;
        }

        public void add(Product p)
        {
            List.Add(p);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1.Model;
using Lab1.Repository;
using Lab1.Factory;
namespace Lab1
{
    public partial class Form1 : Form
    {
        private User_Repo user_repo;
        private IRepository<Product> shopping_repo ;
        private IRepository<Install_Method> install_repo;
        private List<Product> products;
        private List<Install_Method> in_method;
        private Necessities ins;
        private AbstractFactory fact;
        private Item a;

        public Form1()
        {
            user_repo = new User_Repo();
            shopping_repo = new Shop_Repo();
            install_repo = new Install_Repo();
            products = new List<Product>();
            in_method = new List<Install_Method>();
            fact = new ItemFactory();
            user_repo.add(new User("ioana", "1234"));
            user_repo.add(new User("user1", "789"));
            user_repo.add(new User("user2", "admin"));
            user_repo.add(new User("andrei", "parola"));
            user_repo.add(new User("admin", "asdf"));

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = user_repo.check_user(username_box.Text, password_box.Text);

            if (a == 0)
                MessageBox.Show("The username and password are incorrect, please try again.", "Error");
            else if (a == 1)
                MessageBox.Show("The username is incorrect, please try again.", "Error");
            else if (a == 2)
                MessageBox.Show("The password is incorrect, please try again.", "Error");
            else
            {
                login_panel.Enabled = false;
                login_panel.Visible = false;

                createSessionToolStripMenuItem.Enabled = true;
            }
        }

        private void createSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initiate_Product_Lists();

            label_products.Visible = true;
            label_shopping.Visible = true;

            label_shopping.Enabled = true;
            label_products.Enabled = true;

            shopping_list.Visible = true;
            shopping_list.Enabled = true;

            remove_button.Enabled = true;
            remove_button.Visible = true;

            add_button.Visible = true;
            add_button.Enabled = true;

            product_list.Visible = true;
            product_list.Enabled = true;
        }

        public void initiate_Product_Lists()
        {
            product_list.View = View.Details;
            product_list.FullRowSelect = true;
            product_list.Sorting = SortOrder.Ascending;
            product_list.GridLines = true;

            product_list.Columns.Add("Name", -2, HorizontalAlignment.Left);
            product_list.Columns.Add("Color", -2, HorizontalAlignment.Left);
            product_list.Columns.Add("Unit", -2, HorizontalAlignment.Left);
            product_list.Columns.Add("Install method", -2, HorizontalAlignment.Left);
            product_list.Columns.Add("Price", -2, HorizontalAlignment.Left);

            product_list.CheckBoxes = true;


            a = fact.getItem(15, "Nailing", null, "Using nails and a hammer to fix the pieces together", "Hammer, Nails");
            if (a is Install_Method)
                in_method.Add((Install_Method)a);
            a = fact.getItem(20,"Sticking",null, "Using powerful glue and spray to fix the pieces together", "Glue, Spray");
            if (a is Install_Method)
                in_method.Add((Install_Method)a);
            a = fact.getItem(25,"Fitting",null, "Fitting the pieces together very closely", "Measuring Tape, Rubber Hammer");
            if (a is Install_Method)
                in_method.Add((Install_Method)a);
            a = fact.getItem(45, "Plumbing", null, "Installing plumbing appliances", "Wrench Set, Rubber Seals");
            if (a is Install_Method)
                in_method.Add((Install_Method)a);

            a = fact.getItem(105, "Closet", in_method[1], "Brown", "meters");
            if (a is Product)
                products.Add((Product)a);
            a = fact.getItem(70, "Table", in_method[1], "White", "meters");
            if (a is Product)
                products.Add((Product)a);
            a = fact.getItem(85, "Bookshelf", in_method[0], "Blue", "meters");
            if (a is Product)
                products.Add((Product)a);
            a = fact.getItem(130, "Sink", in_method[3], "White", "m^3");
            if (a is Product)
                products.Add((Product)a);
            a = fact.getItem(250, "Wood Floor", in_method[3], "Brown", "m^2");
            if (a is Product)
                products.Add((Product)a);

            for (int i = 0; i < products.Count; i++)
            {
                ListViewItem listItem = new ListViewItem(products[i].getName());
                listItem.SubItems.Add(products[i].getColor());
                listItem.SubItems.Add(products[i].getUnit());
                listItem.SubItems.Add(products[i].getMethod().getName());
                listItem.SubItems.Add(products[i].getPrice().ToString());
                product_list.Items.Add(listItem);
            }

        }

        public void initiate_Shopping_List()
        {
            shopping_list.Clear();
            shopping_list.View = View.Details;
            shopping_list.FullRowSelect = true;
            shopping_list.GridLines = true;
            shopping_list.CheckBoxes = true;

            shopping_list.Columns.Add("Name", 100, HorizontalAlignment.Left);
            shopping_list.Columns.Add("Color", 60, HorizontalAlignment.Left);
            shopping_list.Columns.Add("Unit", 60, HorizontalAlignment.Left);
            shopping_list.Columns.Add("Items needed", 100, HorizontalAlignment.Left);
            shopping_list.Columns.Add("Product and items price", 100, HorizontalAlignment.Left);

            for (int i = 0; i < shopping_repo.getList().Count; i++)
            {
                ListViewItem listItem = new ListViewItem(shopping_repo.getList()[i].getName());
                listItem.SubItems.Add(shopping_repo.getList()[i].getColor());
                listItem.SubItems.Add(shopping_repo.getList()[i].getUnit());
                listItem.SubItems.Add(shopping_repo.getList()[i].getMethod().getItems());
                listItem.SubItems.Add((shopping_repo.getList()[i].getPrice() + shopping_repo.getList()[i].getMethod().getPrice()).ToString());
                shopping_list.Items.Add(listItem);
            }
            ListViewItem listItem1 = new ListViewItem("Total price");
            listItem1.SubItems.Add(shopping_repo.total().ToString());
            shopping_list.Items.Add(listItem1);

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (product_list.CheckedItems.Count == 0)
                MessageBox.Show("Please select a product to be added to the shopping list", "Info");
            else
            {
                Product item = new Product();
                foreach (ListViewItem i in product_list.CheckedItems)
                {
                    item = products.FirstOrDefault(it => it.getName() == i.Text);
                    if (item != null)
                    {
                        shopping_repo.add(item);
                        install_repo.add(item.getMethod());
                    }
                }

                initiate_Shopping_List();

                finalize_button.Enabled = true;
                finalize_button.Visible = true;
            }
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            if (shopping_list.CheckedItems.Count == 0)
                MessageBox.Show("Please select a product to be removed from the shopping list", "Info");
            else
            {
                Product item = new Product();
                foreach (ListViewItem i in shopping_list.CheckedItems)
                {
                    item = products.FirstOrDefault(it => it.getName() == i.Text);
                    if (item != null)
                    {
                        shopping_repo.remove(item);
                        install_repo.remove(item.getMethod());
                    }
                }


                initiate_Shopping_List();
            }
        }

        private void finalize_button_Click(object sender, EventArgs e)
        {
            ins = new Necessities((Install_Repo)install_repo);
            ins.ShowDialog();
        }
    }
}

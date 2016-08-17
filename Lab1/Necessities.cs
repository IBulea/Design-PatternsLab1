using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1.Repository;
using Lab1.Model;

namespace Lab1
{
    public partial class Necessities : Form
    {
        Install_Repo install_repo;
        public Necessities(Install_Repo repo)
        {
            install_repo = repo;
            InitializeComponent();
            initiate_list();
        }

        public Lab1.Repository.Install_Repo Install_Repo
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        private void initiate_list()
        {
            cart_list.View = View.Details;
            cart_list.FullRowSelect = true;
            cart_list.GridLines = true;

            cart_list.Columns.Add("Name", -2, HorizontalAlignment.Left);
            cart_list.Columns.Add("Description", -2, HorizontalAlignment.Left);
            cart_list.Columns.Add("Items", -2, HorizontalAlignment.Left);
            cart_list.Columns.Add("Price", -2, HorizontalAlignment.Left);


            for (int i = 0; i < install_repo.getList().Count; i++)
            {
                ListViewItem listItem = new ListViewItem(install_repo.getList()[i].getName());
                listItem.SubItems.Add(install_repo.getList()[i].getDescription());
                listItem.SubItems.Add(install_repo.getList()[i].getItems());
                listItem.SubItems.Add(install_repo.getList()[i].getPrice().ToString());
                cart_list.Items.Add(listItem);
            }
            ListViewItem listItem1 = new ListViewItem("Total price");
            listItem1.SubItems.Add(install_repo.total().ToString());
            cart_list.Items.Add(listItem1);
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

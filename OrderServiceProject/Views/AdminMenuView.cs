using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderServiceProject.Services;
using OrderServiceProject.Views;

namespace OrderServiceProject.Views
{
    public partial class AdminMenuView : Form
    {
        private GlobalContextService _contex;
        public AdminMenuView(GlobalContextService contex)
        {
            InitializeComponent();
            _contex = contex;
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            ProductListView listView = new ProductListView(_contex);
            listView.Show();
            this.Hide();

           
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            OrderListView orderList = new OrderListView(_contex);
            orderList.Show();
            this.Hide();
        }

        private void AdminMenuView_FormClosed(object sender, FormClosedEventArgs e)
        {
            AuthorizationView singInView = new AuthorizationView(_contex);
            singInView.Visible = true;
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            var userListView = new UserListView(_contex);
            userListView.Show();
            this.Hide();
        }
    }
}

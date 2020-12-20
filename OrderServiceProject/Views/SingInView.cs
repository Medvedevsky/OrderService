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

namespace OrderServiceProject.Views
{
    public partial class SingInView : Form
    {
        private GlobalContextService _context;
        public SingInView(GlobalContextService context)
        {
            InitializeComponent();
            _context = context;
        }

        private void singInButton_Click(object sender, EventArgs e)
        {
            var login = loginBox.Text;
            var password = passwordBox.Text;

            var res = _context.Authorization.SingIn(login, password);

            if (res == null)
                MessageBox.Show("Неправельный логин либо пороль");
            else if (res.Role == "admin")
            {
                var adminMenuWindow = new AdminMenuView(_context);
                adminMenuWindow.Show();
                this.Hide();
            }
            else if(res.Role == "client")
            {
                var clientMenuWindow = new ClientMenuView(_context);
                clientMenuWindow.Show();
                this.Hide();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

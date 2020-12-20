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
    public partial class ClientView : Form
    {
        private GlobalContextService _context;
        public ClientView(GlobalContextService context)
        {
            InitializeComponent();
            _context = context;
        }

        private void ClientView_Load(object sender, EventArgs e)
        {

        }

        private void ClientView_FormClosed(object sender, FormClosedEventArgs e)
        {
            SingInView singInView = new SingInView(_context);
            singInView.Visible = true;
        }
    }
}

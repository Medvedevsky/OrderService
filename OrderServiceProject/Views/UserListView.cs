using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderServiceProject.Models;
using OrderServiceProject.Services;

namespace OrderServiceProject.Views
{
    public partial class UserListView : Form
    {
        private GlobalContextService _context;
        public UserListView(GlobalContextService context)
        {
            InitializeComponent();
            userDataGridView.AutoGenerateColumns = false;
            _context = context;
        }

        private void UserListView_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminMenuView adminMenuView = new AdminMenuView(_context);
            adminMenuView.Visible = true;
        }

        public void RefreshDataHandler()
        {
            try
            {
                userDataGridView.DataSource = _context.User.GetAll();
            }
            catch
            {
                MessageBox.Show("Ошибка при считывании данных");
            }
        }

        private void UserListView_Load(object sender, EventArgs e)
        {
            RefreshDataHandler();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userDataGridView.SelectedRows == null)
            {
                MessageBox.Show("Выделите строку для удаления пользователя!");
                return;
            }
            var selectedData = userDataGridView.SelectedRows[0].DataBoundItem as User;
            int id = int.Parse(userDataGridView.SelectedRows[0].Cells[0].Value.ToString());

            _context.User.Delete(id, selectedData);
            RefreshDataHandler();
        }
    }
}

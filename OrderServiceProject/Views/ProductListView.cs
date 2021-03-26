using OrderServiceProject.Models;
using OrderServiceProject.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OrderServiceProject.Views
{
    public partial class ProductListView : Form
    {
        private GlobalContextService _context;
        public ProductListView(GlobalContextService context)
        {
            InitializeComponent();
            productDataGridView.AutoGenerateColumns = false;
            _context = context;

        }

        private void ProductListView_Load(object sender, EventArgs e)
        {
            RefreshDataHandler();
            if (_context.Authorization.Me.Role == "client")
            {
                addToolStripMenuItem.Visible = false;
                changeToolStripMenuItem.Visible = false;
                deleteToolStripMenuItem.Visible = false;
                tableGroupsButton.Visible = false;
            }
            else
                doOrderButton.Visible = false;
        }

        public void RefreshDataHandler()
        {
            try
            {
                productDataGridView.DataSource = _context.Product.GetAll();
            }
            catch
            {
                MessageBox.Show("Ошибка при считывании данных");
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshDataHandler();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(productDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выделите строку для ее удаления!");
                return;
            }

            var selectedRow = productDataGridView.SelectedRows[0].DataBoundItem as Product;
            int id = int.Parse(productDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            _context.Product.Delete(id, selectedRow);

            RefreshDataHandler();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var product = new Product();
            var editProductView = new EditProductView();
            var res = editProductView.ShowDialog(product);

            if(res == DialogResult.OK)
            {
                _context.Product.Add(editProductView.ChangeData);
                RefreshDataHandler();
            }
            
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (productDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выделите строку для ее изменения!");
                return;
            }
            var selectedRow = productDataGridView.SelectedRows[0].DataBoundItem as Product;

            var editProductView = new EditProductView();
            var res = editProductView.ShowDialog(selectedRow);

            if(res == DialogResult.OK)
            {
                _context.Product.ChangeData(selectedRow.Id, editProductView.ChangeData);
                RefreshDataHandler();
            }

        }

        private void tableGroupsButton_Click(object sender, EventArgs e)
        {
            var orderListWindow = new OrderListView(_context);
            orderListWindow.ShowDialog();
        }

        private void ProductListView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(_context.Authorization.Me.Role == "client")
            {
                ClientMenuView clientMenuView = new ClientMenuView(_context);
                clientMenuView.Visible = true;
            }
            else
            {
                AdminMenuView adminMenuView = new AdminMenuView(_context);
                adminMenuView.Visible = true;
            }
        }

        private void doOrderButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                var selectedRow = productDataGridView.SelectedRows[0].DataBoundItem as Product;
                _context.Product.DoOrder(_context.Authorization.Me, selectedRow);
                MessageBox.Show("Вы совершили заказ");
            }
            catch
            {
                if (productDataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выделите строку, чтобы совершить заказ");
                    return;
                }
                else
                MessageBox.Show("Ошибка при совершении заказа!");
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

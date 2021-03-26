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
    public partial class OrderListView : Form
    {
        private GlobalContextService _context;
        public OrderListView(GlobalContextService context)
        {
            InitializeComponent();
            _context = context;
            orderDataGridView.AutoGenerateColumns = false;
        }

        private void OrderListView_Load(object sender, EventArgs e)
        {
            RefreshDataHandler();

            if (_context.Authorization.Me.Role == "client")
                orderDataGridView.Columns[0].Visible = false;
           
        }

        public void RefreshDataHandler()
        {
            try
            {
                if (_context.Authorization.Me.Role == "client")
                {
                    orderDataGridView.DataSource = _context.Order.GetOnlyClient(_context.Authorization.Me);
                }
                else
                    orderDataGridView.DataSource = _context.Order.GetAll();
            }
            catch
            {
                MessageBox.Show("Ошибка при считывании данных");
            }
        }

        private void orderDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var column = orderDataGridView.Columns[e.ColumnIndex];
            var order = orderDataGridView.Rows[e.RowIndex].DataBoundItem as Order;

            if (column.Name == "NameProductColumn")
                e.Value = order.Product.NameProduct;
            else if (column.Name == "NameUserColumn")
                e.Value = order.User.Name;
            else
                return;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (orderDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выделите строку для отмены заказа!");
                return;
            }
            var data = orderDataGridView.SelectedRows[0].DataBoundItem as Order;
            var rowId = orderDataGridView.SelectedRows[0];

            int id = int.Parse(rowId.Cells[1].Value.ToString());

            _context.Order.Delete(id, data);
            RefreshDataHandler();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshDataHandler();
        }

        private void OrderListView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_context.Authorization.Me.Role == "client")
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

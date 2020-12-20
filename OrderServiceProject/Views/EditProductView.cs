using OrderServiceProject.Models;
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
    public partial class EditProductView : Form
    {
        public EditProductView()
        {
            InitializeComponent();
        }
        private int id;

        public Product ChangeData
        {
            get
            {
                return new Product
                {
                    Id = id,
                    NameProduct = nameBox.Text,
                    Price = int.Parse(priceBox.Text),
                    IsDeleted = false
                };
            }
        }

        public DialogResult ShowDialog(Product product)
        {
            if (product == null)
                product = new Product();

            id = product.Id;
            nameBox.Text = product.NameProduct;
            priceBox.Text = product.Price.ToString();

            return ShowDialog();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

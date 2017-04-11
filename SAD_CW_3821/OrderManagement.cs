using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManagement.DAL;

namespace SAD_CW_3821
{
    public partial class OrderManagement : Form
    {
        public OrderManagement()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void allProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllProducts form = new AllProducts();
            form.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EditProduct form = new EditProduct();
            //form.Show();

            ProductsTable newProduct = new ProductsTable();
            EditProduct form = new EditProduct(newProduct, true);
            form.Show();
        }

        private void addOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersTable newOrder = new OrdersTable();
            AddOrder form = new AddOrder(newOrder, true);
            form.Show();
        }

        private void allOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AllOrders form = new AllOrders();
            form.Show();
        }

        private void generateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report form = new Report();
            form.Show();
        }
    }
}

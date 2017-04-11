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
    public partial class AllProducts : Form
    {
        public AllProducts()
        {
            InitializeComponent();
            MdiParent = Application.OpenForms["OrderManagement"];
        }

        private void AllProducts_Load(object sender, EventArgs e)
        {
            cbxCategory.DataSource = Enum.GetNames(typeof(Category));
            cbxSubCategory.DataSource = Enum.GetNames(typeof(ComputersSubCategory));
            cbxSubCategory.Enabled = false;
            RefreshProducts();
        }

        public void RefreshProducts()
        {
            //this.productsTableTableAdapter.Fill(this.orderManagementDBDataSetProducts.ProductsTable);
            dgvAllProducts.SuspendLayout();
            productsTableBindingSource.SuspendBinding();
            productsTableBindingSource.DataSource = OrderingRepository.getInstance.GetProducts();
            dgvAllProducts.DataSource = null;
            dgvAllProducts.DataSource = productsTableBindingSource;
            productsTableBindingSource.ResumeBinding();
            dgvAllProducts.ResumeLayout();
        }

        public void RefreshProductsByCategory()
        {
            //this.productsTableTableAdapter.Fill(this.orderManagementDBDataSetProducts.ProductsTable);
            dgvAllProducts.SuspendLayout();
            productsTableBindingSource.SuspendBinding();
            productsTableBindingSource.DataSource = OrderingRepository.getInstance.GetProductsByCategory(cbxCategory.Text);
            dgvAllProducts.DataSource = null;
            dgvAllProducts.DataSource = productsTableBindingSource;
            productsTableBindingSource.ResumeBinding();
            dgvAllProducts.ResumeLayout();
        }

        public void RefreshProductsBySubCategory()
        {
            //this.productsTableTableAdapter.Fill(this.orderManagementDBDataSetProducts.ProductsTable);
            dgvAllProducts.SuspendLayout();
            productsTableBindingSource.SuspendBinding();
            productsTableBindingSource.DataSource = OrderingRepository.getInstance.GetProductsBySubCategory(cbxSubCategory.Text);
            dgvAllProducts.DataSource = null;
            dgvAllProducts.DataSource = productsTableBindingSource;
            productsTableBindingSource.ResumeBinding();
            dgvAllProducts.ResumeLayout();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductsTable newProduct = new ProductsTable();
            EditProduct form = new EditProduct(newProduct, true);
            form.Show();
            form.FormClosed += EditProduct_FormClosed;
        }

        private void EditProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshProducts();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAllProducts.SelectedRows.Count > 0)
            {
                //grab selected object
                ProductsTable currentProduct = (ProductsTable)dgvAllProducts.SelectedRows[0].DataBoundItem;
                //provided parameters will open an edit form for teacher
                //last parameter which is boolean is responsible for opening adding or editing form
                EditProduct editForm = new EditProduct(currentProduct, false);
                editForm.Show();
            }
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxSubCategory.Enabled = true;
            if ((Category)cbxCategory.SelectedIndex == Category.Computers)
            {
                cbxSubCategory.DataSource = Enum.GetNames(typeof(ComputersSubCategory));
            }
            else if ((Category)cbxCategory.SelectedIndex == Category.Accessory)
            {
                cbxSubCategory.DataSource = Enum.GetNames(typeof(AccessorySubCategory));
            }
            else if ((Category)cbxCategory.SelectedIndex == Category.Software)
            {
                cbxSubCategory.DataSource = Enum.GetNames(typeof(SoftwareSubCategory));
            }

            RefreshProductsByCategory();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            RefreshProducts();
            cbxSubCategory.Enabled = false;
        }

        private void cbxSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshProductsBySubCategory();
        }

        private void AllProducts_Activated(object sender, EventArgs e)
        {
            RefreshProducts();
        }
    }
}

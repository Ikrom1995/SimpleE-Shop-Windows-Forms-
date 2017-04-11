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
    public partial class EditProduct : Form
    {
        private ProductsTable _product { get; set; }

        private bool isNew { get; set; }

        public EditProduct(ProductsTable prod, bool New)
        {
            InitializeComponent();
            MdiParent = Application.OpenForms["OrderManagement"];

            isNew = New;
            _product = prod;

            //set form text
            if (isNew)
            {
                this.Text = "New Product";
            }
            else
            {
                this.Text = "Edit Product";
            }

            if (!isNew)
            {
                ShowDataInForm();
            }
        }

        //gets data from form
        private void GetDataFromForm()
        {
            _product.Name = tbxName.Text;
            _product.Category = cbxCategory.Text;
            _product.SubCategory = cbxSubCategory.Text;
            _product.Brand = tbxBrand.Text;
            _product.Description = rtbDescription.Text;
            _product.Price = Decimal.ToDouble(nudPrice.Value);
        }

        //shows data to the form
        //used in editing
        private void ShowDataInForm()
        {
            tbxName.Text = _product.Name;
            cbxCategory.Text = _product.Category;
            cbxSubCategory.Text = _product.SubCategory;
            tbxBrand.Text = _product.Brand;
            rtbDescription.Text = _product.Description;
            nudPrice.Value = (Decimal) _product.Price;
        }

        private void Save()
        {
            if (string.IsNullOrEmpty(tbxName.Text) ||
               string.IsNullOrEmpty(cbxCategory.Text) ||
               string.IsNullOrEmpty(cbxSubCategory.Text) ||
               string.IsNullOrEmpty(tbxBrand.Text) ||
               string.IsNullOrEmpty(rtbDescription.Text) ||
               nudPrice.Value == 0)
            {
                MessageBox.Show("Fill in all fields!");
            }
            else
            {
                GetDataFromForm();
                if (isNew)
                {
                    OrderingRepository.getInstance.AddProduct(_product);
                }
                else
                {
                    OrderingRepository.getInstance.EditProduct(_product);
                }
                Close();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            cbxCategory.DataSource = Enum.GetNames(typeof(Category));
            cbxSubCategory.DataSource = Enum.GetNames(typeof(ComputersSubCategory));
            ShowDataInForm();
            if(isNew)
                cbxSubCategory.Enabled = false;
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxSubCategory.Enabled = true;
            if ((Category)cbxCategory.SelectedIndex  == Category.Computers)
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
        }
    }
}

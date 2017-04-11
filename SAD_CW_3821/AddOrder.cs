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
    public partial class AddOrder : Form
    {
        private bool isNew { get; set; }
        private OrdersTable _order { get; set; }

        private List<OrderLinesTable> orderList;

        public AddOrder(OrdersTable order, bool New)
        {
            InitializeComponent();
            MdiParent = Application.OpenForms["OrderManagement"];

            isNew = New;
            _order = order;
            orderList = new List<OrderLinesTable>();

            if (isNew)
            {
                this.Text = "New Order";
            }
            else
            {
                this.Text = "Edit Order";
                btnAddOrder.Text = "Save Changes";
                List<OrderLinesTable> orderLines = OrderingRepository.getInstance.GetOrderLines(_order);
                //if order is editing takes all orderlines of that order and puts it in orderList (another list of order lines)
                foreach (OrderLinesTable item in orderLines)
                {
                    item.ProductsTable = (ProductsTable) OrderingRepository.getInstance.GetProducts().First(c => c.Id == item.ProductID);
                    item.OrdersTable = _order;
                    orderList.Add(item);
                }
            }

            if (!isNew)
            {
                RefreshOrderList();
                tbxAddress.Text = _order.DeliveryAddress;
                lblTotal.Text = _order.Total.ToString();
            }
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            //setting datasource for comboboxes
            cbxCategories.DataSource = Enum.GetNames(typeof(Category));
            cbxSubCategories.DataSource = Enum.GetNames(typeof(ComputersSubCategory));
            cbxSubCategories.Enabled = false;
            RefreshProducts();
            RefreshOrderList();
            
        }

        public void RefreshProducts()
        {
            dgvAllProducts.SuspendLayout();
            productsTableBindingSource.SuspendBinding();
            productsTableBindingSource.DataSource = OrderingRepository.getInstance.GetProducts();
            dgvAllProducts.DataSource = null;
            dgvAllProducts.DataSource = productsTableBindingSource;
            productsTableBindingSource.ResumeBinding();
            dgvAllProducts.ResumeLayout();
        }

        public void RefreshOrderList()
        {
            dgvList.SuspendLayout();
            orderLinesTableBindingSource.SuspendBinding();
            orderLinesTableBindingSource.DataSource = orderList;
            dgvList.DataSource = null;
            dgvList.DataSource = orderLinesTableBindingSource;
            orderLinesTableBindingSource.ResumeBinding();
            dgvList.ResumeLayout();
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            if (dgvAllProducts.SelectedRows.Count == 1)
            {
                ProductsTable product = (ProductsTable)dgvAllProducts.SelectedRows[0].DataBoundItem;
                OrderLinesTable line = new OrderLinesTable();
                line.OrdersTable = _order;
                line.ProductsTable = product;
                line.ProductID = product.Id;
                line.QuantityOrdered = (int) nudQuantity.Value;
                line.SellingPrice = product.Price;
                line.TotalForItem = product.Price * (int)nudQuantity.Value;

                bool itemFound = false;
                if (orderList.Count > 0)
                {
                    foreach (var item in orderList)
                    {
                        if (item.ProductID == product.Id)
                        {
                            //if there is id of product adding to the list is already in the list
                            //quantity and total values are changed instead of adding the same product twice to the datagridview
                            itemFound = true;
                            item.QuantityOrdered += line.QuantityOrdered;
                            item.TotalForItem += line.QuantityOrdered * product.Price;
                        }
                    }
                    
                }
                if(itemFound == false)
                {
                    orderList.Add(line);
                }

                RefreshOrderList();

                nudQuantity.Value = 1;

                float total = 0;
                foreach (var item in orderList)
                {
                    total += (float)item.TotalForItem;
                }

                lblTotal.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Select product to add!");
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbxAddress.Text))
            {
                MessageBox.Show("Fill in Address!");
            }
            else if (orderList.Count < 1)
            {
                MessageBox.Show("Select at least 1 product to order!");
            }
            else
            {
                float total = 0;
                foreach (var item in orderList)
                {
                    total += (float)item.TotalForItem;
                }

                _order.OrderDate = DateTime.Now;
                _order.DeliveryAddress = tbxAddress.Text;
                _order.OrderStatus = OrderStatus.Open.ToString();
                _order.Total = total;

                if (isNew)
                {
                    OrderingRepository.getInstance.AddOrder(_order);
                    foreach (var item in orderList)
                    {
                        OrderingRepository.getInstance.AddOrderLine(item);
                    }
                }
                else
                {
                    List<OrderLinesTable> orderLines = OrderingRepository.getInstance.GetOrderLines(_order);
                    //deletes all orderlines from the current order
                    foreach (var item in orderLines)
                    {
                        OrderingRepository.getInstance.DeleteOrderLine(item);
                    }

                    OrderingRepository.getInstance.EditOrder(_order);
                    //adding new order lines
                    foreach (var item in orderList)
                    {
                        OrderingRepository.getInstance.AddOrderLine(item);
                    }

                }

                Close();
            }

        }

        public void RefreshProductsByCategory()
        {
            dgvAllProducts.SuspendLayout();
            productsTableBindingSource.SuspendBinding();
            productsTableBindingSource.DataSource = OrderingRepository.getInstance.GetProductsByCategory(cbxCategories.Text);
            dgvAllProducts.DataSource = null;
            dgvAllProducts.DataSource = productsTableBindingSource;
            productsTableBindingSource.ResumeBinding();
            dgvAllProducts.ResumeLayout();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            OrderLinesTable orderLine = (OrderLinesTable)dgvList.SelectedRows[0].DataBoundItem;
            ProductsTable product = OrderingRepository.getInstance.GetProducts().First(c => c.Id ==orderLine.ProductID);

            if (nudRemoveQuantity.Value == nudRemoveQuantity.Maximum)
            {
                orderList.Remove(orderLine);
            }
            else
            {
                orderLine.QuantityOrdered -= (int)nudRemoveQuantity.Value;
                orderLine.TotalForItem -= (double) nudRemoveQuantity.Value * product.Price;
            }

            //orderList.Remove(orderLine);
            RefreshOrderList();

            nudRemoveQuantity.Maximum = orderLine.QuantityOrdered;
            nudRemoveQuantity.Value = nudRemoveQuantity.Maximum;
            btnRemove.Text = "Remove All";

            float total = 0;
            foreach (var item in orderList)
            {
                total += (float)item.TotalForItem;
            }

            lblTotal.Text = total.ToString();
        }

        private void cbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxSubCategories.Enabled = true;
            if ((Category)cbxCategories.SelectedIndex == Category.Computers)
            {
                cbxSubCategories.DataSource = Enum.GetNames(typeof(ComputersSubCategory));
            }
            else if ((Category)cbxCategories.SelectedIndex == Category.Accessory)
            {
                cbxSubCategories.DataSource = Enum.GetNames(typeof(AccessorySubCategory));
            }
            else if ((Category)cbxCategories.SelectedIndex == Category.Software)
            {
                cbxSubCategories.DataSource = Enum.GetNames(typeof(SoftwareSubCategory));
            }

            RefreshProductsByCategory();
        }

        public void RefreshProductsBySubCategory()
        {
            //this.productsTableTableAdapter.Fill(this.orderManagementDBDataSetProducts.ProductsTable);
            dgvAllProducts.SuspendLayout();
            productsTableBindingSource.SuspendBinding();
            productsTableBindingSource.DataSource = OrderingRepository.getInstance.GetProductsBySubCategory(cbxSubCategories.Text);
            dgvAllProducts.DataSource = null;
            dgvAllProducts.DataSource = productsTableBindingSource;
            productsTableBindingSource.ResumeBinding();
            dgvAllProducts.ResumeLayout();
        }

        private void cbxSubCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshProductsBySubCategory();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            RefreshProducts();
            cbxSubCategories.Enabled = false;
        }

        private void dgvAllProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nudRemoveQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (dgvList.RowCount > 0)
            {
                OrderLinesTable currentOrderLine = (OrderLinesTable)dgvList.SelectedRows[0].DataBoundItem;
                if (nudRemoveQuantity.Value == nudRemoveQuantity.Maximum)
                {
                    btnRemove.Text = "Remove All";
                }
                else
                {
                    btnRemove.Text = "Remove " + nudRemoveQuantity.Value;
                }
            }
            
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (orderList.Count > 0)
            {

                OrderLinesTable currentOrderLine = (OrderLinesTable)dgvList.SelectedRows[0].DataBoundItem;
                nudRemoveQuantity.Maximum = currentOrderLine.QuantityOrdered;
                nudRemoveQuantity.Value = currentOrderLine.QuantityOrdered;
                btnRemove.Text = "Remove All";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
